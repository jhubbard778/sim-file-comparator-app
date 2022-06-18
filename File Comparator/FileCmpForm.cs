using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Comparator {
    public partial class ComparatorForm : Form {
        public ComparatorForm() {
            InitializeComponent();
        }

        // Writers
        StreamReader originalFile;
        StreamReader comparisonFile;
        StreamWriter standardOut;
        StreamWriter JSONOut;

        // define a list that will hold the original lines
        List<string> original_lines;
        List<string> comp_file_lines;
        List<string> JSON_Lines;

        // Misc Variables
        string file_type;
        string original_file_name;

        int different_lines = 0;
        bool file_type_error = false;

        private void ComparatorForm_Load(object sender, EventArgs e) {
            ErrLabel.ResetText();
            file1label.ResetText();
            file2label.ResetText();
        }
           
        // Opens the a file dialog for the user to open the original file.
        private void OpenFile1_Click(object sender, EventArgs e) {

            // set the initial directory to the current directory
            orgFileOpenDialog.InitialDirectory = Environment.CurrentDirectory;

            // if the user opens the file
            if (orgFileOpenDialog.ShowDialog() == DialogResult.OK) {

                // Hold the file name for possible errors that may happen later
                original_file_name = orgFileOpenDialog.FileName;
             
                // read each line into the original file lines list, if it fails return
                if (!Read_Original_File_Into_List()) {
                    return;
                }

                // delemit by back slash, get the file name
                string[] filepath = original_file_name.Split('\\');
                string filename = filepath[filepath.Length - 1];

                // Set the label equal to the file name
                Change_Label(file1label, Color.Black, filename);
            }
        }

        private void OpenFile2_Click(object sender, EventArgs e) {

            // set the initial directory
            cmpFileOpenDialog.InitialDirectory = Environment.CurrentDirectory;

            if (cmpFileOpenDialog.ShowDialog() == DialogResult.OK) {

                // declare new list
                comp_file_lines = new List<string>();

                comparisonFile = File.OpenText(cmpFileOpenDialog.FileName);

                // Loop through the file lines making sure it's a valid file
                while (comparisonFile.EndOfStream == false) {
                    string line = comparisonFile.ReadLine();
                    string[] args = line.Split(' ');
                    /* if we can't read the line OR
                        if the line does not begin with an open bracket or newline we encountered an error OR
                        if the line does not contain a closing bracket in the 3rd argument THEN
                        we have an incompatible file */
                    if (line == null || (line[0] != '[' && line[0] != '\n') || !args[2].Contains("]")) {
                        Change_Label(file2label, Color.Red, "Error: Incompatible File");
                        comparisonFile.Close();
                        comparisonFile = null;
                        return;
                    }
                    comp_file_lines.Add(line);
                }

                // delemit by back slash, get the file name
                string[] filepath = cmpFileOpenDialog.FileName.Split('\\');
                string filename = filepath[filepath.Length - 1];

                comparisonFile.Close();
                Change_Label(file2label, Color.Black, filename);

            }

        }

        private void BillboardsRadioButton_CheckedChanged(object sender, EventArgs e) {
            file_type = "billboards";
        }

        private void StatuesRadioButton_CheckedChanged(object sender, EventArgs e) {
            file_type = "statues";
        }

        private void DoComparisonButton_Click(object sender, EventArgs e) {
            
            // If the user hasn't selected an original file
            if (originalFile == null) {
                Change_Label(ErrLabel, Color.Red, "Choose Original File");
                return;
            }

            // If the user hasn't selected a comparison file
            if (comparisonFile == null) {
                Change_Label(ErrLabel, Color.Red, "Choose a Comparison File");
                return;
            }
            
            // If the user hasn't selected a file type yet, display error and return
            if (file_type == null) {
                Change_Label(ErrLabel, Color.Red, "Please Select a Comparison File Type");
                return;
            }
            // Reset the error label text
            ErrLabel.ResetText();
            // Reset json lines string array
            JSON_Lines = new List<string>();

            // open the files and write the headers
            standardOut = File.CreateText(Environment.CurrentDirectory + "\\standard_output.txt");
            standardOut.WriteLine("Different Line Outputs:");

            JSONOut = File.CreateText(Environment.CurrentDirectory + "\\json_output.txt");
            JSONOut.WriteLine("Different Line Outputs:");

            // if we had a file type error in the prior submission, re-read the lines from the original file into the list
            if (file_type_error) {
                if (!Read_Original_File_Into_List()) {
                    return;
                }
                file_type_error = false;
            }

            foreach (string line in comp_file_lines) {
                var index = original_lines.IndexOf(line);
                // if we found this line in the original lines, remove it from the list and continue on
                if (index > -1) {
                    // splice from the original lines list
                    original_lines.RemoveAt(index);
                    continue;
                }

                different_lines++;

                // output to standard output and json output
                standardOut.WriteLine(line);

                // if it fails to parse the json kill the loop and return
                bool pass = Parse_JSON(line);
                if (!pass) return;
            }

            var result = JSON_Lines.OrderBy(x => x.Length);
            foreach(string line in result) {
                JSONOut.WriteLine(line);
            }

            // close the files
            standardOut.Close();
            JSONOut.Close();
            string type = "billboards";
            if (file_type == "statues") type = "statues";
            string out_msg = "Successfully Compared Files\n" + different_lines.ToString() + " different " + type + "!";
            Change_Label(ErrLabel, Color.Green, out_msg);
            different_lines = 0;
        }

        private bool Parse_JSON(string line) {
            // split the line on whitespace
            string[] args = line.Split(' ');
            
            // If we don't have the correct argument lengths we have an incorrect file type
            if ((file_type == "billboards" && args.Length != 6) || (file_type == "statues" && args.Length != 7)) {
                Change_Label(ErrLabel, Color.Red, "Error: Wrong File Type");
                standardOut.Close();
                JSONOut.Close();
                different_lines = 0;
                file_type_error = true;
                return false;
            }

            string json_line;

            if (file_type == "billboards") {
                
                // Go through the JSON Lines to see if we have a billboard that already exists
                for (int i = 0; i < JSON_Lines.Count; i++) {
                    // Split the line when it hits a substring ", "
                    string[] split = JSON_Lines[i].Split(new string[] { ", " }, StringSplitOptions.None);

                    // Create a copy of our split lines
                    string[] replace = new string[split.Length];
                    split.CopyTo(replace, 0);
                    
                    // Convert JSON Line formatting to args formatting
                    replace[1] = replace[1].Replace("size: ", string.Empty);
                    replace[2] = replace[2].Replace("aspect: ", string.Empty);
                    replace[3] = replace[3].Replace("png: \"", string.Empty).Replace("\"},", string.Empty);

                    // if the size, aspect, and png are all the same, there is a billboard that already exists
                    if (replace[1] == args[3] && replace[2] == args[4] && replace[3] == args[5]) {
                        split[0] = split[0].Replace("]]", "]," + args[0] + "," + args[1] + "," + args[2] + "]");
                        JSON_Lines[i] = split[0] + ", " + split[1] + ", " + split[2] + ", " + split[3];
                        return true;
                    }
                }
                // args: [x, y, z], size, aspect, png
                json_line = "{coords: [" + args[0] + ',' + args[1] + ',' + args[2] +
                    "], size: " + args[3] + ", aspect: " + args[4] + ", png: \"" + args[5] + "\"},";
            }
            else {
                // Go through the JSON Lines to see if we have a billboard that already exists
                for (int i = 0; i < JSON_Lines.Count; i++) {
                    // Split the line when it hits a substring ", "
                    string[] split = JSON_Lines[i].Split(new string[] { ", " }, StringSplitOptions.None);

                    // Create a copy of our split lines
                    string[] replace = new string[split.Length];
                    split.CopyTo(replace, 0);

                    // Convert JSON Line formatting to args formatting
                    replace[2] = replace[2].Replace("jm: ", string.Empty).Replace("\"", string.Empty);
                    replace[3] = replace[3].Replace("png: ", string.Empty).Replace("\"", string.Empty);
                    replace[4] = replace[4].Replace("shp: \"", string.Empty).Replace("\"},", string.Empty);

                    // if the size, aspect, and png are all the same, there is a billboard that already exists
                    if (replace[2] == args[4] && replace[3] == args[5] && replace[4] == args[6]) {
                        split[0] = split[0].Replace("]]", "]," + args[0] + "," + args[1] + "," + args[2] + "]");
                        split[1] = split[1].Replace("]", "," + args[3] + "]");
                        JSON_Lines[i] = split[0] + ", " + split[1] + ", " + split[2] + ", " + split[3] + ", " + split[4];
                        return true;
                    }
                }
                // args: [x, y, z], angle, jm, png, shp
                json_line = "{coords: [" + args[0] + ',' + args[1] + ',' + args[2]
                + "], angles: [" + args[3] + "], jm: \"" + args[4] + "\", png: \"" + args[5]
                + "\", shp: \"" + args[6] + "\"},";
            }

            // write the line, return true, we passed the parse
            JSON_Lines.Add(json_line);
            return true;
        }

        private void Change_Label(Label label, Color color, string text) {
            label.ForeColor = color;
            label.Text = text;
        }

        private bool Read_Original_File_Into_List() {

            // declare new list
            original_lines = new List<string>();

            // Open the file denoted by the user
            originalFile = File.OpenText(original_file_name);

            // Loop through until we reach end of file
            while (originalFile.EndOfStream == false) {
                string line = originalFile.ReadLine();
                string[] args = line.Split(' ');
                /* if we can't read the line OR
                    if the line does not begin with an open bracket or newline we encountered an error OR
                    if the line does not contain a closing bracket in the 3rd argument THEN
                    we have an incompatible file */
                if (line == null || (line[0] != '[' && line[0] != '\n') || !args[2].Contains("]")) {
                    Change_Label(file1label, Color.Red, "Error: Incompatible File");
                    originalFile.Close();
                    originalFile = null;
                    return false;
                }
                // add to the list
                original_lines.Add(line);
            }

            // close the original file
            originalFile.Close();
            return true;
        }
    }
}

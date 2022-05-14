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

namespace File_Comparitor {
    public partial class ComparitorForm : Form {
        public ComparitorForm() {
            InitializeComponent();
        }

        StreamReader originalFile;
        StreamReader comparisonFile;
        StreamWriter standardOut;
        StreamWriter JSONOut;

        private void ComparitorForm_Load(object sender, EventArgs e) {
            selectCompareTypeErrLabel.ResetText();
            file1label.ResetText();
            file2label.ResetText();
        }
    }
}

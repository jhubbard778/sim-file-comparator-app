namespace File_Comparitor
{
    partial class ComparitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComparitorForm));
            this.openFile1 = new System.Windows.Forms.Button();
            this.openFile2 = new System.Windows.Forms.Button();
            this.doComparisonButton = new System.Windows.Forms.Button();
            this.radioButtonGroup = new System.Windows.Forms.GroupBox();
            this.billboardsRadioButton = new System.Windows.Forms.RadioButton();
            this.statuesRadioButton = new System.Windows.Forms.RadioButton();
            this.selectCompareTypeErrLabel = new System.Windows.Forms.Label();
            this.orgFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.cmpFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.file1label = new System.Windows.Forms.Label();
            this.file2label = new System.Windows.Forms.Label();
            this.radioButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile1
            // 
            this.openFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile1.Location = new System.Drawing.Point(11, 12);
            this.openFile1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.openFile1.Name = "openFile1";
            this.openFile1.Size = new System.Drawing.Size(108, 30);
            this.openFile1.TabIndex = 0;
            this.openFile1.Text = "Original File";
            this.openFile1.UseVisualStyleBackColor = true;
            // 
            // openFile2
            // 
            this.openFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile2.Location = new System.Drawing.Point(11, 48);
            this.openFile2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.openFile2.Name = "openFile2";
            this.openFile2.Size = new System.Drawing.Size(108, 43);
            this.openFile2.TabIndex = 1;
            this.openFile2.Text = "File to Compare";
            this.openFile2.UseVisualStyleBackColor = true;
            // 
            // doComparisonButton
            // 
            this.doComparisonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doComparisonButton.Location = new System.Drawing.Point(11, 240);
            this.doComparisonButton.Name = "doComparisonButton";
            this.doComparisonButton.Size = new System.Drawing.Size(141, 48);
            this.doComparisonButton.TabIndex = 2;
            this.doComparisonButton.Text = "Compare Files";
            this.doComparisonButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroup
            // 
            this.radioButtonGroup.Controls.Add(this.billboardsRadioButton);
            this.radioButtonGroup.Controls.Add(this.statuesRadioButton);
            this.radioButtonGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGroup.Location = new System.Drawing.Point(12, 109);
            this.radioButtonGroup.Name = "radioButtonGroup";
            this.radioButtonGroup.Size = new System.Drawing.Size(179, 88);
            this.radioButtonGroup.TabIndex = 3;
            this.radioButtonGroup.TabStop = false;
            this.radioButtonGroup.Text = "File to Compare Type";
            // 
            // billboardsRadioButton
            // 
            this.billboardsRadioButton.AutoSize = true;
            this.billboardsRadioButton.Location = new System.Drawing.Point(17, 26);
            this.billboardsRadioButton.Name = "billboardsRadioButton";
            this.billboardsRadioButton.Size = new System.Drawing.Size(96, 24);
            this.billboardsRadioButton.TabIndex = 4;
            this.billboardsRadioButton.TabStop = true;
            this.billboardsRadioButton.Text = "Billboards";
            this.billboardsRadioButton.UseVisualStyleBackColor = true;
            // 
            // statuesRadioButton
            // 
            this.statuesRadioButton.AutoSize = true;
            this.statuesRadioButton.Location = new System.Drawing.Point(17, 56);
            this.statuesRadioButton.Name = "statuesRadioButton";
            this.statuesRadioButton.Size = new System.Drawing.Size(83, 24);
            this.statuesRadioButton.TabIndex = 5;
            this.statuesRadioButton.TabStop = true;
            this.statuesRadioButton.Text = "Statues";
            this.statuesRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectCompareTypeErrLabel
            // 
            this.selectCompareTypeErrLabel.AutoSize = true;
            this.selectCompareTypeErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCompareTypeErrLabel.Location = new System.Drawing.Point(15, 206);
            this.selectCompareTypeErrLabel.Name = "selectCompareTypeErrLabel";
            this.selectCompareTypeErrLabel.Size = new System.Drawing.Size(51, 20);
            this.selectCompareTypeErrLabel.TabIndex = 6;
            this.selectCompareTypeErrLabel.Text = "label1";
            this.selectCompareTypeErrLabel.Visible = false;
            // 
            // file1label
            // 
            this.file1label.AutoSize = true;
            this.file1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file1label.Location = new System.Drawing.Point(133, 19);
            this.file1label.Name = "file1label";
            this.file1label.Size = new System.Drawing.Size(46, 17);
            this.file1label.TabIndex = 7;
            this.file1label.Text = "label2";
            // 
            // file2label
            // 
            this.file2label.AutoSize = true;
            this.file2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file2label.Location = new System.Drawing.Point(133, 63);
            this.file2label.Name = "file2label";
            this.file2label.Size = new System.Drawing.Size(46, 17);
            this.file2label.TabIndex = 8;
            this.file2label.Text = "label3";
            // 
            // ComparitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 351);
            this.Controls.Add(this.file2label);
            this.Controls.Add(this.file1label);
            this.Controls.Add(this.selectCompareTypeErrLabel);
            this.Controls.Add(this.radioButtonGroup);
            this.Controls.Add(this.doComparisonButton);
            this.Controls.Add(this.openFile2);
            this.Controls.Add(this.openFile1);
            this.Font = new System.Drawing.Font("American Captain", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ComparitorForm";
            this.Text = "MX Simulator File Comparitor";
            this.Load += new System.EventHandler(this.ComparitorForm_Load);
            this.radioButtonGroup.ResumeLayout(false);
            this.radioButtonGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFile1;
        private System.Windows.Forms.Button openFile2;
        private System.Windows.Forms.Button doComparisonButton;
        private System.Windows.Forms.GroupBox radioButtonGroup;
        private System.Windows.Forms.RadioButton billboardsRadioButton;
        private System.Windows.Forms.RadioButton statuesRadioButton;
        private System.Windows.Forms.Label selectCompareTypeErrLabel;
        private System.Windows.Forms.OpenFileDialog orgFileOpenDialog;
        private System.Windows.Forms.OpenFileDialog cmpFileOpenDialog;
        private System.Windows.Forms.Label file1label;
        private System.Windows.Forms.Label file2label;
    }
}


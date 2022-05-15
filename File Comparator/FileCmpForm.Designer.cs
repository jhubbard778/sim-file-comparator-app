namespace File_Comparitor
{
    partial class ComparatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComparatorForm));
            this.OpenFile1 = new System.Windows.Forms.Button();
            this.OpenFile2 = new System.Windows.Forms.Button();
            this.DoComparisonButton = new System.Windows.Forms.Button();
            this.radioButtonGroup = new System.Windows.Forms.GroupBox();
            this.BillboardsRadioButton = new System.Windows.Forms.RadioButton();
            this.StatuesRadioButton = new System.Windows.Forms.RadioButton();
            this.ErrLabel = new System.Windows.Forms.Label();
            this.orgFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.cmpFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.file1label = new System.Windows.Forms.Label();
            this.file2label = new System.Windows.Forms.Label();
            this.radioButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile1
            // 
            this.OpenFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile1.Location = new System.Drawing.Point(11, 12);
            this.OpenFile1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OpenFile1.Name = "OpenFile1";
            this.OpenFile1.Size = new System.Drawing.Size(108, 30);
            this.OpenFile1.TabIndex = 0;
            this.OpenFile1.Text = "Original File";
            this.OpenFile1.UseVisualStyleBackColor = true;
            this.OpenFile1.Click += new System.EventHandler(this.OpenFile1_Click);
            // 
            // OpenFile2
            // 
            this.OpenFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile2.Location = new System.Drawing.Point(11, 48);
            this.OpenFile2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OpenFile2.Name = "OpenFile2";
            this.OpenFile2.Size = new System.Drawing.Size(108, 43);
            this.OpenFile2.TabIndex = 1;
            this.OpenFile2.Text = "File to Compare";
            this.OpenFile2.UseVisualStyleBackColor = true;
            this.OpenFile2.Click += new System.EventHandler(this.OpenFile2_Click);
            // 
            // DoComparisonButton
            // 
            this.DoComparisonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoComparisonButton.Location = new System.Drawing.Point(11, 254);
            this.DoComparisonButton.Name = "DoComparisonButton";
            this.DoComparisonButton.Size = new System.Drawing.Size(141, 48);
            this.DoComparisonButton.TabIndex = 2;
            this.DoComparisonButton.Text = "Compare Files";
            this.DoComparisonButton.UseVisualStyleBackColor = true;
            this.DoComparisonButton.Click += new System.EventHandler(this.DoComparisonButton_Click);
            // 
            // radioButtonGroup
            // 
            this.radioButtonGroup.Controls.Add(this.BillboardsRadioButton);
            this.radioButtonGroup.Controls.Add(this.StatuesRadioButton);
            this.radioButtonGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGroup.Location = new System.Drawing.Point(12, 109);
            this.radioButtonGroup.Name = "radioButtonGroup";
            this.radioButtonGroup.Size = new System.Drawing.Size(179, 88);
            this.radioButtonGroup.TabIndex = 3;
            this.radioButtonGroup.TabStop = false;
            this.radioButtonGroup.Text = "File to Compare Type";
            // 
            // BillboardsRadioButton
            // 
            this.BillboardsRadioButton.AutoSize = true;
            this.BillboardsRadioButton.Location = new System.Drawing.Point(17, 26);
            this.BillboardsRadioButton.Name = "BillboardsRadioButton";
            this.BillboardsRadioButton.Size = new System.Drawing.Size(96, 24);
            this.BillboardsRadioButton.TabIndex = 4;
            this.BillboardsRadioButton.TabStop = true;
            this.BillboardsRadioButton.Text = "Billboards";
            this.BillboardsRadioButton.UseVisualStyleBackColor = true;
            this.BillboardsRadioButton.CheckedChanged += new System.EventHandler(this.BillboardsRadioButton_CheckedChanged);
            // 
            // StatuesRadioButton
            // 
            this.StatuesRadioButton.AutoSize = true;
            this.StatuesRadioButton.Location = new System.Drawing.Point(17, 56);
            this.StatuesRadioButton.Name = "StatuesRadioButton";
            this.StatuesRadioButton.Size = new System.Drawing.Size(83, 24);
            this.StatuesRadioButton.TabIndex = 5;
            this.StatuesRadioButton.TabStop = true;
            this.StatuesRadioButton.Text = "Statues";
            this.StatuesRadioButton.UseVisualStyleBackColor = true;
            this.StatuesRadioButton.CheckedChanged += new System.EventHandler(this.StatuesRadioButton_CheckedChanged);
            // 
            // ErrLabel
            // 
            this.ErrLabel.AutoSize = true;
            this.ErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLabel.Location = new System.Drawing.Point(15, 206);
            this.ErrLabel.Name = "ErrLabel";
            this.ErrLabel.Size = new System.Drawing.Size(51, 20);
            this.ErrLabel.TabIndex = 6;
            this.ErrLabel.Text = "label1";
            // 
            // file1label
            // 
            this.file1label.AutoSize = true;
            this.file1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file1label.Location = new System.Drawing.Point(124, 19);
            this.file1label.Name = "file1label";
            this.file1label.Size = new System.Drawing.Size(46, 17);
            this.file1label.TabIndex = 7;
            this.file1label.Text = "label2";
            // 
            // file2label
            // 
            this.file2label.AutoSize = true;
            this.file2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file2label.Location = new System.Drawing.Point(124, 61);
            this.file2label.Name = "file2label";
            this.file2label.Size = new System.Drawing.Size(46, 17);
            this.file2label.TabIndex = 8;
            this.file2label.Text = "label3";
            // 
            // ComparatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 351);
            this.Controls.Add(this.file2label);
            this.Controls.Add(this.file1label);
            this.Controls.Add(this.ErrLabel);
            this.Controls.Add(this.radioButtonGroup);
            this.Controls.Add(this.DoComparisonButton);
            this.Controls.Add(this.OpenFile2);
            this.Controls.Add(this.OpenFile1);
            this.Font = new System.Drawing.Font("American Captain", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ComparatorForm";
            this.Text = "MX Simulator Billboard/Statue Comparator";
            this.Load += new System.EventHandler(this.ComparitorForm_Load);
            this.radioButtonGroup.ResumeLayout(false);
            this.radioButtonGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile1;
        private System.Windows.Forms.Button OpenFile2;
        private System.Windows.Forms.Button DoComparisonButton;
        private System.Windows.Forms.GroupBox radioButtonGroup;
        private System.Windows.Forms.RadioButton BillboardsRadioButton;
        private System.Windows.Forms.RadioButton StatuesRadioButton;
        private System.Windows.Forms.Label ErrLabel;
        private System.Windows.Forms.OpenFileDialog orgFileOpenDialog;
        private System.Windows.Forms.OpenFileDialog cmpFileOpenDialog;
        private System.Windows.Forms.Label file1label;
        private System.Windows.Forms.Label file2label;
    }
}


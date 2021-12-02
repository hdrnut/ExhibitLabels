namespace ExhibitLabels
{
    partial class Main
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
            this.Label2 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtWorksheetNumber = new System.Windows.Forms.NumericUpDown();
            this.txtStartRow = new System.Windows.Forms.NumericUpDown();
            this.txtStartCol = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorksheetNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartCol)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(41, 66);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 20);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Input";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(231, 276);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(36, 20);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Col:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(83, 276);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(45, 20);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "Row:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(41, 244);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(167, 20);
            this.Label6.TabIndex = 26;
            this.Label6.Text = "Start printing labels at:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(36, 217);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(65, 20);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Output";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(41, 144);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(99, 20);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Worksheet#:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(648, 350);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(527, 350);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(725, 101);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(39, 35);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(41, 111);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(78, 20);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Filename:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(146, 105);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(571, 26);
            this.txtFileName.TabIndex = 18;
            this.txtFileName.Text = "R:\\Photography\\SJCC\\ExhibitTitlesBrotherhoodWinery2019-2020.xlsx";
            // 
            // txtWorksheetNumber
            // 
            this.txtWorksheetNumber.Location = new System.Drawing.Point(147, 142);
            this.txtWorksheetNumber.Name = "txtWorksheetNumber";
            this.txtWorksheetNumber.Size = new System.Drawing.Size(120, 26);
            this.txtWorksheetNumber.TabIndex = 32;
            this.txtWorksheetNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtStartRow
            // 
            this.txtStartRow.Location = new System.Drawing.Point(135, 274);
            this.txtStartRow.Name = "txtStartRow";
            this.txtStartRow.Size = new System.Drawing.Size(69, 26);
            this.txtStartRow.TabIndex = 33;
            this.txtStartRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtStartCol
            // 
            this.txtStartCol.Location = new System.Drawing.Point(283, 274);
            this.txtStartCol.Name = "txtStartCol";
            this.txtStartCol.Size = new System.Drawing.Size(66, 26);
            this.txtStartCol.TabIndex = 34;
            this.txtStartCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStartCol);
            this.Controls.Add(this.txtStartRow);
            this.Controls.Add(this.txtWorksheetNumber);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtFileName);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtWorksheetNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.NumericUpDown txtWorksheetNumber;
        private System.Windows.Forms.NumericUpDown txtStartRow;
        private System.Windows.Forms.NumericUpDown txtStartCol;
    }
}


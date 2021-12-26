namespace Q1Q2_Read_and_Write_Op_XMLSerialization
{
    partial class Form1
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
            this.labelRollNo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMarks = new System.Windows.Forms.Label();
            this.textRollNo = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textMarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnWriteXML = new System.Windows.Forms.Button();
            this.btnReadXML = new System.Windows.Forms.Button();
            this.btnreadTxt = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRollNo
            // 
            this.labelRollNo.AutoSize = true;
            this.labelRollNo.Location = new System.Drawing.Point(38, 178);
            this.labelRollNo.Name = "labelRollNo";
            this.labelRollNo.Size = new System.Drawing.Size(42, 13);
            this.labelRollNo.TabIndex = 3;
            this.labelRollNo.Text = "Roll No";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(38, 216);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelMarks
            // 
            this.labelMarks.AutoSize = true;
            this.labelMarks.Location = new System.Drawing.Point(37, 251);
            this.labelMarks.Name = "labelMarks";
            this.labelMarks.Size = new System.Drawing.Size(36, 13);
            this.labelMarks.TabIndex = 5;
            this.labelMarks.Text = "Marks";
            // 
            // textRollNo
            // 
            this.textRollNo.Location = new System.Drawing.Point(106, 178);
            this.textRollNo.Name = "textRollNo";
            this.textRollNo.Size = new System.Drawing.Size(100, 20);
            this.textRollNo.TabIndex = 6;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(106, 216);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 7;
            // 
            // textMarks
            // 
            this.textMarks.Location = new System.Drawing.Point(106, 248);
            this.textMarks.Name = "textMarks";
            this.textMarks.Size = new System.Drawing.Size(100, 20);
            this.textMarks.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(235, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnWriteXML
            // 
            this.btnWriteXML.Location = new System.Drawing.Point(34, 299);
            this.btnWriteXML.Name = "btnWriteXML";
            this.btnWriteXML.Size = new System.Drawing.Size(75, 23);
            this.btnWriteXML.TabIndex = 10;
            this.btnWriteXML.Text = "Write XML";
            this.btnWriteXML.UseVisualStyleBackColor = true;
            this.btnWriteXML.Click += new System.EventHandler(this.btnWriteXML_Click);
            // 
            // btnReadXML
            // 
            this.btnReadXML.Location = new System.Drawing.Point(131, 299);
            this.btnReadXML.Name = "btnReadXML";
            this.btnReadXML.Size = new System.Drawing.Size(75, 23);
            this.btnReadXML.TabIndex = 11;
            this.btnReadXML.Text = "Read XML";
            this.btnReadXML.UseVisualStyleBackColor = true;
            this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // btnreadTxt
            // 
            this.btnreadTxt.Location = new System.Drawing.Point(95, 109);
            this.btnreadTxt.Name = "btnreadTxt";
            this.btnreadTxt.Size = new System.Drawing.Size(57, 23);
            this.btnreadTxt.TabIndex = 14;
            this.btnreadTxt.Text = "Read";
            this.btnreadTxt.UseVisualStyleBackColor = true;
            this.btnreadTxt.Click += new System.EventHandler(this.btnreadTxt_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(32, 12);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(115, 23);
            this.btnCreateFolder.TabIndex = 15;
            this.btnCreateFolder.Text = "CreateFolder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(32, 65);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(111, 23);
            this.btnCreateFile.TabIndex = 16;
            this.btnCreateFile.Text = "CreateFile";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(34, 109);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(55, 23);
            this.btnWrite.TabIndex = 17;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnreadTxt);
            this.Controls.Add(this.btnReadXML);
            this.Controls.Add(this.btnWriteXML);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textMarks);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textRollNo);
            this.Controls.Add(this.labelMarks);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRollNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRollNo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMarks;
        private System.Windows.Forms.TextBox textRollNo;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textMarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnWriteXML;
        private System.Windows.Forms.Button btnReadXML;
        private System.Windows.Forms.Button btnreadTxt;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnWrite;
    }
}


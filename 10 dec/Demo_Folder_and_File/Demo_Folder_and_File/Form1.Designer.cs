namespace Demo_Folder_and_File
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
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.labeldeptid = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textEmpdept = new System.Windows.Forms.TextBox();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnwritexml = new System.Windows.Forms.Button();
            this.btnreadxml = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryread = new System.Windows.Forms.Button();
            this.btnSoapwrite = new System.Windows.Forms.Button();
            this.btnreadSoap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(10, 58);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(124, 23);
            this.btnCreateFolder.TabIndex = 0;
            this.btnCreateFolder.Text = "btnCreateFolder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(140, 58);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(125, 23);
            this.btnCreateFile.TabIndex = 1;
            this.btnCreateFile.Text = "btnCreateFile";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // labeldeptid
            // 
            this.labeldeptid.AutoSize = true;
            this.labeldeptid.Location = new System.Drawing.Point(37, 128);
            this.labeldeptid.Name = "labeldeptid";
            this.labeldeptid.Size = new System.Drawing.Size(41, 13);
            this.labeldeptid.TabIndex = 2;
            this.labeldeptid.Text = "DeptID";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(37, 169);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 13);
            this.label.TabIndex = 3;
            this.label.Text = "DeptName";
            // 
            // textEmpdept
            // 
            this.textEmpdept.Location = new System.Drawing.Point(116, 128);
            this.textEmpdept.Name = "textEmpdept";
            this.textEmpdept.Size = new System.Drawing.Size(100, 20);
            this.textEmpdept.TabIndex = 4;
            // 
            // textEmpName
            // 
            this.textEmpName.Location = new System.Drawing.Point(116, 166);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(100, 20);
            this.textEmpName.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(40, 207);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(141, 207);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 23);
            this.btnread.TabIndex = 7;
            this.btnread.Text = "read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnwritexml
            // 
            this.btnwritexml.Location = new System.Drawing.Point(40, 253);
            this.btnwritexml.Name = "btnwritexml";
            this.btnwritexml.Size = new System.Drawing.Size(75, 23);
            this.btnwritexml.TabIndex = 8;
            this.btnwritexml.Text = "write XML";
            this.btnwritexml.UseVisualStyleBackColor = true;
            this.btnwritexml.Click += new System.EventHandler(this.btnwritexml_Click);
            // 
            // btnreadxml
            // 
            this.btnreadxml.Location = new System.Drawing.Point(140, 253);
            this.btnreadxml.Name = "btnreadxml";
            this.btnreadxml.Size = new System.Drawing.Size(75, 23);
            this.btnreadxml.TabIndex = 9;
            this.btnreadxml.Text = "read XML";
            this.btnreadxml.UseVisualStyleBackColor = true;
            this.btnreadxml.Click += new System.EventHandler(this.btnreadxml_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(40, 300);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryWrite.TabIndex = 10;
            this.btnBinaryWrite.Text = "write Binary";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryread
            // 
            this.btnBinaryread.Location = new System.Drawing.Point(141, 300);
            this.btnBinaryread.Name = "btnBinaryread";
            this.btnBinaryread.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryread.TabIndex = 11;
            this.btnBinaryread.Text = "read Binary";
            this.btnBinaryread.UseVisualStyleBackColor = true;
            this.btnBinaryread.Click += new System.EventHandler(this.btnBinaryread_Click);
            // 
            // btnSoapwrite
            // 
            this.btnSoapwrite.Location = new System.Drawing.Point(40, 339);
            this.btnSoapwrite.Name = "btnSoapwrite";
            this.btnSoapwrite.Size = new System.Drawing.Size(75, 23);
            this.btnSoapwrite.TabIndex = 12;
            this.btnSoapwrite.Text = "write SOAP";
            this.btnSoapwrite.UseVisualStyleBackColor = true;
            this.btnSoapwrite.Click += new System.EventHandler(this.btnSoapwrite_Click);
            // 
            // btnreadSoap
            // 
            this.btnreadSoap.Location = new System.Drawing.Point(141, 339);
            this.btnreadSoap.Name = "btnreadSoap";
            this.btnreadSoap.Size = new System.Drawing.Size(75, 23);
            this.btnreadSoap.TabIndex = 13;
            this.btnreadSoap.Text = "read SOAP";
            this.btnreadSoap.UseVisualStyleBackColor = true;
            this.btnreadSoap.Click += new System.EventHandler(this.btnreadSoap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.btnreadSoap);
            this.Controls.Add(this.btnSoapwrite);
            this.Controls.Add(this.btnBinaryread);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.btnreadxml);
            this.Controls.Add(this.btnwritexml);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.textEmpdept);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labeldeptid);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label labeldeptid;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textEmpdept;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnwritexml;
        private System.Windows.Forms.Button btnreadxml;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryread;
        private System.Windows.Forms.Button btnSoapwrite;
        private System.Windows.Forms.Button btnreadSoap;
    }
}


namespace Enquiry_System_project
{
    partial class Counsellor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textStuName = new System.Windows.Forms.TextBox();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.checkBoxYes = new System.Windows.Forms.CheckBox();
            this.checkBoxNo = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelStuID = new System.Windows.Forms.Label();
            this.textStuID = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student response";
            // 
            // textStuName
            // 
            this.textStuName.Location = new System.Drawing.Point(126, 49);
            this.textStuName.Name = "textStuName";
            this.textStuName.Size = new System.Drawing.Size(121, 20);
            this.textStuName.TabIndex = 3;
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Items.AddRange(new object[] {
            "java",
            "c++",
            "c#",
            "HTML"});
            this.comboBoxCourses.Location = new System.Drawing.Point(126, 82);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCourses.TabIndex = 6;
            // 
            // checkBoxYes
            // 
            this.checkBoxYes.AutoSize = true;
            this.checkBoxYes.Location = new System.Drawing.Point(126, 162);
            this.checkBoxYes.Name = "checkBoxYes";
            this.checkBoxYes.Size = new System.Drawing.Size(44, 17);
            this.checkBoxYes.TabIndex = 7;
            this.checkBoxYes.Text = "Yes";
            this.checkBoxYes.UseVisualStyleBackColor = true;
            // 
            // checkBoxNo
            // 
            this.checkBoxNo.AutoSize = true;
            this.checkBoxNo.Location = new System.Drawing.Point(207, 163);
            this.checkBoxNo.Name = "checkBoxNo";
            this.checkBoxNo.Size = new System.Drawing.Size(40, 17);
            this.checkBoxNo.TabIndex = 8;
            this.checkBoxNo.Text = "No";
            this.checkBoxNo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2021, 12, 17, 15, 22, 37, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "FollowUp Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(126, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(225, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(270, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // labelStuID
            // 
            this.labelStuID.AutoSize = true;
            this.labelStuID.Location = new System.Drawing.Point(27, 19);
            this.labelStuID.Name = "labelStuID";
            this.labelStuID.Size = new System.Drawing.Size(58, 13);
            this.labelStuID.TabIndex = 16;
            this.labelStuID.Text = "Student ID";
            // 
            // textStuID
            // 
            this.textStuID.Location = new System.Drawing.Point(126, 12);
            this.textStuID.Name = "textStuID";
            this.textStuID.Size = new System.Drawing.Size(121, 20);
            this.textStuID.TabIndex = 17;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(126, 415);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 18;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Counsellor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.textStuID);
            this.Controls.Add(this.labelStuID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxNo);
            this.Controls.Add(this.checkBoxYes);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.textStuName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Counsellor";
            this.Text = "Counsellor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textStuName;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.CheckBox checkBoxYes;
        private System.Windows.Forms.CheckBox checkBoxNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelStuID;
        private System.Windows.Forms.TextBox textStuID;
        private System.Windows.Forms.Button btnDisplay;
    }
}
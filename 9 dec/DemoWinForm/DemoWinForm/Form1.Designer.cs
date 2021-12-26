namespace DemoWinForm
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
            this.btn_details = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textEmpID = new System.Windows.Forms.TextBox();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.labelEmpId = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelBSalary = new System.Windows.Forms.Label();
            this.textBSalary = new System.Windows.Forms.TextBox();
            this.textHRA = new System.Windows.Forms.TextBox();
            this.labelHRA = new System.Windows.Forms.Label();
            this.labelTA = new System.Windows.Forms.Label();
            this.textTA = new System.Windows.Forms.TextBox();
            this.labePF = new System.Windows.Forms.Label();
            this.textPF = new System.Windows.Forms.TextBox();
            this.labelNetPaid = new System.Windows.Forms.Label();
            this.textNetPaid = new System.Windows.Forms.TextBox();
            this.labelDept = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_details
            // 
            this.btn_details.Location = new System.Drawing.Point(41, 353);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(75, 23);
            this.btn_details.TabIndex = 0;
            this.btn_details.Text = "Show details";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(143, 353);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // textEmpID
            // 
            this.textEmpID.Location = new System.Drawing.Point(143, 16);
            this.textEmpID.Name = "textEmpID";
            this.textEmpID.Size = new System.Drawing.Size(100, 20);
            this.textEmpID.TabIndex = 3;
            this.textEmpID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textEmpName
            // 
            this.textEmpName.Location = new System.Drawing.Point(143, 45);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(100, 20);
            this.textEmpName.TabIndex = 4;
            // 
            // labelEmpId
            // 
            this.labelEmpId.AutoSize = true;
            this.labelEmpId.Location = new System.Drawing.Point(27, 19);
            this.labelEmpId.Name = "labelEmpId";
            this.labelEmpId.Size = new System.Drawing.Size(39, 13);
            this.labelEmpId.TabIndex = 6;
            this.labelEmpId.Text = "EmpID";
            this.labelEmpId.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(27, 48);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(56, 13);
            this.labelEmpName.TabIndex = 7;
            this.labelEmpName.Text = "EmpName";
            // 
            // labelBSalary
            // 
            this.labelBSalary.AutoSize = true;
            this.labelBSalary.Location = new System.Drawing.Point(27, 83);
            this.labelBSalary.Name = "labelBSalary";
            this.labelBSalary.Size = new System.Drawing.Size(65, 13);
            this.labelBSalary.TabIndex = 8;
            this.labelBSalary.Text = "Basic Salary";
            // 
            // textBSalary
            // 
            this.textBSalary.Location = new System.Drawing.Point(143, 80);
            this.textBSalary.Name = "textBSalary";
            this.textBSalary.Size = new System.Drawing.Size(100, 20);
            this.textBSalary.TabIndex = 9;
            this.textBSalary.TextChanged += new System.EventHandler(this.textBSalary_TextChanged);
            // 
            // textHRA
            // 
            this.textHRA.Location = new System.Drawing.Point(143, 115);
            this.textHRA.Name = "textHRA";
            this.textHRA.Size = new System.Drawing.Size(100, 20);
            this.textHRA.TabIndex = 10;
            this.textHRA.TextChanged += new System.EventHandler(this.textHRA_TextChanged);
            // 
            // labelHRA
            // 
            this.labelHRA.AutoSize = true;
            this.labelHRA.Location = new System.Drawing.Point(31, 118);
            this.labelHRA.Name = "labelHRA";
            this.labelHRA.Size = new System.Drawing.Size(30, 13);
            this.labelHRA.TabIndex = 11;
            this.labelHRA.Text = "HRA";
            // 
            // labelTA
            // 
            this.labelTA.AutoSize = true;
            this.labelTA.Location = new System.Drawing.Point(31, 159);
            this.labelTA.Name = "labelTA";
            this.labelTA.Size = new System.Drawing.Size(21, 13);
            this.labelTA.TabIndex = 12;
            this.labelTA.Text = "TA";
            // 
            // textTA
            // 
            this.textTA.Location = new System.Drawing.Point(143, 156);
            this.textTA.Name = "textTA";
            this.textTA.Size = new System.Drawing.Size(100, 20);
            this.textTA.TabIndex = 13;
            // 
            // labePF
            // 
            this.labePF.AutoSize = true;
            this.labePF.Location = new System.Drawing.Point(31, 199);
            this.labePF.Name = "labePF";
            this.labePF.Size = new System.Drawing.Size(20, 13);
            this.labePF.TabIndex = 14;
            this.labePF.Text = "PF";
            // 
            // textPF
            // 
            this.textPF.Location = new System.Drawing.Point(143, 196);
            this.textPF.Name = "textPF";
            this.textPF.Size = new System.Drawing.Size(100, 20);
            this.textPF.TabIndex = 15;
            // 
            // labelNetPaid
            // 
            this.labelNetPaid.AutoSize = true;
            this.labelNetPaid.Location = new System.Drawing.Point(31, 238);
            this.labelNetPaid.Name = "labelNetPaid";
            this.labelNetPaid.Size = new System.Drawing.Size(76, 13);
            this.labelNetPaid.TabIndex = 16;
            this.labelNetPaid.Text = "Netpaid Salary";
            // 
            // textNetPaid
            // 
            this.textNetPaid.Location = new System.Drawing.Point(143, 238);
            this.textNetPaid.Name = "textNetPaid";
            this.textNetPaid.Size = new System.Drawing.Size(100, 20);
            this.textNetPaid.TabIndex = 17;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(31, 281);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(95, 13);
            this.labelDept.TabIndex = 18;
            this.labelDept.Text = "Select Department";
            this.labelDept.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(143, 281);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDept.TabIndex = 20;
            this.comboBoxDept.Text = "Testing";
            this.comboBoxDept.SelectedIndexChanged += new System.EventHandler(this.comboBoxDept_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.textNetPaid);
            this.Controls.Add(this.labelNetPaid);
            this.Controls.Add(this.textPF);
            this.Controls.Add(this.labePF);
            this.Controls.Add(this.textTA);
            this.Controls.Add(this.labelTA);
            this.Controls.Add(this.labelHRA);
            this.Controls.Add(this.textHRA);
            this.Controls.Add(this.textBSalary);
            this.Controls.Add(this.labelBSalary);
            this.Controls.Add(this.labelEmpName);
            this.Controls.Add(this.labelEmpId);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.textEmpID);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_details);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textEmpID;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.Label labelEmpId;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelBSalary;
        private System.Windows.Forms.TextBox textBSalary;
        private System.Windows.Forms.TextBox textHRA;
        private System.Windows.Forms.Label labelHRA;
        private System.Windows.Forms.Label labelTA;
        private System.Windows.Forms.TextBox textTA;
        private System.Windows.Forms.Label labePF;
        private System.Windows.Forms.TextBox textPF;
        private System.Windows.Forms.Label labelNetPaid;
        private System.Windows.Forms.TextBox textNetPaid;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.ComboBox comboBoxDept;
    }
}


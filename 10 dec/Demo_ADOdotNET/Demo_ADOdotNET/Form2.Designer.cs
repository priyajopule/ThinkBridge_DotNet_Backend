namespace Demo_ADOdotNET
{
    partial class Form2
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
            this.labelEmpId = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelEmpSalary = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textEmpId = new System.Windows.Forms.TextBox();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.textDeptNo = new System.Windows.Forms.TextBox();
            this.labelDeptNo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmpId
            // 
            this.labelEmpId.AutoSize = true;
            this.labelEmpId.Location = new System.Drawing.Point(12, 9);
            this.labelEmpId.Name = "labelEmpId";
            this.labelEmpId.Size = new System.Drawing.Size(42, 13);
            this.labelEmpId.TabIndex = 0;
            this.labelEmpId.Text = "Emp ID";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(12, 45);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(59, 13);
            this.labelEmpName.TabIndex = 1;
            this.labelEmpName.Text = "Emp Name";
            // 
            // labelEmpSalary
            // 
            this.labelEmpSalary.AutoSize = true;
            this.labelEmpSalary.Location = new System.Drawing.Point(12, 86);
            this.labelEmpSalary.Name = "labelEmpSalary";
            this.labelEmpSalary.Size = new System.Drawing.Size(36, 13);
            this.labelEmpSalary.TabIndex = 2;
            this.labelEmpSalary.Text = "Salary";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(225, 6);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(225, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(225, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textEmpId
            // 
            this.textEmpId.Location = new System.Drawing.Point(107, 9);
            this.textEmpId.Name = "textEmpId";
            this.textEmpId.Size = new System.Drawing.Size(100, 20);
            this.textEmpId.TabIndex = 7;
            // 
            // textEmpName
            // 
            this.textEmpName.Location = new System.Drawing.Point(107, 42);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(100, 20);
            this.textEmpName.TabIndex = 8;
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(107, 79);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(100, 20);
            this.textSalary.TabIndex = 9;
            // 
            // textDeptNo
            // 
            this.textDeptNo.Location = new System.Drawing.Point(107, 120);
            this.textDeptNo.Name = "textDeptNo";
            this.textDeptNo.Size = new System.Drawing.Size(100, 20);
            this.textDeptNo.TabIndex = 10;
            // 
            // labelDeptNo
            // 
            this.labelDeptNo.AutoSize = true;
            this.labelDeptNo.Location = new System.Drawing.Point(12, 126);
            this.labelDeptNo.Name = "labelDeptNo";
            this.labelDeptNo.Size = new System.Drawing.Size(47, 13);
            this.labelDeptNo.TabIndex = 11;
            this.labelDeptNo.Text = "Dept No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(279, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(107, 355);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 13;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDeptNo);
            this.Controls.Add(this.textDeptNo);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.textEmpId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.labelEmpSalary);
            this.Controls.Add(this.labelEmpName);
            this.Controls.Add(this.labelEmpId);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpId;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelEmpSalary;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textEmpId;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.TextBox textDeptNo;
        private System.Windows.Forms.Label labelDeptNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDisplay;
    }
}
namespace assignment_WindowsFormsApp
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
            this.checkedListBoxcat = new System.Windows.Forms.CheckedListBox();
            this.comboBoxcat = new System.Windows.Forms.ComboBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.labelprdt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxcat
            // 
            this.checkedListBoxcat.FormattingEnabled = true;
            this.checkedListBoxcat.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.checkedListBoxcat.Location = new System.Drawing.Point(78, 137);
            this.checkedListBoxcat.Name = "checkedListBoxcat";
            this.checkedListBoxcat.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxcat.TabIndex = 0;
            // 
            // comboBoxcat
            // 
            this.comboBoxcat.FormattingEnabled = true;
            this.comboBoxcat.Location = new System.Drawing.Point(77, 66);
            this.comboBoxcat.Name = "comboBoxcat";
            this.comboBoxcat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxcat.TabIndex = 1;
            this.comboBoxcat.SelectedIndexChanged += new System.EventHandler(this.comboBoxcat_SelectedIndexChanged);
            // 
            // btn_view
            // 
            this.btn_view.ForeColor = System.Drawing.Color.Black;
            this.btn_view.Location = new System.Drawing.Point(297, 64);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "view1";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // labelprdt
            // 
            this.labelprdt.AutoSize = true;
            this.labelprdt.Location = new System.Drawing.Point(307, 124);
            this.labelprdt.Name = "labelprdt";
            this.labelprdt.Size = new System.Drawing.Size(65, 13);
            this.labelprdt.TabIndex = 3;
            this.labelprdt.Text = "labelproduct";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelprdt);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.comboBoxcat);
            this.Controls.Add(this.checkedListBoxcat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxcat;
        private System.Windows.Forms.ComboBox comboBoxcat;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label labelprdt;
    }
}


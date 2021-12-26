namespace Enquiry_System_project
{
    partial class Home
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
            this.btnEnquiry = new System.Windows.Forms.Button();
            this.btnCounseller = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnquiry
            // 
            this.btnEnquiry.Location = new System.Drawing.Point(193, 88);
            this.btnEnquiry.Name = "btnEnquiry";
            this.btnEnquiry.Size = new System.Drawing.Size(75, 23);
            this.btnEnquiry.TabIndex = 0;
            this.btnEnquiry.Text = "Enquiry";
            this.btnEnquiry.UseVisualStyleBackColor = true;
            this.btnEnquiry.Click += new System.EventHandler(this.btnEnquiry_Click);
            // 
            // btnCounseller
            // 
            this.btnCounseller.Location = new System.Drawing.Point(307, 88);
            this.btnCounseller.Name = "btnCounseller";
            this.btnCounseller.Size = new System.Drawing.Size(75, 23);
            this.btnCounseller.TabIndex = 1;
            this.btnCounseller.Text = "Counsellor";
            this.btnCounseller.UseVisualStyleBackColor = true;
            this.btnCounseller.Click += new System.EventHandler(this.btnCounseller_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(420, 88);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enquiry System for Institute";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCounseller);
            this.Controls.Add(this.btnEnquiry);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnquiry;
        private System.Windows.Forms.Button btnCounseller;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
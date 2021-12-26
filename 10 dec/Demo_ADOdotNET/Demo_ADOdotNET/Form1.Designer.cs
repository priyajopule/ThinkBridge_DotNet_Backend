namespace Demo_ADOdotNET
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
            this.textID = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.labelproductID = new System.Windows.Forms.Label();
            this.labelPName = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.btnshowallrec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(159, 27);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 0;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(159, 68);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 1;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(159, 105);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 20);
            this.textprice.TabIndex = 2;
            // 
            // labelproductID
            // 
            this.labelproductID.AutoSize = true;
            this.labelproductID.Location = new System.Drawing.Point(28, 30);
            this.labelproductID.Name = "labelproductID";
            this.labelproductID.Size = new System.Drawing.Size(57, 13);
            this.labelproductID.TabIndex = 3;
            this.labelproductID.Text = "product ID";
            // 
            // labelPName
            // 
            this.labelPName.AutoSize = true;
            this.labelPName.Location = new System.Drawing.Point(28, 68);
            this.labelPName.Name = "labelPName";
            this.labelPName.Size = new System.Drawing.Size(72, 13);
            this.labelPName.TabIndex = 4;
            this.labelPName.Text = "product name";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Location = new System.Drawing.Point(28, 105);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(30, 13);
            this.labelprice.TabIndex = 5;
            this.labelprice.Text = "price";
            // 
            // btnaddnew
            // 
            this.btnaddnew.Location = new System.Drawing.Point(31, 159);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(75, 23);
            this.btnaddnew.TabIndex = 6;
            this.btnaddnew.Text = "add new";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(159, 159);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(31, 199);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(159, 199);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(31, 405);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchID.TabIndex = 11;
            this.btnSearchID.Text = "search by ID";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // btnshowallrec
            // 
            this.btnshowallrec.Location = new System.Drawing.Point(140, 405);
            this.btnshowallrec.Name = "btnshowallrec";
            this.btnshowallrec.Size = new System.Drawing.Size(75, 23);
            this.btnshowallrec.TabIndex = 12;
            this.btnshowallrec.Text = "show all records";
            this.btnshowallrec.UseVisualStyleBackColor = true;
            this.btnshowallrec.Click += new System.EventHandler(this.btnshowallrec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.btnshowallrec);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.labelPName);
            this.Controls.Add(this.labelproductID);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.Label labelproductID;
        private System.Windows.Forms.Label labelPName;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.Button btnshowallrec;
    }
}


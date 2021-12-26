namespace ADODisconnectedDemo
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
            this.labelPid = new System.Windows.Forms.Label();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelPprice = new System.Windows.Forms.Label();
            this.textPid = new System.Windows.Forms.TextBox();
            this.textPname = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.btnShowAllrecords = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPid
            // 
            this.labelPid.AutoSize = true;
            this.labelPid.Location = new System.Drawing.Point(12, 20);
            this.labelPid.Name = "labelPid";
            this.labelPid.Size = new System.Drawing.Size(58, 13);
            this.labelPid.TabIndex = 0;
            this.labelPid.Text = "Product ID";
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Location = new System.Drawing.Point(12, 57);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(75, 13);
            this.labelPname.TabIndex = 1;
            this.labelPname.Text = "Product Name";
            // 
            // labelPprice
            // 
            this.labelPprice.AutoSize = true;
            this.labelPprice.Location = new System.Drawing.Point(12, 93);
            this.labelPprice.Name = "labelPprice";
            this.labelPprice.Size = new System.Drawing.Size(31, 13);
            this.labelPprice.TabIndex = 2;
            this.labelPprice.Text = "Price";
            // 
            // textPid
            // 
            this.textPid.Location = new System.Drawing.Point(106, 20);
            this.textPid.Name = "textPid";
            this.textPid.Size = new System.Drawing.Size(100, 20);
            this.textPid.TabIndex = 3;
            // 
            // textPname
            // 
            this.textPname.Location = new System.Drawing.Point(106, 57);
            this.textPname.Name = "textPname";
            this.textPname.Size = new System.Drawing.Size(100, 20);
            this.textPname.TabIndex = 4;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(106, 90);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(131, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(131, 191);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(75, 23);
            this.btnAddnew.TabIndex = 9;
            this.btnAddnew.Text = "AddNew";
            this.btnAddnew.UseVisualStyleBackColor = true;
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(12, 398);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(106, 23);
            this.btnSearchById.TabIndex = 10;
            this.btnSearchById.Text = "SearchById";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // btnShowAllrecords
            // 
            this.btnShowAllrecords.Location = new System.Drawing.Point(140, 398);
            this.btnShowAllrecords.Name = "btnShowAllrecords";
            this.btnShowAllrecords.Size = new System.Drawing.Size(137, 23);
            this.btnShowAllrecords.TabIndex = 11;
            this.btnShowAllrecords.Text = "ShowAllrecords";
            this.btnShowAllrecords.UseVisualStyleBackColor = true;
            this.btnShowAllrecords.Click += new System.EventHandler(this.btnShowAllrecords_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(262, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowAllrecords);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textPname);
            this.Controls.Add(this.textPid);
            this.Controls.Add(this.labelPprice);
            this.Controls.Add(this.labelPname);
            this.Controls.Add(this.labelPid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPid;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelPprice;
        private System.Windows.Forms.TextBox textPid;
        private System.Windows.Forms.TextBox textPname;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.Button btnShowAllrecords;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


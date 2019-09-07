namespace Veiw
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnreferesh = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.lblerorname = new System.Windows.Forms.Label();
            this.lblerorusername = new System.Windows.Forms.Label();
            this.lblerorsurname = new System.Windows.Forms.Label();
            this.lblerorpassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(30, 10);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 17);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Location = new System.Drawing.Point(30, 42);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(65, 17);
            this.lblsurname.TabIndex = 0;
            this.lblsurname.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(138, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(132, 22);
            this.txtname.TabIndex = 1;
            this.txtname.Validating += new System.ComponentModel.CancelEventHandler(this.txtname_Validating);
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(138, 42);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(132, 22);
            this.txtsurname.TabIndex = 2;
            this.txtsurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtsurname_Validating);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(138, 111);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(132, 22);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtpassword_Validating);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(138, 77);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(132, 22);
            this.txtusername.TabIndex = 3;
            this.txtusername.Validating += new System.ComponentModel.CancelEventHandler(this.txtusername_Validating);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Location = new System.Drawing.Point(12, 144);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(175, 61);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 230);
            this.dataGridView1.TabIndex = 10;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(427, 141);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(175, 64);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnreferesh
            // 
            this.btnreferesh.Location = new System.Drawing.Point(220, 141);
            this.btnreferesh.Name = "btnreferesh";
            this.btnreferesh.Size = new System.Drawing.Size(175, 61);
            this.btnreferesh.TabIndex = 13;
            this.btnreferesh.Text = "Referesh";
            this.btnreferesh.UseVisualStyleBackColor = true;
            this.btnreferesh.Click += new System.EventHandler(this.btnreferesh_Click_1);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(631, 141);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(157, 61);
            this.btnedit.TabIndex = 14;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblerorname
            // 
            this.lblerorname.AutoSize = true;
            this.lblerorname.Location = new System.Drawing.Point(312, 8);
            this.lblerorname.Name = "lblerorname";
            this.lblerorname.Size = new System.Drawing.Size(0, 17);
            this.lblerorname.TabIndex = 16;
            // 
            // lblerorusername
            // 
            this.lblerorusername.AutoSize = true;
            this.lblerorusername.Location = new System.Drawing.Point(312, 80);
            this.lblerorusername.Name = "lblerorusername";
            this.lblerorusername.Size = new System.Drawing.Size(0, 17);
            this.lblerorusername.TabIndex = 17;
            // 
            // lblerorsurname
            // 
            this.lblerorsurname.AutoSize = true;
            this.lblerorsurname.Location = new System.Drawing.Point(312, 42);
            this.lblerorsurname.Name = "lblerorsurname";
            this.lblerorsurname.Size = new System.Drawing.Size(0, 17);
            this.lblerorsurname.TabIndex = 19;
            // 
            // lblerorpassword
            // 
            this.lblerorpassword.AutoSize = true;
            this.lblerorpassword.Location = new System.Drawing.Point(312, 116);
            this.lblerorpassword.Name = "lblerorpassword";
            this.lblerorpassword.Size = new System.Drawing.Size(0, 17);
            this.lblerorpassword.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblerorpassword);
            this.Controls.Add(this.lblerorsurname);
            this.Controls.Add(this.lblerorusername);
            this.Controls.Add(this.lblerorname);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnreferesh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
       
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreferesh;
        private System.Windows.Forms.Button btnedit;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblerorname;
        private System.Windows.Forms.Label lblerorusername;
        private System.Windows.Forms.Label lblerorsurname;
        private System.Windows.Forms.Label lblerorpassword;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtsurname;
        public System.Windows.Forms.TextBox txtpassword;
        public System.Windows.Forms.TextBox txtusername;
        public System.Windows.Forms.Button btnsave;
    }
}


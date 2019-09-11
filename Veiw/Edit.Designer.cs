namespace Veiw
{
    partial class Edit
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnreferesh = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(73, 69);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(132, 22);
            this.txtusername.TabIndex = 3;
            this.txtusername.Validating += new System.ComponentModel.CancelEventHandler(this.txtusername_Validating);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(73, 110);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(132, 22);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtpassword_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Location = new System.Drawing.Point(2, 41);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(65, 17);
            this.lblsurname.TabIndex = 10;
            this.lblsurname.Text = "Surname";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(2, 4);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 17);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Name";
            // 
            // btnedit
            // 
            this.btnedit.Enabled = false;
            this.btnedit.Location = new System.Drawing.Point(203, 143);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(112, 89);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(36, 143);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 17);
            this.lblid.TabIndex = 18;
            this.lblid.Text = "ID";
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(73, 41);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(132, 22);
            this.txtsurname.TabIndex = 2;
            this.txtsurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtsurname_Validating_1);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(53, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(132, 22);
            this.txtname.TabIndex = 1;
            this.txtname.Validating += new System.ComponentModel.CancelEventHandler(this.txtname_Validating);
            // 
            // btnreferesh
            // 
            this.btnreferesh.Enabled = false;
            this.btnreferesh.Location = new System.Drawing.Point(73, 143);
            this.btnreferesh.Name = "btnreferesh";
            this.btnreferesh.Size = new System.Drawing.Size(102, 89);
            this.btnreferesh.TabIndex = 6;
            this.btnreferesh.Text = "Referesh";
            this.btnreferesh.UseVisualStyleBackColor = true;
            this.btnreferesh.Click += new System.EventHandler(this.btnreferesh_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(231, 76);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(0, 17);
            this.lblusername.TabIndex = 0;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(231, 46);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(0, 17);
            this.lbl_surname.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(218, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 17);
            this.lblname.TabIndex = 0;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(231, 115);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(0, 17);
            this.lblpassword.TabIndex = 0;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 233);
            this.ControlBox = false;
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnreferesh);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lbl_Name);
            this.MinimumSize = new System.Drawing.Size(297, 280);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btnedit;
        public System.Windows.Forms.TextBox txtusername;
        public System.Windows.Forms.TextBox txtpassword;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.TextBox txtsurname;
        public System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnreferesh;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblpassword;
    }
}
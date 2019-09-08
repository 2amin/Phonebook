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
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(138, 76);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(132, 22);
            this.txtusername.TabIndex = 16;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(138, 115);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(132, 22);
            this.txtpassword.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Location = new System.Drawing.Point(30, 41);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(65, 17);
            this.lblsurname.TabIndex = 10;
            this.lblsurname.Text = "Surname";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(30, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 17);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Name";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(158, 143);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(112, 89);
            this.btnedit.TabIndex = 17;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(34, 143);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 17);
            this.lblid.TabIndex = 18;
            this.lblid.Text = "ID";
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(138, 41);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(132, 22);
            this.txtsurname.TabIndex = 14;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(138, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(132, 22);
            this.txtname.TabIndex = 13;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 233);
            this.ControlBox = false;
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
            this.MaximumSize = new System.Drawing.Size(297, 280);
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
    }
}
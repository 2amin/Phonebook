namespace Veiw
{
    partial class BuyerRegister
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.btnclick = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(123, 20);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(158, 22);
            this.txtname.TabIndex = 1;
            this.txtname.Validating += new System.ComponentModel.CancelEventHandler(this.txtname_Validating);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(123, 84);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(158, 22);
            this.txtusername.TabIndex = 3;
            this.txtusername.Validating += new System.ComponentModel.CancelEventHandler(this.txtusername_Validating);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(123, 113);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(158, 22);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtpassword_Validating);
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(123, 51);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(158, 22);
            this.txtsurname.TabIndex = 2;
            this.txtsurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtsurname_Validating_1);
            // 
            // btnclick
            // 
            this.btnclick.Enabled = false;
            this.btnclick.Location = new System.Drawing.Point(41, 178);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(134, 62);
            this.btnclick.TabIndex = 6;
            this.btnclick.Text = "Click";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(334, 20);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 17);
            this.lblname.TabIndex = 6;
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Location = new System.Drawing.Point(334, 51);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(0, 17);
            this.lblsurname.TabIndex = 7;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(334, 84);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(0, 17);
            this.lblusername.TabIndex = 8;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(334, 116);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(0, 17);
            this.lblpassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(123, 142);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(158, 22);
            this.txtemail.TabIndex = 5;
            this.txtemail.Validating += new System.ComponentModel.CancelEventHandler(this.txtemail_Validating);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(313, 147);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(0, 17);
            this.lblemail.TabIndex = 11;
            // 
            // BuyerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 252);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnclick);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuyerRegister";
            this.Text = "BuyerRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
    }
}
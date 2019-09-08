namespace Veiw
{
    partial class SellerSignin
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(120, 27);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(137, 22);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(120, 69);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(137, 22);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtpassword_Validating);
            // 
            // btnenter
            // 
            this.btnenter.Enabled = false;
            this.btnenter.Location = new System.Drawing.Point(12, 118);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(146, 64);
            this.btnenter.TabIndex = 3;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(164, 118);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(139, 64);
            this.btnregister.TabIndex = 4;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            // 
            // SellerSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 194);
            this.ControlBox = false;
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(333, 241);
            this.MinimumSize = new System.Drawing.Size(333, 241);
            this.Name = "SellerSignin";
            this.Text = "SellerSignin";
            this.Load += new System.EventHandler(this.SellerSignin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btnregister;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veiw
{
    public partial class SellerSignin : Form
    {
        #region [-Ctor-]
        public SellerSignin()
        {
            InitializeComponent();
        } 
        #endregion
        public VeiwModel.PersonVeiwModel Ref_PersonVeiwModel { get; set; }
        public Form1 Ref_frm1 { get; set; }
        public User Ref_User { get; set; }
        public Edit Ref_Edit { get; set; }
        public MasterForm Ref_Masterform { get; set; }
        #region [-btnenter_Click-]
        private void btnenter_Click(object sender, EventArgs e)
        {
            int i = 0;
            Ref_frm1 = new Form1();
            Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
            Ref_Masterform = new MasterForm();
            Ref_frm1.dataGridView1.DataSource = Ref_PersonVeiwModel.FillGrid();
            Ref_User = new User();
            //Ref_User.MdiParent =Ref_Masterform;

            for (int j = 0; j < Ref_frm1.dataGridView1.RowCount; j++)
            {
                if (i == 0)
                {
                    if (txtusername.Text == Convert.ToString(Ref_frm1.dataGridView1[3, j].Value) &
                   txtpassword.Text == Convert.ToString(Ref_frm1.dataGridView1[4, j].Value))
                    {
                        i++;
                        Ref_User = new User();
                        Ref_Edit = new Edit();
                        Ref_User.toolStripLabel1.Text = "Welcome" + " " + Ref_frm1.dataGridView1[1, j].Value;
                        Ref_User.toolStripLabel2.Text = Convert.ToString(Ref_frm1.dataGridView1[0, j].Value);


                        this.Close();
                        Ref_User.Show();
                        txtpassword.Text = txtusername.Text = null;
                    }
                }
                if (i == 1)
                {
                    break;
                }

            }
            if (i != 1)
            {
                MessageBox.Show("There is no this Username and password" + " " + txtpassword.Text + " " + txtusername.Text);
                txtpassword.Text = txtusername.Text = null;
                btnenter.Enabled = false;
            }


        }
        #endregion
        #region [-txtpassword_Validating-]
        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            btnenter.Enabled = true;
        } 
        #endregion
    }
}

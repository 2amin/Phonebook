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
    public partial class Edit : Form
    {

        #region [-Ctor-]
        public Edit()
        {

            InitializeComponent();

        } 
        #endregion
        #region [-txtname_Validating-]
        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            if (txtname.Text == "")
            {
                lblname.Text = "Please Enter Name";
                lblname.ForeColor = Color.Red;
                txtname.Focus();
            }
            if (txtname.Text != "")
            {
                lblname.Text = "Correct";
                lblname.ForeColor = Color.Green;
            }
            for (int k = 0; k < txtname.Text.Length; k++)
            {
                {
                    if (!(txtname.Text[k] >= 'a' & txtname.Text[k] <= 'z' || txtname.Text[k] >= 'A' & txtname.Text[k] <= 'Z'))
                    {
                        lblname.Text = "Username Should have just Character";
                        lblname.ForeColor = Color.Red;
                        txtname.Focus();
                        i++;

                    }
                    if (i == 0)
                    {
                        if (txtname.Text[k] >= '0' & txtname.Text[k] <= '9')
                        {
                            lblname.Text = "Correct";
                            lblname.ForeColor = Color.Green;

                        }
                    }
                    if (i == 1)
                    {
                        continue;
                    }




                }
            }
        }
        #endregion
        #region [-txtsurname_Validating_1-]
        private void txtsurname_Validating_1(object sender, CancelEventArgs e)
        {
            int i = 0;
            if (txtsurname.Text == "")
            {
                lbl_surname.Text = "Please Enter Name";
                lbl_surname.ForeColor = Color.Red;
                txtsurname.Focus();
            }
            if (txtsurname.Text != "")
            {
                lbl_surname.Text = "Correct";
                lbl_surname.ForeColor = Color.Green;
            }
            for (int k = 0; k < txtsurname.Text.Length; k++)
            {
                {
                    if (!(txtsurname.Text[k] >= 'a' & txtsurname.Text[k] <= 'z' || txtsurname.Text[k] >= 'A' & txtsurname.Text[k] <= 'Z'))
                    {
                        lbl_surname.Text = "Username Should have just Character";
                        lbl_surname.ForeColor = Color.Red;
                        txtsurname.Focus();
                        i++;

                    }
                    if (i == 0)
                    {
                        if (txtsurname.Text[k] >= '0' & txtsurname.Text[k] <= '9')
                        {
                            lbl_surname.Text = "Correct";
                            lbl_surname.ForeColor = Color.Green;

                        }
                    }
                    if (i == 1)
                    {
                        continue;
                    }




                }
            }
        }
        #endregion
        #region [-txtusername_Validating-]

        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            if (txtusername.Text != "")
            {
                for (int k = 0; k < txtusername.Text.Length; k++)
                {
                    {
                        if (!(txtusername.Text[k] >= '0' & txtusername.Text[k] <= '9'))
                        {
                            lblusername.Text = "Username Should have just number";
                            lblusername.ForeColor = Color.Red;
                            txtusername.Focus();
                            i++;

                        }

                        if (i == 0)
                        {
                            if (txtusername.Text[k] >= '0' & txtusername.Text[k] <= '9')
                            {
                                lblusername.Text = "Correct";
                                lblusername.ForeColor = Color.Green;

                            }

                        }
                        if (i == 1)
                        {
                            continue;
                        }



                    }
                }
            }

            if (txtusername.Text == "")
            {
                lblusername.Text = "Please Enter Username";
                lblusername.ForeColor = Color.Red;
                txtusername.Focus();
            }


        }
        #endregion
        #region [-txtpassword_Validating-]

        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            if (txtpassword.Text != "")
            {
                for (int k = 0; k < txtpassword.Text.Length; k++)
                {
                    if (!(txtpassword.Text[k] >= '0' & txtpassword.Text[k] <= '9'))
                    {
                        lblpassword.Text = "Username Should have just number";
                        lblpassword.ForeColor = Color.Red;
                        txtpassword.Focus();
                        i++;
                    }
                    if (i == 0)
                    {
                        if (txtpassword.Text[k] >= '0' & txtpassword.Text[k] <= '9')
                        {
                            lblpassword.Text = "Correct";
                            lblpassword.ForeColor = Color.Green;
                            btnedit.Enabled = true;
                        }
                    }
                    if (i == 1)
                    {
                        continue;
                    }

                }
            }

            if (txtpassword.Text == "")
            {
                lblpassword.Text = "Please Enter Password";
                lblpassword.ForeColor = Color.Red;
                txtpassword.Focus();
                btnedit.Enabled = false;
            }

        }
        #endregion
        #region [-btnedit_Click-]
        public VeiwModel.PersonVeiwModel Ref_PersonVeiwModel { get; set; }

        public Form1 Ref_frm1 { get; set; }
        private void btnedit_Click(object sender, EventArgs e)
        {

            Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
            Ref_PersonVeiwModel.Edit(txtname.Text, txtsurname.Text, Convert.ToInt32(txtusername.Text), Convert.ToInt32(txtpassword.Text), Convert.ToInt32(lblid.Text));
            btnreferesh.Enabled = true;
            int i = 0;
            int CheckUsername = 0;
            int CheckPassword = 0;
            Ref_frm1 = new Form1();
            Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
            Ref_frm1.dataGridView1.DataSource = Ref_PersonVeiwModel.FillGrid();
            for (int j = 0; j < Ref_frm1.dataGridView1.RowCount; j++)
            {
                if (txtusername.Text == Convert.ToString(Ref_frm1.dataGridView1[3, j].Value))
                {
                    CheckUsername++;


                }
                if (txtpassword.Text == Convert.ToString(Ref_frm1.dataGridView1[4, j].Value))
                {
                    CheckPassword++;


                }
            }

            if (CheckPassword >= 1)
            {

                txtpassword.Text = "";
                lblpassword.Text = "Another User had Saved this Password before You saved";
                lblpassword.ForeColor = Color.Red;
                btnedit.Enabled = false;
                i++;
            }
            if (CheckUsername >= 1)
            {

                txtusername.Text = "";
                lblusername.Text = "Another User had Saved this Password before You saved";
                lblusername.ForeColor = Color.Red;
                btnedit.Enabled = false;
                i++;
            }
            if (CheckPassword >= 1 & CheckUsername >= 1)
            {
                MessageBox.Show("Another User had Saved these Username and Password before You saved");
                txtusername.Text = "";
                lblusername.Text = "Another User had Saved this Password before You saved";
                lblusername.ForeColor = Color.Red;
                txtpassword.Text = "";
                lblpassword.Text = "Another User had Saved this Password before You saved";
                lblpassword.ForeColor = Color.Red;
                btnedit.Enabled = false;
                i++;

            }

            if (CheckPassword == 0 & CheckUsername == 0)
            {

                if (i == 0)
                {
                    Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();

                    Ref_PersonVeiwModel.Save(txtname.Text, txtsurname.Text, Convert.ToInt32(txtusername.Text), Convert.ToInt32(txtpassword.Text));
                    MessageBox.Show("Saving is done Please Click Referesh");

                    txtname.Text = txtsurname.Text = txtusername.Text = txtpassword.Text = null;
                    lblname.Text = lblsurname.Text = lblusername.Text = lblpassword.Text = null;

                }

            }



        }
        #endregion
        #region [-btnreferesh_Click-]
        private void btnreferesh_Click(object sender, EventArgs e)
        {
            Ref_frm1 = new Form1();
            Ref_frm1.dataGridView1.DataSource = Ref_PersonVeiwModel.FillGrid();
            this.Close();

        } 
        #endregion


    }
}

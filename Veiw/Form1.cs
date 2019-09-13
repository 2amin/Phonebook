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
    public partial class Form1 : Form
    {
        #region [-Ctor-]
        public Form1()
        {

            InitializeComponent();

        } 
        #endregion
        public VeiwModel.PersonVeiwModel Ref_PersonVeiwModel { get; set; }
        #region [-btnsave_Click-]
        int i = 0;
        
        private void btnsave_Click(object sender, EventArgs e)
        {
            int ChecKUsername = 0;
            int CheckPassword = 0;

            for (int j = 0; j < dataGridView1.RowCount; j++)
            {

                if (txtusername.Text == Convert.ToString(dataGridView1[3, j].Value))
                {
                    ChecKUsername++;


                }
                
                if (txtpassword.Text == Convert.ToString(dataGridView1[4, j].Value))
                {
                    CheckPassword++;


                }
            }

            if (CheckPassword >= 1)
            {
                MessageBox.Show("Another User had Saved this Password before You saved");
                txtpassword.Text = "";
                lblerorpassword.Text = "Another User had Saved this Password before You saved";
                lblerorpassword.ForeColor = Color.Red;
                btnsave.Enabled = false;
            }
            if (ChecKUsername >= 1)
            {
                MessageBox.Show("Another User had Saved this Username before You saved");
                txtpassword.Text = "";
                lblerorusername.Text = "Another User had Saved this Password before You saved";
                lblerorpassword.ForeColor = Color.Red;
                btnsave.Enabled = false;
            }
            if (CheckPassword >= 1 & ChecKUsername >= 1)
            {
                MessageBox.Show("Another User had Saved these Username and Password before You saved");
                txtusername.Text = "";
                lblerorusername.Text = "Another User had Saved this Password before You saved";
                lblerorusername.ForeColor = Color.Red;
                txtpassword.Text = "";
                lblerorpassword.Text = "Another User had Saved this Password before You saved";
                lblerorpassword.ForeColor = Color.Red;
                btnsave.Enabled = false;
                
            }
           
            if (CheckPassword == 0 & ChecKUsername == 0)
            {
               
                if (i == 0)
                {
                    Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
                    Ref_PersonVeiwModel.Save(txtname.Text, txtsurname.Text, Convert.ToInt32(txtusername.Text), Convert.ToInt32(txtpassword.Text),txtemail.Text);
                    MessageBox.Show("Saving is done Please Click Referesh");
                    txtname.Text = txtsurname.Text = txtusername.Text = txtpassword.Text = null;
                    lblerorname.Text = lblerorsurname.Text = lblerorusername.Text = lblerorpassword.Text = null;
              
                }
            
            }
            


        }
        #endregion
        #region [-btndelete_Click-]


        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Please Enter Refersh to load Person");
               
            }
            if (dataGridView1.RowCount>=1)
            {
                Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
                MessageBox.Show("The Current Person is Deleted,Please Click Referesh");
                Ref_PersonVeiwModel.Delete(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
            }


        }
        #endregion
        #region [-btnreferesh_Click_1-]
        private void btnreferesh_Click_1(object sender, EventArgs e)
        {
            Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
            dataGridView1.DataSource = Ref_PersonVeiwModel.FillGrid();

        }
        #endregion
        #region [-btnedit_Click-]
        public Edit Ref_Edit { get; set; }
       
        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Please Enter Refersh to load Person");
               
            }
            if (dataGridView1.RowCount >=1)
            {
                Ref_Edit = new Edit();
                Ref_Edit.lblid.Text = Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                Ref_Edit.txtname.Text = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
                Ref_Edit.txtsurname.Text = Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
                Ref_Edit.txtusername.Text = Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
                Ref_Edit.txtpassword.Text = Convert.ToString(dataGridView1[4, dataGridView1.CurrentRow.Index].Value);
                Ref_Edit.ShowDialog();
            }



        }

        #endregion
        #region [-txtname_Validating-]
        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if (txtname.Text == "")
            {
                lblerorname.Text = "Please Enter Name";
                lblerorname.ForeColor = Color.Red;
                txtname.Focus();
            }
            if (txtname.Text != "")
            {
                lblerorname.Text = "Correct";
                lblerorname.ForeColor = Color.Green;
            }
        }
        #endregion
        #region [-txtsurname_Validating-]
        private void txtsurname_Validating(object sender, CancelEventArgs e)
        {
            if (txtsurname.Text == "")
            {
                lblerorsurname.Text = "Please Enter Name";
                lblerorsurname.ForeColor = Color.Red;
                txtsurname.Focus();
            }
            if (txtsurname.Text != "")
            {
                lblerorsurname.Text = "Correct";
                lblerorsurname.ForeColor = Color.Green;
            }
        }
        #endregion
        #region [-txtusername_Validating-]
        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
            if (txtusername.Text != "")
            {
                for (int k = 0; k < txtusername.Text.Length; k++)
                {
                    {
                        if (!(txtusername.Text[k] >= '0' & txtusername.Text[k] <= '9'))
                        {
                            lblerorusername.Text = "Username Should have just number";
                            lblerorusername.ForeColor = Color.Red;
                            txtusername.Focus();
                        }
                        if (txtusername.Text[k] >= '0' & txtusername.Text[k] <= '9')
                        {
                            lblerorusername.Text = "Correct";
                            lblerorusername.ForeColor = Color.Green;

                        }
                    }
                    if (txtusername.Text == "")
                    {
                        lblerorusername.Text = "Please Enter Username";
                        lblerorusername.ForeColor = Color.Red;
                        txtusername.Focus();
                    }

                }
            }
            
        }
        #endregion
        #region [-txtpassword_Validating-]
        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtpassword.Text != "")
            {
                for (int k = 0; k < txtpassword.Text.Length; k++)
                {
                    if (!(txtpassword.Text[k] >= '0' & txtpassword.Text[k] <= '9'))
                    {
                        lblerorpassword.Text = "Username Should have just number";
                        lblerorpassword.ForeColor = Color.Red;
                        txtpassword.Focus();
                    }
                    if (txtpassword.Text[k] >= '0' & txtpassword.Text[k] <= '9')
                    {
                        lblerorpassword.Text = "Correct";
                        lblerorpassword.ForeColor = Color.Green;
                        btnsave.Enabled = true;
                    }
                }
            }
                
                if (txtpassword.Text == "")
                {
                    lblerorpassword.Text = "Please Enter Password";
                    lblerorpassword.ForeColor = Color.Red;
                    txtpassword.Focus();
                    btnsave.Enabled = false;
                }

            }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
            dataGridView1.DataSource = Ref_PersonVeiwModel.FillGrid();
        }
    } 
        #endregion
    }


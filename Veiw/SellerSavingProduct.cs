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
    public partial class Saving_Product : Form
    {
        #region [-Ctor-]
        public Saving_Product()
        {
            InitializeComponent();
        } 
        #endregion
        public VeiwModel.ProductVeiwModel1 Ref_ProductVeiwModel { get; set; }
        #region [-btnsave_Click-]
        private void btnsave_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(i==0)
            {
                if (txtname.Text == "" & txtunitprice.Text == "" & txtnumber.Text == "")
                {
                    MessageBox.Show("Please Fill All Parametr");
                    i++;
                    
                }
            }
           if(i!=1)
            {
                Ref_ProductVeiwModel = new VeiwModel.ProductVeiwModel1();
               
               
                int Checkname = 0;

                for (int j = 0; j < dataGridView1.RowCount; j++)
                {

                    if (txtname.Text == Convert.ToString(dataGridView1[0, j].Value))
                    {
                        int ChecKname = 0;
                        ChecKname++;


                    }


                }

                if (Checkname == 1)
                {
                    MessageBox.Show("this Producd was Saved");
                    txtname.Text = txtunitprice.Text = txtnumber.Text = "";
                    btnsave.Enabled = false;
                }
                if (Checkname != 1)
                {
                    Ref_ProductVeiwModel = new VeiwModel.ProductVeiwModel1();
                    Ref_ProductVeiwModel.Save(txtname.Text, Convert.ToInt32(txtnumber.Text)
                        , Convert.ToInt32(txtunitprice.Text));
                    MessageBox.Show("This Product is Saved");

                }

            }
          
        }
        #endregion
        #region [-btnreferesh_Click-]
        private void btnreferesh_Click(object sender, EventArgs e)
        {
            Ref_ProductVeiwModel = new VeiwModel.ProductVeiwModel1();
            dataGridView1.DataSource = Ref_ProductVeiwModel.FillGrid();
        }

        #endregion

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Please Enter Refersh to load Person");

            }
            if (dataGridView1.RowCount >= 1)
            {
                Ref_ProductVeiwModel = new VeiwModel.ProductVeiwModel1();
                MessageBox.Show("The Current Person is Deleted,Please Click Referesh");
                Ref_ProductVeiwModel.Delete(Convert.ToInt32(dataGridView1[3, dataGridView1.CurrentRow.Index].Value));
                dataGridView1.DataSource = Ref_ProductVeiwModel.FillGrid();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }
    }
}

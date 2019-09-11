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
    public partial class Buyer_Products : Form
    {
        #region [-Ctor-]
        public Buyer_Products()
        {
            InitializeComponent();
        } 
        #endregion
        public VeiwModel.ProductVeiwModel1 Ref_ProductVeiwModel { get; set; }
        #region [-btnrefersh_Click-]
        private void btnrefersh_Click(object sender, EventArgs e)
        {
            Ref_ProductVeiwModel = new VeiwModel.ProductVeiwModel1();
            dataGridView1.DataSource = Ref_ProductVeiwModel.FillGrid();
        }
        #endregion
        #region [-Buyer_Products_Load-]
        private void Buyer_Products_Load(object sender, EventArgs e)
        {
            Ref_ProductVeiwModel = new VeiwModel.ProductVeiwModel1();
            dataGridView1.DataSource = Ref_ProductVeiwModel.FillGrid();
        }
        #endregion
        #region [-btnsave_Click-]
        private void btnsave_Click(object sender, EventArgs e)
        {
            int i = 0;
            Ref_ProductVeiwModel = new VeiwModel.ProductVeiwModel1();
            int Currentrownum;
            if (Ref_ProductVeiwModel.Consider(Convert.ToInt32(txtid.Text)) == 0)
            {
                MessageBox.Show("There is no Current Item at the moment");

            }
            if (Ref_ProductVeiwModel.Consider(Convert.ToInt32(txtid.Text)) != 0)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (i == 0)
                    {
                        if (txtid.Text == Convert.ToString(dataGridView1[3, j].Value))

                        {
                            i++;
                            Currentrownum = Convert.ToInt32(dataGridView1[2, j].Value);
                            Currentrownum--;
                            Ref_ProductVeiwModel.Changing(Convert.ToInt32(txtid.Text), Currentrownum);
                            dataGridView1.DataSource = Ref_ProductVeiwModel.FillGrid();
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

    }
}
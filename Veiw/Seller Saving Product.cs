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
            Ref_ProductVeiwModel = new VeiwModel.ProductVeiwModel1();
            Ref_ProductVeiwModel.Save(txtname.Text, Convert.ToInt32(txtnumber.Text), Convert.ToInt32(txtunitprice.Text));
        }
        #endregion
        #region [-btnreferesh_Click-]
        private void btnreferesh_Click(object sender, EventArgs e)
        {
            Ref_ProductVeiwModel = new VeiwModel.ProductVeiwModel1();
            dataGridView1.DataSource = Ref_ProductVeiwModel.FillGrid();
        } 
        #endregion


    }
}

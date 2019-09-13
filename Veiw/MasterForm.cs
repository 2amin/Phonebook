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
    public partial class MasterForm : Form
    {
        #region [-Ctor-]
        public MasterForm()
        {
            InitializeComponent();
        }
        #endregion
        #region [-signUpToolStripMenuItem_Click-]
        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyerRegister Ref_frm1 = new BuyerRegister();
            Ref_frm1.MdiParent = this;

            Ref_frm1.Show();
        }
        #endregion
        #region [-sellerToolStripMenuItem_Click-]
        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerSignin Ref_Sellersignin = new SellerSignin();

            User Ref_User = new User();
            Ref_Sellersignin.MdiParent = this;

            Ref_Sellersignin.Show();
        }


        #endregion

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

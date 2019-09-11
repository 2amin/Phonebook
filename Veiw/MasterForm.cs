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
        public MasterForm()
        {
            InitializeComponent();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyerRegister Ref_frm1 = new BuyerRegister();
            Ref_frm1.MdiParent = this;
            
            Ref_frm1.Show();
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerSignin Ref_Sellersignin = new SellerSignin();
           
            User Ref_User = new User();
            Ref_Sellersignin.MdiParent = this;
            
            Ref_Sellersignin.Show();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {

        }
    }
}

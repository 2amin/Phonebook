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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        public Edit Ref_Edit { get; set; }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ref_Edit = new Edit();
            Ref_Edit.MdiParent = this;
            Ref_Edit.Show();
        }
    }
}

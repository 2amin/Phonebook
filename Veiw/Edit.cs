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
       
        public Edit()
        {
            
            InitializeComponent();
           
        }
        
        public VeiwModel.PersonVeiwModel Ref_PersonVeiwModel { get; set; }
        
        
        private void btnedit_Click(object sender, EventArgs e)
        {
            
            
            Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
            Ref_PersonVeiwModel.Edit(txtname.Text, txtsurname.Text, Convert.ToInt32(txtusername.Text), Convert.ToInt32(txtpassword.Text),Convert.ToInt32(lblid.Text));
            this.Close();
            Ref_PersonVeiwModel.FillGrid();
        }
    }
}

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
        public Form1()
        {
            InitializeComponent();
        }
        public VeiwModel.PersonVeiwModel Ref_PersonVeiwModel { get; set; }
        private void btnsave_Click(object sender, EventArgs e)
        {
            Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
            Ref_PersonVeiwModel.Save(txtname.Text, txtsurname.Text, Convert.ToInt32(txtusername.Text),Convert.ToInt32( txtpassword.Text));
            MessageBox.Show("Saving is done");
        }



        private void btndelete_Click(object sender, EventArgs e)
        {
            Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
             ;
            Ref_PersonVeiwModel.Delete(Convert.ToInt32(dataGridView1[0,dataGridView1.CurrentRow.Index].Value));
            
        }

        private void btnreferesh_Click_1(object sender, EventArgs e)
        {
            Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
            dataGridView1.DataSource = Ref_PersonVeiwModel.FillGrid();

        }
        public Edit Ref_Edit { get; set; }
        private void btnedit_Click(object sender, EventArgs e)
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
}

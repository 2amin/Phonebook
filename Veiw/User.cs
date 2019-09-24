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
        #region [-Ctor-]
        public User()
        {
            InitializeComponent();
        } 
        #endregion
        public Edit Ref_Edit { get; set; }
        //public User Ref_User { get; set; }
        //public Form1 Ref_Form1 { get; set; }
        public VeiwModel.PersonVeiwModel Ref_PersonVeiwModel { get; set; }
       
        #region [-editToolStripMenuItem_Click_1-]
        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            #region [Solution1-]
            //int i = 0;
            //Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
            //Ref_Form1 = new Form1();
            //Ref_Edit = new Edit();
            //Ref_User = new User();
            //Ref_Form1.dataGridView1.DataSource = Ref_PersonVeiwModel.FillGrid();
            //for (int j = 0; j < Ref_Form1.dataGridView1.RowCount; j++)
            //{
            //    if (i == 0)
            //    {
            //        if (toolStripLabel2.Text == Convert.ToString(Ref_Form1.dataGridView1[0, j].Value))

            //        {
            //            Ref_Edit.txtname.Text = Convert.ToString(Ref_Form1.dataGridView1[1, j].Value);
            //            Ref_Edit.txtsurname.Text = Convert.ToString(Ref_Form1.dataGridView1[2, j].Value);
            //            Ref_Edit.txtusername.Text = Convert.ToString(Ref_Form1.dataGridView1[3, j].Value);
            //            Ref_Edit.txtpassword.Text = Convert.ToString(Ref_Form1.dataGridView1[4, j].Value);
            //            Ref_Edit.txtemail.Text = Convert.ToString(Ref_Form1.dataGridView1[5, j].Value);
            //            Ref_Edit.lblid.Text = Convert.ToString(Ref_Form1.dataGridView1[0, j].Value);

            //            i++;
            //        }
            //    }
            //    if (i == 1)
            //        break;

            //}
            //Ref_Edit.MdiParent = this;
            //Ref_Edit.Show();
            #endregion
            Ref_PersonVeiwModel = new VeiwModel.PersonVeiwModel();
            Ref_Edit = new Edit();
            List<string> people = new List<string>();
            people=Ref_PersonVeiwModel.EditButtonClick(Convert.ToInt32(toolStripLabel2.Text));
            for(int i=0;i<=people.Capacity;i++)
            {
                switch(i)
                {
                    case 0: Ref_Edit.txtname.Text = people[0];
                        break;
                    case 1:Ref_Edit.txtsurname.Text = people[1];
                        break;
                    case 2:Ref_Edit.txtusername.Text = people[2];
                        break;
                    case 3:Ref_Edit.txtpassword.Text = people[3];
                        break;
                    case 4:Ref_Edit.txtemail.Text = people[4];
                        break;
                }
            }
            Ref_Edit.MdiParent = this;
            Ref_Edit.Show();

        } 
        #endregion
        public Buyer_Products Ref_Buyerproduct { get; set; }
        #region [-productToolStripMenuItem_Click-]
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ref_Buyerproduct = new Buyer_Products();
            Ref_Buyerproduct.Show();
        } 
        #endregion


    }
}

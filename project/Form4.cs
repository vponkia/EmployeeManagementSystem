using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form4 : Form
    {
        private Form1 form1;
        List<employee> eList4 = new List<employee>();
        List<manager> mLsit4 = new List<manager>();
        List<task> tList4 = new List<task>();
        public Form4(Form1 form1,List<employee> eList, List<manager> mList, List<task> tList)
        {
            InitializeComponent();
            this.form1 = form1;
            eList4 = eList;
            mLsit4 = mList;
            tList4 = tList;
        }

        private void btnAssignMangerE_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
            lbxDisplayEmployee.Items.Clear();
        }

        private void btnDisplayE_Click(object sender, EventArgs e)
        {
            lbxDisplayEmployee.Items.Clear();
            Boolean flag = true;

            employee eName = eList4.Find(x => x.E_Name.Equals(txtDisplayE_Ename.Text));
            string appedTask = "";
            if (eName != null)
            {
                appedTask += eName.ToString();

                foreach (var c in eName.TaskAssign)
                {
                    appedTask += " task Name  : " + c.T_name;

                }



                foreach (var c in eName.ManagerAssign)
                {
                    appedTask += " Manager Name  : " + c.M_name;

                }

                lbxDisplayEmployee.Items.Add(appedTask);
            }





            else
            {
                MessageBox.Show("Employee is not in list");
            }
            txtDisplayE_Ename.ResetText();
        }
    }
}

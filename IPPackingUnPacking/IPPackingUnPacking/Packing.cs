using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPPackingUnPacking
{

    public partial class Packing : Form
    {
        public Packing()
        {
            InitializeComponent();
        }
            

        private void lbl_Packing_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Unpacking_Click(object sender, EventArgs e)
        {
            Frm_Unpacking obj = new Frm_Unpacking(tb_result.Text);
            obj.Show();
            this.Hide();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
            int No1 = Convert.ToInt32(tb_First_No.Text);
            int No2 = Convert.ToInt32(tb_Second_No.Text);
            int No3 = Convert.ToInt32(tb_Third_No.Text);
            int No4 = Convert.ToInt32(tb_No4.Text);
            int Res = 0;

            int i = No1 << 24;
            int j = No2 << 16;
            int k = No3 << 8;
            int l = No4;
            Res = i | j | k | l;
            tb_result.Text = Res.ToString();
        }

        private void Packing_Load(object sender, EventArgs e)
        {

        }
    }
}

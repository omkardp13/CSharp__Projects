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
    public partial class Frm_Unpacking : Form
    {
        string Res;
        public Frm_Unpacking(string qs)
        {
            InitializeComponent();
            Res = qs;
        }

        private void Frm_Unpacking_Load(object sender, EventArgs e)
        {

            
            int No1, No2, No3, No4,No = 0;
            No = Convert.ToInt32(Res);
            No1 = No & 0x000000ff;
            No2 = No >> 8;
            No2 = No2 & 0x000000ff;
            No3 = No >> 16;
            No3 = No3 & 0x000000ff;
            No4 = No >> 24;

            
            tb_No4.Text = No1.ToString();
            tb_Third_No.Text=No2.ToString();
            tb_Second_No.Text = No3.ToString();
            tb_First_No.Text = No4.ToString();
     
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Packing obj = new Packing();
            obj.Show();
            this.Hide();
            this.Hide();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

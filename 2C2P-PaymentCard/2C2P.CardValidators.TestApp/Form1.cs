using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2C2P.CardValidators.TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardValidators.CheckCard obj = new CheckCard(txtCardNumber.Text, int.Parse(cboMonth.Text), int.Parse(cboYear.Text));
            lblResponse.Text = string.Format("{0} - {1}", obj.Response.CardResult, obj.Response.CardType);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i =2018;i<2050;i++)
            {
                cboYear.Items.Add(i);
            }
        }
    }
}

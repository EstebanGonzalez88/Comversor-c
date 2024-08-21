using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comversor_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtcelsius_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtfahrenheint.Text = "0.0";
            txtcelsius.Text = "0.0";
            MessageBox.Show("se resetiaron los valores iniciales");
        }

      
        private void btncelcius_Click(object sender, EventArgs e)
        {
            float Celsius = float.Parse(txtcelsius.Text);
            float Farenheint = (Celsius * 9f /5f)+32;
            txtfahrenheint.Text = Farenheint.ToString();

        }

        private void btnfahrenheint_Click(object sender, EventArgs e)
        {
            float Farenheint = float.Parse(txtfahrenheint.Text);
            float Celsius = (Farenheint - 32) + 5.0f / 9.0f;
            txtcelsius.Text = Celsius.ToString();

        }
    }
}

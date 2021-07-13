using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SqrtEquation : Form
    {
        public SqrtEquation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double a, b, c, ans1, ans2;
            a = double.Parse(tb_a.Text);
            b = double.Parse(tb_b.Text);
            c = double.Parse(tb_c.Text);
            ans1 = (-1 * b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            ans2 = (-1 * b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            ansOut.Text = "Первый корень: " + ans1.ToString() + "; " + "Второй корень: " + ans2.ToString();
        }

        private void tb_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-') && (e.KeyChar != '+'))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void tb_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-') && (e.KeyChar != '+'))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void tb_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-') && (e.KeyChar != '+'))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }
    }
}

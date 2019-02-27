using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int sign_Indicator = 0;

        string s1 = string.Empty;
        string s2 = string.Empty;

        //double result;
        double temp1, temp2;

        char operation;

        Boolean f1 = false;

        int addBit = 0;
        int subBit = 0;
        int multBit = 0;
        int divBit = 0;
        int modBit = 0;

        private bool isDone = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                TextBox1.Text = TextBox1.Text + Convert.ToString(1);
            }
            else if (sign_Indicator == 1)
            {
                TextBox1.Text = Convert.ToString(1);
                sign_Indicator = 0;
            }
            f1 = true;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                TextBox1.Text = TextBox1.Text + Convert.ToString(2);
            }
            else if (sign_Indicator == 1)
            {
                TextBox1.Text = Convert.ToString(2);
                sign_Indicator = 0;
            }
            f1 = true;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                TextBox1.Text = TextBox1.Text + Convert.ToString(3);
            }
            else if (sign_Indicator == 1)
            {
                TextBox1.Text = Convert.ToString(3);
                sign_Indicator = 0;
            }
            f1 = true;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                TextBox1.Text = TextBox1.Text + Convert.ToString(4);
            }
            else if (sign_Indicator == 1)
            {
                TextBox1.Text = Convert.ToString(4);
                sign_Indicator = 0;
            }
            f1 = true;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                TextBox1.Text = TextBox1.Text + Convert.ToString(5);
            }
            else if (sign_Indicator == 1)
            {
                TextBox1.Text = Convert.ToString(5);
                sign_Indicator = 0;
            }
            f1 = true;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                TextBox1.Text = TextBox1.Text + Convert.ToString(6);
            }
            else if (sign_Indicator == 1)
            {
                TextBox1.Text = Convert.ToString(6);
                sign_Indicator = 0;
            }
            f1 = true;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                TextBox1.Text = TextBox1.Text + Convert.ToString(7);
            }
            else if (sign_Indicator == 1)
            {
                TextBox1.Text = Convert.ToString(7);
                sign_Indicator = 0;
            }
            f1 = true;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                TextBox1.Text = TextBox1.Text + Convert.ToString(8);
            }
            else if (sign_Indicator == 1)
            {
                TextBox1.Text = Convert.ToString(8);
                sign_Indicator = 0;
            }
            f1 = true;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                TextBox1.Text = TextBox1.Text + Convert.ToString(9);
            }
            else if (sign_Indicator == 1)
            {
                TextBox1.Text = Convert.ToString(9);
                sign_Indicator = 0;
            }
            f1 = true;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                TextBox1.Text = TextBox1.Text + Convert.ToString(0);
            }
            else if (sign_Indicator == 1)
            {
                TextBox1.Text = Convert.ToString(0);
                sign_Indicator = 0;
            }
            f1 = true;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            int i = 0;
            char chr = '\0';
            int decimal_Indicator = 0;
            int l = TextBox1.Text.Length - 1;
            if (sign_Indicator != 1)
            {
                for (i = 0; i < 1; i++)
                {
                    chr = TextBox1.Text[i];
                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }
                if (decimal_Indicator != 1)
                {
                    TextBox1.Text = TextBox1.Text + Convert.ToString(".");
                }
            }
        }

        private void reset_SignBits()
        {
            addBit = 0;
            subBit = 0;
            multBit = 0;
            divBit = 0;
            modBit = 0;

            f1 = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                addBit = 1;
                sign_Indicator = 1;
                // TextBox1.Cursor = Cursors.Arrow;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
            }
            sign_Indicator = 1;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length != 0)
            {
                temp2 = Convert.ToDouble(TextBox1.Text);
                calculate();
                reset_SignBits();
                divBit = 1;
                sign_Indicator = 1;
            }
        }
        private void btnDifference_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                temp1 = 0;
                TextBox1.Text = Convert.ToString(temp1);
                reset_SignBits();
                sign_Indicator = 1;
            }
            if (TextBox1.Text.Length != 0)
            {
                temp2 = Convert.ToDouble(TextBox1.Text);
                calculate();
                reset_SignBits();
                subBit = 1;
                sign_Indicator = 1;
            }

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length != 0)
            {
                temp2 = Convert.ToDouble(TextBox1.Text);
                calculate();
                reset_SignBits();
                multBit = 1;
                sign_Indicator = 1;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            s1 = TextBox1.Text;
            int l = s1.Length;
            for (int i = 0; i < l - 1; i++)
            {
                s2 += s1[i];
            }
            TextBox1.Text = s2;
            s2 = "";
            //TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            sign_Indicator = 0;
            temp1 = 0;
            temp2 = 0;
            reset_SignBits();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            TextBox1.Text = " ";
            sign_Indicator = 1;
        }

        private void calculate()
        {
            if (TextBox1.Text != ".")
            {
                temp2 = Convert.ToDouble(TextBox1.Text);
                if (f1 == false)
                    temp1 = temp2;

                else if (addBit == 1)
                    temp1 = temp1 + temp2;

                else if (subBit == 1)
                    temp1 = temp1 - temp2;

                else if (multBit == 1)
                    temp1 = temp1 * temp2;

                else if (divBit == 1)
                    temp1 = temp1 / temp2;

                else if (modBit == 1)
                {
                    temp2 = Convert.ToInt32(TextBox1.Text);
                    temp1 = Convert.ToInt32(temp1 % temp2);
                }
                else
                {
                    temp1 = temp2;
                }
                TextBox1.Text = Convert.ToString(temp1);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                modBit = 1;
                sign_Indicator = 1;
            }
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            try
            {
                long fact = 1;
                for (int i = 1; i <= Convert.ToInt32(TextBox1.Text); i++)
                {
                    fact = fact * i;
                }
                TextBox1.Text = Convert.ToString(fact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double temp, t2;
            t2 = Convert.ToDouble(TextBox1.Text);
            temp = Math.Sqrt(t2);
            TextBox1.Text = Convert.ToString(temp);
        }

        public void keyPress(char c)
        {
            switch (c)
            {
                case '1': btnOne.PerformClick();
                    break;
                case '2': btnTwo.PerformClick();
                    break;
                case '3': btnThree.PerformClick();
                    break;
                case '4': btnFour.PerformClick();
                    break;
                case '5': btnFive.PerformClick();
                    break;
                case '6': btnSix.PerformClick();
                    break;
                case '7': btnSeven.PerformClick();
                    break;
                case '8': btnEight.PerformClick();
                    break;
                case '9': btnNine.PerformClick();
                    break;
                case '0': btnZero.PerformClick();
                    break;
                case '+': btnAdd.PerformClick();
                    break;
                case '-': btnDifference.PerformClick();
                    break;
                case '*': btnMultiply.PerformClick();
                    break;
                case '/': btnDivide.PerformClick();
                    break;
                case '=': btnEqual.PerformClick();
                    break;
            }
        }

        public void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnEqual.PerformClick();
            
            if (e.KeyChar == (char)Keys.Escape)
                btnClear.PerformClick();

            keyPress(e.KeyChar);
        }

        private void btnPlusMin_Click(object sender, EventArgs e)
        {
            double t1 = Convert.ToDouble(TextBox1.Text);
            t1 = -t1;
            TextBox1.Text = t1.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string myTest = "";
            if (e.KeyData == (Keys.Control | Keys.V))
            {
                myTest = Clipboard.GetText();
                foreach (char ch in myTest)
                {
                    keyPress(ch);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBox1.Text.ToString());
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string myTest = "";
            myTest = Clipboard.GetText();
            foreach (char ch in myTest)
            {
                keyPress(ch);
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Exp(Convert.ToDouble(TextBox1.Text));
                    TextBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Sin(Convert.ToDouble(TextBox1.Text));
                    TextBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Cos(Convert.ToDouble(TextBox1.Text));
                    TextBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Tan(Convert.ToDouble(TextBox1.Text));
                    TextBox1.Text = Convert.ToString(l);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Sinh(Convert.ToDouble(TextBox1.Text));
                    TextBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Cosh(Convert.ToDouble(TextBox1.Text));
                    TextBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Tanh(Convert.ToDouble(TextBox1.Text));
                    TextBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Log10(Convert.ToDouble(TextBox1.Text));
                    TextBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Math.PI.ToString();
            sign_Indicator = 1;
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Length != 0)
                {
                    double l;
                    l = Convert.ToDouble(TextBox1.Text);
                    double x = l * l;
                    TextBox1.Text = Convert.ToString(x);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        


    }
}

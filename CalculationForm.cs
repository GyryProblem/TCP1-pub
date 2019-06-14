using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP1
{
    public partial class CalculationForm : Form
    {
        public CalculationForm()
        {
            InitializeComponent();
        }

        private bool CheckKey(char number)  //Возможен ввод 1 или 0
        {
            if ((number <= 47 || number >= 50) && number != 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Increase() //Заполнение до 8 разрядов 
        {
            while (RgABox.Text.Length < 8)
            {
                RgABox.Text = '0' + RgABox.Text;
            }
            while (RgBBox.Text.Length < 8)
            {
                RgBBox.Text = '0' + RgBBox.Text;
            }
        }

        private void RgABox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            e.Handled = CheckKey(number);
        }

        private void RgBBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            e.Handled = CheckKey(number);
        }

        private void OperationPlus_Click(object sender, EventArgs e)
        {
            Increase();
            InfoBox.Clear();
            InfoBox.Text = "RgA: ";
            RgCBox.Clear();
            for (int i = 0; i < RgABox.Text.Length; i++)
            {
                InfoBox.Text = InfoBox.Text + RgABox.Text[i];
                if (i == 0)
                {
                    InfoBox.Text = InfoBox.Text + ',';
                }
            }
            InfoBox.Text = InfoBox.Text + "\r\n";
            InfoBox.Text = InfoBox.Text + "RgB: ";
            for (int i = 0; i < RgBBox.Text.Length; i++)
            {
                InfoBox.Text = InfoBox.Text + RgBBox.Text[i];
                if (i == 0)
                {
                    InfoBox.Text = InfoBox.Text + ',';
                }
            }
            InfoBox.Text = InfoBox.Text + "\r\n";
            InfoBox.Text = InfoBox.Text + "Operation +" + "\r\n" + "\r\n";
            Calculations.Copy(RgABox.Text);
            Calculations.Copy(RgBBox.Text);
            int[] check = new int[8] { 1, 0, 0, 0, 0, 0, 0, 0 };
            if ((Calculations.rg_a[0] == 1)&&(!Equals(Calculations.rg_a, check)))
            {
                Calculations.Inverse(Calculations.rg_a);
            }
            if ((Calculations.rg_b[0] == 1)&&(!Equals(Calculations.rg_b, check)))
            {
                Calculations.Inverse(Calculations.rg_b);
            }
            Plus();
            if (!Calculations.overflow)
            {
                for (int i = 0; i < 8; i++)
                {
                    RgCBox.Text = RgCBox.Text + Convert.ToString(Calculations.rg_c[i]);
                    if (i == 0)
                    {
                        RgCBox.Text = RgCBox.Text + ',';
                    }
                }
            }
            else
            {
                InfoBox.Text = InfoBox.Text + "Возникло переполнение!";
            }
        }

        public void Plus()
        {
            Calculations.rg_c = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            Calculations.overflow = false;
            int ct = 7;
            Calculations.tg_p = 0;
            Calculations.step = 1;
            do
            {
                int summ = 1;
                InfoBox.Text = InfoBox.Text + "Сложение в сумматоре от " + ct + " до " + (ct - 3) + ": " + "\r\n";
                do
                {
                    InfoBox.Text = InfoBox.Text + "Step: " + Calculations.step + "\r\n";
                    InfoBox.Text = InfoBox.Text + "TgP: " + Calculations.tg_p + "\r\n";
                    InfoBox.Text = InfoBox.Text + "RgC: ";
                    for (int i = 0; i < 8; i++)
                    {
                        InfoBox.Text = InfoBox.Text + Calculations.rg_c[i];
                        if (i == 0)
                        {
                            InfoBox.Text = InfoBox.Text + ',';
                        }
                    }
                    InfoBox.Text = InfoBox.Text + "\r\n" + "\r\n";
                    Calculations.rg_c[ct] = Calculations.rg_a[ct] + Calculations.rg_b[ct] + Calculations.tg_p;
                    if (Calculations.rg_c[ct] > 1)
                    {
                        if (ct == 0)
                        {
                            if (Calculations.tg_p == 0)
                            {
                                Calculations.overflow = true;
                            }
                        }
                        Calculations.tg_p = 1;
                        Calculations.rg_c[ct] = Calculations.rg_c[ct] - 2;
                    }
                    else
                    {
                        if (ct == 0)
                        {
                            if (Calculations.tg_p == 1)
                            {
                                Calculations.overflow = true;
                            }
                        }
                        Calculations.tg_p = 0;
                    }
                    ct--;
                    summ--;
                    Calculations.step++;
                } while (summ >= 0);
            } while (ct >= 0);
            if ((Calculations.rg_c[0] == 1) && (!Calculations.overflow))
            {
                Calculations.Inverse(Calculations.rg_c);
            }
        }


        private void OperatonMinus_Click(object sender, EventArgs e)
        {
            Increase();
            InfoBox.Clear();
            InfoBox.Text = "RgA: ";
            RgCBox.Clear();
            for (int i = 0; i < RgABox.Text.Length; i++)
            {
                InfoBox.Text = InfoBox.Text + RgABox.Text[i]; 
                if (i == 0)
                {
                    InfoBox.Text = InfoBox.Text + ',';
                }
            }
            InfoBox.Text = InfoBox.Text + "\r\n";
            InfoBox.Text = InfoBox.Text + "RgB: ";
            for (int i = 0; i < RgBBox.Text.Length; i++)
            {
                InfoBox.Text = InfoBox.Text + RgBBox.Text[i];
                if (i == 0)
                {
                    InfoBox.Text = InfoBox.Text + ',';
                }
            }
            InfoBox.Text = InfoBox.Text + "\r\n";
            InfoBox.Text = InfoBox.Text + "Operation -" + "\r\n" + "\r\n";
            Calculations.Copy(RgABox.Text);
            Calculations.Copy(RgBBox.Text);
            int[] check = new int[8] { 1, 0, 0, 0, 0, 0, 0, 0 };
            if ((Calculations.rg_a[0] == 1) && (!Equals(Calculations.rg_a, check)))
            {
                Calculations.Inverse(Calculations.rg_a);
            }
            if (Calculations.rg_b[0] == 0)
            {
                Calculations.rg_b[0] = 1;
                if (!Equals(Calculations.rg_b, check))
                {
                    Calculations.Inverse(Calculations.rg_b);
                }
            }
            else
            {
                Calculations.rg_b[0] = 0;
            }
            Plus();
            if (!Calculations.overflow)
            {
                for (int i = 0; i < 8; i++)
                {
                    RgCBox.Text = RgCBox.Text + Convert.ToString(Calculations.rg_c[i]);
                    if (i == 0)
                    {
                        RgCBox.Text = RgCBox.Text + ',';
                    }
                }
            }
            else
            {
                InfoBox.Text = InfoBox.Text + "Возникло переполнение!";
            }
        }
    }
}

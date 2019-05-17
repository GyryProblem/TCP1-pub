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
                RgABox.Text = RgABox.Text + '0';
            }
            while (RgBBox.Text.Length < 8)
            {
                RgBBox.Text = RgBBox.Text + '0';
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
            int[] check = new int[8] { 1, 0, 0, 0, 0, 0, 0, 0};
            if ((Calculations.rg_a[0] == 1)&&(!Equals(Calculations.rg_a, check)))
            {
                Calculations.Inverse(Calculations.rg_a);
            }
            if ((Calculations.rg_b[0] == 1)&&(!Equals(Calculations.rg_b, check)))
            {
                Calculations.Inverse(Calculations.rg_b);
            }
            Calculations.Operation();
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
            Calculations.Operation();
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

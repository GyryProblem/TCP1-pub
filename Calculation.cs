using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP1
{
    static class Calculation
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculationForm());
        }
    }
    
    public class Calculations
    {
        public static int[] rg_a = new int[8];
        public static int[] rg_b = new int[8];
        public static bool count = false;
        public static int[] rg_c = new int[8];
        public static bool overflow = false;

        public static void Inverse(int[] rg) //Перевод числа в дополнительный код
        {
            for (int i = 1; i < rg.Length; i++)
            {
                rg[i] = (rg[i] + 1) % 2;
            }
            bool increase = true;
            int col = 7;
            int more = 1;
            while (increase)
            {
                rg[col] = rg[col] + more;
                if (rg[col] > 1)
                {
                    rg[col] = rg[col] - 2;
                    col--;
                }
                else
                {
                    increase = false;
                }
            }
        }

        public static void Copy(string copy_str) //Запись в переменные
        {
            if (!count)
            {
                for (int i = 0; i < copy_str.Length; i++)
                {
                    rg_a[i] = Convert.ToInt16(copy_str[i]) - 48;
                }
                count = true;
            }
            else
            {
                for (int i = 0; i < copy_str.Length; i++)
                {
                    rg_b[i] = Convert.ToInt16(copy_str[i]) - 48;
                }
                count = false;
            }
        }
        public static void Operation() //Сложение двух 8-ми разрядных чисел для 8-ми разрядного сумматора
        {
            rg_c = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            overflow = false;
            int ct = 7;
            int tg_p = 0;
            int step = 1;
            do
            {
                rg_c[ct] = rg_a[ct] + rg_b[ct] + tg_p;
                if (rg_c[ct] > 1)
                {
                    if (ct == 0)
                    {
                        if (tg_p == 0)
                        {
                            overflow = true;
                        }
                    }
                    tg_p = 1;
                    rg_c[ct] = rg_c[ct] - 2;
                }
                else
                {
                    if (ct == 0)
                    {
                        if (tg_p == 1)
                        {
                            overflow = true;
                        }
                    }
                    tg_p = 0;
                }
                ct--;
                step++;
            } while (ct >= 0);
            if ((rg_c[0] == 1)&&(!overflow))
            {
                Inverse(rg_c);
            }
        }
    }
}

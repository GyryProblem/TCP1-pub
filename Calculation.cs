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
        public static int step;
        public static int tg_p;

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
    }
}

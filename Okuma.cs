using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberReading
{
    public class Okuma
    {


        string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
        string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
        string yuz = "yüz";
        string[] bm = { "", "bin", "milyon", "milyar", "trilyon", "katrilyon", "kentilyon" };
        public void Bol(ref string s)
        {
            int j = 0;
            for (int i = s.Length; i >= 0; i--)
            {
                bool b = (j != 0) && (j % 3 == 0) && (i != 0);
                if (b) s = s.Insert(i, ",");
                j++;
            }
        }
        public string Oku(string sNumber)
        {
            //sNumber = 1,123,076

            string[] numbers = sNumber.Split(',');
            // numbers = {"1","123","076"}


            string result = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                int _number = Convert.ToInt32(numbers[i]);
                int t = numbers.Length - (i + 1);

                int x, y, z;
                // x = yüzler,y=onlar,b=birler

                x = _number / 100;
                y = (_number % 100) / 10;
                z = _number % 10;

                if (x != 0)
                {
                    result += x == 1 ? $"{yuz} " : $"{birler[x]}{yuz} ";
                }
                result += $"{onlar[y]} {birler[z]} ";
                bool bmR = (x != 0) || (y != 0) || (z != 0);
                result += bmR ? $"{bm[t]} " : "";
            }
            return result;
        }

    }
}

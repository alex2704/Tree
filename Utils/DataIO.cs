using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class DataIO
    {
        public static int[] ReadFromFile(string filename)
        {
            string str = File.ReadAllText(filename);
            string[] mas = str.Split(new Char[] { ',', ' ' });
            int[] arr = new int[mas.Length];
            for(int i = 0; i < mas.Length; i++)
            {
                arr[i] = Convert.ToInt32(mas[i]);
            }
            return arr;
        }
        public static void WriteToFile(string[] mas, string filename)
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                for(int i = 0; i < mas.Length; i++)
                {
                    sw.Write("{0}", mas[i]);
                }
            }
        }
    }
}

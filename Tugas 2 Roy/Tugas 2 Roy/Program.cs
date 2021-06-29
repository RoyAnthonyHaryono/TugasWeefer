using System;
using System.Collections.Generic;

namespace Tugas_2_Roy
{
    class Program
    {
        static void Main(string[] args)
        {
            string testing = "Halo! Apa kabar dunia ini? aku akan menjadi raja bajak laut ";
            List<string> kalimat = new List<string>();
            int a = 0;
            int kata1;
            do
            {
                kata1 = testing.IndexOf(" ", a);
                if (kata1 >= 0)
                {
                    kalimat.Add(testing.Substring(a, kata1 - a + 1));
                    a = kata1 + 1;
                }
            } 
            while (kata1 > 0);
            foreach (var kalimatcut in kalimat)
                Console.WriteLine(kalimatcut);
           



            
            







           
        }
    }
}



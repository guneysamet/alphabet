using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alfabe ={"a","b","c","ç","d","e","f","g","ğ","h","ı","i","j","k","l","m","n","o",
            "ö","p","r","s","ş","t","u","ü","v","y","z","w","x"," "};
            Console.Write("metin : ");
            string metin = Console.ReadLine();
            metin = metin.ToLower();
            int alfabelength = alfabe.Length;
            int x = 0;
            string kelime = "";
            for (int i = 0; i < metin.Length; i++)
            {
                while (alfabelength > 0)
                {
                    if (metin.Substring(i, 1) == alfabe[x])
                    {
                        kelime = kelime + metin.Substring(i, 1);
                        Console.WriteLine(kelime);
                        x = 0;
                        alfabelength = alfabe.Length;
                        break;
                    }
                    else
                    {
                        if (i == 0)
                        {
                            Console.WriteLine(alfabe[x]);
                        }
                        if (i != 0)
                        {
                            Console.WriteLine(kelime + alfabe[x]);
                        }
                    }
                    alfabelength--;
                    x++;
                }
            }
            Console.ReadLine();
        }
    }
}

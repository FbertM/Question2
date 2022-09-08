using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       
        static void Main()
        {
            for (int i = 1; i <= 500; i++)
            {
                string txt = "";
                if (i % 3 == 0)
                    txt += "Tik";
                if (i % 5 == 0)
                    txt += "Tek";
                if (i % 7 == 0)
                    txt += "Tok";
                if (txt == "")
                    txt = i.ToString();
                Console.WriteLine(txt);
            }
        }
        
    }
}

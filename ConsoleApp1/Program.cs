using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Params_of_notes params_of_notes;
            int a = 1;
            string text_for_title = "Test title";
            string text_for_body = "Test body";
            string b;
            while (a != 0){

                b = Convert.ToString(a);
                params_of_notes.title = (text_for_title +" "+ b);
                params_of_notes.body = (text_for_body+" "+  b);
                params_of_notes.Show(); 
                    a++;
            }







        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Params_of_notes
    {
       public string title ;
       public string body  ;
       public int id;
       public DateTime time;

        
        

        public void Show() { Console.WriteLine($"{title} - {body} - {id} - {time}"); } 



    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var params_of_notes = new Params_of_notes();
            int a = 1;
            string text_for_title = "Test title";
            string text_for_body = "Test body";
            string text_for_id = "Test id";
             string b;
            /*  while (a != 0) {

                  b = Convert.ToString(a);
                  params_of_notes.title = (text_for_title + " " + b);
                  params_of_notes.body = (text_for_body + " " + b);
                  params_of_notes.id = (a);
                  params_of_notes.time = DateTime.Now;

                  params_of_notes.Show();
                  a++;
              }
              */
            Params_of_notes[] notes = new Params_of_notes[100];
            for (int i = 0; i <100; i++)
            {
                b = Convert.ToString(i);
                params_of_notes.title = (text_for_title + " " + b);
                params_of_notes.body = (text_for_body + " " + b);
                params_of_notes.id = (i);
                
                params_of_notes.time = DateTime.Now;

                params_of_notes.Show();
                i++;
                notes[i] = params_of_notes; 
                
                






            }


            var zapakovka = JsonConvert.SerializeObject(notes);
            var path = JsonConvert.DeserializeObject<notes>(zapakovka);





        }
    }
}

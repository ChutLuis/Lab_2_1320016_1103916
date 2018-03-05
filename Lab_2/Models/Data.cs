using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Lab_2.Models
{
    public class Data
    {
        private static Data instance;

        public static Data Instance
        {
            get 
            {
                if (instance == null) return instance = new Data();

                return instance;
            }
        }

        public Arbol a1;

        public Data()
        {
            a1 = new Arbol();
        }


    }
}
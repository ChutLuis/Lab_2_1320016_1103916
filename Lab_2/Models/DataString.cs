using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_2.Models
{
    public class DataString
    {
        private static DataString instance;

        public static DataString Instance
        {
            get
            {
                if (instance == null) return instance = new DataString();

                return instance;
            }
        }

        public ArbolString a1;

        public DataString()
        {
            a1 = new ArbolString();
        }

    }
}
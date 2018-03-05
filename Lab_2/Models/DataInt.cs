using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_2.Models
{
    public class DataInt
    {
        private static DataInt instance;

        public static DataInt Instance
        {
            get
            {
                if (instance == null) return instance = new DataInt();

                return instance;
            }
        }

        public ArbolInt a1;

        public DataInt()
        {
            a1 = new ArbolInt();
        }


    }
}
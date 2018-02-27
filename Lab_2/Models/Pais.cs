using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_2.Models
{
    public class Pais
    {
        private string NombrePais;
        private string Grupo;

        public string NombrePais1
        {
            get
            {
                return NombrePais;
            }

            set
            {
                NombrePais = value;
            }
        }

        public string Grupo1
        {
            get
            {
                return Grupo;
            }

            set
            {
                Grupo = value;
            }
        }
    }
}
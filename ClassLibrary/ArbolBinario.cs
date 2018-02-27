using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    class ArbolBinario<T>:Node<T>, IComparable<T>
    {
        
        private Node<T> Raiz;
        public ArbolBinario()
        {
            Raiz = null;
            
        }       

        public void Insert(Node<T> nodo, T value)
        {
            if (Raiz == null)
                Raiz = nodo;
            if(CompareTo())


        }

        public int CompareTo(T other)
        {
            
        }

    }
}

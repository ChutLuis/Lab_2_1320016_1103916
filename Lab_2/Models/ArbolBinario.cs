using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary;


namespace ClassLibrary
{
    class ArbolBinario<T> where T : IComparable<T>
    {
        
        private Node<T> Raiz;
        public ArbolBinario()
        {
            Raiz = null;
            
        }
        public bool isEmpty()
        {
            return Raiz == null;
        }
        public void insert(T d)
        {
            if (isEmpty())
            {
                Raiz = new Node<T>(d);
            }
            else
            {
                Raiz.Insert(Raiz,d);
            }            
        }

        public Node<T> Search(Node<T> nodo, T value)
        {
            Node<T> current = nodo;
            if (current == null)
                return null;
            if (nodo.Value.Equals(value))
                return nodo;
            if (nodo.Value.CompareTo(value) < 0)
                return Search(nodo.Right, value);
            
                return Search(nodo.Left, value);            
        }
        









    }
}

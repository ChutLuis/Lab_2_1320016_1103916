using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Node<T> where T : IComparable<T>
    {
        T value;
        Node<T> left;
        Node<T> right, parent;
        public Node(T t){
            value = t;

            }


        public T Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public Node<T> Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        public Node<T> Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }

        public Node<T> Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public void Insert(Node<T> nodo, T value)
        {
            if (nodo == null)
                nodo = new Node<T>(value);
            if (nodo.Value.CompareTo(value) < 0)
                Insert(nodo.Left, value);
            if (nodo.Value.CompareTo(value) > 0)
                Insert(nodo.Right, value);
        }


    }
}

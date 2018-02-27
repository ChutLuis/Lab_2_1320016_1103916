using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Node<T>:
    {
        T value;
        Node<T> left;
        Node<T> right;

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

        
    }
}

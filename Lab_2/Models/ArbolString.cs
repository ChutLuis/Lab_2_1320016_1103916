using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_2.Models
{
    public class ArbolString
    {
        public string valor { get; set; }
        public ArbolString izquierdo { get; set; }
        public ArbolString derecho { get; set; }
        string auxs = "";
        string auxs2 = "";
        string auxs3 = "";
        public void Insert(ArbolString raiz, ArbolString n)
        {
            if (raiz == null)
            {
                raiz = n;
            }
            else
            {
                if (n.valor.CompareTo(raiz.valor) < 0)
                {
                    if (raiz.izquierdo == null)
                        raiz.izquierdo = n;
                    else
                        Insert(raiz.izquierdo, n);
                }
                else
                {
                    if (raiz.derecho == null)
                    {
                        raiz.derecho = n;
                    }
                    else
                    {
                        Insert(raiz.derecho, n);
                    }
                }
            }

        }
        public bool delete(ArbolString raiz, ArbolString e)
        {
            ArbolString aux = new ArbolString();
            ArbolString aux2 = new ArbolString();
            if (raiz.valor.CompareTo(e.valor) < 0 && raiz != null)
                delete(raiz.izquierdo, e);
            else if (raiz.valor.CompareTo(e.valor) > 0 && raiz != null)
                delete(raiz.derecho, e);

            if (raiz.valor == e.valor)
            {
                if (raiz.izquierdo == null && raiz.derecho == null)
                {
                    raiz.valor = default(string);
                    return true;
                }

                if (raiz.izquierdo != null && raiz.derecho == null)
                {
                    aux.valor = raiz.izquierdo.valor;
                    raiz.izquierdo.valor = default(string);
                    raiz = aux;
                    return true;
                }
                if (raiz.izquierdo == null && raiz.derecho != null)
                {
                    aux.valor = raiz.derecho.valor;
                    raiz.derecho.valor = default(string);
                    raiz.valor = aux.valor;
                    return true;
                }
                if (raiz.izquierdo != null && raiz.derecho != null)
                {
                    aux.valor = raiz.izquierdo.valor;
                    aux2.valor = raiz.derecho.valor;

                    raiz = recorrerIzquierda(raiz);
                    raiz.izquierdo.valor = aux.valor;
                    raiz.derecho.valor = aux2.valor;
                    return true;
                }
            }


            return false;


        }
        private ArbolString recorrerIzquierda(ArbolString raiz)
        {
            if (raiz.izquierdo != null)
            {
                return recorrerIzquierda(raiz.izquierdo);
            }
            return raiz;
        }
        public string inorderRec(ArbolString root)
        {

            if (root != null)
            {
                inorderRec(root.izquierdo);
                auxs += "-> " + root.valor.ToString();
                inorderRec(root.derecho);
            }
            return auxs;
        }
        public string preorderRec(ArbolString root)
        {

            if (root != null)
            {
                auxs2 += "-> " + root.valor.ToString();
                preorderRec(root.izquierdo);
                preorderRec(root.derecho);
            }
            return auxs2;
        }
        public string postorderRec(ArbolString root)
        {

            if (root != null)
            {
                postorderRec(root.izquierdo);
                postorderRec(root.derecho);
                auxs3 += "-> " + root.valor.ToString();
            }
            return auxs3;
        }
    }
}
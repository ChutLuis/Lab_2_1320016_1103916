using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_2.Models
{
    public class Arbol
    {

        public Pais valor { get; set; }
        public Arbol izquierdo { get; set; }
        public Arbol derecho { get; set; }
        string auxs = "";
        string auxs2 = "";
        string auxs3= "";
        public class Pais
        {
            public string nombre { get; set; }
            public string Grupo { get; set; }
        }
        public void Insert(Arbol raiz, Arbol n)
        {
            if (raiz == null)
            {
                raiz = n;
            }
            else
            {
                if (n.valor.nombre.CompareTo(raiz.valor.nombre) < 0)
                {
                    if (raiz.izquierdo == null)
                        raiz.izquierdo = n;
                    else
                        Insert(raiz.izquierdo,n);
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
        public bool delete(Arbol raiz, Arbol e)
        {
            Arbol aux = new Arbol();
            Arbol aux2 = new Arbol();
                    if (raiz.valor.nombre.CompareTo(e.valor.nombre) < 0&&raiz!=null)
                    delete(raiz.izquierdo, e);
                else if (raiz.valor.nombre.CompareTo(e.valor.nombre) > 0 && raiz != null)
                    delete(raiz.derecho, e);

                if (raiz.valor.nombre == e.valor.nombre)
                {
                    if (raiz.izquierdo == null && raiz.derecho == null)
                    {
                    raiz.valor = null;
                    return true;
                }
                    
                    if (raiz.izquierdo != null && raiz.derecho == null)
                    {
                        aux.valor = raiz.izquierdo.valor;
                        raiz.izquierdo.valor = null;
                        raiz = aux;
                        return true;
                    }
                    if (raiz.izquierdo == null && raiz.derecho != null)
                    {
                        aux.valor = raiz.derecho.valor;
                        raiz.derecho.valor = null;
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
        private Arbol recorrerIzquierda(Arbol raiz)
        {
            if(raiz.izquierdo != null)
            {
                return recorrerIzquierda(raiz.izquierdo);
            }
            return raiz;
        }
        public string inorderRec(Arbol root)
        {
            
            if (root != null)
            {
                inorderRec(root.izquierdo);
                auxs+="-> "+root.valor.nombre.ToString();
                inorderRec(root.derecho);
            }
            return auxs;
        }
        public string preorderRec(Arbol root)
        {

            if (root != null)
            {
                auxs2 += "-> " + root.valor.nombre.ToString();
                preorderRec(root.izquierdo);                
                preorderRec(root.derecho);
            }
            return auxs2;
        }
        public string postorderRec(Arbol root)
        {

            if (root != null)
            {
                postorderRec(root.izquierdo);                
                postorderRec(root.derecho);
                auxs3 += "-> " + root.valor.nombre.ToString();
            }
            return auxs3;
        }
        public int Balanceado(Arbol raiz)
        {
            int cont=0;
            while (raiz != null)
            {

                if (raiz.izquierdo == null && raiz.derecho == null)
                {
                    cont+= 0;
                }

                if (raiz.izquierdo != null && raiz.derecho == null)
                {
                    Balanceado(raiz.izquierdo);
                    cont++;
                    
                }
                if (raiz.izquierdo == null && raiz.derecho != null)
                {
                    Balanceado(raiz.derecho);
                    cont++;
                    
                }
                if (raiz.izquierdo != null && raiz.derecho != null)
                {
                    Balanceado(raiz.izquierdo);
                    Balanceado(raiz.derecho);
                }
            }
            return cont;
        }

    }
}
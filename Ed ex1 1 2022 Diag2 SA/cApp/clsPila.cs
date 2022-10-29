/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria Informatica
Materia:        Estructura de Datos I
Proyecto:       cApp (Proyecto de Clases)
Descripción:    Implementacion del TAD Pila utilizando Arreglos.
Creador:        Ing. Ubaldo Perez.
Lenguaje:       C#
Herramienta:     Visual Studio 2010 - Windows Aplications
*************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp {
    public class clsPila {

        //ATRIBUTOS
        public const int MAX = 10;
        private int _top;
        private int[] _pila;

        //CONSTRUCTOR
        public clsPila( ) {
            _top = -1;
            _pila = new int[MAX];
        }

        //METODOS
        public clsPila( clsPila p ) {
            _top = p._top;
            _pila = new int[MAX];
            for ( int i = 0 ; i < p._top ; i++ ) {
                _pila[i] = p._pila[i];
            }
        }

        public int Top {
            get { return _top; }
            set { _top = value; }
        }
        public int[] Pila {
            get { return _pila; }
            set { _pila = value; }
        }

        // Destruye la Pila
        public void Drop()
        {
            _top = -1;
        }

        // Valida si la Pila esta vacia
        public Boolean Vacia()
        {
            if (_top == -1)
            {
                return true;
            }
            return false;
        }

        // Obtiene el elemento de la Cima de la Pila 
        public int Tope()
        {
            if (Vacia() != true)
                return _pila[_top];
            return 0;
        }

        // Adiciona un elemento en la cima de la Pila
        public void Add(int e){
            {
                if (Llena() != true)
                {
                    _top++;
                    _pila[_top] = e;
                }
            }
        }

        // Elimina el elemento de la cima de la Pila
        public void Delete()
        {
            if (Vacia() != true)
                _top--;
        }

               // Valida si la Pila esta llena
        public Boolean Llena()
        {
            if (_top+1 == MAX)
            {
                return true;
            }
            return false;
        }

       
        // Obtiene la cantidad de elementos en la Pila 
        public int Long()
        {
            return _top+1;
        }

        // Imprime los elementos de la Pila 
        public string Imprimir( ) {
            string salida = "";
            for ( int i = 0 ; i <= _top ; i++ ) {
                salida += "[ " + _pila[i].ToString( ) + " ]";
            }
            return salida;
        }

       

       

    }
   
}

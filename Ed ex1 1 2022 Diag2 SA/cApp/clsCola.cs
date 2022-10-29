/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria Informatica
Materia:        Estructura de Datos I
Proyecto:       cApp (Proyecto de Clases)
Descripción:    Implementacion del TAD Cola utilizando Arreglos.
Creador:        Ing. Ubaldo Perez.
Lenguaje:       C#
Herramienta:     Visual Studio 2010 - Windows Aplications
*************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp {

    public class clsCola {
        //ATRIBUTOS
        private int[] _cola;            // Arreglo para alamcenar los elementos de la cola
        public const int MAX = 100;      // Cantidad celdas del arreglo _cola
        private int _front;             // Puntero que indica la ubicacion del elemento del frente de la cola en el arreglo
        private int _rear;              // Puntero que indica la ubicacion del elemnto posterior de la cola en el arreglo
        

        //CONSTRUCTOR
        public clsCola( ) {
            _front = -1;
            _rear = -1;
            _cola = new int[MAX];
        }

        public clsCola(clsCola p)
        {
            _front = p._front;
            _rear = p._rear;
            _cola = new int[MAX];
            for ( int i = 0 ; i < p._front ; i++ ) {
                _cola[i] = p._cola[i];
            }
        }

        public int front {
            get { return _front; }
            set { _front = value; }
        }

        public int rear
        {
            get { return _rear; }
            set { _rear = value; }
        }

        public int[] cola {
            get { return _cola; }
            set { _cola = value; }
        }

    // OPERACIONES

    //Destruye la Cola
        public void Drop()
        {
            front = -1;
            rear = -1;
        }
        
   // Adiciona un elemento en la parte posterior de la Cola
        public void Add(int e)
        {
                if (Llena() != true)
                {
                    rear++;
                    cola[rear] = e;
                }
        }

	//Borra el elemento de la parte del frente de la Cola
        public void Delete()
        {
            if (Vacia() != true)
                front++;
        }

    
	// Valida si Cola esta Vacia
        public Boolean Vacia()
        {
            if (front == rear)
            {
                return true;
            }
            return false;
        }

	// Valida si la Cola esta llena
        public Boolean Llena()
        {
            if (rear+1 == MAX)
                return true;

            return false;
        }

    // Obtiene el Primer Elelemeto de la Cola
        public int Front( ) 
        {
            if (Vacia()!=true)
                return cola[front+1];
            return 0;
        }

    // Obtiene el Ultimo Elemento de la Cola
        public int Rear()
        {
            if (Vacia() != true)
                return cola[rear];
            return 0;
        }

	// Obtiene la cantidad de elementos de la Cola
        public int Long()
        {
            return (rear-front);
        }

	// Imprime la Cola en un String
        public string Imprimir( ) {
            string salida = "";
            if (Vacia()!=true) {
                for ( int i = _front+1 ; i <= _rear ; i++ ) {
                    salida += "[ " + _cola[i].ToString( ) + " ]";
                }
            }
            return salida;
        }
  
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry01_OperArreglos
{
    //Clase para implememntar los metodos para realizar las operaciones
    //con arreglos
    class COperArreglos
    {
        //Metodo para agregar elementos al arreglo
        //a es el arreglo, len la longitud o tamaño y v el valor
        public int agregarArray(int[] a, ref int len, int v)
        {
            a[len]= v; //Asignar el valor al arreglo a en la posicion len
            len++; //Incrementar en 1 la longitud o tamaño del arreglo
            //La longitud o tamaño del arreglo se retorna con menos 1
            //debido a que la primera posicion del arreglo inicia en Cero
            return len-1;
        }
        //Metodo para buscar un elemento en el arreglo
        public int buscarArray(int[] a, int len, int v)
        {
            int i = 0; //Indice del arreglo
            //Recorrer el arreglo
            //Mientras que el indice del arreglo sea menor al tamaño del arreglo
            //y ademas el valor del arreglo sea diferente al valor buscado
            while (i<len && a[i]!=v)
            {
                i++; //Incrementar en 1 la posicion del arreglo
            }
            //Retorono depende de una condicion
            //Si la posicion del arreglo es menor al tamaño del arreglo
            //entonces (?) retornar la posicion (i), caso contrario -1
            return i < len ? i : -1;
        }
        //Metodo para buscar y agregar elementos en el arreglo
        //a es el arreglo, len la longitud o tamaño, v es el valor
        //enc indica si el elemento del arreglo se ha encontrado o no
        public int buscarYAgregar(int[] a, ref int len,
            int v, ref int enc)
        {
            //Buscar el dato en el arreglo y capturar su posicion
            int pos = buscarArray(a, len, v);
            //Si pos > = 0 
            if (pos >= 0)
            {
                enc = 1;//Asignar 1 a encontrado
            }
            else
            {
                enc = 0; //Asignar 0 a encontrado
                //Agregar el nuevo elemento al arreglo
                pos = agregarArray(a, ref len, v);
            }
            return pos; //Retornar la posicion
        }
        //Metodo para insertar elementos en el arreglo
        public void insertarArray(int[] a, ref int len, int v, int pos)
        {
            int i; //Indice del arreglo
            //Recorrer el arreglo de abajo hacia arriba,
            //partiendo desde la longitud del arreglo hasta posicion
            for(i= len;i>pos; i--)
            {
                a[i] = a[i-1];
            }
            //Almacenar el valor v en el arreglo a
            //segun pos
            a[pos] = v;
            //Actualizar la longitud o tamaño del arreglo
            len++; //Incrementar en 1
        }
        //Metodo para eliminar elementos en el arreglo
        public void eliminarArray(int[] a, ref int len,int pos)
        {
            int i; //Indice del arreglo
            //Recorrer el arreglo de arriba hacia abajo
            //partiendo desde la posicion del elemento
            //a eliminar hasta la longitud o tamaño del arreglo
            //disminuido en 1 por que el indice del arreglo inicia en cero
            for (i = pos; i < len - 1; i++)
            {
                a[i] = a[i+1];
            }
            //Actualizar la longitud o tamaño del arreglo
            len--; //Disminuir en 1 
        }
        //Metodo para ordenar los datos usando el metodo de burbuja
        public void ordenarBurbujaArray(int[] a, int len)
        {
            int ordenado = 0; //Indica si el arreglo esta o no ordenado
            //Mientras que ordenado sea igual a cero
            while (ordenado == 0)
            {
                ordenado = 1; //Asignar 1 a ordenado
                int i; //Indice del arreglo
                for (i = 0; i < len - 1; i++)
                {
                    //Comparar el elemento del arreglo con su siguiente
                    //elemento
                    //Ordenar en forma ascendente : > (Datos diferentes)
                    //Ordenar en forma descendente : < (Datos diferentes)
                    if (a[i] > a[i+1])
                    {
                        //Intercambio
                        int aux = a[i];
                        a[i] = a[i+1];
                        a[i+1] = aux;
                        ordenado = 0; //Todavia no ha terminado el ordenamiento
                    }
                }
            }
        }
        //Metodo para mostrar los elementos del arreglo
        public void mostrarArray(int[] a,int len)
        {
            int i; //Indice del arreglo
            for(i=0; i < len; i++)
            {
                Console.WriteLine("\t" + a[i]);
            }
        }
        //Metodo para mostrar el menu
        public int menuArray()
        {
            int opc;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menu - Operaciones con Arreglos");
            Console.WriteLine("*******************************");
            Console.WriteLine("[1] Agregar Elementos al Arreglo");
            Console.WriteLine("[2] Buscar Elementos al Arreglo");
            Console.WriteLine("[3] Buscar y Agregar Elementos al Arreglo");
            Console.WriteLine("[4] Insertar Elementos en el Arreglo");
            Console.WriteLine("[5] Eliminar Elementos en el Arreglo");
            Console.WriteLine("[6] Ordenar Elementos en el Arreglo (Burbuja)");
            Console.WriteLine("[7] Salir");
            Console.Write("Ingrese Opcion : ");
            opc = int.Parse(Console.ReadLine());
            return opc; //Retornar la opcion del menu seleccionada
        }
    }
}

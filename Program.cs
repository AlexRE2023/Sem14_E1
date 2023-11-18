using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry01_OperArreglos
{
    
    class Program
    {
        //Crear el objeto Array
        static COperArreglos objArray = new COperArreglos();
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            int len = 0; //Longitud inicial del arreglo
            int v;
            int enc;
            int pos;
            int opcion;
            int nElem;
            do
            {
                Console.WriteLine();
                //Llamar al menu
                opcion = objArray.menuArray();
                //Limpiar la consola
                Console.Clear();
                //Controlar las opciones del menu
                Console.ForegroundColor = ConsoleColor.Green;
                switch (opcion)
                {
                    
                    case 1: //Agregar elementos
                        
                        Console.WriteLine("Agregar elementos al areglo");
                        Console.WriteLine("***************************");
                        //Validar el numero de elementos
                        do
                        {
                            Console.WriteLine("Nro. Elementos [1-50] :");
                            nElem = int.Parse(Console.ReadLine());
                        } while ((nElem < 1) || (nElem > 50));
                        break;
                    case 2: //Buscar elemento en el arreglo
                        Console.WriteLine("Buscar elementos en el arreglo");
                        Console.WriteLine("******************************");
                        Console.Write("Ingrese un valor a buscar: ");
                        v = int.Parse(Console.ReadLine());
                        //Buscar el elmento y encontrar su posicion
                        pos = objArray.buscarArray(arr, len, v);
                        if (pos < 0)
                            Console.WriteLine("Elemento {0} no existe...!", v);
                        else
                            Console.WriteLine("Elemento {0} existe en la posicion {1}", v, pos);
                        break;
                    case 3:
                        Console.WriteLine("Buscar y agregar elementos en el arreglo");
                        Console.WriteLine("****************************************");
                        Console.Write("Ingrese un valor a buscar");
                        v = int.Parse(Console.ReadLine());
                        enc = 0;
                        //Llamar a la funcion buscar y agregar
                        pos = objArray.buscarYAgregar(arr, ref len, v, ref enc);
                        if (enc == 0) //Elemento no enontardo
                            //Mostrar el elemeto agregado
                            Console.WriteLine("Elemento {0} agregado en la posicion {1}", v, pos);
                        else
                            //Mostrar el elemento que existe
                            Console.WriteLine("Elemento {0} existe en posicion {1}", arr[pos], pos);
                        //Mostrar el arreglo
                        objArray.mostrarArray(arr, len);
                        break;
                    case 4: //Insertar elementos en el arreglo
                        Console.WriteLine("Insertar elementos en el arreglo");
                        Console.WriteLine("********************************");
                        //Mostrar el arreglo
                        objArray.mostrarArray(arr, len);
                        //Ingrese la posición y validarla
                        do
                        {
                            Console.Write("Ingrese posicion [0-{0}{1}", len - 1, "] : ");
                            pos = int.Parse(Console.ReadLine());
                        } while ((pos < 0) || (pos > len - 1));
                        //Ingresar el valor
                        Console.Write("Ingrese un valor: ");
                        v = int.Parse(Console.ReadLine());
                        objArray.insertarArray(arr, ref len, v, pos);
                        //Mostrar el arreglo
                        objArray.mostrarArray(arr, len);
                        break;
                    case 5: //Eliminar elemtno en el arrelgo
                        Console.WriteLine("Eliminar elementos en el arreglo");
                        Console.WriteLine("********************************");
                        //Mostrar el arreglo
                        objArray.mostrarArray(arr, len);
                        //Ingresar el valor
                        Console.Write("Ingrese un valor: ");
                        v = int.Parse(Console.ReadLine());
                        //Buscar el elemento y encontrar la posicion
                        pos = objArray.buscarArray(arr, len, v);
                        if (pos == -1)
                            //Elemento no existe
                            Console.WriteLine("Elemento {0} No existe...!");
                        else
                        {
                            //Eliminar elemento
                            objArray.eliminarArray(arr, ref len, pos);
                            Console.WriteLine("Elemento {0} eliminado de la posición {1}", v, pos);
                            //Mostrar el arreglo
                            objArray.mostrarArray(arr, len);
                        }
                        break;
                    case 6: //Ordenar los elementos del arreglo (burbuja)
                        Console.WriteLine("Ordenar elementos en el arreglo (burbuja)");
                        Console.WriteLine("********************************");
                        objArray.ordenarBurbujaArray(arr, len);
                        //Mostrar el arreglo
                        objArray.mostrarArray(arr, len);
                        break;
                }
                //pausa
                Console.ReadKey();
            } while (opcion != 7);



        }
    }
    
}

using ListasSimplementeLigadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaHash
{
    internal class Program
    {
        private static Dictionary<int, Lista> tablaHash = new Dictionary<int, Lista>();

        static void Main(string[] args)
        {
            // En diccionario agregar el par de clave y valor
            AgregarHash("Dia", "Lunes");
            AgregarHash("HOLA", "MUNDO"); // Para colisión

            // Colisión
            AgregarHash("IIII", "PRUEBA");

            // En este punto, la clave que colisiona debe tener ya un encadenamiento

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadLine();

        }

        static void AgregarHash(string clave, string dato)
        {
            int sumaValorByteClave = 0;
            int moduloClave = -1;

            foreach (char caracter in clave.ToCharArray())
            {
                sumaValorByteClave += (byte)caracter;
            }

            moduloClave = sumaValorByteClave % dato.Length;

            // Agregar hash a diccionario
            
            // Verificar si ya existe
            if (tablaHash.ContainsKey(moduloClave))
            {
                // Busca la clave y agrega un dato al la clave
                tablaHash[moduloClave].AgregarNodo(dato);
            }
            else
            {
                // de lo contrario crear una lista nueva temporal para agregarla como nueva clave y lista de datos en nodos
                Lista lista = new Lista();
                lista.AgregarNodo(dato);
                
                tablaHash.Add(moduloClave, lista);
            }

        }

    }
}

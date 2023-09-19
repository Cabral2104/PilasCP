using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una pila de enteros
            Stack<int> pila = new Stack<int>();

            // Agregar elementos a la pila
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);

            // Imprimir el contenido de la pila
            Console.WriteLine("Contenido de la pila:");
            foreach (int elemento in pila)
            {
                Console.WriteLine(elemento);
            }

            // Verificar si la pila está vacía
            if (pila.Count == 0)
            {
                Console.WriteLine("La pila está vacía.");
            }
            else
            {
                Console.WriteLine("La pila NO está vacía.");
            }

            // Quitar elementos de la pila
            int elementoEliminado = pila.Pop();
            Console.WriteLine($"Elemento eliminado de la pila: {elementoEliminado}");

            // Imprimir el elemento en la cima de la pila (sin eliminarlo)
            int elementoEnCima = pila.Peek();
            Console.WriteLine($"Elemento en la cima de la pila: {elementoEnCima}");

            // Verificar el tamaño actual de la pila
            Console.WriteLine($"Tamaño actual de la pila: {pila.Count}");

            // Limpiar la pila (quitar todos los elementos)
            pila.Clear();

            // Verificar si la pila está vacía después de limpiarla
            if (pila.Count == 0)
            {
                Console.WriteLine("La pila está vacía después de limpiarla.");
            }
            else
            {
                Console.WriteLine("La pila NO está vacía después de limpiarla.");
            }
            Console.ReadKey();
        }
    }
}

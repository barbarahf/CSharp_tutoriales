using System;
using System.Collections.Generic;

namespace tutorial_dotnet_consol
{
    public class colecciones
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int num in new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11})
            {
                numeros.AddLast(num);
            }

            /*
            foreach (var i in numeros)
            {
                Console.Write(i + " ");
            }*/
            numeros.Remove(6);
            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);
            numeros.AddFirst(nodoImportante);
            for (LinkedListNode<int>? nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.Write(numero + " ");
            }
        }
    }
}
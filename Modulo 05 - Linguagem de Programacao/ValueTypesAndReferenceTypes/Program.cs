/* 
Em C#, existem dois tipos principais de dados: 
Tipos de Valor (Value Types) e 
Tipos de Referência (Reference Types)

=> Tipos de Valor (Value Types)

    São armazenados na pilha (stack)
    Contêm o valor real na variável
    Os valores são copiados quando atribuídos a outra variável
        Ambas serão independentes, ou seja, quando uma variável for alterada, a outra não será 
    São imutáveis
    Exemplos: int, float, bool, struct, enum


=>Tipos de Referência (Reference Types)

    São armazenados na pilha (heap)
    Contêm uma referência ao objeto na memória
    São compartilhados quando atribuídos a outra variável
        Ambas serão dependentes, ou seja, quando uma variável for alterada, a outra também será
    Podem ser mutáveis
    Exemplos: classe, interface, array, lista, objeto
*/

namespace ValueTypesAndReferenceTypes
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Value Types (tipos primitivos, structs, enum)
            Console.WriteLine("Value Types:");
            int x = 25;
            int y = x;
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");

            x = 32;
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");


            // Reference Types (objects, string, classes, interfaces, record)
            Console.WriteLine("\nReference Types:");
            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;
            Console.WriteLine($"Arr[0] = {arr[0]}");
            Console.WriteLine($"Arr2[0] = {arr2[0]}");

            arr[0] = "Item 2";
            Console.WriteLine($"Arr[0] = {arr[0]}");
            Console.WriteLine($"Arr2[0] = {arr2[0]}");
        }

        
    }
}




using System.Data;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // *ARRAY 
            // *    -> Estrutura de dados que permite armazenar uma coleção de elementos de um mesmo tipo
            // *    -> Os elementos do array podem ser acessados pelo seu index
            // *    -> Os arrays em C# tem tamanho fixo, ao criar um array, precisamos informar quantos elementos ele irá armazenar

            Console.WriteLine("Instanciado um array de Inteiros:");
            var intArray = new int[3] {1, 3, 5};
            Console.WriteLine("Índice 0: " + intArray[0]);
            Console.WriteLine("Índice 1: " + intArray[1]);
            Console.WriteLine("Índice 2: " + intArray[2]);
            // Console.WriteLine(intArray[3]); // erro, pois o array tem 3 elementos

            Console.WriteLine("Instanciado um array de Struct:");
            var myArray = new Teste[2];
            myArray[0] = new Teste();
            myArray[0].Id = 1;
            myArray[1] = new Teste();
            myArray[1].Id = 2;
            Console.WriteLine("Índice 0, exibir o ID: " + myArray[0].Id);
            Console.WriteLine("Índice 1, exibir o ID: " + myArray[1].Id);


            // *Percorrendo um array
            Console.WriteLine("Percorrendo um array de inteiros:");
            for (int i = 0; i < intArray.Length; i++)
            {                
                Console.WriteLine(intArray[i]);
            }


            // *Foreach
            // *     -> Utilizado para apercorrer uma lista já existente

            Console.WriteLine("Percorrendo um array de inteiros com Foreach:");
            var arrayForeach = new int[5] {2, 6, 3, 5, 8};
            arrayForeach[2] = 12;

            foreach (var item in arrayForeach)
            {
                Console.WriteLine(item);
            } 


            Console.WriteLine("Percorrendo um array de Professores com Foreach:");
            var arrayProfessores = new Professores[2];
            arrayProfessores[0] = new Professores(){ Nome = "Erasmo", Disciplina = "Lógica de Programação"};
            arrayProfessores[1] = new Professores(){ Nome = "Fabiola", Disciplina = "Farmacologia"};

            Console.WriteLine(arrayProfessores[0].Nome);
            Console.WriteLine(arrayProfessores[1].Nome);


            // *Atribuição de Valores em Arrays
            // *   -> Arrays são Reference Types, ou seja, quando copiamos um array, é copiada sua referência, não o valor.
            // *   -> Se arr[4] for atribuído/copiado ao arrb[4], ambos apontam para o mesmo endereço da memória.
            // *   -> Ao atribuímos novos valores em um deles, o outro array com mesma referência, receberá tbm os mesmos valores.
            Console.WriteLine("Atribuição de valores:");
            var arr = new int[4];
            var arrb = arr;
            arr[0] = 23;
            Console.WriteLine(arrb[0]);  

        }
    }

    public struct Teste
    {
        public int Id { get; set; }
    }

    public struct Professores
    {
        public string Nome { get; set; }
        public string Disciplina { get; set; }
    }
}
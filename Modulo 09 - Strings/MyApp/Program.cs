using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* IDENTIFICADOR ÚNICO
            // Cria um identificador único para o programa
            var id = Guid.NewGuid(); 
            // Converte o identificador em uma string
            id.ToString();
            Console.WriteLine(id);

            // Cria um identificador com um valor predefinido
            id = new Guid("d8265f63-439f-4427-a0e5-2f2b60a3ae73");
            Console.WriteLine(id);

            // Criando um identificado vazio
            id = new Guid();
            //id = Guid.Empty;
            Console.WriteLine(id);
            */


            
            // CONCATENAÇÃO DE STRINGS
            // var price = 10.2;

            // 1ª forma de interpolação de strings
            //var text = "O preço do produto é " + price + " reais apenas na promoção.";
            // Console.WriteLine(text); 

            // 2ª forma de interpolação de strings
            //var text = string.Format("O preço do produto é {price} reais apenas na promoção.", price);
            // Console.WriteLine(text);             

            // 3ª forma de interpolação de strings
            //var text = $"O preço do produto é {price} reais apenas na promoção.";    
            // Console.WriteLine(text);      

            // $@ -> permite escrever múltiplas linhas em uma string e ignora os caracteres de escape
            // var text = $@"O preço do produto é {price} 
            // reais \n apenas na promoção.";    
            // Console.WriteLine(text);

            // @ -> ignora os caracteres de escape, incluindo  o que estiver dentro de { }
            //var text = @"O preço do produto é {price} 
            //reais \n apenas na promoção."; 

            //Console.WriteLine(text);


            // COMPARAÇÃO DE STRINGS
            // -> CompareTo: Retorna 0 se for igual, 1 se for maior, -1 se for menor
            // -> Contains: Verifica se um texto contém outro. Não aceita valor Null 

            // var texto = "Testando";
            // Console.WriteLine(texto.CompareTo("Testando")); // 0 pois os textos são iguais
            // Console.WriteLine(texto.CompareTo("testando")); // 1 pois 
            // Console.WriteLine(texto.Contains('t')); // true pois texto contém a letra 't'
            // Console.WriteLine(texto.Contains("testando")); // false pois C# é case-sensitive
            // Console.WriteLine(texto.Contains("testando", StringComparison.OrdinalIgnoreCase)); // true pois é ignorada a case-sensitive
            // Console.WriteLine(texto.Contains(null)); // Console.WriteLine(texto.Contains("testando"));



            // StartsWith/EndsWith
            // -> Verifica se um texto inicia ou termina com outro

            // var texto = "Testando a string";
            // Console.WriteLine(texto.StartsWith("Test")); // true
            // Console.WriteLine(texto.StartsWith("test")); // false
            // Console.WriteLine(texto.StartsWith("test", StringComparison.OrdinalIgnoreCase)); // true           
            // Console.WriteLine(texto.EndsWith("ings")); // false
            // Console.WriteLine(texto.EndsWith("ing")); // true


            // EQUALS
            // -> Verifica se toda a extensão de um texto é igual ao outro
            // -> Aceita valor Null 

            // var texto = "Testando a string";
            // Console.WriteLine(texto.Equals("Testando a string")); // true
            // Console.WriteLine(texto.Equals("testando a string")); // false
            // Console.WriteLine(texto.Equals("testando a string", StringComparison.OrdinalIgnoreCase)); // true
            // Console.WriteLine(texto.Equals(null)); // false


            // INDEXOF e LASTINDEXOF
            // -> INDEXOF Verifica a PRIMEIRA posição/índex de uma string dentro de outra 
            // -> LASTINDEXOF Verifica a ÚLTIMA posição/índex de uma string dentro de outra
            // -> Não recebem valor null
            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.IndexOf("e")); // 11 
            // Console.WriteLine(texto.LastIndexOf("t")); // 19


            // TOUPPER e TOLOWER
            // -> Converte uma string para maiúsculo ou minúsculo
            // -> Aceita valor null
            // var texto = "Testando a string";
            // Console.WriteLine(texto.ToUpper()); // TESTANDO A STRING
            // Console.WriteLine(texto.ToLower()); // testando a string


            //INSERT, REMOVE E LENGTH
            // -> INSERT -> Insere um texto em uma string a partir do index informado
            // -> REMOVE -> Remove um texto de uma string a partir do index informado
            // -> LENGTH -> Retorna o tamanho/quantidade de caracteres de uma string
            var texto = "Testando a string"; 
            Console.WriteLine(texto.Insert(17, " inserindo.")); // Testando a string inserindo.
            Console.WriteLine(texto.Remove(0, 9)); // a string
            Console.WriteLine(texto.Length); // 17


        }
    }
}
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
            var price = 10.2;

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

            // var texto = "Testando";
            // Console.WriteLine(texto.CompareTo("Testando")); // 0 pois os textos são iguais
            // Console.WriteLine(texto.CompareTo("testando")); // 1 pois 
            // Console.WriteLine(texto.Contains('t')); // true pois texto contém a letra 't'
            // Console.WriteLine(texto.Contains("testando")); // false pois C# é case-sensitive
            // Console.WriteLine(texto.Contains("testando", StringComparison.OrdinalIgnoreCase)); // true pois é ignorada a case-sensitive
            // Console.WriteLine(texto.Contains(null)); // Console.WriteLine(texto.Contains("testando"));



            // StartsWith/EndsWith
            var texto = "Testando a string";
            Console.WriteLine(texto.StartsWith("Test")); // true
            Console.WriteLine(texto.StartsWith("test")); // false
            Console.WriteLine(texto.StartsWith("test", StringComparison.OrdinalIgnoreCase)); // true           
            Console.WriteLine(texto.EndsWith("ings")); // false
            Console.WriteLine(texto.EndsWith("ing")); // true
        }
    }
}
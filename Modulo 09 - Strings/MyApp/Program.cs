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
            var text = @"O preço do produto é {price} 
            reais \n apenas na promoção."; 

            Console.WriteLine(text);

        }
    }
}
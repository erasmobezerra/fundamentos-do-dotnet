using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            // *Decimal -> Recomendado para trabalhar com moedas, maior precisão         
            // *=> Por default, converte para o padrão do Sistema operacional, 
            // *neste caso está em pt-BR, com vírgular para separar decimais
            Console.Clear();
            decimal valor = 12.50m;   
            Console.WriteLine($"Número decimal no padrão do Sistema Operacional: {valor}"); 


            // *GetCultureInfo("en-US") -> Retorna uma instancia da cultura estadunidense 
            var enUS = CultureInfo.GetCultureInfo("en-US"); 
            // *Converte o decimal para o padrão inglês estadunidense
            Console.WriteLine("=== Padrão Americano ===");
            Console.WriteLine("Moeda: " + valor.ToString("C", enUS)); 
            Console.WriteLine("Número sem formatação: " + valor.ToString("N", enUS));
            Console.WriteLine("Porcentagem: " + valor.ToString("P", enUS));     
            Console.WriteLine("Genérico: " + valor.ToString("G", enUS)); 
            Console.WriteLine("Número de maior precisão: " + valor.ToString("F", enUS));            
            Console.WriteLine();



            // *GetCultureInfo("pt-BR") -> Retorna uma instancia da cultura brasileira 
            var ptBR = CultureInfo.GetCultureInfo("pt-BR"); 
            // *Converte o decimal para o padrão português brasileiro   
            Console.WriteLine("=== Padrão Brasileiro ===");       
            Console.WriteLine($"Moeda: {valor.ToString("C", ptBR)}");     
            Console.WriteLine($"Número sem formatação: {valor.ToString("N", ptBR)}");
            Console.WriteLine($"Número sem formatação truncado em duas casas decimais: {valor.ToString("N2", ptBR)}");  
            Console.WriteLine($"Porcentagem: {valor.ToString("P", ptBR)}" );    
            Console.WriteLine($"Porcentagem truncada em duas casas decimais: {valor.ToString("P2", ptBR)}"); 

            Console.WriteLine($"Tipo genérico: {valor.ToString("G", ptBR)}"); 
            Console.WriteLine($"Número de precisão: {valor.ToString("F", ptBR)}");
            Console.WriteLine($"Número de precisão truncado em duas casas decimais: {valor.ToString("F2", ptBR)}");     
            Console.WriteLine();


            // *Math -> Classe com métodos matemáticos
            Console.WriteLine("=== Classe Math ===");
            decimal numeroDecimal = 299.999m;
            Console.WriteLine($"Número decimal: {numeroDecimal}");
            Console.WriteLine($"Arredonda para 2 casas decimais: {Math.Round(numeroDecimal, 2)}"); 
            Console.WriteLine($"Retorna a parte inteira do decimal: {Math.Truncate(numeroDecimal)}"); 
            Console.WriteLine($"Arredonda para próximo inteiro acima: {Math.Ceiling(numeroDecimal)}");
            Console.WriteLine($"Arredonda para próximo inteiro abaixo: {Math.Floor(numeroDecimal)}"); 
            








        }
    }
}
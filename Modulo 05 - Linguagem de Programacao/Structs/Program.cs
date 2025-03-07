/*
STRUCTS são usados para criar objetos que representam valores simples, como pontos, datas, etc.

->São valores, ou seja, quando você cria um objeto de um struct, você está criando um valor que é armazenado diretamente na variável.
->São passados por valor, ou seja, quando você passa um objeto de um struct como parâmetro para um método, você está passando uma cópia do valor, não a referência para o valor.
->Não podem ser herdadas, ou seja, você não pode criar um struct que herde as propriedades e métodos de outro struct.
->Não podem ser nulas, ou seja, você não pode atribuir null a um objeto de um struct.
->Não são coletados pelo garbage collector, ou seja, quando um objeto de um struct não é mais necessário, a memória é liberada imediatamente.

Em geral, as classes são usadas para criar objetos que representam entidades complexas, como pessoas, carros, etc., 
enquanto os structs são usados para criar objetos que representam valores simples, como pontos, datas, etc.
*/
namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nota 
            // Diferentemente das classes, mesmo com a adição de um construtor personalizado,
            // uma struct continua tendo um construtor padrão vazio, apesar de não ter sido declarado explicitamente.  
            Product product= new Product();
            Console.WriteLine($"Valor padrão para preço: {product.Price}");

            Product notebook = new Product(1, "Acer Nitro 5", 1200.00m, EProductType.Product);
            notebook.Price = notebook.PriceInDolar(5.80m); 

            Console.WriteLine("Dados do notebook: ");
            Console.WriteLine($"Id: {notebook.Id}");
            Console.WriteLine($"Name: {notebook.Name}");
            Console.WriteLine($"Preço convertido em dólar:${decimal.Round(notebook.Price, 2)}");

            Product formatacaoNotebook = new Product(2, "Formatação para notebooks", 120.00m, EProductType.Service);
            Console.WriteLine($"Preço para formatar um notebook: R${formatacaoNotebook.Price}");
            
        }
    }

    struct Product
    {
        public int Id;
        public string Name;
        public decimal Price;
        public EProductType Type;

        // public Product() { } // -> Construtor padrão Implícito, não é necessário declarar. 

        public Product(int id, string name, decimal price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        } 

        public decimal PriceInDolar(decimal dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }

}
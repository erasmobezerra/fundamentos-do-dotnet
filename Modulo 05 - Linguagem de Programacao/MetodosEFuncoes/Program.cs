/*
Definições
    Podemos segmentar nosso programa em funções
    Também conhecidos como métodos
    O main é um exemplo de método
    Possui um retorno, um nome e parâmetros
    Esta composição é camada de assinatura
    Começam sempre com maiúscula
*/
namespace MetodosEFuncoes
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Invocação do método
            // Armazena o resultado em uma variável
            var nome = RetornaNome("André", "Baltieri");

            // Imprime o nome na tela
            Console.WriteLine(nome);
        }

        // Definição do método
        // Retorna uma string e recebe vários parâmetros
        static string RetornaNome(
                string nome, 
                string sobrenome,
                int idade = 36 // Valor padrão para idade. Se nenhuma idade for informada, o padrão será 36
            )
        {
            // Retorna o nome e sobrenome
            return nome + " " + sobrenome + " - " + idade;
        }
    }
}




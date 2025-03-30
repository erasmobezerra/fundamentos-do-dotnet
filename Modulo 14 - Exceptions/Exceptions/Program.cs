/*
Em .NET, uma Exception (exceção) é um erro inesperado que ocorre durante a execução do programa. 
O tratamento de exceções é essencial para evitar falhas inesperadas e melhorar a robustez do código.

1. Tratamento de Exceções: try, catch, finally
Bloco try e catch: O código que pode gerar uma exceção é envolvido no bloco try, e a exceção pode ser 
capturada no bloco catch.

Bloco finally: O bloco finally é opcional e sempre será executado, independentemente de uma exceção ocorrer ou não. 
Ele é útil para liberar recursos, como fechar conexões de banco de dados ou arquivos.


2. Exceções Personalizadas
Em alguns casos, pode ser útil criar exceções específicas para o contexto da aplicação. 
Isso é feito criando uma classe que herda de Exception.


3. Captura Genérica vs. Captura Específica
O tratamento deve ser feito sempre a partir da exceção mais específica para a mais genérica
Capturar exceções específicas ajuda a tratar erros de forma mais controlada.
Capturar todas as exceções (Exception) é útil em cenários onde o erro não pode ser previsto, mas deve ser tratado de forma genérica.

*/

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[3];

            try
            {
                // for (int index = 0; index < 10; index++)
                // {
                //     //  System.IndexOutOfRangeException:
                //     Console.WriteLine(arr[index]);                    
                // }

                Cadastrar("");

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Não encontrei o índice na lista.");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Falha ao cadastrar texto!");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            catch (MinhaException ex)
            {
                Console.WriteLine("Exceção customizada.");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops, algo deu errado!");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }

        // Método Cadastrar 
        // -> Caso recebe uma string vazia ou nula, irá lançar a exceção personalizada MinhaException
        //    que armazerá um objetivo DateTime daquela exata data e hora. 
        private static void Cadastrar(string palavra)
        {
            if (string.IsNullOrEmpty(palavra))
                //  throw new ArgumentNullException("Não foi informado nenhum texto");
                throw new MinhaException(DateTime.Now);

            else
                Console.WriteLine($"Texto inserido no método Cadastrar(): {palavra}");
        }


        // Exception Personalizada que contém um atributo do tipo DateTime e um construtor passa.do como argumento a data. 
        public class MinhaException : Exception
        {
            public DateTime QuandoAconteceu { get; set; }

            public MinhaException(DateTime _QuandoAconteceu)
            {
                QuandoAconteceu = _QuandoAconteceu;
            }


        }
    }
}
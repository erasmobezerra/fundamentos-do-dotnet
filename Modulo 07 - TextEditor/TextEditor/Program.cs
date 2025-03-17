namespace TextEditor
{
    class Program
    {      
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            
            short option = short.Parse(Console.ReadLine());

            switch (option) {
                case 0: System.Environment.Exit(0); break;
                case 1: AbrirArquivo(); break;
                case 2: EditarArquivo(); break;
                default: Menu(); break;
            }
        }

        static void AbrirArquivo() {
            Console.Clear();
            Console.WriteLine("Qual caminho completo do arquivo txt?");
            var path = Console.ReadLine();
            Console.WriteLine("\nFavor informe o nome do arquivo para abrir");
            var fileName = Console.ReadLine();
            Console.Clear();

            // using -> garante que o arquivo seja fechado quando o bloco for encerrado
            // StreamReader -> leitura de arquivos
            using (var file = new StreamReader(path + fileName)) {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }            
            
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");            
            Console.ReadLine();
            Menu();
        }

        static void EditarArquivo() {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair):");
            Console.WriteLine("---------------------");
            string texto= "";
            do {
                texto += Console.ReadLine();
            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            SalvarArquivo(texto);
        }

          /// Salva um arquivo de texto com o conteúdo da variável texto no caminho especificado    
        static void SalvarArquivo(string text) {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();
            Console.WriteLine("\nFavor informe o nome do arquivo para salvar");
            var fileName = Console.ReadLine();     
            Console.Clear();       

            // StreamWriter -> grava o conteúdo da variável text em um arquivo
            using (var file = new StreamWriter(path + fileName)) 
            {
                file.Write(text);
            }

            Console.WriteLine($"O Arquivo {fileName} foi salvo com sucesso no caminho {path}");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadLine();
            Menu();
        }
    }
}

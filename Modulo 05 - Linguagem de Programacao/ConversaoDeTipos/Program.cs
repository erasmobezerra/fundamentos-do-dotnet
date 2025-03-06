// Conversão Implicita -> Conversão de um tipo para outro sem perda de dados
float valor = 25.8F;
int outro = 25;

valor = outro; // Conversão implícita
Console.WriteLine(valor);

// Casting ou Conversão Explícita -> Conversão de um tipo para outro com perda de dados
int inteiro = 100;
uint inteiroSemSinal = (uint)inteiro; // Conversão explícita
Console.WriteLine(inteiroSemSinal);


// Parse -> Conversão de string para outro tipo primitivo. Caso a string não seja compatível com o tipo, o parse irá falhar.
//       -> Não funciona para conversoes explicitas. Para isso, utilizamos o Convert
int numero = int.Parse("1000");
Console.WriteLine(numero);


// Convert -> Semelhante ao Parse, porém consegue converter vários tipos de valor, não apenas Strings
//         -> Deve-se informar o tipo na chamada da conversao
int numero2 = Convert.ToInt32("10000");
Console.WriteLine(numero2);
Console.WriteLine(Convert.ToBoolean(0));


// Método TryParse -> Para conversões de string para tipos numéricos ou para data/hora, 
//                    os métodos TryParse são ideais, pois tentam realizar a conversão e 
//                    retornam um booleano indicando o sucesso, sem lançar exceções.
string input = "789";
if (int.TryParse(input, out int resultado))
{
    Console.WriteLine("Conversão bem-sucedida: " + resultado);
}
else
{
    Console.WriteLine("Falha na conversão.");
}
Console.WriteLine("");



// Para conversões seguras entre tipos de referência, operador "as" / Pattern Matching: 

// Operador "as": Útil para conversões entre tipos de referência. Ele tenta converter o 
//                objeto para o tipo desejado e retorna null se a conversão não for possível, evitando exceções.
object obj = "exemplo";
string? texto = obj as string;
if (texto != null)
{
    Console.WriteLine("Conversão realizada com sucesso: " + texto);
}
Console.WriteLine("");


// Pattern Matching: Com o uso do is ou switch com pattern matching, você pode verificar o tipo antes de realizar a conversão.
object valor1 = 100;
if (valor1 is int numeroInteiro)
{
    Console.WriteLine("Valor é um inteiro: " + numeroInteiro);
}
else
{
    Console.WriteLine("Valor não é um inteiro.");
}


object valor2 = "Olá, mundo!";
switch (valor2)
{
    case int i:
        Console.WriteLine($"O valor é um inteiro: {i}");
        break;
    case string s:
        Console.WriteLine($"O valor é uma string: {s}");
        break;
    case null:
        Console.WriteLine("O valor é null");
        break;
    default:
        Console.WriteLine("Tipo desconhecido");
        break;
}


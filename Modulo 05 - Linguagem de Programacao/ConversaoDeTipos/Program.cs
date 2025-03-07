// Conversão Implicita -> Conversão de um tipo para outro sem perda de dados
float valor = 25.8F;
int outro = 25;

valor = outro; // Conversão implícita
Console.WriteLine(valor);

// Casting ou Conversão Explícita -> Conversão de um tipo para outro com perda de dados
int inteiro = 100;
uint inteiroSemSinal = (uint)inteiro; // Conversão explícita
Console.WriteLine(inteiroSemSinal);


// Parse -> Conversão de string para outro tipo primitivo. 
//       -> Não funciona para conversoes explicitas. Para isso, utilizamos o Convert
//       -> Caso não consiga converter, retorna uma exceção
double numero = int.Parse("1000");
Console.WriteLine(numero);
var dataTime = DateTime.Parse("01/01/2023 00:00:00"); 
Console.WriteLine("dataTime: " + dataTime);


// Convert -> Semelhante ao Parse, porém consegue converter vários tipos de valor, não apenas Strings
//         -> Deve-se informar o tipo na chamada da conversao
//         -> Caso não consiga converter, retorna uma exceção 
int numero2 = Convert.ToInt32("10000");
Console.WriteLine(numero2);
Console.WriteLine(Convert.ToBoolean(0));

var dataTime2 = Convert.ToDateTime("01/01/2023 00:00:00");
Console.WriteLine(dataTime2);


// Método TryParse -> Para conversões de string para tipos numéricos ou para data/hora, 
//                    os métodos TryParse são ideais, pois tentam realizar a conversão e 
//                    retornam um booleano indicando o sucesso, sem lançar exceções.
string? input = null;
if (int.TryParse(input, out int resultado))
{
    Console.WriteLine("Conversão bem-sucedida: " + resultado);
}
else
{
    Console.WriteLine("Falha na conversão.");
}
Console.WriteLine("");



// Operador "as": Útil para conversões explícitas entre objetos ou entre tipos de referência. Ele tenta converter o 
//                objeto para o tipo desejado e retorna null se a conversão não for possível, evitando exceções.
object obj = "exemplo";
string? texto = obj as string;
if (texto != null)
{
    Console.WriteLine("Conversão realizada com sucesso: " + texto);
}
Console.WriteLine("");



// OPERADOR IS
// O is é um operador de comparação, que podemos utilizar para comparar tipos tanto primitivos quanto complexos, 
// eliminando a necessidade do typeof, até então presente como única opção.


var someText = "This is a string";
var result = someText is string; // retorna um valor booleano
Console.WriteLine("Result: " + result);

// Também podemos utilizar a seguinte sintaxe:
if (someText is string result2)
{
    Console.WriteLine("A variável someText é uma string: " + result2);
} 
else
{
    Console.WriteLine("A variável someText não é uma string.");
} 


// Comparando objeto com tipos primitivos
object valor1 = 100;
if (valor1 is int numeroInteiro)
{
    Console.WriteLine("Valor é um inteiro: " + numeroInteiro);
}
else
{
    Console.WriteLine("Valor não é um inteiro.");
}

// Comparando objeto com DateTime
object obj3 = DateTime.Now;
if (obj3 is DateTime)
{
    Console.WriteLine("É um DateTime.");
}


// Utilizando switch para comparar objetos tipos primitivos
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









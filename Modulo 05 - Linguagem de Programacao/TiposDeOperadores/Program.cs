// Operadores Aritméticos

Console.WriteLine("Operadores Aritméticos");
int soma = 25 + 22; // 47
int subtracao = 25 - 22; // 3
int divisao = 25 * 22; // 550
int multiplicacao = 22 / 5; // 4 – Foi arredondado

decimal a = 1.0M;
decimal b = 2.0M;

// Soma
Console.WriteLine(a + b);
// Subtracao
Console.WriteLine(a - b);
// Multiplicacao
Console.WriteLine(a * b);
//  Divisao
Console.WriteLine(a / b);
// Resto
Console.WriteLine(a % b); // retorna o resto da divisão inteira, ou seja, utiliza o quociente truncado (parte inteira da divisão)

// Utilizamos parênteses para redefinir a ordem de execução
int c = 2 + 2 * 2; // 6
int d = 2 + (2 * 2); // 6 – Mesmo do anterior
int e = (2 + 2) * 2; // 8 – Executou a soma primeiro

// Operadores de Atribuição
int x = 0; // Atribuição
x += 5; // x = x + 5;
x -= 1; // x = x – 1;
x *= 10; // x = x * 10;
x /= 2; // x = x / 2;
x ++; // incrementa x em 1
x --; // decrementa x em 1
Console.WriteLine($"x = {x}");


// Operadores de Comparação
Console.WriteLine("Operadores de Comparação");
int y = 1;
int z = 2;
Console.WriteLine(y == z); // False
Console.WriteLine(y != z); // True
Console.WriteLine(y > z); // False
Console.WriteLine(y < z); // True
Console.WriteLine(y >= z); // False
Console.WriteLine(y <= z); // True


string nome = "João";
string sobrenome = "Silva";
Console.WriteLine(nome == nome); // True
Console.WriteLine(nome != sobrenome); // True   
Console.WriteLine(nome == sobrenome); // False 



// Operadores Lógicos -> usado para operações condicionais / booleanas
//      -> Retorna sempre verdadeiro ou falso
//      AND (&&) - Todas as condições precisam ser verdadeiras
//      OR (||) - Uma das condições precisa ser verdadeira
//      NOT (!) - Inverte o resultado da condição 

Console.WriteLine("Operadores Lógicos");
int k = 20;
Console.WriteLine((k > 25) && (k < 40));
Console.WriteLine((k > 25) || (k < 40));
Console.WriteLine(!(k < 25));




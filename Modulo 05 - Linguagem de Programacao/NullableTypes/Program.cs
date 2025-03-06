int? numero = null;
// int? numero = 12;

if (numero.HasValue){
    Console.WriteLine(numero.Value);
} else {
    Console.WriteLine("numero é nulo");
}

// Método GetValueOrDefault -> Permite fornecer um valor padrão caso o valor seja nulo
Console.WriteLine(numero.GetValueOrDefault());
Console.WriteLine(numero.GetValueOrDefault(12));

// Operador de Coalescência Nula (??) -> Permite fornecer um valor padrão caso o valor seja nulo
Console.WriteLine(numero ?? 0);
Console.WriteLine(numero ?? 12);


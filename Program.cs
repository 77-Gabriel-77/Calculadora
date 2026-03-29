Console.WriteLine("Calculadora\n");

Console.WriteLine("Informe o primeiro número:");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Informe o segundo número:");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Informe o operador (+, -, *, /)");
string operador = Console.ReadLine();
 


if (operador == "/" && numero2 == 0)
{
    Console.WriteLine("Não é possivel dividir por 0");
}
else if (string.IsNullOrWhiteSpace(operador) || operador != "+" && operador != "-" && operador != "*" && operador != "/")
{
    Console.WriteLine("Operador inválido");
}
else
{
    switch (operador)
    {
        case "+":
            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                break;
        case "-":
            Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
            break;
        case "*":
            Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
            break;
        case "/":
            Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
            break;



        default:
            Console.WriteLine("Operador inválido");
            break;
    }
}

Console.ReadKey();
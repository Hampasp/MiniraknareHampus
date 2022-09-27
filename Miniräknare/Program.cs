
Console.WriteLine("Välkommen till miniräknaren!");
Console.WriteLine("Ange din ekvation!");
int tal1 = 0;
bool correctInput = false;
while (!correctInput)
{
    Console.Write("tal 1: ");
    correctInput = int.TryParse(Console.ReadLine(), out tal1);
    
}
Console.Write("Ange operand: ");
string operand = Console.ReadLine();

int tal2 = 0;
correctInput = false;
while (!correctInput)
{
    Console.Write("tal 2: ");
    correctInput = int.TryParse(Console.ReadLine(), out tal2);
}

switch (operand)
{
    case "+":
        int summaAddition = tal1 + tal2;
        Console.WriteLine(summaAddition);
        break;
    case "-":
        int summaSubtrakion = tal1 - tal2;
        Console.WriteLine(summaSubtrakion);
        break;
    case "*":
        int produkt = tal1 * tal2;
        Console.WriteLine(produkt);
        break;
    case "/":
        int kvot;

        try
        {
            kvot = tal1 / tal2;
            Console.WriteLine(kvot);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Omöjligt att dividera med 0!");
        }
        break;

    default:
        break;
}
Console.ReadLine();



short userOption = 0;
float n1, n2;

while (userOption != 9)
{
    Console.Clear();
    userOption = UserInput();

    switch(userOption)
    {
        case 1: 
        case 2: 
        case 3: 
        case 4: InputData(out n1, out n2, userOption); ProcessData(n1, n2, userOption); break;
        case 9: break;
        default: Console.WriteLine("The selected option is invalid. Try again"); break;
    }
}

Console.WriteLine("Thanks for using our program!");
Console.ReadKey();
Console.Clear();


static short UserInput()
{
    Console.WriteLine("Select one of the options bellow:");
    Console.WriteLine("1- Sum");
    Console.WriteLine("2- Subtraction");
    Console.WriteLine("3- Multiplication");
    Console.WriteLine("4- Division");
    Console.WriteLine("9- Exit");
    Console.Write("Your option: ");
    short userOption = short.Parse(Console.ReadLine());
    return userOption;
}

static void InputData(out float n1, out float n2, short userOption)
{
    var operation = CalculationType(userOption);
    Console.Clear();
    Console.WriteLine($"You chose the {operation} operation");
    Console.Write("Digite o primeiro valor: ");
    n1 = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    n2 = float.Parse(Console.ReadLine());
}

static void ProcessData(float n1, float n2, short userOption)
{
    float result=0;
    char sign=' ';
    switch (userOption)
    {
        case 1: result = n1+n2; sign = '+'; break;
        case 2: result = n1-n2; sign = '-'; break;
        case 3: result = n1*n2; sign = '*'; break;
        case 4: result = n1/n2; sign = '/'; break;
    }
    Console.WriteLine($"{n1} {sign} {n2} = {result}");
    Console.ReadKey();
    // Console.Write("Would you like to use the result in your next calculation? (y/n): ");
    // var reuse = Console.ReadLine();

}

static string CalculationType(short userOption)
{
    string operation="";
    switch (userOption)
    {
        case 1: operation = "SUM"; break;
        case 2: operation = "SUBTRACTION"; break;
        case 3: operation = "MULTIPLICATION"; break;
        case 4: operation = "DIVISION"; break;
    }
    return operation;
}

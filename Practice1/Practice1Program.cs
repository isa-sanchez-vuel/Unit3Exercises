using Practice1;

const int EXIT_NUMBER = 3;

bool exit;
int option;
string? input;

Son son = new Son();

do
{
    exit = false;

    PrintMenu();
    option = GetInputParsedInt();

    if (option != EXIT_NUMBER) ManageOptions(option);
    
    if (option == EXIT_NUMBER) exit = true;

} while (!exit);


void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("1 - Show values\n" +
        "2 - Modify Values\n" +
        $"{EXIT_NUMBER} - Exit\n" +
        "Please select an option:");
    Console.Write("=>");
}

void PrintFarewell()
{
    Console.WriteLine("Do you want to execute another action?\n" +
        $"Press {EXIT_NUMBER} to exit if not, press any other key if yes:");
    Console.Write("=>");
    option = GetInputParsedInt();
}

void ManageOptions(int option)
{
    switch (option)
    {
        case 1: son.PrintAllValues();
            break;

        case 2: //son.ChangeValue();
            break;

        default: Console.WriteLine("Wrong number, try again.");

            break;
    }

    PrintFarewell();
}

int GetInputParsedInt()
{
    input = Console.ReadLine()?.Trim();

    if (int.TryParse(input, out option)) return int.Parse(input);
    else return 0;

}
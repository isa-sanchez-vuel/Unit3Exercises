using Practice1;
using ConsoleMenu;
using System.Text;

const int EXIT_NUMBER = 3;

bool exit;
int option;

Son son = new();

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

do
{
    exit = false;

    Console.Clear();
    Menu.PrintMenu($"1 - Show values\n" +
        $"2 - Modify Values\n" +
        $"{EXIT_NUMBER} - Exit\n" +
        $"Please select an option:");
    option = Menu.GetInputParsedInt();

    if (option != EXIT_NUMBER)
    { 
        ManageOptions(option);
    }

    if (option == EXIT_NUMBER) exit = true;

} while (!exit);


void ManageOptions(int opt)
{
    switch (opt)
    {
        case 1:
            son.PrintAllValues();
            break;

        case 2: son.ChangeValue();
            break;

        default:
            Console.WriteLine("Wrong number, try again.");
            break;
    }

    Menu.PrintMenu("Do you want to execute another action?\n" +
        $"Press {EXIT_NUMBER} to exit if not, press any other key if yes:");
    option = Menu.GetInputParsedInt();

}


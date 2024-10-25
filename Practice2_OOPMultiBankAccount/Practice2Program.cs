using Practice2_OOPMultiBankAccount;
using ConsoleMenu;

bool exit;


Bank bank = new("ES", "PoatatoBank S.L", "3000", "54", "4790");

bank.CreateAccount("1122334455", "1111", "Francisco Bezerra");
bank.CreateAccount("2233445566", "2222", "Manel Joaquin Terez");
bank.CreateAccount("3344556677", "3333", "Ithiar Lobillo");
bank.CreateAccount("4455667788", "4444", "Laura Bastión");
bank.CreateAccount("5566778899", "5555", "Pol Bezerra");
bank.CreateAccount("6677889900", "6666", "Marina Bezerra");



do
{
    exit = false;

    Console.Clear();
    Menu.PrintMenu($"1 - Show values\n" +
        $"2 - Modify Values\n" +
        $" - Exit\n" +
        $"Please select an option:");


} while (true);
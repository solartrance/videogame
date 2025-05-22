using System;
using System.Text;
using VideoGame;

class Program
{
    static RentalService rentalService = new RentalService();

    static void SeedGames() {
        rentalService.AddGame(new Game("G001", "The Witcher 3", "RPG", 2015, 5.99m));
        rentalService.AddGame(new Game("G002", "Cyberpunk 2077", "Action RPG", 2020, 7.99m));
        rentalService.AddGame(new Game("G003", "Minecraft", "Sandbox", 2011, 3.99M));
    }
    static void SeedCustomers() {
        rentalService.AddCustomer(new Customer(1, "Cset Elek"));
        rentalService.AddCustomer(new Customer(2, "Hiszt Erika"));
        rentalService.AddCustomer(new Customer(3, "Cicam Ica"));
        rentalService.AddCustomer(new Customer(4, "Idét Lenke"));
        rentalService.AddCustomer(new Customer(5, "kispál inka"));
    }

    static void DisplayInfo(IEnumerable<object> lista) {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }

    static void AddGame()
    {
        Console.Write("Játék ID: ");
        string id = Console.ReadLine();
        Console.Write("Cím: ");
        string title = Console.ReadLine();
        Console.Write("Műfaj: ");
        string genre = Console.ReadLine();
        Console.Write("Kiadási év: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Ár/nap: ");
        decimal price = decimal.Parse(Console.ReadLine());

        rentalService.AddGame(new Game(id, title, genre, year, price));
        Console.WriteLine("Játék hozzáadva.");
    }

    static void RemoveGame()
    {
        Console.Write("Törlendő játék ID: ");
        string id = Console.ReadLine();
        rentalService.RemoveGame(id);
        Console.WriteLine("Ha elérhető volt, törölve lett.");
    }



    static void RentGame()
    {
        Console.Write("Felhasználó neve: ");
        string name = Console.ReadLine();
        Console.Write("Játék ID: ");
        string id = Console.ReadLine();

        if (rentalService.RentGame(name, id))
            Console.WriteLine("Sikeres kölcsönzés.");
        else
            Console.WriteLine("Kölcsönzés sikertelen (játék lehet, hogy nem elérhető vagy nem létezik).");
    }

    static void ReturnGame()
    {
        Console.Write("Felhasználó neve: ");
        string name = Console.ReadLine();
        Console.Write("Játék ID: ");
        string id = Console.ReadLine();

        if (rentalService.ReturnGame(name, id))
            Console.WriteLine("Sikeres visszavétel.");
        else
            Console.WriteLine("Visszavétel sikertelen.");
    }

    static void DisplayRentalCosts()
    {

    }

    static void SaveData()
    {

    }

    static void LoadGames()
    {

    }
    static void LoadCustomers()
    {
    }

    static void Main()
    {

        // Betöltés fájlból
        if (File.Exists("games.csv")) LoadGames();
        else SeedGames();
        
        if (File.Exists("customers.csv")) LoadCustomers();
        else SeedCustomers();

        string choice = "\n";
       
        while (true)
        {

            Console.WriteLine("\nVideójátékkölcsönző rendszer\n");
            Console.WriteLine("1. Játékok listázása");
            Console.WriteLine("2. Új játék felvétele");
            Console.WriteLine("3. Elérhető játékok listázása");
            Console.WriteLine("4. Felhasználók listázása");
            Console.WriteLine("5. Új felhasználó felvétele");
            Console.WriteLine("6. Játék kölcsönzése");
            Console.WriteLine("7. Játék visszavétele");
            Console.WriteLine("8. Kölcsönzési díjak megtekintése");
            Console.WriteLine("9. Kilépés és mentés");
            Console.WriteLine();
            Console.WriteLine("Válassz egy opciót: ");
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    DisplayInfo(rentalService.ListAllGames());
                    break;
                case "2":
                    AddGame();
                    break;
                case "3":
                    DisplayInfo(rentalService.ListAvailableGames());
                    break;
                case "4":
                    DisplayInfo(rentalService.ListCustomers());
                    break;
                case "5":
                    AddCustomer();
                    break;
                case "6":
                    RentGame();
                    break;
                case "7":
                    ReturnGame();
                    break;
                case "8":
                    DisplayRentalCosts();
                    break;
                case "9":
                    SaveData();
                default:
                    Console.WriteLine("Érvénytelen választás. Próbáld újra!");
                    break;
            }

            Console.SetCursorPosition(20, 13);
            choice = Console.ReadLine();
            Console.Clear();
        }
    }
}

  
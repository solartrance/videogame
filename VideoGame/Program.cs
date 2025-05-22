using System;
using System.Text;
using VideoGame;

class Program
{
    static RentalService rentalService = new RentalService();

    static void SeedGames() {
        //rentalService.AddGame(new Game("G001", "The Witcher 3", "RPG", 2015, 5.99m));
        //rentalService.AddGame(new Game("G002", "Cyberpunk 2077", "Action RPG", 2020, 7.99m));
        //rentalService.AddGame(new Game("G003", "Minecraft", "Sandbox", 2011, 3.99M));
    }
    static void SeedCustomers() {
        //rentalService.AddCustomer(new Customer(1, "Cset Elek"));
        //rentalService.AddCustomer(new Customer(2, "Hiszt Erika"));
        //rentalService.AddCustomer(new Customer(3, "Cicam Ica"));
        //rentalService.AddCustomer(new Customer(4, "Idét Lenke"));
        //rentalService.AddCustomer(new Customer(5, "Kispál Inka"));
    }

    static void DisplayInfo(IEnumerable<object> lista) {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }

    static void RentGame()
    {

    }

    static void ReturnGame()
    {

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
                   
                    break; 
                case "2":
                    
                    break; 
                case "3":
                    
                    break;
                case "4":
               
                    break;
                case "5":
                  
                    break;
                case "6":
                   
                    break;
                case "7":
                   
                    break;
                case "8":
                    
                    break;
                case "9":
                   
                    return;
                case "\n":
                    break;
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

  
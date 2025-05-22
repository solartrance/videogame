using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class RentalService
    {
        public List<Game> Games { get; set; } = new List<Game>();
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public void AddGame(Game game)
        {
            Games.Add(game);
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public bool RentGame(string customerName, string gameId)
        {
            var customer = FindCustomerName(customerName);
            var game = FindGame(gameId);
            if (customer != null && game != null && game.IsAvailable)
            {
                customer.RentGame(game);
                return true;
            }
            return false;
        }

        public bool ReturnGame(string customerName, string gameId)
        {
            var customer = FindCustomerName(customerName);
            var game = FindGame(gameId);
            if (customer != null && game != null && !game.IsAvailable && customer.RentedGames.Contains(game))
            {
                customer.ReturnGame(game);
                return true;
            }
            return false;
        }

        public void RemoveGame(string gameID)
        {
            var game = FindGame(gameID);
            if (game != null && game.IsAvailable)
            {
                Games.Remove(game);
            }
        }

        public Game FindGame(string gameID)
        {
            return Games.FirstOrDefault(g => g.GameID == gameID);
        }

        public Customer FindCustomerName(string customerName)
        {
            return Customers.FirstOrDefault(c => c.Name.Equals(customerName, StringComparison.OrdinalIgnoreCase));
        }

        public List<Game> ListAvailableGames()
        {
            return Games.Where(g => g.IsAvailable).ToList();
        }

        public List<Game> ListAllGames()
        {
            return Games;
        }

        public List<Customer> ListCustomers()
        {
            return Customers;
        }


    }
}

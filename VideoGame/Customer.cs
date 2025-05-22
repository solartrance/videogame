using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public List<Game> RentedGames { get; set; }

        public Customer(int customerID, string name)
        {
            CustomerID = customerID;
            Name = name;
            RentedGames = new List<Game>();
        }

        public void RentGame(Game game)
        {
            if (game.IsAvailable)
            {
                game.IsAvailable = false;
                RentedGames.Add(game);
            }
        }

        public void ReturnGame(Game game)
        {
            if (RentedGames.Contains(game))
            {
                game.IsAvailable = true;
                RentedGames.Remove(game);
            }
        }

        public override string? ToString()
        {
            return $"{Name} (ID: {CustomerID}) - {RentedGames.Count} játék kölcsönözve";
        }
    }

}

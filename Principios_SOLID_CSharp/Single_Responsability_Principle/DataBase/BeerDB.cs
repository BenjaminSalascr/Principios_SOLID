using Single_Responsability_Principle.Models;

namespace Single_Responsability_Principle.DataBase
{
    public class BeerDB
    {
        private Beer _beer;

        public BeerDB(Beer beer)
        {
            _beer = beer;
        }

        public void Save()
        {
            Console.WriteLine($"Guardamos {_beer.Name} y {_beer.Brand}");
        }
        
    }
}

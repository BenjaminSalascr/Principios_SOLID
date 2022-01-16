using Single_Responsability_Principle.Models;

namespace Single_Responsability_Principle.Service
{
    public class BeerRequest
    {
        private Beer _beer;

        public BeerRequest(Beer beer)
        {
            _beer = beer;
        }

        public void Send()
        {
            Console.WriteLine($"Enviamos {_beer.Name} y {_beer.Brand}");
        }
    }
}

namespace Single_Responsability_Principle.Models
{
    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public Beer(string Name, string Brand)
        {
            this.Name = Name;
            this.Brand = Brand;
        }
        
    }
}

namespace CitiesKata.EF.Entities
{
    public class Attraction
    {
        public Attraction()
        {
            
        }

        public Attraction(string name)
        {
            Name = name;
        }

        public long Id { get; set; }
        public string Name { get; set; }
    }
}
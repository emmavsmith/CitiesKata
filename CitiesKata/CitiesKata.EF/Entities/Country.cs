namespace CitiesKata.EF.Entities
{
    public class Country
    {
        public Country()
        {
        }

        public Country(string name)
        {
            Name = name;
        }

        public long Id { get; set; }
        public string Name { get; set; }
    }
}
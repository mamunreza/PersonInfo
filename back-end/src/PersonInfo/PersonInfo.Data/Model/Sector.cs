namespace PersonInfo.Data.Model
{
    public class Sector
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int ParentId { get; set; }
        public Sector? Parent { get; set; }
        public ICollection<Sector> Children { get; set; }
    }
}

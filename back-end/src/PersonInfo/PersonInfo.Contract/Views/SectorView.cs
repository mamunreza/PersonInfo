namespace PersonInfo.Contract.Views
{
    public class SectorView
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int ParentId { get; set; }
        public bool IsParent { get; set; }
        public int Level { get; set; }
    }
}

namespace PersonInfo.Contract.Views
{
    public class PersonView : BaseView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SectorId { get; set; }
        public bool AgreeToTerms { get; set; }
    }
}

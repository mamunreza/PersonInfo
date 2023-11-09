namespace PersonInfo.Contract.Commands
{
    public class UpdatePersonCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SectorId { get; set; }
        public bool AgreeToTerms { get; set; }
    }
}

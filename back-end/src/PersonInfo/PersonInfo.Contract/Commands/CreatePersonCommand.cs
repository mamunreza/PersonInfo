namespace PersonInfo.Contract.Commands
{
    public class CreatePersonCommand
    {
        public string Name { get; set; }
        public int SectorId { get; set; }
        public bool AgreeToTerms { get; set; }
    }
}

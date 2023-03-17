namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The engineer must have a name!")]
    public string Name { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}
using System.ComponentModel.DataAnnotations;
namespace Factory.Models
{
  using System.Collections.Generic;
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The machine must have a name!")]
    public string Name { get; set; }
    public string MachineStatus { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}
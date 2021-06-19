using System.Collections.Generic;

namespace SweetAndSavory.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntities { get; }
  }
}
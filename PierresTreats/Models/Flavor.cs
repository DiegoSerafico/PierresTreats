using System;
using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}
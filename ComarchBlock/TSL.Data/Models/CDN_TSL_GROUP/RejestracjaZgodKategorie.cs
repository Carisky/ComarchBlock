using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class RejestracjaZgodKategorie
{
    public int RzkRzkid { get; set; }

    public string RzkNazwa { get; set; } = null!;

    public virtual ICollection<RejestracjaZgodTresc> RejestracjaZgodTrescs { get; set; } = new List<RejestracjaZgodTresc>();
}

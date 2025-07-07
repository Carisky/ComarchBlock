using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfOstree
{
    public int DcoId { get; set; }

    public int? DcoDcoid { get; set; }

    public int DcoDcdid { get; set; }

    public bool DcoArchival { get; set; }

    public virtual DfConfOsdictionary DcoDcd { get; set; } = null!;

    public virtual DfConfOstree? DcoDco { get; set; }

    public virtual ICollection<DfConfOstree> InverseDcoDco { get; set; } = new List<DfConfOstree>();
}

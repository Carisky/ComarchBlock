using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Connection
{
    public int ConId { get; set; }

    public string? ConServer { get; set; }

    public string? ConDatabase { get; set; }

    public int? ConDbType { get; set; }

    public bool? ConIsDeleted { get; set; }

    public bool ConIsDefault { get; set; }

    public string? ConName { get; set; }

    public int ConPort { get; set; }

    public string? ConUserId { get; set; }

    public string? ConPassword { get; set; }

    public int ConOpenTimeout { get; set; }

    public int ConQueryTimeout { get; set; }

    public string? ConCube { get; set; }

    public bool ConIsDefinedInWeb { get; set; }

    public bool ConIsInMemoryConnection { get; set; }

    public int ConCompanyId { get; set; }

    public int? ConBitype { get; set; }

    public virtual Company ConCompany { get; set; } = null!;

    public virtual ICollection<DataModel> DataModels { get; set; } = new List<DataModel>();
}

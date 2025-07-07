using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class OlapServer
{
    public int Id { get; set; }

    public string ServerName { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public int RowVer { get; set; }

    public virtual ICollection<Cube> Cubes { get; set; } = new List<Cube>();
}

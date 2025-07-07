using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class DatabaseName
{
    public int DbnId { get; set; }

    public int DbnSrvid { get; set; }

    public string DbnName { get; set; } = null!;

    public virtual ICollection<DatabaseSchema> DatabaseSchemas { get; set; } = new List<DatabaseSchema>();

    public virtual Server DbnSrv { get; set; } = null!;
}

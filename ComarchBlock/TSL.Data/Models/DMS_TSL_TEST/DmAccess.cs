using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DmAccess
{
    public int DraId { get; set; }

    public int DraDrtid { get; set; }

    public int DraDcdid { get; set; }

    public bool? DraDokView { get; set; }

    public bool? DraDokEdit { get; set; }

    public bool? DraDokArchive { get; set; }

    public bool? DraCatEdit { get; set; }

    public bool? DraCatArchive { get; set; }

    public bool? DraCatAdministrator { get; set; }

    public bool? DraIsArchival { get; set; }

    public virtual DmHeadTree DraDrt { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfOsflowAccess
{
    public int TfaDcdid { get; set; }

    public int TfaDfhid { get; set; }

    public bool TfaExists { get; set; }

    public virtual DfConfOsdictionary TfaDcd { get; set; } = null!;

    public virtual DfHeadDokumentFlow TfaDfh { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DokRelacje
{
    public int DoRDoRid { get; set; }

    public short DoRParentTyp { get; set; }

    public int DoRParentId { get; set; }

    public Guid? DoRParentGuid { get; set; }

    public short DoRDokumentTyp { get; set; }

    public int DoRDokumentId { get; set; }

    public Guid? DoRDokumentGuid { get; set; }

    public short DoRFlaga { get; set; }

    public short? DoRHrm { get; set; }
}

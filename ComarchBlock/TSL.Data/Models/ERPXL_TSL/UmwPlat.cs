using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class UmwPlat
{
    public short? UplGidtyp { get; set; }

    public int? UplGidfirma { get; set; }

    public int UplGidnumer { get; set; }

    public short UplGidlp { get; set; }

    public string? UplWaluta { get; set; }

    public short? UplNrKursu { get; set; }

    public decimal? UplKursM { get; set; }

    public decimal? UplKursL { get; set; }

    public byte? UplTyp { get; set; }

    public int? UplTermin { get; set; }

    public byte? UplFormaNr { get; set; }

    public string? UplFormaNazwa { get; set; }

    public decimal? UplKwota { get; set; }

    public decimal? UplProcent { get; set; }

    public decimal? UplPozostaje { get; set; }

    public string? UplNotatki { get; set; }

    public int? UplTerminDni { get; set; }

    public short? UplTrNtyp { get; set; }

    public int? UplTrNnumer { get; set; }

    public short? UplNrRaty { get; set; }

    public int? UplDataDokumentu { get; set; }

    public short? UplImpTyp { get; set; }

    public int? UplImpNumer { get; set; }

    public virtual UmwNag UplGidnumerNavigation { get; set; } = null!;
}

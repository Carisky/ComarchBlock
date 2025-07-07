using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class StaZakazy
{
    public short? StZStaTyp { get; set; }

    public int? StZStaFirma { get; set; }

    public int StZStaNumer { get; set; }

    public short? StZStaLp { get; set; }

    public int StZProcId { get; set; }

    public byte? StZMaskaFormy { get; set; }

    public short? StZMaskaFormyAtr { get; set; }

    public short? StZMaskaFormyExp { get; set; }

    public virtual StaKarty StZStaNumerNavigation { get; set; } = null!;
}

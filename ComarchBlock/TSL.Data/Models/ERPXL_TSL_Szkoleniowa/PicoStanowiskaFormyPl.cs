using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PicoStanowiskaFormyPl
{
    public int? PfpPsaId { get; set; }

    public string? PfpNazwaPos { get; set; }

    public short? PfpKartyp { get; set; }

    public int? PfpKarfirma { get; set; }

    public int? PfpKarnumer { get; set; }

    public short? PfpKarlp { get; set; }

    public byte? PfpFormaNr { get; set; }

    public byte? PfpBezKpKw { get; set; }

    public byte? PfpCzyscPoZamknieciuSesji { get; set; }

    public int? PfpCzasModyfikacji { get; set; }

    public virtual PicoStanowiska? PfpPsa { get; set; }
}

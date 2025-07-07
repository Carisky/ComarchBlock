using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdNormatywRealizacjaElem
{
    public int NreId { get; set; }

    public int? NreNormatywId { get; set; }

    public int? NreOperacja { get; set; }

    public int? NreMaterial { get; set; }

    public int? NreMaterialNietechnologiczny { get; set; }

    public decimal? NreIloscWtp { get; set; }

    public int? NreTypZasobu { get; set; }

    public decimal? NreMinIloscZp { get; set; }

    public decimal? NreSredniaIloscZp { get; set; }

    public decimal? NreMaksIloscZp { get; set; }

    public byte? NreRodzajWykorzystania { get; set; }

    public int? NreIdZpmax { get; set; }

    public int? NreIdZpmin { get; set; }

    public int? NreTimeStamp { get; set; }

    public virtual ProdNormatywRealizacja? NreNormatyw { get; set; }
}

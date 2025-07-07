using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class IstElem
{
    public short? IsEGidtyp { get; set; }

    public int? IsEGidfirma { get; set; }

    public int IsEGidnumer { get; set; }

    public short IsEGidlp { get; set; }

    public string? IsEPozDo { get; set; }

    public byte? IsERodzajKorekty { get; set; }

    public string? IsEKrajWysPrzez { get; set; }

    public string? IsEOpisTowaru { get; set; }

    public string? IsEWarunkiDostawy { get; set; }

    public string? IsEKodRodzajuTransakcji { get; set; }

    public string? IsEKodRodzajuTransportu { get; set; }

    public string? IsEKodCn { get; set; }

    public string? IsEKrajPoch { get; set; }

    public decimal? IsEMasaNetto { get; set; }

    public decimal? IsEIloscJmuzup { get; set; }

    public decimal? IsEWartoscFakt { get; set; }

    public decimal? IsEWartoscStat { get; set; }

    public byte? IsETypEdycji { get; set; }

    public int? IsEPozycja { get; set; }

    public string? IsENip { get; set; }

    public virtual IstNag IsEGidnumerNavigation { get; set; } = null!;

    public virtual ICollection<IstSelem> IstSelems { get; set; } = new List<IstSelem>();
}

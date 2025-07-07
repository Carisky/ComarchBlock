using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class WypSkladniki
{
    public int WpsWpsId { get; set; }

    public int WpsWplId { get; set; }

    public int WpsWpeId { get; set; }

    public int WpsPraId { get; set; }

    public int WpsDzlId { get; set; }

    public int? WpsPnbId { get; set; }

    public int WpsTwpId { get; set; }

    public int? WpsRodzajZrodla { get; set; }

    public int? WpsZrodloId { get; set; }

    public string WpsNazwa { get; set; } = null!;

    public decimal WpsWartosc { get; set; }

    public DateTime WpsDataDanych { get; set; }

    public DateTime? WpsDataOd { get; set; }

    public DateTime? WpsDataDo { get; set; }

    public decimal? WpsPodstawa { get; set; }

    public int WpsOkresDni { get; set; }

    public DateTime WpsOkresCzas { get; set; }

    public decimal WpsEkwiwalentIlosc { get; set; }

    public decimal WpsProcent { get; set; }

    public decimal WpsWartosc1 { get; set; }

    public decimal WpsWartosc2 { get; set; }

    public decimal WpsSplacono { get; set; }

    public byte WpsSplaconoAll { get; set; }

    public int? WpsZaliczka { get; set; }

    public int? WpsDstId { get; set; }

    public int? WpsHrmId { get; set; }

    public DateTime WpsGodziny { get; set; }

    public decimal WpsWartoscWal { get; set; }

    public byte WpsArchiwalny { get; set; }

    public byte WpsPracaRodzic { get; set; }

    public decimal WpsPracaRodzicPodstawa { get; set; }

    public DateTime WpsOkresCzasUmowa { get; set; }

    public decimal WpsPodstawaSklWych { get; set; }

    public int WpsZrodloIdExt { get; set; }

    public decimal WpsWartoscPodst { get; set; }

    public int? WpsParentPpk { get; set; }

    public int? WpsPzeId { get; set; }

    public int? WpsOpeZalId { get; set; }

    public int? WpsStaZalId { get; set; }

    public DateTime WpsTsZal { get; set; }

    public int? WpsOpeModId { get; set; }

    public int? WpsStaModId { get; set; }

    public DateTime WpsTsMod { get; set; }

    public string WpsOpeModKod { get; set; } = null!;

    public string WpsOpeModNazwisko { get; set; } = null!;

    public string WpsOpeZalKod { get; set; } = null!;

    public string WpsOpeZalNazwisko { get; set; } = null!;

    public string? WpsImportRowId { get; set; }

    public virtual DefinicjeStref? WpsDst { get; set; }

    public virtual PracNieobec? WpsPnb { get; set; }

    public virtual PracKod WpsPra { get; set; } = null!;

    public virtual PracZestaw? WpsPze { get; set; }

    public virtual TypWyplatum WpsTwp { get; set; } = null!;

    public virtual WypElementy WpsWpe { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class OkresoweElem
{
    public int OkEOkEid { get; set; }

    public int OkEOkNid { get; set; }

    public int OkELp { get; set; }

    public string OkEKontoWn { get; set; } = null!;

    public string OkEKontoMa { get; set; } = null!;

    public string OkEDokument { get; set; } = null!;

    public string OkEKwota { get; set; } = null!;

    public int? OkEKatId { get; set; }

    public string OkEKategoria { get; set; } = null!;

    public string OkEWarunek { get; set; } = null!;

    public int? OkERozrachunki { get; set; }

    public decimal? OkEKwotaWartosc { get; set; }

    public byte OkEHarmonogram { get; set; }

    public byte OkEZakresDat { get; set; }

    public DateTime? OkEDataOd { get; set; }

    public DateTime? OkEDataDo { get; set; }

    public string? OkEUwagi { get; set; }

    public virtual Kategorie? OkEKat { get; set; }

    public virtual OkresoweNag OkEOkN { get; set; } = null!;

    public virtual ICollection<OkresoweHarmonogram> OkresoweHarmonograms { get; set; } = new List<OkresoweHarmonogram>();
}

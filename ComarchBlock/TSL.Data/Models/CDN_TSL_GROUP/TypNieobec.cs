using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TypNieobec
{
    public int TnbTnbId { get; set; }

    public int TnbPdzId { get; set; }

    public int? TnbTwpId { get; set; }

    public int? TnbLnbId { get; set; }

    public int TnbTyuId { get; set; }

    public int TnbTnkId { get; set; }

    public string TnbNazwa { get; set; } = null!;

    public string TnbAkronim { get; set; } = null!;

    public int TnbTyp { get; set; }

    public byte TnbRozliczDni { get; set; }

    public int TnbTypRozliczenia { get; set; }

    public byte TnbPomnCzasPracy { get; set; }

    public byte TnbPomnCzasRna { get; set; }

    public byte TnbPomnStazPracy { get; set; }

    public byte TnbPomnLimitUrlopu { get; set; }

    public byte TnbPomniejszWynagr { get; set; }

    public byte TnbPomniejszenie { get; set; }

    public short TnbStandardowy { get; set; }

    public byte TnbWycofany { get; set; }

    public byte TnbNieaktywny { get; set; }

    public byte TnbWliczOkresPracyNaucz { get; set; }

    public string? TnbImportRowId { get; set; }

    public int? TnbOpeZalId { get; set; }

    public int? TnbStaZalId { get; set; }

    public DateTime? TnbTsZal { get; set; }

    public int? TnbOpeModId { get; set; }

    public int? TnbStaModId { get; set; }

    public DateTime? TnbTsMod { get; set; }

    public byte TnbPlanowany { get; set; }

    public int? TnbPoZatwierdzeniu { get; set; }

    public string TnbOpeModKod { get; set; } = null!;

    public string TnbOpeModNazwisko { get; set; } = null!;

    public string TnbOpeZalKod { get; set; } = null!;

    public string TnbOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<PracNieobec> PracNieobecs { get; set; } = new List<PracNieobec>();

    public virtual LimitNieobec? TnbLnb { get; set; }

    public virtual PozDeklZu TnbPdz { get; set; } = null!;

    public virtual TypNieobecKartaPracy TnbTnk { get; set; } = null!;

    public virtual TypWyplatum? TnbTwp { get; set; }

    public virtual TytUbezp TnbTyu { get; set; } = null!;
}

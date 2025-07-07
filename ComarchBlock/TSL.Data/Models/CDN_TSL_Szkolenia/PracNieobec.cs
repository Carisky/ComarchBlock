using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PracNieobec
{
    public int PnbPnbId { get; set; }

    public int PnbPraId { get; set; }

    public int? PnbTnbId { get; set; }

    public int PnbTyuId { get; set; }

    public int? PnbParentId { get; set; }

    public byte? PnbTryb { get; set; }

    public byte PnbNaPodstPoprzNb { get; set; }

    public DateTime PnbOkresOd { get; set; }

    public string PnbSeria { get; set; } = null!;

    public string PnbNumer { get; set; } = null!;

    public DateTime PnbOkresDo { get; set; }

    public string PnbOpis { get; set; } = null!;

    public byte PnbRozliczona { get; set; }

    public byte? PnbRozliczWdniu { get; set; }

    public DateTime? PnbRozliczData { get; set; }

    public string? PnbKodNieobecnosci { get; set; }

    public DateTime? PnbZwolnWystawione { get; set; }

    public DateTime? PnbZwolnDostarczone { get; set; }

    public byte? PnbPomnZasilek { get; set; }

    public byte? PnbPrzedluzenieOz { get; set; }

    public byte? PnbKontynuacjaOz { get; set; }

    public byte PnbZwolFpfgsp { get; set; }

    public byte? PnbPierwszyDzienChor { get; set; }

    public byte PnbUrlopNaZadanie { get; set; }

    public int PnbPrzyczyna { get; set; }

    public int PnbDniPracy { get; set; }

    public int PnbDniKalend { get; set; }

    public int PnbCalodzienna { get; set; }

    public DateTime? PnbGodz { get; set; }

    public int? PnbWymiarL { get; set; }

    public int? PnbWymiarM { get; set; }

    public byte PnbZlecZasilekPit { get; set; }

    public byte PnbPracaRodzic { get; set; }

    public int? PnbRdzId { get; set; }

    public string PnbDziecko { get; set; } = null!;

    public int? PnbZastepca { get; set; }

    public int? PnbOpeZalId { get; set; }

    public int? PnbStaZalId { get; set; }

    public DateTime PnbTsZal { get; set; }

    public int? PnbOpeModId { get; set; }

    public int? PnbStaModId { get; set; }

    public DateTime PnbTsMod { get; set; }

    public string PnbOpeModKod { get; set; } = null!;

    public string PnbOpeModNazwisko { get; set; } = null!;

    public string PnbOpeZalKod { get; set; } = null!;

    public string PnbOpeZalNazwisko { get; set; } = null!;

    public byte PnbZrodlo { get; set; }

    public string? PnbImportRowId { get; set; }

    public virtual PracKod PnbPra { get; set; } = null!;

    public virtual Rodzina? PnbRdz { get; set; }

    public virtual TypNieobec? PnbTnb { get; set; }

    public virtual TytUbezp PnbTyu { get; set; } = null!;

    public virtual PracKod? PnbZastepcaNavigation { get; set; }

    public virtual ICollection<WypSkladniki> WypSkladnikis { get; set; } = new List<WypSkladniki>();
}

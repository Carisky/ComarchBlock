using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Kontum
{
    public int AccAccId { get; set; }

    public int? AccPrevAccId { get; set; }

    public byte AccKorektaKosztow { get; set; }

    public byte AccKontrolaBudzetu { get; set; }

    public int? AccParId { get; set; }

    public string AccNumer { get; set; } = null!;

    public string AccNumerIdx { get; set; } = null!;

    public string AccSegment { get; set; } = null!;

    public string AccNazwa { get; set; } = null!;

    public string? AccNazwa2 { get; set; }

    public string AccWaluta { get; set; } = null!;

    public int AccOobId { get; set; }

    public byte AccTypKonta { get; set; }

    public byte AccRozrachunkowe { get; set; }

    public byte AccBezRozliczenia { get; set; }

    public byte AccKontrolaSalda { get; set; }

    public short AccSlownik { get; set; }

    public byte AccSlownikGrupa { get; set; }

    public int? AccNextAccId { get; set; }

    public short? AccSlownikTyp { get; set; }

    public int? AccSlownikId { get; set; }

    public byte AccNieAktywne { get; set; }

    public short AccPoziom { get; set; }

    public byte AccAnalityka { get; set; }

    public int? AccOpeZalId { get; set; }

    public int? AccStaZalId { get; set; }

    public DateTime AccTsZal { get; set; }

    public int? AccOpeModId { get; set; }

    public int? AccStaModId { get; set; }

    public DateTime AccTsMod { get; set; }

    public string AccOpeModKod { get; set; } = null!;

    public string AccOpeModNazwisko { get; set; } = null!;

    public string AccOpeZalKod { get; set; } = null!;

    public string AccOpeZalNazwisko { get; set; } = null!;

    public virtual OkresyObrach AccOob { get; set; } = null!;

    public virtual Kontum? AccPar { get; set; }

    public virtual ICollection<Boelem> Boelems { get; set; } = new List<Boelem>();

    public virtual ICollection<DekretyKontum> DekretyKonta { get; set; } = new List<DekretyKontum>();

    public virtual ICollection<GrupyKontElem> GrupyKontElems { get; set; } = new List<GrupyKontElem>();

    public virtual ICollection<Kontum> InverseAccPar { get; set; } = new List<Kontum>();

    public virtual ICollection<KontaZakazy> KontaZakazies { get; set; } = new List<KontaZakazy>();

    public virtual ICollection<KragKosztNag> KragKosztNags { get; set; } = new List<KragKosztNag>();

    public virtual ICollection<PrzeszacWalutElem> PrzeszacWalutElemPweAccMas { get; set; } = new List<PrzeszacWalutElem>();

    public virtual ICollection<PrzeszacWalutElem> PrzeszacWalutElemPweAccWns { get; set; } = new List<PrzeszacWalutElem>();

    public virtual ICollection<PrzeszacWalutNag> PrzeszacWalutNagPwnAccMas { get; set; } = new List<PrzeszacWalutNag>();

    public virtual ICollection<PrzeszacWalutNag> PrzeszacWalutNagPwnAccWns { get; set; } = new List<PrzeszacWalutNag>();

    public virtual ICollection<ZestawieniaKontum> ZestawieniaKonta { get; set; } = new List<ZestawieniaKontum>();
}

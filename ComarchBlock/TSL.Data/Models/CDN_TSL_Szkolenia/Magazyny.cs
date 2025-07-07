using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class Magazyny
{
    public int MagMagId { get; set; }

    public int? MagGidnumer { get; set; }

    public byte? MagMagazynZwrotnyXl { get; set; }

    public short MagTyp { get; set; }

    public string MagSymbol { get; set; } = null!;

    public string MagNazwa { get; set; } = null!;

    public string MagOpis { get; set; } = null!;

    public string MagRejestr { get; set; } = null!;

    public byte MagNieAktywny { get; set; }

    public int? MagMagIdXl { get; set; }

    public byte MagUnijny { get; set; }

    public string MagUekraj { get; set; } = null!;

    public string MagKodTransakcji { get; set; } = null!;

    public string? MagKonto { get; set; }

    public int? MagOpeZalId { get; set; }

    public int? MagStaZalId { get; set; }

    public DateTime MagTsZal { get; set; }

    public int? MagOpeModId { get; set; }

    public int? MagStaModId { get; set; }

    public DateTime MagTsMod { get; set; }

    public int MagTwCnumer { get; set; }

    public int MagAdres { get; set; }

    public string MagOpeModKod { get; set; } = null!;

    public string MagOpeModNazwisko { get; set; } = null!;

    public string MagOpeZalKod { get; set; } = null!;

    public string MagOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<DetalZakazyMagazyn> DetalZakazyMagazyns { get; set; } = new List<DetalZakazyMagazyn>();

    public virtual ICollection<MagazynZakazy> MagazynZakazies { get; set; } = new List<MagazynZakazy>();

    public virtual ICollection<ProdElem> ProdElems { get; set; } = new List<ProdElem>();

    public virtual ICollection<ProdSkladniki> ProdSkladnikis { get; set; } = new List<ProdSkladniki>();

    public virtual ICollection<SrsZlecenium> SrsZlecenia { get; set; } = new List<SrsZlecenium>();

    public virtual ICollection<TraNag> TraNagTrNMagDocs { get; set; } = new List<TraNag>();

    public virtual ICollection<TraNag> TraNagTrNMagZrds { get; set; } = new List<TraNag>();

    public virtual ICollection<TwrIlosci> TwrIloscis { get; set; } = new List<TwrIlosci>();

    public virtual ICollection<TwrZasoby> TwrZasobies { get; set; } = new List<TwrZasoby>();
}

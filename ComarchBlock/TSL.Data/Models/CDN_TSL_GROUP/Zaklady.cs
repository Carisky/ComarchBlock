using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Zaklady
{
    public int ZakZakId { get; set; }

    public string ZakSymbol { get; set; } = null!;

    public string? ZakNazwaFirmy { get; set; }

    public string? ZakNipKraj { get; set; }

    public string? ZakNipE { get; set; }

    public string? ZakRegon { get; set; }

    public string? ZakNazwaZakladu { get; set; }

    public string? ZakUlica { get; set; }

    public string? ZakNrDomu { get; set; }

    public string? ZakNrLokalu { get; set; }

    public string? ZakMiejscowosc { get; set; }

    public string? ZakPoczta { get; set; }

    public string? ZakKodPocztowy { get; set; }

    public byte ZakNieaktywny { get; set; }

    public byte ZakDomyslny { get; set; }

    public byte ZakPierwszy { get; set; }

    public DateTime? ZakTsExport { get; set; }

    public string? ZakImportAppId { get; set; }

    public string? ZakImportRowId { get; set; }

    public int? ZakOpeZalId { get; set; }

    public int? ZakStaZalId { get; set; }

    public DateTime ZakTsZal { get; set; }

    public int? ZakOpeModId { get; set; }

    public int? ZakStaModId { get; set; }

    public DateTime ZakTsMod { get; set; }

    public string ZakOpeModKod { get; set; } = null!;

    public string ZakOpeModNazwisko { get; set; } = null!;

    public string ZakOpeZalKod { get; set; } = null!;

    public string ZakOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<ListyPlac> ListyPlacs { get; set; } = new List<ListyPlac>();

    public virtual ICollection<PracEtaty> PracEtaties { get; set; } = new List<PracEtaty>();
}

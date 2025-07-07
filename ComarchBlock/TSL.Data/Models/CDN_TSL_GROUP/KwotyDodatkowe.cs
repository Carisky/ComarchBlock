using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class KwotyDodatkowe
{
    public int KddKddId { get; set; }

    public int KddPrzekrojTyp { get; set; }

    public int KddDokumentTyp { get; set; }

    public int KddDokumentId { get; set; }

    public int? KddKatId { get; set; }

    public string? KddOpis { get; set; }

    public int? KddKat2Id { get; set; }

    public string? KddOpis2 { get; set; }

    public decimal KddKwota { get; set; }

    public decimal KddKwotaWal { get; set; }

    public string KddSegment1 { get; set; } = null!;

    public string KddSegment2 { get; set; } = null!;

    public string? KddSegment3 { get; set; }

    public string? KddSegment4 { get; set; }

    public byte KddWartosc1 { get; set; }

    public byte KddWartosc2 { get; set; }

    public string KddWaluta { get; set; } = null!;

    public int KddKursNumer { get; set; }

    public decimal KddKursL { get; set; }

    public decimal KddKursM { get; set; }

    public DateTime KddDataKur { get; set; }

    public int? KddRozrachunki { get; set; }

    public int KddLp { get; set; }

    public virtual Kategorie? KddKat { get; set; }

    public virtual Kategorie? KddKat2 { get; set; }
}

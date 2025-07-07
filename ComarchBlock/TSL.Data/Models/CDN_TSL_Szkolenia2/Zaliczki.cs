using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Zaliczki
{
    public int ZalZalId { get; set; }

    public short ZalDokumentTyp { get; set; }

    public int ZalDokumentId { get; set; }

    public int ZalBzpId { get; set; }

    public byte ZalZaznaczenie { get; set; }

    public decimal ZalKwota { get; set; }

    public int? ZalOpeZalId { get; set; }

    public int? ZalStaZalId { get; set; }

    public DateTime ZalTsZal { get; set; }

    public int? ZalOpeModId { get; set; }

    public int? ZalStaModId { get; set; }

    public DateTime ZalTsMod { get; set; }

    public string ZalOpeModKod { get; set; } = null!;

    public string ZalOpeModNazwisko { get; set; } = null!;

    public string ZalOpeZalKod { get; set; } = null!;

    public string ZalOpeZalNazwisko { get; set; } = null!;

    public virtual BnkZapisy ZalBzp { get; set; } = null!;
}

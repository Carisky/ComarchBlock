using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class BnkRozKwotyMw
{
    public int BrkmwBrkmwid { get; set; }

    public int? BrkmwBraId { get; set; }

    public decimal BrkmwKwota { get; set; }

    public decimal BrkmwKwotaSysL { get; set; }

    public decimal BrkmwKwotaSysP { get; set; }

    public decimal BrkmwRoznicaKursowaSys { get; set; }

    public int BrkmwDdfId { get; set; }

    public string BrkmwNumerString { get; set; } = null!;

    public int BrkmwNumerNr { get; set; }

    public string? BrkmwNumerPelny { get; set; }

    public DateTime BrkmwDataDok { get; set; }

    public short? BrkmwLdokTyp { get; set; }

    public int? BrkmwLdokId { get; set; }

    public short? BrkmwPdokTyp { get; set; }

    public int? BrkmwPdokId { get; set; }

    public string? BrkmwWaluta { get; set; }

    public int? BrkmwLpodTyp { get; set; }

    public int? BrkmwLpodId { get; set; }

    public int? BrkmwPpodTyp { get; set; }

    public int? BrkmwPpodId { get; set; }

    public string? BrkmwLnumer { get; set; }

    public string? BrkmwPnumer { get; set; }

    public int? BrkmwDekId { get; set; }

    public int? BrkmwDek2Id { get; set; }

    public int? BrkmwPreDekId { get; set; }

    public int? BrkmwKprid { get; set; }

    public byte BrkmwKolumnaKpr { get; set; }

    public int? BrkmwRycId { get; set; }

    public byte BrkmwKolumnaRyc { get; set; }

    public string BrkmwKontoWn1 { get; set; } = null!;

    public string BrkmwKontoMa1 { get; set; } = null!;

    public int? BrkmwOpeZalId { get; set; }

    public int? BrkmwStaZalId { get; set; }

    public DateTime BrkmwTsZal { get; set; }

    public int? BrkmwOpeModId { get; set; }

    public int? BrkmwStaModId { get; set; }

    public DateTime BrkmwTsMod { get; set; }

    public string BrkmwOpeModKod { get; set; } = null!;

    public string BrkmwOpeModNazwisko { get; set; } = null!;

    public string BrkmwOpeZalKod { get; set; } = null!;

    public string BrkmwOpeZalNazwisko { get; set; } = null!;

    public int? BrkmwZakId { get; set; }

    public byte? BrkmwLwynagrodzenie { get; set; }

    public byte? BrkmwPwynagrodzenie { get; set; }

    public virtual DokDefinicje BrkmwDdf { get; set; } = null!;
}

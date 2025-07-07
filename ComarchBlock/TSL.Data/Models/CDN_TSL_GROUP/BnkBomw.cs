using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class BnkBomw
{
    public int BomwBomwid { get; set; }

    public short BomwKierunek { get; set; }

    public int? BomwBraId { get; set; }

    public int BomwNumerNr { get; set; }

    public string BomwNumerObcy { get; set; } = null!;

    public int? BomwKatId { get; set; }

    public DateTime BomwDataDok { get; set; }

    public decimal BomwKwotaSys { get; set; }

    public decimal BomwKwotaRozSysMw { get; set; }

    public decimal BomwKwota { get; set; }

    public decimal BomwKwotaRozMw { get; set; }

    public string BomwWaluta { get; set; } = null!;

    public int BomwKursNumer { get; set; }

    public decimal BomwKursL { get; set; }

    public decimal BomwKursM { get; set; }

    public byte BomwWgKursuMw { get; set; }

    public short BomwRozliczonoMw { get; set; }

    public short BomwRozliczono2Mw { get; set; }

    public DateTime? BomwDataRozMw { get; set; }

    public DateTime BomwDataKur { get; set; }

    public string BomwOpis { get; set; } = null!;

    public int? BomwOpeZalId { get; set; }

    public int? BomwStaZalId { get; set; }

    public DateTime BomwTsZal { get; set; }

    public int? BomwOpeModId { get; set; }

    public int? BomwStaModId { get; set; }

    public DateTime BomwTsMod { get; set; }

    public string BomwOpeModKod { get; set; } = null!;

    public string BomwOpeModNazwisko { get; set; } = null!;

    public string BomwOpeZalKod { get; set; } = null!;

    public string BomwOpeZalNazwisko { get; set; } = null!;

    public string? BomwNumerPelny { get; set; }

    public string? BomwNumer { get; set; }

    public virtual BnkRachunki? BomwBra { get; set; }
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class RodzajeBonow
{
    public int RboId { get; set; }

    public string? RboKod { get; set; }

    public string? RboNazwa { get; set; }

    public decimal? RboKwota { get; set; }

    public int? RboTerminDni { get; set; }

    public byte? RboTerminOdWydania { get; set; }

    public byte? RboTypRozliczenia { get; set; }

    public string? RboMaska { get; set; }

    public short? RboTwrTyp { get; set; }

    public int? RboTwrNumer { get; set; }

    public string? RboOpis { get; set; }

    public byte? RboKopiujOpis { get; set; }

    public byte? RboArchiwalny { get; set; }

    public byte? RboKwotaAktualizuj { get; set; }

    public short? RboMdnTyp { get; set; }

    public int? RboMdnNumer { get; set; }
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class RejestracjaZgodZrodlo
{
    public int RzzRzzid { get; set; }

    public string RzzNazwa { get; set; } = null!;

    public byte RzzNieaktywny { get; set; }

    public int? RzzOpeZalId { get; set; }

    public int? RzzStaZalId { get; set; }

    public DateTime RzzTsZal { get; set; }

    public int? RzzOpeModId { get; set; }

    public int? RzzStaModId { get; set; }

    public DateTime RzzTsMod { get; set; }

    public string RzzOpeModKod { get; set; } = null!;

    public string RzzOpeModNazwisko { get; set; } = null!;

    public string RzzOpeZalKod { get; set; } = null!;

    public string RzzOpeZalNazwisko { get; set; } = null!;
}

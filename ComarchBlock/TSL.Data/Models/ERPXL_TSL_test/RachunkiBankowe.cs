using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class RachunkiBankowe
{
    public int RkBId { get; set; }

    public short? RkBObiTyp { get; set; }

    public int? RkBObiFirma { get; set; }

    public int? RkBObiNumer { get; set; }

    public short? RkBObiLp { get; set; }

    public string? RkBNrRachunku { get; set; }

    public string? RkBNrRachunkuE { get; set; }

    public byte? RkBIban { get; set; }

    public short? RkBBnkTyp { get; set; }

    public int? RkBBnkFirma { get; set; }

    public int? RkBBnkNumer { get; set; }

    public short? RkBBnkLp { get; set; }

    public string? RkBWaluta { get; set; }

    public int? RkBOpeUtworzyl { get; set; }

    public int? RkBCzasUtworzenia { get; set; }

    public int? RkBKntAdres { get; set; }

    public int? RkBTypRachunku { get; set; }

    public string? RkBUwagi { get; set; }

    public int? RkBCzasArchiwizacji { get; set; }

    public byte? RkBDomyslny { get; set; }

    public int? RkBCzasModyfikacji { get; set; }

    public int? RkBOpeModyfikowal { get; set; }

    public byte? RkBZgloszonyDoUs { get; set; }

    public virtual ICollection<RachunkiBankoweVat> RachunkiBankoweVats { get; set; } = new List<RachunkiBankoweVat>();
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class CrmraportyDef
{
    public int CrdId { get; set; }

    public byte? CrdTyp { get; set; }

    public string? CrdKod { get; set; }

    public string? CrdNazwa { get; set; }

    public byte? CrdIlosc { get; set; }

    public byte? CrdCena { get; set; }

    public byte? CrdEkspozycja { get; set; }

    public byte? CrdFacing { get; set; }

    public byte? CrdDostawca { get; set; }

    public int? CrdCzasUtworzenia { get; set; }

    public int? CrdCzasModyfikacji { get; set; }

    public int? CrdCzasModyfikacjiC { get; set; }

    public int? CrdCzasArchiwizacji { get; set; }

    public byte? CrdOddzialowy { get; set; }

    public int? CrdOpeNumerU { get; set; }

    public int? CrdOpeNumerM { get; set; }

    public int? CrdOpeNumerA { get; set; }

    public byte? CrdTwrElem { get; set; }

    public virtual ICollection<CrmraportyKolumny> CrmraportyKolumnies { get; set; } = new List<CrmraportyKolumny>();

    public virtual ICollection<TwrKarty> CrtTwrNumers { get; set; } = new List<TwrKarty>();
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class AtstNag
{
    public int AtnTestId { get; set; }

    public int AtnDokumentId { get; set; }

    public int? AtnDokumentLp { get; set; }

    public short? AtnDokumentTyp { get; set; }

    public string? AtnAkronim { get; set; }

    public string? AtnMagazyn { get; set; }

    public string? AtnRejestrVat { get; set; }

    public short? AtnAkcja { get; set; }

    public short? AtnTypGenerowanegoDok { get; set; }

    public int? AtnZanNumer { get; set; }

    public short? AtnDokKsiTyp { get; set; }

    public int? AtnDokKsiNumer { get; set; }

    public short? AtnSchematKsiTyp { get; set; }

    public int? AtnSchematKsiNumer { get; set; }

    public string? AtnDziennikKsi { get; set; }

    public string? AtnDokSeria { get; set; }

    public byte? AtnDokBufor { get; set; }

    public virtual AtstTesty AtnTest { get; set; } = null!;

    public virtual ICollection<AtstElem> AtstElems { get; set; } = new List<AtstElem>();
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class AtrybutyObiekty
{
    public int AtOGidtyp { get; set; }

    public short AtOElement { get; set; }

    public int AtOAtKid { get; set; }

    public short? AtOLp { get; set; }

    public short? AtOWymagany { get; set; }

    public short? AtOAutomat { get; set; }

    public short? AtOReadOnly { get; set; }

    public int? AtOAtzid { get; set; }

    public int? AtOAkcja { get; set; }

    public short? AtOOnline { get; set; }

    public int? AtOCzasModyfikacji { get; set; }

    public byte? AtOMiara { get; set; }

    public int? AtOAgregacja { get; set; }

    public int? AtORozbijanie { get; set; }

    public int? AtOFormat { get; set; }

    public byte? AtOKorekty { get; set; }

    public byte? AtOPusteWartosci { get; set; }

    public int AtOId { get; set; }

    public virtual ICollection<AtrybutyObiektyFakty> AtrybutyObiektyFakties { get; set; } = new List<AtrybutyObiektyFakty>();
}

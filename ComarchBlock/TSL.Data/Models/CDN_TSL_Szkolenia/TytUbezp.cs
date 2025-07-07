using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TytUbezp
{
    public int TyuTyuId { get; set; }

    public int TyuTyUb4 { get; set; }

    public int TyuPoziom { get; set; }

    public int TyuWybieralny { get; set; }

    public byte? TyuPracownik { get; set; }

    public byte? TyuWlasciciel { get; set; }

    public byte? TyuWspolpracownik { get; set; }

    public byte? TyuZleceniobiorca { get; set; }

    public byte? TyuUczen { get; set; }

    public string? TyuOpis { get; set; }

    public string? TyuCheckBox { get; set; }

    public byte TyuUmowa { get; set; }

    public string TyuZjeId { get; set; } = null!;

    public string? TyuImportRowId { get; set; }

    public virtual ICollection<PracEtaty> PracEtaties { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracNieobec> PracNieobecs { get; set; } = new List<PracNieobec>();

    public virtual ICollection<TypNieobec> TypNieobecs { get; set; } = new List<TypNieobec>();

    public virtual ICollection<Umowy> Umowies { get; set; } = new List<Umowy>();
}

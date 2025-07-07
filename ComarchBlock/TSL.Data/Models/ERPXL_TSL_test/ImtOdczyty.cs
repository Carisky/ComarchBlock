using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ImtOdczyty
{
    public int ItoId { get; set; }

    public int? ItoItaid { get; set; }

    public short? ItoLp { get; set; }

    public int? ItoCzasOdczytu { get; set; }

    public string? ItoNazwa { get; set; }

    public string? ItoOpis { get; set; }

    public int? ItoOpeWnumer { get; set; }

    public byte? ItoZamkniety { get; set; }

    public virtual ICollection<ImtOdczytyElem> ImtOdczytyElems { get; set; } = new List<ImtOdczytyElem>();

    public virtual ImtArkusze? ItoIta { get; set; }
}

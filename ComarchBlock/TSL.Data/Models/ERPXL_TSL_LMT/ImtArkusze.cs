using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ImtArkusze
{
    public int ItaId { get; set; }

    public int? ItaItnid { get; set; }

    public short? ItaLp { get; set; }

    public string? ItaNazwa { get; set; }

    public int? ItaOpeWnumer { get; set; }

    public int? ItaDataUtworzenia { get; set; }

    public byte? ItaRodzajOdczytow { get; set; }

    public string? ItaOpis { get; set; }

    public byte? ItaTorLp { get; set; }

    public virtual ICollection<ImtArkuszeElem> ImtArkuszeElems { get; set; } = new List<ImtArkuszeElem>();

    public virtual ICollection<ImtOdczyty> ImtOdczyties { get; set; } = new List<ImtOdczyty>();

    public virtual ImtNag? ItaItn { get; set; }
}

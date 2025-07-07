using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdKoszty
{
    public int PkoId { get; set; }

    public short? PkoZrdTyp { get; set; }

    public int? PkoZrdNumer { get; set; }

    public short? PkoZrdLp { get; set; }

    public decimal? PkoKwota { get; set; }

    public int? PkoKategoria { get; set; }

    public byte? PkoKlucz { get; set; }

    public string? PkoWyrazenie { get; set; }

    public byte? PkoPodrzedny { get; set; }

    public int? PkoDataPrzypisania { get; set; }

    public string? PkoOpis { get; set; }

    public string? PkoSqlzrodlo { get; set; }

    public string? PkoSqlklucz { get; set; }

    public string? PkoSqlwarunek { get; set; }

    public int? PkoPwkid { get; set; }

    public virtual ICollection<ProdKosztyElemO> ProdKosztyElemOs { get; set; } = new List<ProdKosztyElemO>();

    public virtual ICollection<ProdKosztyElem> ProdKosztyElems { get; set; } = new List<ProdKosztyElem>();

    public virtual ICollection<ProdKosztyParametry> ProdKosztyParametries { get; set; } = new List<ProdKosztyParametry>();
}

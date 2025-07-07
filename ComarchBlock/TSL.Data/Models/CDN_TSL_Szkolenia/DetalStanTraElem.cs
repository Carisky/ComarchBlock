using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DetalStanTraElem
{
    public int DstrEDstrEid { get; set; }

    public int DstrEDstrNid { get; set; }

    public int DstrEStornoId { get; set; }

    public int DstrELp { get; set; }

    public int? DstrEZwrId { get; set; }

    public int DstrETwrId { get; set; }

    public string DstrETwrNazwa { get; set; } = null!;

    public string DstrETwrEan { get; set; } = null!;

    public string DstrETwrKod { get; set; } = null!;

    public decimal DstrEStawka { get; set; }

    public short DstrEFlaga { get; set; }

    public decimal DstrECena { get; set; }

    public decimal DstrERabat { get; set; }

    public decimal DstrECenaPoRabacie { get; set; }

    public byte DstrEKaucja { get; set; }

    public decimal DstrEIlosc { get; set; }

    public string DstrEJm { get; set; } = null!;

    public byte DstrEJmCalkowite { get; set; }

    public decimal DstrEJmprzelicznikL { get; set; }

    public decimal DstrEJmprzelicznikM { get; set; }

    public string DstrEWaluta { get; set; } = null!;

    public decimal DstrEWartoscBrutto { get; set; }

    public virtual DetalStanTraNag DstrEDstrN { get; set; } = null!;

    public virtual DetalStanTowary DstrETwr { get; set; } = null!;
}

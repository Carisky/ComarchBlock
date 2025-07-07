using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DetalTraElem
{
    public int DtrEDtrEid { get; set; }

    public int DtrEDstrEid { get; set; }

    public int DtrEDstrNid { get; set; }

    public int DtrEStanDetalId { get; set; }

    public int? DtrEZwrId { get; set; }

    public int DtrETwrId { get; set; }

    public decimal DtrEStawka { get; set; }

    public short DtrEFlaga { get; set; }

    public decimal DtrECena { get; set; }

    public decimal DtrERabat { get; set; }

    public decimal DtrECenaPoRabacie { get; set; }

    public string DtrEWaluta { get; set; } = null!;

    public byte DtrEKaucja { get; set; }

    public decimal DtrEIlosc { get; set; }

    public decimal DtrEIloscJm { get; set; }

    public string DtrEJm { get; set; } = null!;

    public byte DtrEJmCalkowite { get; set; }

    public decimal DtrEJmprzelicznikL { get; set; }

    public decimal DtrEJmprzelicznikM { get; set; }

    public decimal DtrEWartoscBrutto { get; set; }

    public string? DtrEOpis { get; set; }

    public string DtrEJmz { get; set; } = null!;

    public byte DtrEUslugaZlozona { get; set; }

    public int DtrEUslugaZlozonaRecepturaId { get; set; }

    public byte DtreOdwrotneObciazenie { get; set; }

    public int DtreTwCnumer { get; set; }

    public virtual DetalTraNag DetalTraNag { get; set; } = null!;
}

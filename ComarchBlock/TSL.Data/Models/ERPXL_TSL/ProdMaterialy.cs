using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdMaterialy
{
    public int? PmaTyp { get; set; }

    public int PmaNumer { get; set; }

    public int PmaLp { get; set; }

    public int PmaSubLp { get; set; }

    public int? PmaZrdTyp { get; set; }

    public int? PmaZrdNumer { get; set; }

    public string? PmaKod { get; set; }

    public string? PmaNazwa { get; set; }

    public decimal? PmaIlosc { get; set; }

    public decimal? PmaZrealizowano { get; set; }

    public int? PmaMagazyn { get; set; }

    public int? PmaTwrNumer { get; set; }

    public string? PmaTwrJm { get; set; }

    public int? PmaZamiennik { get; set; }

    public int? PmaPlanowany { get; set; }

    public int? PmaZasob { get; set; }

    public short? PmaTwrTyp { get; set; }

    public string? PmaIloscPom { get; set; }

    public string? PmaJmPom { get; set; }

    public int? PmaPodlegaKj { get; set; }
}

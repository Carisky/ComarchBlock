using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class DefPodNag
{
    public int DpnId { get; set; }

    public string? DpnSymbol { get; set; }

    public short? DpnWersja { get; set; }

    public byte? DpnWersjaSilnika { get; set; }

    public short? DpnTypPodatku { get; set; }

    public byte? DpnZalacznik { get; set; }

    public string? DpnNadrzedna { get; set; }

    public int? DpnDataOd { get; set; }

    public int? DpnDataDo { get; set; }

    public short? DpnIloscStron { get; set; }

    public byte? DpnPlatnosci { get; set; }

    public string? DpnPlatnosciWyrazenie { get; set; }

    public byte? DpnKsiegowanie { get; set; }

    public string? DpnKsiegowanieWyrazenie { get; set; }

    public byte? DpnNrPozIloscPodpoziomow { get; set; }

    public byte? DpnZalacznikOkresDef { get; set; }

    public byte? DpnPoczatekOkresu { get; set; }

    public byte? DpnKoniecOkresu { get; set; }

    public byte? DpnPoczatekPodOkresu { get; set; }

    public byte? DpnKoniecPodOkresu { get; set; }

    public byte? DpnTypDeklaracji { get; set; }

    public string? DpnSumaKontrolna { get; set; }

    public int? DpnWersjaNadrzednej { get; set; }

    public string? DpnWersjaWewn { get; set; }

    public string? DpnXlwersjaOd { get; set; }

    public string? DpnXlwersjaDo { get; set; }

    public byte? DpnTypUrzedu { get; set; }

    public byte? DpnLp { get; set; }

    public string? DpnXmltagNazwa { get; set; }

    public string? DpnXmltagAtrybuty { get; set; }

    public virtual ICollection<DefPodElem> DefPodElems { get; set; } = new List<DefPodElem>();
}

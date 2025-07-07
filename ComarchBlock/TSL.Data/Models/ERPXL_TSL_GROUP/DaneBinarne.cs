using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class DaneBinarne
{
    public int DabId { get; set; }

    public int? DabTlumaczenie { get; set; }

    public int? DabJezyk { get; set; }

    public string? DabNazwa { get; set; }

    public int? DabTypId { get; set; }

    public string? DabRozszerzenie { get; set; }

    public int? DabRozmiar { get; set; }

    public byte[]? DabDane { get; set; }

    public string? DabKod { get; set; }

    public int? DabCzasModyfikacji { get; set; }

    public int? DabOpeNumer { get; set; }

    public int? DabCzasDodania { get; set; }

    public int? DabOpeNumerD { get; set; }

    public byte? DabUsuwac { get; set; }

    public byte? DabArchiwalny { get; set; }

    public int? DabAktywny { get; set; }

    public int DabCzasArchiwizacji { get; set; }

    public string? DabOpisArchiwizacji { get; set; }

    public byte? DabPpprawa { get; set; }

    public byte? DabPkprawa { get; set; }

    public byte? DabESklep { get; set; }

    public byte? DabIMall { get; set; }

    public byte? DabMobSpr { get; set; }

    public byte? DabBi { get; set; }

    public int? DabDbgid { get; set; }

    public byte? DabSystemowa { get; set; }

    public int? DabProcId { get; set; }

    public int? DabZewnetrznySys { get; set; }

    public int? DabZewnetrznyId { get; set; }

    public decimal? DabGpssz { get; set; }

    public decimal? DabGpsdl { get; set; }

    public int? DabGpsdataPobrania { get; set; }

    public int? DabGpsgodzinaPobrania { get; set; }

    public byte? DabESklepTypDanych { get; set; }

    public int? DabZewnetrznyTyp { get; set; }

    public byte? DabRetail { get; set; }

    public string? DabOpis { get; set; }

    public string? DabUrl { get; set; }

    public byte? DabWmszarzadzanie { get; set; }

    public byte? DabWmsmagazynier { get; set; }

    public byte? DabWszystkoPl { get; set; }

    public string? DabWszystkoPlLink { get; set; }

    public virtual DaneBinarneGrupy? DabDbg { get; set; }
}

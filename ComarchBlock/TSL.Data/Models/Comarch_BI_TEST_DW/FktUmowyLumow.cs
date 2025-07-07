using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktUmowyLumow
{
    public int UmyId { get; set; }

    public int UmyCzdid { get; set; }

    public int UmyZrodgid { get; set; }

    public string UmyOrgId { get; set; } = null!;

    public string UmyDirtyOrgId { get; set; } = null!;

    public string? UmyOpis { get; set; }

    public DateTime UmyTsinsert { get; set; }

    public DateTime UmyTsupdate { get; set; }

    public int UmyUpdateSubTransformationId { get; set; }

    public int? UmyUpdateTransformationId { get; set; }

    public int UmyInsertSubTransformationId { get; set; }

    public int? UmyInsertTransformationId { get; set; }

    public int UmySvatid { get; set; }

    public int UmyUmeid { get; set; }

    public int UmyUmnid { get; set; }

    public int UmyDataRozId { get; set; }

    public int UmyOpiekunId { get; set; }

    public int UmyWalutaId { get; set; }

    public int UmyDataZawId { get; set; }

    public int UmyDataPotId { get; set; }

    public int UmyDataZakId { get; set; }

    public int UmyOpepid { get; set; }

    public int UmyKntId { get; set; }

    public int UmyBudzetId { get; set; }

    public int UmyAlokacjaId { get; set; }

    public int UmyOpewid { get; set; }

    public int UmyStrFrmId { get; set; }

    public int UmyKndId { get; set; }

    public int UmyAdrKndId { get; set; }

    public int UmyProjektId { get; set; }

    public decimal? UmyMwartoscBruto { get; set; }

    public decimal? UmyMwartoscNetto { get; set; }

    public decimal? UmyMwartoscBrutoFin { get; set; }

    public decimal? UmyMwartoscNettoFin { get; set; }

    public decimal? UmyMwartoscBrutoRuch { get; set; }

    public decimal? UmyMwartoscNettoRuch { get; set; }

    public decimal? UmyMczasUmowyPlan { get; set; }

    public decimal? UmyMczasDoKonPlan { get; set; }

    public decimal? UmyMczasObowiPlan { get; set; }

    public decimal? UmyMczasUmowyRzec { get; set; }

    public decimal? UmyMczasDoKonRzec { get; set; }

    public decimal? UmyMczasObowiRzec { get; set; }

    public decimal? UmyMwartoscBrutoWal { get; set; }

    public decimal? UmyMwartoscNettoWal { get; set; }

    public decimal? UmyMwartoscBrutoRuchWal { get; set; }

    public decimal? UmyMwartoscNettoRuchWal { get; set; }

    public int UmyObzid { get; set; }

    public int UmyWygId { get; set; }

    public int UmyUmnpid { get; set; }

    public string UmyOrgAtrId { get; set; } = null!;

    public string? UmyOrgAtrNagId { get; set; }

    public int? UmyStrPrwId { get; set; }

    public int UmyCechaGid { get; set; }

    public int UmyFormPlatGid { get; set; }

    public int UmyProdGid { get; set; }

    public int UmyJmId { get; set; }

    public int UmyJmPid { get; set; }

    public string? UmyFlagaNb { get; set; }

    public decimal? UmyMilosc { get; set; }

    public decimal? UmyMiloscJmP { get; set; }

    public decimal? UmyMwartoscBruttoElem { get; set; }

    public decimal? UmyMwartoscNettoElem { get; set; }

    public decimal? UmyMwartoscPlnelem { get; set; }

    public string? UmyOrgAtrEleId { get; set; }
}

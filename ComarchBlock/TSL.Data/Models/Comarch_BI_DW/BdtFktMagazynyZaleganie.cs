using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktMagazynyZaleganie
{
    public int MgzId { get; set; }

    public decimal? IloczynZalegania { get; set; }

    public int MgzAbcgid { get; set; }

    public int MgzAlokacjaId { get; set; }

    public int? MgzRejonId { get; set; }

    public int? MgzWymTyp { get; set; }

    public string? MgzWymObjGidLp { get; set; }

    public int? MgzTypKwoty { get; set; }

    public string? MgzOrgWymId { get; set; }

    public string? MgzOrgAtrId { get; set; }

    public int? MgzKierunek { get; set; }

    public int? MgzDataZaleganieId { get; set; }

    public int? MgzDataWaznoscId { get; set; }

    public decimal? MgzMwartoscStan { get; set; }

    public decimal? MgzMwartoscKsStan { get; set; }

    public decimal? MgzMwaga { get; set; }

    public decimal? MgzMobjetosc { get; set; }

    public decimal? MgzMiloscStanJm { get; set; }

    public decimal? MgzMiloscStan { get; set; }

    public decimal? MgzMiloscKsStanJm { get; set; }

    public decimal? MgzMiloscKsStan { get; set; }

    public decimal? MgzMiloscWdrodze { get; set; }

    public decimal? MgzMdniZalegania { get; set; }

    public decimal? MgzMdniWaznosci { get; set; }

    public int MgzZrodgid { get; set; }

    public int MgzZaleganieId { get; set; }

    public int MgzWaznoscId { get; set; }

    public int MgzStrFrmId { get; set; }

    public int MgzSposobDostawyId { get; set; }

    public int MgzSpiNumerId { get; set; }

    public int MgzProjektId { get; set; }

    public int MgzProdId { get; set; }

    public int MgzPerspektywaId { get; set; }

    public int MgzMagId { get; set; }

    public int MgzLokId { get; set; }

    public int MgzKatFinId { get; set; }

    public int MgzJmpId { get; set; }

    public int MgzFirmaId { get; set; }

    public int MgzDstId { get; set; }

    public int MgzDokNumerId { get; set; }

    public int MgzCztid { get; set; }

    public int MgzCzrid { get; set; }

    public int MgzCzmid { get; set; }

    public int MgzCzdid { get; set; }

    public int MgzCechyId { get; set; }

    public int MgzBudzetId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? MgzUpdateTransformationId { get; set; }

    public int? MgzUpdateSubTransformationId { get; set; }

    public DateTime MgzTsupdate { get; set; }

    public DateTime MgzTsinsert { get; set; }

    public string MgzOrgId { get; set; } = null!;

    public string? MgzOpis { get; set; }

    public int? MgzInsertSubTransformationId { get; set; }

    public string? MgzDirtyOrgId { get; set; }

    public int MgzPrmgid { get; set; }

    public int? MgzStrPrwId { get; set; }

    public int MgzDostId { get; set; }
}

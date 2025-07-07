using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class SFktOpisyAnalityczne
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WymDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long WymId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WymInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WymObjOrgId { get; set; } = null!;

    public string? WymOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WymTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WymTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WymUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int WymUpdateTransformationId { get; set; }

    public int WymCzdgid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int WymZrodgid { get; set; }

    public int? WymCentrum { get; set; }

    public int? WymKategorieFinansowe { get; set; }

    public int? WymKierunek { get; set; }

    public int? WymKontrahentDocelowy { get; set; }

    public int? WymLokalizacja { get; set; }

    public int? WymObjGidDokLp { get; set; }

    public int? WymObjGidLp { get; set; }

    public int? WymObjGidNumer { get; set; }

    public int? WymObjGidTyp { get; set; }

    public string? WymOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WymOrgId { get; set; }

    public string? WymOrgWymId { get; set; }

    public decimal? WymProcent { get; set; }

    public int? WymProjekt { get; set; }

    public int? WymTypKwoty { get; set; }

    public decimal? WymWartosc { get; set; }

    public int? WymWymFirma { get; set; }

    public int? WymWymTyp { get; set; }

    public virtual WymCzasDzien WymCzdg { get; set; } = null!;

    public virtual WymZrodloDanych WymZrodg { get; set; } = null!;
}

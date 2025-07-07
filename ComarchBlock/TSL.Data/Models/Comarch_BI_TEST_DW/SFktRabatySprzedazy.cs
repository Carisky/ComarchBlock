using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class SFktRabatySprzedazy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RsprDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long RsprId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RsprInsertSubTransformationId { get; set; }

    public string? RsprOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RsprOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RsprTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RsprTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RsprUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int RsprUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu zamówienia. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int RsprCzdgid { get; set; }

    /// <summary>
    /// Identyfikator promocji. Relacja do wymiaru WYM_Promocje
    /// </summary>
    public int RsprPrmGid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int RsprZrodgid { get; set; }

    /// <summary>
    /// Wartosc rabatu
    /// </summary>
    public decimal? RsprMrabat { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? RsprKierunek { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? RsprOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? RsprOrgWymId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? RsprTypKwoty { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? RsprWymTyp { get; set; }

    /// <summary>
    /// Identyfikator dokumentu zamówienia. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int RsprDokNumerGid { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? RsprPaczka { get; set; }

    /// <summary>
    /// 1 - Sprzedaz, 2 - Zakupy, 3 i 4 - Zamowienia
    /// </summary>
    public int? RsprObszar { get; set; }

    /// <summary>
    /// ID Subpozycji na dokumencie
    /// </summary>
    public string? RsprSubGidLp { get; set; }

    /// <summary>
    /// Wartosc rabatu % dla poszczegolnego typu rabatu na pozycji
    /// </summary>
    public decimal? RsprMrabatProcent { get; set; }

    /// <summary>
    /// Wartosc rabatu % dla calej pozycji
    /// </summary>
    public decimal? RsprMrabatProcentPozycja { get; set; }

    /// <summary>
    /// ID pozycji na dokumencie
    /// </summary>
    public int? RsprPozycja { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int RsprOperatorId { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int RsprOpewgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int RsprOpezgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int RsprOpemgid { get; set; }

    public string? RsprDataMod { get; set; }

    public int? RsprGidLp { get; set; }

    public int? RsprGidNumer { get; set; }

    public int? RsprGidPrm { get; set; }

    public int? RsprGidSubLp { get; set; }

    public int? RsprGidTyp { get; set; }

    public virtual WymCzasDzien RsprCzdg { get; set; } = null!;

    public virtual WymDokumentNumer RsprDokNumerG { get; set; } = null!;

    public virtual WymOperator RsprOpemg { get; set; } = null!;

    public virtual WymOperator RsprOperator { get; set; } = null!;

    public virtual WymOperator RsprOpewg { get; set; } = null!;

    public virtual WymOperator RsprOpezg { get; set; } = null!;

    public virtual WymPromocje RsprPrmG { get; set; } = null!;

    public virtual WymZrodloDanych RsprZrodg { get; set; } = null!;
}

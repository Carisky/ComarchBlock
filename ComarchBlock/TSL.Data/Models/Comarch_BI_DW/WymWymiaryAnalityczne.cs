using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymWymiaryAnalityczne
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WymDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WymDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WymDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int WymId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WymKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WymKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WymOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WymOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WymParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WymParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int WymRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] WymRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WymSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WymTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WymTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int WymZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WymAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WymAktualneOrgParId { get; set; }

    /// <summary>
    /// Informacja, czy wymiar jest aktywny
    /// </summary>
    public int? WymAktywny { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public string? WymCastomRollup { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? WymKategoria { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? WymKonto { get; set; }

    /// <summary>
    /// Dla wymiaru jego nazwa, dla elementu wymiaru jego wartość
    /// </summary>
    public string? WymNazwa { get; set; }

    public string? WymNazwaPoziomu { get; set; }

    /// <summary>
    /// Opis
    /// </summary>
    public string? WymOpis { get; set; }

    /// <summary>
    /// Identyfikator klasy wymiaru
    /// </summary>
    public int? WymOrgAtkId { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public string? WymOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? WymPoprzednikId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? WymRoot { get; set; }

    /// <summary>
    /// Typ
    /// </summary>
    public int? WymTyp { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? WymTypWymiaru { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? WymWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? WymWymTyp { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WymTmpParId { get; set; }

    public int? WymLevel1Id { get; set; }

    public string? WymLevel1OrgId { get; set; }

    public string? WymLevel1DirtyOrgId { get; set; }

    public string? WymLevel1Nazwa { get; set; }

    public int? WymLevel2Id { get; set; }

    public string? WymLevel2OrgId { get; set; }

    public string? WymLevel2DirtyOrgId { get; set; }

    public string? WymLevel2Nazwa { get; set; }

    public int? WymLevel3Id { get; set; }

    public string? WymLevel3OrgId { get; set; }

    public string? WymLevel3DirtyOrgId { get; set; }

    public string? WymLevel3Nazwa { get; set; }

    public virtual WymZrodloDanych WymZrodg { get; set; } = null!;
}

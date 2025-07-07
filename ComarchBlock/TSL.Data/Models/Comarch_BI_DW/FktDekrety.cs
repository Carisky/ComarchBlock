using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktDekrety
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DtDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long DtId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DtInsertSubTransformationId { get; set; }

    public string? DtOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DtOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DtTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DtTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DtUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int DtUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int DtBudzetId { get; set; }

    public int DtBuforId { get; set; }

    public int DtCzdid { get; set; }

    public int DtCzmid { get; set; }

    public int DtCzrid { get; set; }

    public int DtDokNumerId { get; set; }

    public int DtDziennikId { get; set; }

    public int DtFirmaId { get; set; }

    public int DtKatFinId { get; set; }

    public int DtKndId { get; set; }

    public int DtKntId { get; set; }

    public int DtKontoId { get; set; }

    public int DtLokId { get; set; }

    public int DtOpeWystId { get; set; }

    public int DtOpeZatwId { get; set; }

    public int DtPerspektywaId { get; set; }

    public int DtPlatId { get; set; }

    public int DtPracownikId { get; set; }

    public int DtProjektId { get; set; }

    public int DtSpiNumerId { get; set; }

    public int DtStrFrmId { get; set; }

    public int DtWalutaId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int DtZrodgid { get; set; }

    public decimal? DtMkwotaMa { get; set; }

    public decimal? DtMkwotaWn { get; set; }

    public string? DtAnulowany { get; set; }

    public int? DtDataWystawienia { get; set; }

    public int? DtKierunek { get; set; }

    public string? DtModyfikacjaTs { get; set; }

    public string? DtOrgAtrId { get; set; }

    public string? DtOrgWymId { get; set; }

    public int? DtPaczka { get; set; }

    public int? DtPozycja { get; set; }

    public decimal? DtPrzelicznikWaluty { get; set; }

    public int? DtTypDekretu { get; set; }

    public int? DtTypKwoty { get; set; }

    public string? DtWymObjGidLp { get; set; }

    public int? DtWymTyp { get; set; }

    public string? DtKonto { get; set; }

    public decimal? DtMkwotaDokMa { get; set; }

    public decimal? DtMkwotaDokWn { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? DtRejonId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int DtAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Delegacja
    /// </summary>
    public int DtDlggid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? DtStrPrwId { get; set; }

    public string? DtOpisPozycji { get; set; }

    public int DtCzdWprowadzeniaId { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public int DtKontoPrzGid { get; set; }

    public string? DtPomId { get; set; }

    public virtual WymAlokacja DtAlokacja { get; set; } = null!;

    public virtual WymBudzet DtBudzet { get; set; } = null!;

    public virtual WymDekretBufor DtBufor { get; set; } = null!;

    public virtual WymCzasDzien DtCzd { get; set; } = null!;

    public virtual WymCzasDzien DtCzdWprowadzenia { get; set; } = null!;

    public virtual WymCzasMiesiac DtCzm { get; set; } = null!;

    public virtual WymCzasRok DtCzr { get; set; } = null!;

    public virtual WymDelegacja DtDlgg { get; set; } = null!;

    public virtual WymDokumentNumer DtDokNumer { get; set; } = null!;

    public virtual WymDekretDziennik DtDziennik { get; set; } = null!;

    public virtual WymFirma DtFirma { get; set; } = null!;

    public virtual WymKategorieFinansowe DtKatFin { get; set; } = null!;

    public virtual WymKontrahent DtKnd { get; set; } = null!;

    public virtual WymKontrahent DtKnt { get; set; } = null!;

    public virtual WymKonto DtKontoNavigation { get; set; } = null!;

    public virtual WymKonto DtKontoPrzG { get; set; } = null!;

    public virtual WymLokalizacja DtLok { get; set; } = null!;

    public virtual WymOperator DtOpeWyst { get; set; } = null!;

    public virtual WymOperator DtOpeZatw { get; set; } = null!;

    public virtual WymPerspektywa DtPerspektywa { get; set; } = null!;

    public virtual WymKontrahent DtPlat { get; set; } = null!;

    public virtual WymPracownik DtPracownik { get; set; } = null!;

    public virtual WymProjekt DtProjekt { get; set; } = null!;

    public virtual WymRejon? DtRejon { get; set; }

    public virtual WymDokumentNumer DtSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy DtStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? DtStrPrw { get; set; }

    public virtual WymWalutum DtWaluta { get; set; } = null!;

    public virtual WymZrodloDanych DtZrodg { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktPlatnosciStanyKa
{
    public int StkPerspektywaId { get; set; }

    public int StkFirmaId { get; set; }

    public int StkKntId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int StkBudzetId { get; set; }

    public int StkCzdtid { get; set; }

    public int StkDokNumerId { get; set; }

    public int StkKndId { get; set; }

    public int StkDataZamknieciaId { get; set; }

    public int StkDataOtwarciaId { get; set; }

    public int StkRejonid { get; set; }

    public int StkWalutaId { get; set; }

    public int StkFormPlatId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int StkId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int StkZrodgid { get; set; }

    public int StkCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string StkCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string StkDirtyOrgId { get; set; } = null!;

    public string? StkOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int StkUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StkUpdateSubTransformationId { get; set; }

    public int StkInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? StkInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime StkTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime StkTsupdate { get; set; }

    public decimal? StkKierunek { get; set; }

    public decimal? StkMnaleznosc { get; set; }

    public decimal? StkMnaleznoscWaluta { get; set; }

    public decimal? StkMzobowiazanie { get; set; }

    public decimal? StkMzobowiazanieWaluta { get; set; }

    public decimal? StkStanRejestr { get; set; }

    public decimal? StkStanRejestrWaluta { get; set; }

    public decimal? StkStanRaport { get; set; }

    public decimal? StkStanRaportWaluta { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int StkAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int StkProjektId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int StkStrFrmId { get; set; }

    public string? StkOrgAtrId { get; set; }

    public string? StkOrgWymId { get; set; }

    public string? StkWymObjGidLp { get; set; }

    public int? StkWymTyp { get; set; }

    public int? StkTypKwoty { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int StkLokId { get; set; }

    /// <summary>
    /// Relation to dimension Delegacja
    /// </summary>
    public int StkDlggid { get; set; }

    /// <summary>
    /// Relation to dimension Wniosek
    /// </summary>
    public int StkWnogid { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public virtual WymAlokacja StkAlokacja { get; set; } = null!;

    public virtual WymBudzet StkBudzet { get; set; } = null!;

    public virtual WymCzasDzien StkCzd { get; set; } = null!;

    public virtual WymCzasDzien StkCzdt { get; set; } = null!;

    public virtual WymCzasDzien StkDataOtwarcia { get; set; } = null!;

    public virtual WymCzasDzien StkDataZamkniecia { get; set; } = null!;

    public virtual WymDelegacja StkDlgg { get; set; } = null!;

    public virtual WymDokumentNumer StkDokNumer { get; set; } = null!;

    public virtual WymFirma StkFirma { get; set; } = null!;

    public virtual WymFormyPlatnosci StkFormPlat { get; set; } = null!;

    public virtual WymKontrahent StkKnd { get; set; } = null!;

    public virtual WymKontrahent StkKnt { get; set; } = null!;

    public virtual WymLokalizacja StkLok { get; set; } = null!;

    public virtual WymPerspektywa StkPerspektywa { get; set; } = null!;

    public virtual WymProjekt StkProjekt { get; set; } = null!;

    public virtual WymRejon StkRejon { get; set; } = null!;

    public virtual WymStrukturaFirmy StkStrFrm { get; set; } = null!;

    public virtual WymWalutum StkWaluta { get; set; } = null!;

    public virtual WymWniosek StkWnog { get; set; } = null!;

    public virtual WymZrodloDanych StkZrodg { get; set; } = null!;
}

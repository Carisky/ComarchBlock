using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktPlatnosciSrednie
{
    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int PlsBudzetId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int PlsId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PlsZrodgid { get; set; }

    public int PlsCzmid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PlsCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PlsDirtyOrgId { get; set; }

    public string? PlsOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PlsUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PlsUpdateSubTransformationId { get; set; }

    public int PlsInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PlsInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PlsTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PlsTsupdate { get; set; }

    public string? PlsOrgAtrId { get; set; }

    public int PlsPlatId { get; set; }

    public int PlsWalutaId { get; set; }

    public int PlsFormPlatId { get; set; }

    public int PlsKndId { get; set; }

    public int PlsDokNumerId { get; set; }

    public int PlsKntId { get; set; }

    public int PlsRejonid { get; set; }

    public int PlsSpiNumerId { get; set; }

    public int PlsFirmaId { get; set; }

    public int PlsCzdterminPlatId { get; set; }

    public int PlsOpiekunId { get; set; }

    public int PlsProdId { get; set; }

    public int PlsAkwId { get; set; }

    public decimal? PlsMsrStanNaleznosci { get; set; }

    public decimal? PlsMsrStanZowowiazan { get; set; }

    public decimal? PlsMiloscDniWMiesiacu { get; set; }

    public decimal? PlsMsumaStanuNaleznosci { get; set; }

    public decimal? PlsMsunaStanuZobowiazan { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int PlsAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int PlsStrFrmId { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int PlsProjektId { get; set; }

    public int? PlsWymTyp { get; set; }

    public string? PlsWymObjGidLp { get; set; }

    public int? PlsTypKwoty { get; set; }

    public int? PlsKierunek { get; set; }

    public string? PlsOrgWymId { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int PlsLokId { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Atr0213Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public virtual WymKontrahent PlsAkw { get; set; } = null!;

    public virtual WymAlokacja PlsAlokacja { get; set; } = null!;

    public virtual WymBudzet PlsBudzet { get; set; } = null!;

    public virtual WymCzasDzien PlsCzdterminPlat { get; set; } = null!;

    public virtual WymCzasMiesiac PlsCzm { get; set; } = null!;

    public virtual WymDokumentNumer PlsDokNumer { get; set; } = null!;

    public virtual WymFirma PlsFirma { get; set; } = null!;

    public virtual WymFormyPlatnosci PlsFormPlat { get; set; } = null!;

    public virtual WymKontrahent PlsKnd { get; set; } = null!;

    public virtual WymKontrahent PlsKnt { get; set; } = null!;

    public virtual WymLokalizacja PlsLok { get; set; } = null!;

    public virtual WymPracownik PlsOpiekun { get; set; } = null!;

    public virtual WymKontrahent PlsPlat { get; set; } = null!;

    public virtual WymProdukt PlsProd { get; set; } = null!;

    public virtual WymProjekt PlsProjekt { get; set; } = null!;

    public virtual WymRejon PlsRejon { get; set; } = null!;

    public virtual WymDokumentNumer PlsSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy PlsStrFrm { get; set; } = null!;

    public virtual WymWalutum PlsWaluta { get; set; } = null!;

    public virtual WymZrodloDanych PlsZrodg { get; set; } = null!;
}

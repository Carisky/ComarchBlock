using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktProdukcjaMarszrutum
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PmaDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long PmaId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PmaInsertSubTransformationId { get; set; }

    public int PmaInsertTransformationId { get; set; }

    public string? PmaOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PmaOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PmaTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PmaTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PmaUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PmaUpdateTransformationId { get; set; }

    public int PmaCzdid { get; set; }

    public int PmaCzdzakId { get; set; }

    public int PmaCznid { get; set; }

    public int PmaDokNumerId { get; set; }

    public int PmaKnDid { get; set; }

    public int PmaKntId { get; set; }

    public int PmaObpid { get; set; }

    public int PmaOddid { get; set; }

    public int PmaProdId { get; set; }

    public int PmaStpid { get; set; }

    public int PmaStrFrmId { get; set; }

    public int PmaTchid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PmaZrodgid { get; set; }

    public decimal PmaMczasNormatyw { get; set; }

    /// <summary>
    ///  
    /// </summary>
    public decimal PmaMczasRozliczNorma { get; set; }

    public decimal PmaMczasRozliczPlan { get; set; }

    public decimal PmaMczasRozliczRzecz { get; set; }

    public decimal PmaMkosztyNormatyw { get; set; }

    public decimal PmaMkosztyPlan { get; set; }

    public decimal PmaMkosztyRzeczywiste { get; set; }

    public string? PmaOrgAtrId { get; set; }

    public string? PmaOrgWymId { get; set; }

    public decimal PmaMiloscPlan { get; set; }

    public decimal PmaMiloscRzeczywista { get; set; }

    public decimal PmaMiloscNormatyw { get; set; }

    public int? PmaJczid { get; set; }

    public int? PmaDokRealizacjaId { get; set; }

    public int? PmaRodzKosztId { get; set; }

    public int PmaProjektId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int PmaBudzetId { get; set; }

    public int PmaEprid { get; set; }

    public int PmaDataDokumentuId { get; set; }

    public decimal? PmaMczasPlanOd { get; set; }

    public decimal? PmaMczasPlanDo { get; set; }

    public decimal? PmaMczasRzeczywisteOd { get; set; }

    public decimal? PmaMczasRzeczywisteDo { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int PmaAlokacjaId { get; set; }

    public decimal? PmaMczasPlan { get; set; }

    public decimal? PmaMczasRzeczywiste { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PmaZamDokNumerId { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public virtual WymAlokacja PmaAlokacja { get; set; } = null!;

    public virtual WymBudzet PmaBudzet { get; set; } = null!;

    public virtual WymCzasDzien PmaCzd { get; set; } = null!;

    public virtual WymCzasDzien PmaCzdzak { get; set; } = null!;

    public virtual WymCzynnosc PmaCzn { get; set; } = null!;

    public virtual WymCzasDzien PmaDataDokumentu { get; set; } = null!;

    public virtual WymDokumentNumer PmaDokNumer { get; set; } = null!;

    public virtual WymDokumentNumer? PmaDokRealizacja { get; set; }

    public virtual WymEtapProdukcji PmaEpr { get; set; } = null!;

    public virtual WymJednostkaCzasu? PmaJcz { get; set; }

    public virtual WymKontrahent PmaKnD { get; set; } = null!;

    public virtual WymKontrahent PmaKnt { get; set; } = null!;

    public virtual WymObiektyProdukcji PmaObp { get; set; } = null!;

    public virtual WymOddzial PmaOdd { get; set; } = null!;

    public virtual WymProdukt PmaProd { get; set; } = null!;

    public virtual WymProjekt PmaProjekt { get; set; } = null!;

    public virtual WymRodzajKosztu? PmaRodzKoszt { get; set; }

    public virtual WymStatusProdukcji PmaStp { get; set; } = null!;

    public virtual WymStrukturaFirmy PmaStrFrm { get; set; } = null!;

    public virtual WymTechnologium PmaTch { get; set; } = null!;

    public virtual WymDokumentNumer PmaZamDokNumer { get; set; } = null!;

    public virtual WymZrodloDanych PmaZrodg { get; set; } = null!;
}

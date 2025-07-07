using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktProdukcjaStMaterialowa
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PsmDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long PsmId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PsmInsertSubTransformationId { get; set; }

    public int PsmInsertTransformationId { get; set; }

    public string? PsmOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PsmOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PsmTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PsmTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PsmUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PsmUpdateTransformationId { get; set; }

    public int PsmCelId { get; set; }

    public int PsmCzdid { get; set; }

    public int PsmCzdkosztId { get; set; }

    public int PsmCznid { get; set; }

    public int PsmDokNumerId { get; set; }

    public int PsmKnDid { get; set; }

    public int PsmKntId { get; set; }

    public int PsmProdId { get; set; }

    public int PsmStpid { get; set; }

    public int PsmStrFrmId { get; set; }

    public int PsmTchid { get; set; }

    public int PsmTzaid { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PsmZrodgid { get; set; }

    public decimal? PsmMiloscNormatyw { get; set; }

    public decimal? PsmMiloscPlan { get; set; }

    public decimal? PsmMiloscRzeczywista { get; set; }

    public decimal? PsmMkosztNormatyw { get; set; }

    public decimal? PsmMkosztPlan { get; set; }

    public decimal? PsmMkosztRzeczywisty { get; set; }

    public string? PsmOrgAtrId { get; set; }

    public string? PsmOrgWymId { get; set; }

    public int? PsmRwdokNumerId { get; set; }

    public int PsmProjektId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int PsmBudzetId { get; set; }

    public int PsmEprid { get; set; }

    public int PsmOddid { get; set; }

    public int PsmMagMaterialId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int PsmAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PsmZamDokNumerId { get; set; }

    /// <summary>
    /// Relation to dimension ProdProcesy
    /// </summary>
    public int PsmPpcid { get; set; }

    public decimal? PsmMkosztRealizacji { get; set; }

    public decimal? PsmMiloscRealizacji { get; set; }

    public string? PsmRworgAtrId { get; set; }

    /// <summary>
    /// Relation to dimension Jednostka
    /// </summary>
    public int PsmJmPomId { get; set; }

    /// <summary>
    /// ilość realizacji w jednostce pomocniczej
    /// </summary>
    public decimal? PsmMiloscRealizacjiPom { get; set; }

    /// <summary>
    /// Relation to dimension Material
    /// </summary>
    public int PsmMatGid { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public virtual WymAlokacja PsmAlokacja { get; set; } = null!;

    public virtual WymBudzet PsmBudzet { get; set; } = null!;

    public virtual WymProdukt PsmCel { get; set; } = null!;

    public virtual WymCzasDzien PsmCzd { get; set; } = null!;

    public virtual WymCzasDzien PsmCzdkoszt { get; set; } = null!;

    public virtual WymCzynnosc PsmCzn { get; set; } = null!;

    public virtual WymDokumentNumer PsmDokNumer { get; set; } = null!;

    public virtual WymEtapProdukcji PsmEpr { get; set; } = null!;

    public virtual WymJednostka PsmJmPom { get; set; } = null!;

    public virtual WymKontrahent PsmKnD { get; set; } = null!;

    public virtual WymKontrahent PsmKnt { get; set; } = null!;

    public virtual WymMagazyn PsmMagMaterial { get; set; } = null!;

    public virtual WymMaterial PsmMatG { get; set; } = null!;

    public virtual WymOddzial PsmOdd { get; set; } = null!;

    public virtual WymProdProcesy PsmPpc { get; set; } = null!;

    public virtual WymProdukt PsmProd { get; set; } = null!;

    public virtual WymProjekt PsmProjekt { get; set; } = null!;

    public virtual WymDokumentNumer? PsmRwdokNumer { get; set; }

    public virtual WymStatusProdukcji PsmStp { get; set; } = null!;

    public virtual WymStrukturaFirmy PsmStrFrm { get; set; } = null!;

    public virtual WymTechnologium PsmTch { get; set; } = null!;

    public virtual WymTypZasobu PsmTza { get; set; } = null!;

    public virtual WymDokumentNumer PsmZamDokNumer { get; set; } = null!;

    public virtual WymZrodloDanych PsmZrodg { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktProdukcjaZlecenium
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PrzDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long PrzId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PrzInsertSubTransformationId { get; set; }

    public int PrzInsertTransformationId { get; set; }

    public string? PrzOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PrzOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PrzTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PrzTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PrzUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PrzUpdateTransformationId { get; set; }

    public int PrzCzdanId { get; set; }

    public int PrzCzdid { get; set; }

    public int PrzCzdplanWproId { get; set; }

    public int PrzCzdplanZakId { get; set; }

    public int PrzCzdwproId { get; set; }

    public int PrzCzdzakId { get; set; }

    public int PrzDokNumerId { get; set; }

    public int PrzKnDid { get; set; }

    public int PrzKntId { get; set; }

    public int PrzLokId { get; set; }

    public int PrzOddid { get; set; }

    public int PrzProdId { get; set; }

    public int PrzProjektId { get; set; }

    public int PrzStpid { get; set; }

    public int PrzStrFrmId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PrzZrodgid { get; set; }

    public decimal? PrzMiloscPlan { get; set; }

    public decimal? PrzMiloscRealizacji { get; set; }

    public decimal? PrzMkosztPlan { get; set; }

    public decimal? PrzMkosztPlanMat { get; set; }

    public decimal? PrzModchylenieRealizacji { get; set; }

    public int? PrzKierunek { get; set; }

    public string? PrzOrgAtrId { get; set; }

    public string? PrzOrgWymId { get; set; }

    public int? PrzTypKwoty { get; set; }

    public int? PrzWymObjGidLp { get; set; }

    public int? PrzWymTyp { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int PrzBudzetId { get; set; }

    public int PrzTchid { get; set; }

    public int PrzKatFinId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int PrzRejonId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int PrzAlokacjaId { get; set; }

    public string? PrzOrgAtrNagId { get; set; }

    public string? PrzOrgAtrEleId { get; set; }

    public decimal? PrzModRealizacji { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PrzZamDoknumerId { get; set; }

    /// <summary>
    /// ilosc realizacji w jednostce pomocniczej
    /// </summary>
    public decimal? PrzMiloscRealizacjipom { get; set; }

    /// <summary>
    /// Relation to dimension Jednostka
    /// </summary>
    public int PrzJmpomId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? PrzStrPrwId { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public virtual WymAlokacja PrzAlokacja { get; set; } = null!;

    public virtual WymBudzet PrzBudzet { get; set; } = null!;

    public virtual WymCzasDzien PrzCzd { get; set; } = null!;

    public virtual WymCzasDzien PrzCzdan { get; set; } = null!;

    public virtual WymCzasDzien PrzCzdplanWpro { get; set; } = null!;

    public virtual WymCzasDzien PrzCzdplanZak { get; set; } = null!;

    public virtual WymCzasDzien PrzCzdwpro { get; set; } = null!;

    public virtual WymCzasDzien PrzCzdzak { get; set; } = null!;

    public virtual WymDokumentNumer PrzDokNumer { get; set; } = null!;

    public virtual WymJednostka PrzJmpom { get; set; } = null!;

    public virtual WymKategorieFinansowe PrzKatFin { get; set; } = null!;

    public virtual WymKontrahent PrzKnD { get; set; } = null!;

    public virtual WymKontrahent PrzKnt { get; set; } = null!;

    public virtual WymLokalizacja PrzLok { get; set; } = null!;

    public virtual WymOddzial PrzOdd { get; set; } = null!;

    public virtual WymProdukt PrzProd { get; set; } = null!;

    public virtual WymProjekt PrzProjekt { get; set; } = null!;

    public virtual WymRejon PrzRejon { get; set; } = null!;

    public virtual WymStatusProdukcji PrzStp { get; set; } = null!;

    public virtual WymStrukturaFirmy PrzStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? PrzStrPrw { get; set; }

    public virtual WymTechnologium PrzTch { get; set; } = null!;

    public virtual WymDokumentNumer PrzZamDoknumer { get; set; } = null!;

    public virtual WymZrodloDanych PrzZrodg { get; set; } = null!;
}

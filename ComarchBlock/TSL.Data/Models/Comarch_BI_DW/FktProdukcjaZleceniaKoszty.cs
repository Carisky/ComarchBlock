using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktProdukcjaZleceniaKoszty
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long PzkId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PzkOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PzkDirtyOrgId { get; set; } = null!;

    public string? PzkOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PzkUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PzkUpdateSubTransformationId { get; set; }

    public int PzkInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PzkInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PzkTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PzkTsupdate { get; set; }

    public int? PzkTypKwoty { get; set; }

    public int? PzkKierunek { get; set; }

    public string? PzkOrgAtrId { get; set; }

    public string? PzkOrgWymId { get; set; }

    public int? PzkWymObjGidLp { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PzkZrodgid { get; set; }

    public int? PzkCzdid { get; set; }

    public int? PrzCzdzakId { get; set; }

    public int? PzkCzdwproId { get; set; }

    public int? PzkCzdplanZakId { get; set; }

    public int? PzkCzdplanWproId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int? PzkBudzetId { get; set; }

    public int? PzkDokNumerId { get; set; }

    public int? PzkFirmaId { get; set; }

    public int? PzkKntId { get; set; }

    public int? PzkKndId { get; set; }

    public int? PzkLokId { get; set; }

    public int PzkOddid { get; set; }

    public int? PzkProdId { get; set; }

    public int? PzkProjektId { get; set; }

    public int? PzkRodzKosztId { get; set; }

    public int? PzkStpid { get; set; }

    public int? PzkStrFrmId { get; set; }

    public int PzkCzdanId { get; set; }

    public decimal? PzkMkosztRealizacji { get; set; }

    public decimal? PzkMkosztRealizacjiMat { get; set; }

    public int PzkTchid { get; set; }

    public int PzkKatFinId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? PzkRejonId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int PzkAlokacjaId { get; set; }

    public int PzkCzdprzypisaniaKosztuId { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PzkZamDokNumerId { get; set; }

    public virtual WymCzasDzien? PrzCzdzak { get; set; }

    public virtual WymAlokacja PzkAlokacja { get; set; } = null!;

    public virtual WymBudzet? PzkBudzet { get; set; }

    public virtual WymCzasDzien? PzkCzd { get; set; }

    public virtual WymCzasDzien PzkCzdan { get; set; } = null!;

    public virtual WymCzasDzien? PzkCzdplanWpro { get; set; }

    public virtual WymCzasDzien? PzkCzdplanZak { get; set; }

    public virtual WymCzasDzien PzkCzdprzypisaniaKosztu { get; set; } = null!;

    public virtual WymCzasDzien? PzkCzdwpro { get; set; }

    public virtual WymDokumentNumer? PzkDokNumer { get; set; }

    public virtual WymFirma? PzkFirma { get; set; }

    public virtual WymKategorieFinansowe PzkKatFin { get; set; } = null!;

    public virtual WymKontrahent? PzkKnd { get; set; }

    public virtual WymKontrahent? PzkKnt { get; set; }

    public virtual WymLokalizacja? PzkLok { get; set; }

    public virtual WymOddzial PzkOdd { get; set; } = null!;

    public virtual WymProdukt? PzkProd { get; set; }

    public virtual WymProjekt? PzkProjekt { get; set; }

    public virtual WymRejon? PzkRejon { get; set; }

    public virtual WymRodzajKosztu? PzkRodzKoszt { get; set; }

    public virtual WymStatusProdukcji? PzkStp { get; set; }

    public virtual WymStrukturaFirmy? PzkStrFrm { get; set; }

    public virtual WymTechnologium PzkTch { get; set; } = null!;

    public virtual WymDokumentNumer PzkZamDokNumer { get; set; } = null!;

    public virtual WymZrodloDanych PzkZrodg { get; set; } = null!;
}

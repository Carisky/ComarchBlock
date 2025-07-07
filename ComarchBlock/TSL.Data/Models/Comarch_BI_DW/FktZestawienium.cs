using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktZestawienium
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZksDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long ZksId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZksInsertSubTransformationId { get; set; }

    public string? ZksOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZksOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZksTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZksTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZksUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZksUpdateTransformationId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int ZksBudzetId { get; set; }

    public int ZksBuforId { get; set; }

    public int ZksCzdid { get; set; }

    public int ZksCzmid { get; set; }

    public int ZksDziennikId { get; set; }

    public int ZksFirmaId { get; set; }

    public int ZksKatFinId { get; set; }

    public int ZksKndId { get; set; }

    public int ZksKntId { get; set; }

    public int ZksKontoId { get; set; }

    public int ZksLokId { get; set; }

    public int ZksPerspektywaId { get; set; }

    public int ZksPlatId { get; set; }

    public int ZksProjektId { get; set; }

    public int ZksStrFrmId { get; set; }

    public int ZksWalutaId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZksZrodgid { get; set; }

    public int ZksZstid { get; set; }

    public decimal? ZksMkwota { get; set; }

    public decimal? ZksMkwotaOrg { get; set; }

    public int? ZksKierunek { get; set; }

    public string? ZksOrgAtrId { get; set; }

    public string? ZksOrgWymId { get; set; }

    public int? ZksPaczka { get; set; }

    public decimal? ZksPrzelicznikWaluty { get; set; }

    public int? ZksTypKwoty { get; set; }

    public string? ZksWymObjGidLp { get; set; }

    public int? ZksWymTyp { get; set; }

    public string? ZksZstnazwa { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZksZstOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ZksAlokacjaId { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public virtual WymAlokacja ZksAlokacja { get; set; } = null!;

    public virtual WymBudzet ZksBudzet { get; set; } = null!;

    public virtual WymDekretBufor ZksBufor { get; set; } = null!;

    public virtual WymCzasDzien ZksCzd { get; set; } = null!;

    public virtual WymCzasMiesiac ZksCzm { get; set; } = null!;

    public virtual WymDekretDziennik ZksDziennik { get; set; } = null!;

    public virtual WymFirma ZksFirma { get; set; } = null!;

    public virtual WymKategorieFinansowe ZksKatFin { get; set; } = null!;

    public virtual WymKontrahent ZksKnd { get; set; } = null!;

    public virtual WymKontrahent ZksKnt { get; set; } = null!;

    public virtual WymKonto ZksKonto { get; set; } = null!;

    public virtual WymLokalizacja ZksLok { get; set; } = null!;

    public virtual WymPerspektywa ZksPerspektywa { get; set; } = null!;

    public virtual WymKontrahent ZksPlat { get; set; } = null!;

    public virtual WymProjekt ZksProjekt { get; set; } = null!;

    public virtual WymStrukturaFirmy ZksStrFrm { get; set; } = null!;

    public virtual WymWalutum ZksWaluta { get; set; } = null!;

    public virtual WymZrodloDanych ZksZrodg { get; set; } = null!;

    public virtual WymZestawieniaInkrementalnie ZksZst { get; set; } = null!;
}

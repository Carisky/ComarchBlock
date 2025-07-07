using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktAnkiety
{
    /// <summary>
    /// Relation to dimension WizytyElement
    /// </summary>
    public int AntWelId { get; set; }

    /// <summary>
    /// Relation to dimension CRMEtapy
    /// </summary>
    public int AntCrmetapId { get; set; }

    /// <summary>
    /// Relation to dimension Ankieta
    /// </summary>
    public int AntAnkid { get; set; }

    /// <summary>
    /// Relation to dimension Odpowiedz
    /// </summary>
    public int AntOdpid { get; set; }

    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int AntProdId { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int AntKntId { get; set; }

    /// <summary>
    /// Relation to dimension Pytanie
    /// </summary>
    public int AntPytid { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int AntAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Wizyty
    /// </summary>
    public int AntWzwId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int AntBudzetId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int AntId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int AntZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int AntCzdgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AntOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AntDirtyOrgId { get; set; } = null!;

    public string? AntOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AntTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AntTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int AntUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AntUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int AntInsertSubTransformationId { get; set; }

    public int? AntInsertTransformationId { get; set; }

    public int? AntModpowiedz { get; set; }

    public decimal? AntMpunktacja { get; set; }

    public string? AntMlank { get; set; }

    /// <summary>
    /// Relation to dimension Pracownik
    /// </summary>
    public int AntPrcId { get; set; }

    public virtual WymAlokacja AntAlokacja { get; set; } = null!;

    public virtual WymAnkietum AntAnk { get; set; } = null!;

    public virtual WymBudzet AntBudzet { get; set; } = null!;

    public virtual WymCrmetapy AntCrmetap { get; set; } = null!;

    public virtual WymCzasDzien AntCzdg { get; set; } = null!;

    public virtual WymKontrahent AntKnt { get; set; } = null!;

    public virtual WymOdpowiedz AntOdp { get; set; } = null!;

    public virtual WymPracownik AntPrc { get; set; } = null!;

    public virtual WymProdukt AntProd { get; set; } = null!;

    public virtual WymPytanie AntPyt { get; set; } = null!;

    public virtual WymWizytyElement AntWel { get; set; } = null!;

    public virtual WymWizyty AntWzw { get; set; } = null!;

    public virtual WymZrodloDanych AntZrodg { get; set; } = null!;
}

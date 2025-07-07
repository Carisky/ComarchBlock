using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktPlatnosciNaDzien
{
    public string? PndDescription { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PndDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long PndId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PndInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PndOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PndTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PndTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PndUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PndUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int PndBudzetId { get; set; }

    public int PndCechyId { get; set; }

    public int PndCrmEtapId { get; set; }

    public int PndCzdid { get; set; }

    public int PndCzmid { get; set; }

    public int PndDokNumerId { get; set; }

    public int PndFirmaId { get; set; }

    public int PndFormPlatId { get; set; }

    public int PndKndId { get; set; }

    public int PndKntId { get; set; }

    public int? PndOpiekunId { get; set; }

    public int PndPerspektywaId { get; set; }

    public int PndPlatId { get; set; }

    public int PndSpiNumerId { get; set; }

    public int PndSpZapId { get; set; }

    public int PndWalutaId { get; set; }

    public int PndZapId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PndZrodgid { get; set; }

    public decimal? PndMnaleznosc { get; set; }

    public decimal? PndMspodziewanaZapadalnosc { get; set; }

    public decimal? PndMzapadalnosc { get; set; }

    public decimal? PndMzobowiazanie { get; set; }

    public int? PndKierunek { get; set; }

    public string? PndOrgAtrId { get; set; }

    public string? PndOrgWymId { get; set; }

    public int? PndPaczka { get; set; }

    public decimal? PndPrzelicznikWaluty { get; set; }

    public int? PndTypKwoty { get; set; }

    public string? PndWymObjGidLp { get; set; }

    public int? PndWymTyp { get; set; }

    public int? PndProdId { get; set; }

    public decimal? PndMnaleznoscWaluta { get; set; }

    public decimal? PndMzobowiazanieWaluta { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? PndRejonId { get; set; }

    public int PndCzdterminPlatId { get; set; }

    public int PndSpZap2Id { get; set; }

    public int PndZap2Id { get; set; }

    public int? PndAkwId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int PndAlokacjaId { get; set; }

    public int? PndDataWystawienia { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int PndStrFrmId { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int PndProjektId { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int PndLokId { get; set; }

    /// <summary>
    /// Relation to dimension Wniosek
    /// </summary>
    public int PndWnogid { get; set; }

    /// <summary>
    /// Relation to dimension Delegacja
    /// </summary>
    public int PndDlggid { get; set; }

    public int PndDokPlaId { get; set; }

    public int PndPrlvid { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0213Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public int? Atr0242Id { get; set; }

    public int? Atr0267Id { get; set; }

    public int? Atr027Id { get; set; }

    public int? Atr028Id { get; set; }

    public int? Atr029Id { get; set; }

    public int? Atr0299Id { get; set; }

    public int? Atr02101Id { get; set; }

    public virtual WymKontrahent? PndAkw { get; set; }

    public virtual WymAlokacja PndAlokacja { get; set; } = null!;

    public virtual WymBudzet PndBudzet { get; set; } = null!;

    public virtual WymCechy PndCechy { get; set; } = null!;

    public virtual WymCrmetapy PndCrmEtap { get; set; } = null!;

    public virtual WymCzasDzien PndCzd { get; set; } = null!;

    public virtual WymCzasDzien PndCzdterminPlat { get; set; } = null!;

    public virtual WymCzasMiesiac PndCzm { get; set; } = null!;

    public virtual WymDelegacja PndDlgg { get; set; } = null!;

    public virtual WymDokumentNumer PndDokNumer { get; set; } = null!;

    public virtual WymDokumentPlatnosc PndDokPla { get; set; } = null!;

    public virtual WymFirma PndFirma { get; set; } = null!;

    public virtual WymFormyPlatnosci PndFormPlat { get; set; } = null!;

    public virtual WymKontrahent PndKnd { get; set; } = null!;

    public virtual WymKontrahent PndKnt { get; set; } = null!;

    public virtual WymLokalizacja PndLok { get; set; } = null!;

    public virtual WymPracownik? PndOpiekun { get; set; }

    public virtual WymPerspektywa PndPerspektywa { get; set; } = null!;

    public virtual WymKontrahent PndPlat { get; set; } = null!;

    public virtual WymPreliminarz PndPrlv { get; set; } = null!;

    public virtual WymProdukt? PndProd { get; set; }

    public virtual WymProjekt PndProjekt { get; set; } = null!;

    public virtual WymRejon? PndRejon { get; set; }

    public virtual WymSpodziewanaZapadalnosc PndSpZap { get; set; } = null!;

    public virtual WymSpodziewanaZapadalnosc2 PndSpZap2 { get; set; } = null!;

    public virtual WymDokumentNumer PndSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy PndStrFrm { get; set; } = null!;

    public virtual WymWalutum PndWaluta { get; set; } = null!;

    public virtual WymWniosek PndWnog { get; set; } = null!;

    public virtual WymZapadalnosc PndZap { get; set; } = null!;

    public virtual WymZapadalnosc2 PndZap2 { get; set; } = null!;

    public virtual WymZrodloDanych PndZrodg { get; set; } = null!;
}

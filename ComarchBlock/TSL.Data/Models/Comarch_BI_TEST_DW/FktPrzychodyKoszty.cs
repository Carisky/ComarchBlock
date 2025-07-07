using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktPrzychodyKoszty
{
    public string? PkDescription { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PkDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long PkId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PkInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PkOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PkTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PkTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PkUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PkUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    public int PkAkwId { get; set; }

    public int PkAkwStazId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int PkBudzetId { get; set; }

    public int PkCechyId { get; set; }

    public int PkCrmEtapId { get; set; }

    public int PkCzdid { get; set; }

    public int PkCzmid { get; set; }

    public int PkDokNumerId { get; set; }

    public int PkDstId { get; set; }

    public int PkFirmaId { get; set; }

    public int PkKatFinId { get; set; }

    public int PkKndId { get; set; }

    public int PkKndStazId { get; set; }

    public int PkKntId { get; set; }

    public int PkKntStazId { get; set; }

    public int PkLokId { get; set; }

    public int PkMagId { get; set; }

    public int PkMsklId { get; set; }

    public int PkOpiekunId { get; set; }

    public int PkPerspektywaId { get; set; }

    public int PkPlatId { get; set; }

    public int PkPracownikId { get; set; }

    public int PkProdId { get; set; }

    public int PkProdStazId { get; set; }

    public int PkProjektId { get; set; }

    public int PkRksId { get; set; }

    public int PkSpiNumerId { get; set; }

    public int PkStrFrmId { get; set; }

    public int PkWalutaId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PkZrodgid { get; set; }

    public decimal? PkMsaldo { get; set; }

    public decimal? PkMspiZmniejszenie { get; set; }

    public decimal? PkMspiZwiekszenie { get; set; }

    public decimal? PkMtreZmniejszenie { get; set; }

    public decimal? PkMtreZwiekszenie { get; set; }

    public decimal? PkMtrnZmniejszenie { get; set; }

    public decimal? PkMtrnZwiekszenie { get; set; }

    public decimal? PkMzmniejszenie { get; set; }

    public decimal? PkMzwiekszenie { get; set; }

    public int? PkAnulowany { get; set; }

    public int? PkDataWystawienia { get; set; }

    public int? PkDstStazId { get; set; }

    public int? PkKierunek { get; set; }

    public int? PkObjGidLp { get; set; }

    public string? PkOrgAtrId { get; set; }

    public string? PkOrgWymId { get; set; }

    public int? PkPaczka { get; set; }

    public int? PkPlatStazId { get; set; }

    public int? PkPozycjaId { get; set; }

    public decimal? PkPrzelicznikWaluty { get; set; }

    public int? PkTypKwoty { get; set; }

    public string? PkWymObjGidLp { get; set; }

    public int? PkWymTyp { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? PkRejonId { get; set; }

    public int PkOpiekunSpinaczId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int PkAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PkDataDokumentuId { get; set; }

    public string? PkOrgAtrNagId { get; set; }

    public string? PkOrgAtrEleId { get; set; }

    public string? PkOrgAtrSubId { get; set; }

    /// <summary>
    /// Kolumna wskazuje czy dany wiersz pochodzi z dokumentu korekty lub nie (0/1).
    /// </summary>
    public bool? PkIsCorrection { get; set; }

    /// <summary>
    /// Relation to dimension Delegacja
    /// </summary>
    public int PkDlggid { get; set; }

    /// <summary>
    /// Relation to dimension Wniosek
    /// </summary>
    public int PkWnogid { get; set; }

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

    public virtual WymKontrahent PkAkw { get; set; } = null!;

    public virtual WymStazKlientum PkAkwStaz { get; set; } = null!;

    public virtual WymAlokacja PkAlokacja { get; set; } = null!;

    public virtual WymBudzet PkBudzet { get; set; } = null!;

    public virtual WymCechy PkCechy { get; set; } = null!;

    public virtual WymCrmetapy PkCrmEtap { get; set; } = null!;

    public virtual WymCzasDzien PkCzd { get; set; } = null!;

    public virtual WymCzasMiesiac PkCzm { get; set; } = null!;

    public virtual WymCzasDzien PkDataDokumentu { get; set; } = null!;

    public virtual WymDelegacja PkDlgg { get; set; } = null!;

    public virtual WymDokumentNumer PkDokNumer { get; set; } = null!;

    public virtual WymKontrahent PkDst { get; set; } = null!;

    public virtual WymFirma PkFirma { get; set; } = null!;

    public virtual WymKategorieFinansowe PkKatFin { get; set; } = null!;

    public virtual WymKontrahent PkKnd { get; set; } = null!;

    public virtual WymStazKlientum PkKndStaz { get; set; } = null!;

    public virtual WymKontrahent PkKnt { get; set; } = null!;

    public virtual WymStazKlientum PkKntStaz { get; set; } = null!;

    public virtual WymLokalizacja PkLok { get; set; } = null!;

    public virtual WymMagazyn PkMag { get; set; } = null!;

    public virtual WymMiejsceSkladowanium PkMskl { get; set; } = null!;

    public virtual WymPracownik PkOpiekun { get; set; } = null!;

    public virtual WymPracownik PkOpiekunSpinacz { get; set; } = null!;

    public virtual WymPerspektywa PkPerspektywa { get; set; } = null!;

    public virtual WymKontrahent PkPlat { get; set; } = null!;

    public virtual WymPracownik PkPracownik { get; set; } = null!;

    public virtual WymProdukt PkProd { get; set; } = null!;

    public virtual WymStazKlientum PkProdStaz { get; set; } = null!;

    public virtual WymProjekt PkProjekt { get; set; } = null!;

    public virtual WymRejon? PkRejon { get; set; }

    public virtual WymRodzajKosztuSprzedazy PkRks { get; set; } = null!;

    public virtual WymDokumentNumer PkSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy PkStrFrm { get; set; } = null!;

    public virtual WymWalutum PkWaluta { get; set; } = null!;

    public virtual WymWniosek PkWnog { get; set; } = null!;

    public virtual WymZrodloDanych PkZrodg { get; set; } = null!;
}

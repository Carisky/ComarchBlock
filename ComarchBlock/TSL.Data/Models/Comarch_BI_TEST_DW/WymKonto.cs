using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymKonto
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KontoDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KontoDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KontoDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int KontoId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KontoKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KontoKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KontoOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KontoOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KontoParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KontoParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KontoRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] KontoRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KontoSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KontoTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KontoTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KontoZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    public int? KontoKntId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KontoAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KontoAktualneOrgParId { get; set; }

    public int? KontoAktywny { get; set; }

    public string? KontoAnalityczne { get; set; }

    public string? KontoKlasa { get; set; }

    public string? KontoLisc { get; set; }

    public string? KontoNazwa { get; set; }

    public string? KontoNazwaDodatkowa { get; set; }

    public string? KontoNumer { get; set; }

    public string? KontoOpis { get; set; }

    public string? KontoOrgAtrId { get; set; }

    public int? KontoPoprzednikId { get; set; }

    public int? KontoPozabilansowe { get; set; }

    public string? KontoRozrachunkowe { get; set; }

    public string? KontoSaldoDwustronnie { get; set; }

    public string? KontoTyp { get; set; }

    public string? KontoTypOgolny { get; set; }

    public string? KontoWaluta { get; set; }

    public int? KontoWymFirma { get; set; }

    public int? KontoWymTyp { get; set; }

    public string? KontoSegment0 { get; set; }

    public string? KontoSegment1 { get; set; }

    public string? KontoSegment2 { get; set; }

    public string? KontoSegment3 { get; set; }

    public string? KontoSegment4 { get; set; }

    public string? KontoSegment5 { get; set; }

    public string? KontoSegment6 { get; set; }

    public int? KontoPoziom0Id { get; set; }

    public string? KontoPoziom0Nazwa { get; set; }

    public int? KontoPoziom1Id { get; set; }

    public string? KontoPoziom1Nazwa { get; set; }

    public int? KontoPoziom2Id { get; set; }

    public string? KontoPoziom2Nazwa { get; set; }

    public int? KontoPoziom3Id { get; set; }

    public string? KontoPoziom3Nazwa { get; set; }

    public int? KontoPoziom4Id { get; set; }

    public string? KontoPoziom4Nazwa { get; set; }

    public int? KontoPoziom5Id { get; set; }

    public string? KontoPoziom5Nazwa { get; set; }

    public int? KontoPoziom6Id { get; set; }

    public string? KontoPoziom6Nazwa { get; set; }

    public string? KontoNumerAktualny { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KontoNumerNastepnyOkresOrgId { get; set; }

    public int? KontoPoziom { get; set; }

    public string? KontoNumerNastepnyOkres { get; set; }

    public int KontoOkresId { get; set; }

    public int? KontoPoziomAktualny { get; set; }

    public string? KontoPoziom0SaldoDwustronnie { get; set; }

    public string? KontoPoziom1SaldoDwustronnie { get; set; }

    public string? KontoPoziom2SaldoDwustronnie { get; set; }

    public string? KontoPoziom3SaldoDwustronnie { get; set; }

    public string? KontoPoziom4SaldoDwustronnie { get; set; }

    public string? KontoPoziom5SaldoDwustronnie { get; set; }

    public string? KontoPoziom6SaldoDwustronnie { get; set; }

    public string? KontoPoziom0NazwaKonta { get; set; }

    public string? KontoPoziom1NazwaKonta { get; set; }

    public string? KontoPoziom2NazwaKonta { get; set; }

    public string? KontoPoziom3NazwaKonta { get; set; }

    public string? KontoPoziom4NazwaKonta { get; set; }

    public string? KontoPoziom5NazwaKonta { get; set; }

    public string? KontoPoziom6NazwaKonta { get; set; }

    public string? KontoArchiwalny { get; set; }

    public string? KontoSegment7 { get; set; }

    public string? KontoSegment8 { get; set; }

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();

    public virtual WymKontrahent? KontoKnt { get; set; }

    public virtual WymOkresyObrachunkowe KontoOkres { get; set; } = null!;

    public virtual WymZrodloDanych KontoZrodg { get; set; } = null!;
}

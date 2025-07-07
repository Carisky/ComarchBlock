using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymZestawienium
{
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

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZstDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ZstId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZstOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZstOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZstParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZstRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] ZstRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZstSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZstTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZstTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZstZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZstAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZstAktualneOrgParId { get; set; }

    public int? ZstAktywny { get; set; }

    public string? ZstDefinicja { get; set; }

    public string? ZstFunkcja { get; set; }

    public int? ZstIdKonta { get; set; }

    public string? ZstLisc { get; set; }

    public decimal ZstMnoznik { get; set; }

    public string? ZstNazwa { get; set; }

    public string? ZstNumeracja { get; set; }

    public string? ZstOpis { get; set; }

    public string? ZstOrgAtrId { get; set; }

    public int? ZstPoprzednikId { get; set; }

    public string? ZstPoziom { get; set; }

    public int? ZstPoziomNr { get; set; }

    public string? ZstPozycjaChar { get; set; }

    public decimal? ZstPozycjaNr { get; set; }

    public string? ZstPrezentacja { get; set; }

    public string? ZstSaldoDwustronnie { get; set; }

    public int? ZstSyntetyka { get; set; }

    public int? ZstTypPozycji { get; set; }

    public int? ZstWymFirma { get; set; }

    public int? ZstWymTyp { get; set; }

    public string? ZstZknNazwa { get; set; }

    public int? ZstZknNumer { get; set; }

    public int? ZstZnak { get; set; }

    public string? ZstZnakPozycji { get; set; }

    public int? ZstPoziom0Id { get; set; }

    public string? ZstPoziom0Nazwa { get; set; }

    public int? ZstPoziom1Id { get; set; }

    public string? ZstPoziom1Nazwa { get; set; }

    public int? ZstPoziom2Id { get; set; }

    public string? ZstPoziom2Nazwa { get; set; }

    public int? ZstPoziom3Id { get; set; }

    public string? ZstPoziom3Nazwa { get; set; }

    public int? ZstPoziom4Id { get; set; }

    public string? ZstPoziom4Nazwa { get; set; }

    public int? ZstPoziom5Id { get; set; }

    public string? ZstPoziom5Nazwa { get; set; }

    public int? ZstPoziom6Id { get; set; }

    public string? ZstPoziom6Nazwa { get; set; }

    public int? ZstPoziom7Id { get; set; }

    public string? ZstPoziom7Nazwa { get; set; }

    public int? ZstPoziom8Id { get; set; }

    public string? ZstPoziom8Nazwa { get; set; }

    public int? ZstPoziom9Id { get; set; }

    public string? ZstPoziom9Nazwa { get; set; }

    public int? ZstPoziom10Id { get; set; }

    public string? ZstPoziom10Nazwa { get; set; }

    public string? ZstKontoNumerAktualny { get; set; }

    public int? ZstKolejnosc { get; set; }

    public int? ZstPoziom11Id { get; set; }

    public string? ZstPoziom11Nazwa { get; set; }

    public int? ZstPoziom12Id { get; set; }

    public string? ZstPoziom12Nazwa { get; set; }

    public int? ZstPoziom13Id { get; set; }

    public string? ZstPoziom13Nazwa { get; set; }

    public int? ZstPoziom14Id { get; set; }

    public string? ZstPoziom14Nazwa { get; set; }

    public int? ZstPoziom15Id { get; set; }

    public string? ZstPoziom15Nazwa { get; set; }

    public int ZstOkresId { get; set; }

    public virtual WymOkresyObrachunkowe ZstOkres { get; set; } = null!;

    public virtual WymZrodloDanych ZstZrodg { get; set; } = null!;
}

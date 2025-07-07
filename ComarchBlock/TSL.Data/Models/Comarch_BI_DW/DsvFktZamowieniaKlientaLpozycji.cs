using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktZamowieniaKlientaLpozycji
{
    public int ZakAbcid { get; set; }

    public int ZakAdrKndId { get; set; }

    public int ZakAkwId { get; set; }

    public int ZakAlokacjaId { get; set; }

    public int ZakBudzetId { get; set; }

    public int ZakCechyId { get; set; }

    public string ZakCleanOrgId { get; set; } = null!;

    public int ZakCzdfaktId { get; set; }

    public int ZakCzdid { get; set; }

    public int ZakCzdplanId { get; set; }

    public decimal ZakCzyRabat { get; set; }

    public string ZakDirtyOrgId { get; set; } = null!;

    public int ZakDokElemId { get; set; }

    public int ZakDokNumerId { get; set; }

    public string? ZakFlagaNb { get; set; }

    public int ZakFormPlatId { get; set; }

    public int ZakGeoid { get; set; }

    public long ZakId { get; set; }

    public int? ZakInsertSubTransformationId { get; set; }

    public int ZakInsertTransformationId { get; set; }

    public int ZakJmId { get; set; }

    public int ZakJmPid { get; set; }

    public int? ZakKierunek { get; set; }

    public int ZakKnDid { get; set; }

    public int ZakKntId { get; set; }

    public int ZakLokGid { get; set; }

    public int ZakMagId { get; set; }

    public decimal? ZakMczasRealizacji { get; set; }

    public decimal? ZakMczasRealizacjiRzeczywisty { get; set; }

    public decimal? ZakMdni { get; set; }

    public decimal? ZakMilosc { get; set; }

    public decimal? ZakMiloscJmP { get; set; }

    public decimal? ZakMkgo { get; set; }

    public decimal? ZakModchylenieRealizacji { get; set; }

    public decimal? ZakMvat { get; set; }

    public decimal? ZakMwaga { get; set; }

    public decimal? ZakMwartosc { get; set; }

    public decimal? ZakMwartoscBrutto { get; set; }

    public decimal? ZakMwartoscBruttoPln { get; set; }

    public decimal? ZakMwartoscKoszt { get; set; }

    public decimal? ZakMwartoscPln { get; set; }

    public decimal? ZakMwartoscSpr { get; set; }

    public decimal? ZakMzakladanaCenaZ { get; set; }

    public decimal? ZakMzakladanaMarzaZ { get; set; }

    public int ZakOpegid { get; set; }

    public int ZakOpemgid { get; set; }

    public int ZakOpewgid { get; set; }

    public int ZakOpezgid { get; set; }

    public int ZakOpiekunId { get; set; }

    public string? ZakOpis { get; set; }

    public string? ZakOrgAtrEleId { get; set; }

    public string? ZakOrgAtrId { get; set; }

    public string? ZakOrgAtrNagId { get; set; }

    public string? ZakOrgWymId { get; set; }

    public int ZakPlatId { get; set; }

    public int? ZakPozycjaId { get; set; }

    public int ZakPrmgid { get; set; }

    public int ZakProdId { get; set; }

    public int ZakProduktPozycjeDokId { get; set; }

    public int ZakProjektGid { get; set; }

    public int ZakRejonId { get; set; }

    public int ZakStrFrmId { get; set; }

    public int? ZakStrPrwId { get; set; }

    public DateTime ZakTsinsert { get; set; }

    public DateTime ZakTsupdate { get; set; }

    public int? ZakTypKwoty { get; set; }

    public int? ZakTzamId { get; set; }

    public int? ZakUpdateSubTransformationId { get; set; }

    public int ZakUpdateTransformationId { get; set; }

    public int ZakWalutaId { get; set; }

    public int? ZakWymTyp { get; set; }

    public int ZakZamStanId { get; set; }

    public int ZakZrodgid { get; set; }
}

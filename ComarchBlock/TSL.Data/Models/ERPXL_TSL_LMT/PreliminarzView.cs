using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PreliminarzView
{
    public short? PrlvGidtyp { get; set; }

    public int? PrlvGidfirma { get; set; }

    public int PrlvGidnumer { get; set; }

    public short? PrlvGidlp { get; set; }

    public int? PrlvSpiTyp { get; set; }

    public int? PrlvSpiFirma { get; set; }

    public int? PrlvSpiNumer { get; set; }

    public short? PrlvSpiLp { get; set; }

    public string? PrlvDokument { get; set; }

    public string? PrlvDokumentObcy { get; set; }

    public decimal? PrlvKwota { get; set; }

    public decimal? PrlvKwotaPln { get; set; }

    public decimal? PrlvPozostaje { get; set; }

    public decimal? PrlvPozostajePln { get; set; }

    public decimal? PrlvPozostajePlndzisiaj { get; set; }

    public decimal? PrlvSpkwotaVat { get; set; }

    public int? PrlvSplitPayment { get; set; }

    public int? PrlvMpp { get; set; }

    public int PrlvNaleznosciZobowiazania { get; set; }

    public int? PrlvPrzychodyRozchody { get; set; }

    public int? PrlvData { get; set; }

    public int? PrlvTermin { get; set; }

    public int? PrlvSpodziewanyTermin { get; set; }

    public int? PrlvTerminPoProlongacie { get; set; }

    public byte? PrlvRozliczony { get; set; }

    public string? PrlvWaluta { get; set; }

    public string? PrlvRejestr { get; set; }

    public byte? PrlvTypRejestru { get; set; }

    public int? PrlvZaksiegowano { get; set; }

    public int? PrlvNieKsiegowac { get; set; }

    public int? PrlvDataKsiegowania { get; set; }

    public int PrlvBufor { get; set; }

    public string? PrlvKontoPrzec { get; set; }

    public int? PrlvAktywny { get; set; }

    public int? PrlvLp { get; set; }

    public int? PrlvStan { get; set; }

    public int? PrlvFiskalny { get; set; }

    public int? PrlvKonTyp { get; set; }

    public int? PrlvTStatus { get; set; }

    public short? PrlvKnpTyp { get; set; }

    public int? PrlvKnpNumer { get; set; }

    public string? PrlvAkronim { get; set; }

    public string? PrlvNazwa1 { get; set; }

    public string? PrlvNazwa2 { get; set; }

    public string? PrlvNazwa3 { get; set; }

    public string? PrlvMiasto { get; set; }

    public int? PrlvStatus { get; set; }

    public int? PrlvNumer { get; set; }

    public short? PrlvKntTyp { get; set; }

    public int? PrlvKntNumer { get; set; }

    public int? PrlvWynagrodzenie { get; set; }

    public string? PrlvCdcmsgId { get; set; }

    public string? PrlvCdcstatusKod { get; set; }

    public string? PrlvCdcstatusOpis { get; set; }

    public int? PrlvCdcstatusTimeStamp { get; set; }

    public int? PrlvMaksymalnyTermin { get; set; }

    public int? PrlvKntStatus { get; set; }

    public string? PrlvProlongowanyDokument { get; set; }

    public string? PrlvProlongowanyDokumentObcy { get; set; }
}

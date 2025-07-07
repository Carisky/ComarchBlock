using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TraPlat
{
    public short TrPGidtyp { get; set; }

    public int? TrPGidfirma { get; set; }

    public int TrPGidnumer { get; set; }

    public short TrPGidlp { get; set; }

    public short? TrPKntTyp { get; set; }

    public int? TrPKntFirma { get; set; }

    public int? TrPKntNumer { get; set; }

    public short? TrPKntLp { get; set; }

    public short? TrPAkwTyp { get; set; }

    public int? TrPAkwFirma { get; set; }

    public int? TrPAkwNumer { get; set; }

    public short? TrPAkwLp { get; set; }

    public string? TrPWaluta { get; set; }

    public short? TrPNrKursu { get; set; }

    public decimal? TrPKursM { get; set; }

    public decimal? TrPKursL { get; set; }

    public short? TrPTyp { get; set; }

    public int? TrPTermin { get; set; }

    public byte? TrPFormaNr { get; set; }

    public string? TrPFormaNazwa { get; set; }

    public decimal? TrPKwota { get; set; }

    public decimal? TrPPozostaje { get; set; }

    public byte? TrPRozliczona { get; set; }

    public short? TrPStatus { get; set; }

    public short? TrPOpeWtyp { get; set; }

    public int? TrPOpeWfirma { get; set; }

    public int? TrPOpeWnumer { get; set; }

    public short? TrPOpeWlp { get; set; }

    public string? TrPNotatki { get; set; }

    public short? TrPSpiTyp { get; set; }

    public int? TrPSpiFirma { get; set; }

    public int? TrPSpiNumer { get; set; }

    public short? TrPSpiLp { get; set; }

    public short? TrPKartyp { get; set; }

    public int? TrPKarfirma { get; set; }

    public int? TrPKarnumer { get; set; }

    public short? TrPKarlp { get; set; }

    public short? TrPNrKonta { get; set; }

    public int? TrPSpodziewanyTermin { get; set; }

    public byte? TrPSepa { get; set; }

    public int? TrPExpId { get; set; }

    public int? TrPExpLin { get; set; }

    public decimal? TrPKwotaSys { get; set; }

    public decimal? TrPPozostajeSys { get; set; }

    public int? TrPKnAnumer { get; set; }

    public int? TrPCzasModyfikacji { get; set; }

    public byte? TrPRodzaj { get; set; }

    public int? TrPZewnetrznyId { get; set; }

    public string? TrPEndToEndId { get; set; }

    public string? TrPCdcmsgId { get; set; }

    public string? TrPCdcorgInstrId { get; set; }

    public int? TrPCdcexpTimestamp { get; set; }

    public short? TrPOpeCdctyp { get; set; }

    public int? TrPOpeCdcfirma { get; set; }

    public int? TrPOpeCdcnumer { get; set; }

    public short? TrPOpeCdclp { get; set; }

    public string? TrPCdcstatusKod { get; set; }

    public string? TrPCdcstatusOpis { get; set; }

    public int? TrPCdcstatusTimestamp { get; set; }

    public int? TrPMaksymalnyTermin { get; set; }

    public int? TrPDataWysylki { get; set; }

    public byte? TrPJestLimitCelowy { get; set; }

    public byte? TrPSplitPayment { get; set; }

    public decimal? TrPSpkwotaVat { get; set; }

    public string? TrPSpnip { get; set; }

    public string? TrPSpdokument { get; set; }

    public int? TrPTerminPoProlongacie { get; set; }

    public short? TrPProlZrdTyp { get; set; }

    public int? TrPProlZrdFirma { get; set; }

    public int? TrPProlZrdNumer { get; set; }

    public short? TrPProlZrdLp { get; set; }

    public int? TrPPrleLp { get; set; }

    public int? TrPRachBank { get; set; }

    public short? TrPZrdTyp { get; set; }

    public int? TrPZrdFirma { get; set; }

    public int? TrPZrdNumer { get; set; }

    public short? TrPZrdLp { get; set; }

    public byte? TrPKorektaDanych { get; set; }

    public int? TrPBbonId { get; set; }

    public int? TrPDataRozliczenia { get; set; }

    public byte? TrPCzySprawaSporna { get; set; }

    public short? TrPSprawaSpornaId { get; set; }

    public string? TrPCdctaskId { get; set; }

    public int? TrPLastMod { get; set; }

    public virtual ICollection<PodElemDok> PodElemDoks { get; set; } = new List<PodElemDok>();

    public virtual ICollection<Przelewy> Przelewies { get; set; } = new List<Przelewy>();

    public virtual ICollection<UpoElem> UpoElems { get; set; } = new List<UpoElem>();

    public virtual WydatkiPrcPlatnosci? WydatkiPrcPlatnosci { get; set; }
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SrtKarty
{
    public short? SrtGidtyp { get; set; }

    public int? SrtGidfirma { get; set; }

    public int SrtGidnumer { get; set; }

    public short? SrtGidlp { get; set; }

    public short? SrtPrcTyp { get; set; }

    public int? SrtPrcFirma { get; set; }

    public int? SrtPrcNumer { get; set; }

    public short? SrtPrcLp { get; set; }

    public short? SrtOpeTyp { get; set; }

    public int? SrtOpeFirma { get; set; }

    public int? SrtOpeNumer { get; set; }

    public short? SrtOpeLp { get; set; }

    public short? SrtKnDtyp { get; set; }

    public int? SrtKnDfirma { get; set; }

    public int? SrtKnDnumer { get; set; }

    public short? SrtKnDlp { get; set; }

    public short? SrtZakTyp { get; set; }

    public int? SrtZakFirma { get; set; }

    public int? SrtZakNumer { get; set; }

    public short? SrtZakLp { get; set; }

    public string? SrtZakNrDok { get; set; }

    public short? SrtLikwTyp { get; set; }

    public int? SrtLikwFirma { get; set; }

    public int? SrtLikwNumer { get; set; }

    public short? SrtLikwLp { get; set; }

    public string? SrtLikwNrDok { get; set; }

    public string? SrtKsiega { get; set; }

    public int? SrtNrInw { get; set; }

    public string? SrtNrEwid { get; set; }

    public string? SrtAkronim { get; set; }

    public string? SrtNazwa { get; set; }

    public byte? SrtRodzaj { get; set; }

    public string? SrtKrst { get; set; }

    public int? SrtSktid { get; set; }

    public byte? SrtMetodaUm { get; set; }

    public byte? SrtMetodaAm { get; set; }

    public byte? SrtDwutorowosc { get; set; }

    public byte? SrtPodlegaAmp { get; set; }

    public decimal? SrtStawka { get; set; }

    public decimal? SrtWspUmAm { get; set; }

    public decimal? SrtWspDegr { get; set; }

    public decimal? SrtStawkaAm { get; set; }

    public decimal? SrtWspAm { get; set; }

    public decimal? SrtWspDegrAm { get; set; }

    public string? SrtWaluta { get; set; }

    public string? SrtEtykieta { get; set; }

    public string? SrtEtykietaKod { get; set; }

    public int? SrtDataZak { get; set; }

    public string? SrtSposobZak { get; set; }

    public int? SrtData { get; set; }

    public int? SrtDataEksp { get; set; }

    public int? SrtDataRozp { get; set; }

    public int? SrtDataRozpAm { get; set; }

    public int? SrtDataLikw { get; set; }

    public string? SrtSposobLikw { get; set; }

    public string? SrtMiejsceUzyw { get; set; }

    public int? SrtLastModL { get; set; }

    public int? SrtLastModO { get; set; }

    public int? SrtLastModC { get; set; }

    public string? SrtKontoGl { get; set; }

    public string? SrtKontoUm { get; set; }

    public string? SrtKontoAmP { get; set; }

    public string? SrtKontoAmB { get; set; }

    public string? SrtKontoStk { get; set; }

    public string? SrtOpis { get; set; }

    public byte? SrtWsk { get; set; }

    public byte? SrtSezonowy { get; set; }

    public string? SrtAtr1 { get; set; }

    public string? SrtAtr2 { get; set; }

    public string? SrtAtr3 { get; set; }

    public string? SrtAtr4 { get; set; }

    public byte? SrtMsNaliczania { get; set; }

    public byte? SrtMsNaliczaniaAm { get; set; }

    public decimal? SrtKwotaZlom { get; set; }

    public decimal? SrtKwotaZlomAm { get; set; }

    public decimal? SrtKwotaZlomWal { get; set; }

    public string? SrtWalutaKwotaZlom { get; set; }

    public string? SrtUrl { get; set; }

    public byte? SrtUjecieJednoT { get; set; }

    public byte? SrtUjecieDwuT { get; set; }

    public byte? SrtDokumentWedycji { get; set; }

    public byte SrtOdliczeniaVat { get; set; }

    public int? SrtOgraniczenieOdl { get; set; }

    public int? SrtSamId { get; set; }

    public byte? SrtMajatekObcy { get; set; }

    public byte? SrtZestaw { get; set; }

    public byte? SrtMetodaTor3 { get; set; }

    public byte? SrtMetodaTor4 { get; set; }

    public byte? SrtMetodaTor5 { get; set; }

    public decimal? SrtStawkaTor3 { get; set; }

    public decimal? SrtWspAmTor3 { get; set; }

    public decimal? SrtWspDegrTor3 { get; set; }

    public decimal? SrtStawkaTor4 { get; set; }

    public decimal? SrtWspAmTor4 { get; set; }

    public decimal? SrtWspDegrTor4 { get; set; }

    public decimal? SrtStawkaTor5 { get; set; }

    public decimal? SrtWspAmTor5 { get; set; }

    public decimal? SrtWspDegrTor5 { get; set; }

    public int? SrtDataRozpTor3 { get; set; }

    public int? SrtDataRozpTor4 { get; set; }

    public int? SrtDataRozpTor5 { get; set; }

    public string? SrtKontoGlP { get; set; }

    public string? SrtKontoGlTor3 { get; set; }

    public string? SrtKontoGlTor4 { get; set; }

    public string? SrtKontoGlTor5 { get; set; }

    public string? SrtKontoUmP { get; set; }

    public string? SrtKontoUmTor3 { get; set; }

    public string? SrtKontoUmTor4 { get; set; }

    public string? SrtKontoUmTor5 { get; set; }

    public string? SrtKontoAmTor3 { get; set; }

    public string? SrtKontoAmTor4 { get; set; }

    public string? SrtKontoAmTor5 { get; set; }

    public string? SrtKontoStkp { get; set; }

    public string? SrtKontoStktor3 { get; set; }

    public string? SrtKontoStktor4 { get; set; }

    public string? SrtKontoStktor5 { get; set; }

    public byte? SrtMsNaliczaniaAmTor3 { get; set; }

    public byte? SrtMsNaliczaniaAmTor4 { get; set; }

    public byte? SrtMsNaliczaniaAmTor5 { get; set; }

    public decimal? SrtKwotaZlomTor3 { get; set; }

    public decimal? SrtKwotaZlomTor4 { get; set; }

    public decimal? SrtKwotaZlomTor5 { get; set; }

    public byte? SrtUjecieOpisA { get; set; }

    public byte? SrtTorUmLp { get; set; }

    public byte? SrtTorAmLp { get; set; }

    public byte? SrtTor3Lp { get; set; }

    public byte? SrtTor4Lp { get; set; }

    public byte? SrtTor5Lp { get; set; }

    public byte? SrtWbudowie { get; set; }

    public int? SrtNkupograniczenie { get; set; }

    public virtual ICollection<ImtArkuszeElem> ImtArkuszeElems { get; set; } = new List<ImtArkuszeElem>();

    public virtual ICollection<SrtDokZakupu> SrtDokZakupus { get; set; } = new List<SrtDokZakupu>();

    public virtual ICollection<SrtOpisy> SrtOpisies { get; set; } = new List<SrtOpisy>();

    public virtual ICollection<SrtSezon> SrtSezons { get; set; } = new List<SrtSezon>();
}

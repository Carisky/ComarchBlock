using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class MagNag
{
    public short? MaNGidtyp { get; set; }

    public int? MaNGidfirma { get; set; }

    public int MaNGidnumer { get; set; }

    public short? MaNGidlp { get; set; }

    public short? MaNZrdTyp { get; set; }

    public int? MaNZrdFirma { get; set; }

    public int? MaNZrdNumer { get; set; }

    public short? MaNZrdLp { get; set; }

    public short? MaNTrMtyp { get; set; }

    public int? MaNTrMfirma { get; set; }

    public int? MaNTrMnumer { get; set; }

    public short? MaNTrMlp { get; set; }

    public short? MaNTrNtyp { get; set; }

    public short? MaNTrNrok { get; set; }

    public byte? MaNTrNmiesiac { get; set; }

    public string? MaNTrNseria { get; set; }

    public int? MaNTrNnumer { get; set; }

    public short? MaNTrNlp { get; set; }

    public short? MaNKntTyp { get; set; }

    public int? MaNKntFirma { get; set; }

    public int? MaNKntNumer { get; set; }

    public short? MaNKntLp { get; set; }

    public short? MaNKnAtyp { get; set; }

    public int? MaNKnAfirma { get; set; }

    public int? MaNKnAnumer { get; set; }

    public short? MaNKnAlp { get; set; }

    public short? MaNOpeTyp { get; set; }

    public int? MaNOpeFirma { get; set; }

    public int? MaNOpeNumer { get; set; }

    public short? MaNOpeLp { get; set; }

    public short? MaNOpeTypR { get; set; }

    public int? MaNOpeFirmaR { get; set; }

    public int? MaNOpeNumerR { get; set; }

    public short? MaNOpeLpR { get; set; }

    public int? MaNData3 { get; set; }

    public short? MaNStan { get; set; }

    public short? MaNLicznikKopii { get; set; }

    public short? MaNMagDtyp { get; set; }

    public int? MaNMagDfirma { get; set; }

    public int? MaNMagDnumer { get; set; }

    public short? MaNMagDlp { get; set; }

    public int? MaNFrsId { get; set; }

    public int? MaNAktywny { get; set; }

    public byte? MaNWsk { get; set; }

    public string? MaNCechaOpis { get; set; }

    public short? MaNOpeTypM { get; set; }

    public int? MaNOpeFirmaM { get; set; }

    public int? MaNOpeNumerM { get; set; }

    public short? MaNOpeLpM { get; set; }

    public short? MaNZaNtyp { get; set; }

    public int? MaNZaNfirma { get; set; }

    public int? MaNZaNnumer { get; set; }

    public short? MaNZaNlp { get; set; }

    public byte? MaNTypZrd { get; set; }

    public int? MaNRokMiesiac { get; set; }

    public int? MaNFrmNumer { get; set; }

    public int? MaNZewnetrznySys { get; set; }

    public int? MaNZewnetrzneId { get; set; }

    public int? MaNLastMod { get; set; }

    public int? MaNDataOd { get; set; }

    public int? MaNDataDo { get; set; }

    public short? MaNSpeTyp { get; set; }

    public int? MaNSpeFirma { get; set; }

    public int? MaNSpeNumer { get; set; }

    public short? MaNSpeLp { get; set; }

    public int? MaNTrasaId { get; set; }

    public byte? MaNRealizacja { get; set; }

    public string? MaNSposobDostawy { get; set; }

    public byte? MaNPriorytet { get; set; }

    public byte? MaNStatus { get; set; }

    public byte? MaNWms { get; set; }

    public int? MaNDataZatwierdzenia { get; set; }

    public byte? MaNZrodlo { get; set; }

    public byte? MaNRezerwujZasoby { get; set; }

    public byte? MaNWmsdokWewn { get; set; }

    public byte? MaNWzwmpelneJpom { get; set; }

    public int? MaNKolejnoscZal { get; set; }

    public byte? MaNLaczPozycje { get; set; }

    public virtual ICollection<MaNopisy> MaNopisies { get; set; } = new List<MaNopisy>();

    public virtual ICollection<MagElem> MagElems { get; set; } = new List<MagElem>();
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class CrmkntEtapy
{
    public int CekId { get; set; }

    public short? CekCketyp { get; set; }

    public int? CekCkefirma { get; set; }

    public int? CekCkenumer { get; set; }

    public short? CekCkelp { get; set; }

    public short? CekKntTyp { get; set; }

    public int? CekKntFirma { get; set; }

    public int? CekKntNumer { get; set; }

    public short? CekKntLp { get; set; }

    public short? CekKntOsobaLp { get; set; }

    public short? CekSzansa { get; set; }

    public decimal? CekKwota { get; set; }

    public short? CekStatus { get; set; }

    public short? CekSaZadania { get; set; }

    public int? CekFiaskoId { get; set; }

    public int? CekDataStart { get; set; }

    public int? CekDataKoniec { get; set; }

    public int? CekTstampAkt { get; set; }

    public string? CekNotatki { get; set; }

    public string? CekUrl { get; set; }

    public short? CekOpeTyp { get; set; }

    public int? CekOpeFirma { get; set; }

    public int? CekOpeNumer { get; set; }

    public short? CekOpeLp { get; set; }

    public int? CekOpeNumerD { get; set; }

    public short? CekOpeTypM { get; set; }

    public int? CekOpeFirmaM { get; set; }

    public int? CekOpeNumerM { get; set; }

    public short? CekOpeLpM { get; set; }

    public short? CekAkwTyp { get; set; }

    public int? CekAkwFirma { get; set; }

    public int? CekAkwNumer { get; set; }

    public short? CekAkwLp { get; set; }

    public short? CekAkwOsobaLp { get; set; }

    public short? CekAkwLpKoniec { get; set; }

    public short? CekOpeTypA { get; set; }

    public int? CekOpeFirmaA { get; set; }

    public int? CekOpeNumerA { get; set; }

    public short? CekOpeLpA { get; set; }

    public int? CekDataAkcji { get; set; }

    public string? CekAkcja { get; set; }

    public short? CekAkcjaWykonana { get; set; }

    public short? CekNumerCyklu { get; set; }

    public short? CekCykliczna { get; set; }

    public short? CekCyklTyp { get; set; }

    public int? CekCyklKoniec { get; set; }

    public short? CekIloscCykli { get; set; }

    public short? CekInterwal { get; set; }

    public int? CekDataZakonczenia { get; set; }

    public byte? CekKopiujAtrybuty { get; set; }

    public int? CekCzkzrdId { get; set; }

    public byte? CekTerminarz { get; set; }

    public short? CekKnAtyp { get; set; }

    public int? CekKnAnumer { get; set; }

    public byte? CekPrzypomnienie { get; set; }

    public int? CekCzasPrzypomnienia { get; set; }

    public byte? CekCzasPrzypomnieniaJedn { get; set; }

    public byte? CekKopiujBinarne { get; set; }

    public decimal? CekPrzychodIlosc { get; set; }

    public int? CekAntId { get; set; }

    public int? CekAntZadId { get; set; }

    public decimal? CekKntKoszt { get; set; }

    public int? CekPrzeniesionyZ { get; set; }

    public int? CekTypKnt { get; set; }

    public byte? CekWyliczKwote { get; set; }

    public virtual ICollection<CrmkntEtapyTwr> CrmkntEtapyTwrs { get; set; } = new List<CrmkntEtapyTwr>();

    public virtual ICollection<SrsNag> CkwSsnNumers { get; set; } = new List<SrsNag>();
}

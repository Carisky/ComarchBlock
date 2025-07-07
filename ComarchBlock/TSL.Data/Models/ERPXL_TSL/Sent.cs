using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Sent
{
    public int SnTId { get; set; }

    public short? SnTRok { get; set; }

    public byte? SnTMiesiac { get; set; }

    public string? SnTSeria { get; set; }

    public int? SnTNumer { get; set; }

    public byte? SnTTyp { get; set; }

    public byte? SnTStatus { get; set; }

    public int? SnTFrsId { get; set; }

    public int? SnTDataWystawienia { get; set; }

    public int? SnTDataRozpoczeciaPrzewozu { get; set; }

    public string? SnTAdresKraj { get; set; }

    public string? SnTAdresMiasto { get; set; }

    public string? SnTAdresUlica { get; set; }

    public string? SnTAdresKodP { get; set; }

    public int? SnTKcnid { get; set; }

    public short? SnTKntGidTyp { get; set; }

    public int? SnTKntGidNumer { get; set; }

    public short? SnTKnaGidTyp { get; set; }

    public int? SnTKnaGidNumer { get; set; }

    public decimal? SnTIlosc { get; set; }

    public string? SnTJm { get; set; }

    public decimal? SnTMasa { get; set; }

    public string? SnTUwagi { get; set; }

    public string? SnTWypImie { get; set; }

    public string? SnTWypNazwisko { get; set; }

    public string? SnTWypEmail { get; set; }

    public int? SnTOpeWgidNumer { get; set; }

    public int? SnTOpeMgidNumer { get; set; }

    public int? SnTOpeZgidNumer { get; set; }

    public string? SnTNumerSent { get; set; }

    public string? SnTKluczW { get; set; }

    public string? SnTKluczO { get; set; }

    public string? SnTKluczP { get; set; }

    public string? SnTEmailPrzewoznika { get; set; }

    public int? SnTDataRejestracjizSent { get; set; }

    public int? SnTDataModyfikacjizSent { get; set; }

    public string? SnTKorelacja { get; set; }

    public string? SnTCheckSum { get; set; }

    public int? SnTIleWyslano { get; set; }

    public int? SnTIleOdebrano { get; set; }

    public string? SnTWojewodztwo { get; set; }

    public string? SnTDlugoscGeo { get; set; }

    public string? SnTSzerokoscGeo { get; set; }

    public decimal? SnTStawkaVat { get; set; }

    public byte? SnTFlagaVat { get; set; }

    public byte? SnTRodzajTransportu { get; set; }

    public virtual ICollection<SentElem> SentElems { get; set; } = new List<SentElem>();

    public virtual FrmStruktura? SnTFrs { get; set; }
}

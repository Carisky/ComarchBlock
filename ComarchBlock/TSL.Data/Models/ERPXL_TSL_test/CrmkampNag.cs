using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class CrmkampNag
{
    public short? CknGidtyp { get; set; }

    public int? CknGidfirma { get; set; }

    public int CknGidnumer { get; set; }

    public short? CknGidlp { get; set; }

    public string? CknNazwa { get; set; }

    public string? CknOpis { get; set; }

    public int? CknDataUtw { get; set; }

    public int? CknDataStart { get; set; }

    public int? CknDataKoniec { get; set; }

    public short? CknZakonczona { get; set; }

    public short? CknIleEtapow { get; set; }

    public string? CknUrl { get; set; }

    public short? CknJedenWatek { get; set; }

    public short? CknOpeTyp { get; set; }

    public int? CknOpeFirma { get; set; }

    public int? CknOpeNumer { get; set; }

    public short? CknOpeLp { get; set; }

    public int CknKategoria { get; set; }

    public byte? CknKopiujAtrybuty { get; set; }

    public short? CknRok { get; set; }

    public byte? CknMiesiac { get; set; }

    public string? CknSeria { get; set; }

    public int? CknNumer { get; set; }

    public int? CknFrsId { get; set; }

    public string? CknKod { get; set; }

    public int? CknOpeMnumer { get; set; }

    public int? CknWzNumer { get; set; }

    public decimal? CknPrzychodWartosc { get; set; }

    public decimal? CknPrzychodIlosc { get; set; }

    public decimal? CknKoszt { get; set; }

    public byte? CknWielokrotneDodawanie { get; set; }

    public short? CknTwrTyp { get; set; }

    public int? CknTwrNumer { get; set; }

    public byte? CknCykliczna { get; set; }

    public short? CknCyklTyp { get; set; }

    public int? CknCyklKoniec { get; set; }

    public short? CknIloscCykli { get; set; }

    public short? CknInterwal { get; set; }

    public byte? CknArchiwalny { get; set; }

    public int? CknRokMiesiac { get; set; }

    public int? CknAntId { get; set; }

    public int? CknDataZakonczenia { get; set; }

    public int? CknIloscProspekt { get; set; }

    public byte? CknWyliczPrzychod { get; set; }

    public byte? CknKontrolujIlosc { get; set; }

    public virtual ICollection<CrmkampEtapy> CrmkampEtapies { get; set; } = new List<CrmkampEtapy>();

    public virtual ICollection<CrmkampTwr> CrmkampTwrs { get; set; } = new List<CrmkampTwr>();

    public virtual ICollection<CrmzwiazaneKamp> CrmzwiazaneKampCzkCknnumerNavigations { get; set; } = new List<CrmzwiazaneKamp>();

    public virtual ICollection<CrmzwiazaneKamp> CrmzwiazaneKampCzkCknzwNumerNavigations { get; set; } = new List<CrmzwiazaneKamp>();
}

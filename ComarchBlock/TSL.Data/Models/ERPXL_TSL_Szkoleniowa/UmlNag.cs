using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class UmlNag
{
    public int UlnId { get; set; }

    public short? UlnUlntyp { get; set; }

    public short? UlnUlnrok { get; set; }

    public byte? UlnUlnmiesiac { get; set; }

    public string? UlnUlnseria { get; set; }

    public int? UlnUlnnumer { get; set; }

    public short? UlnUlnlp { get; set; }

    public string? UlnGrupaPod { get; set; }

    public decimal? UlnStawkaPod { get; set; }

    public byte? UlnFlagaVat { get; set; }

    public decimal? UlnZrodlowa { get; set; }

    public decimal? UlnAkcyza { get; set; }

    public int? UlnOpeWnumer { get; set; }

    public int? UlnOpeMnumer { get; set; }

    public int? UlnDataCzasW { get; set; }

    public int? UlnDataCzasM { get; set; }

    public int? UlnFrsid { get; set; }

    public string? UlnDokumentObcy { get; set; }

    public short? UlnPodmFinansTyp { get; set; }

    public int? UlnPodmFinansNumer { get; set; }

    public byte? UlnRodzajUmowy { get; set; }

    public int? UlnDataRozpoczecia { get; set; }

    public int? UlnDataZakonczenia { get; set; }

    public byte? UlnOkresRaty { get; set; }

    public byte? UlnPlatnosci { get; set; }

    public short? UlnIloscRat { get; set; }

    public decimal? UlnWartoscPrzedmiotu { get; set; }

    public decimal? UlnOplataWstKwota { get; set; }

    public decimal? UlnOplataWstProcent { get; set; }

    public decimal? UlnWartoscWykKwota { get; set; }

    public decimal? UlnWartoscWykProcent { get; set; }

    public decimal? UlnSumaRatNetto { get; set; }

    public byte? UlnStan { get; set; }

    public byte? UlnPodzRatyLeasingowej { get; set; }

    public byte? UlnUwzglElementyUm { get; set; }

    public byte? UlnMetodaPodzialu { get; set; }

    public int? UlnDataAneksu { get; set; }

    public string? UlnNrAneksu { get; set; }

    public string? UlnSrtAkronim { get; set; }

    public string? UlnOpis { get; set; }

    public int? UlnAktywny { get; set; }

    public byte? UlnAneksGenRaty { get; set; }

    public byte? UlnPierwszaRataNaliczanie { get; set; }

    public byte? UlnOdliczeniaVat { get; set; }

    public int? UlnOgraniczenieOdl { get; set; }

    public string? UlnWaluta { get; set; }

    public short? UlnNrKursu { get; set; }

    public decimal? UlnKursM { get; set; }

    public decimal? UlnKursL { get; set; }

    public decimal? UlnWartoscPrzedmiotuSys { get; set; }

    public decimal? UlnOplataWstKwotaSys { get; set; }

    public decimal? UlnWartoscWykKwotaSys { get; set; }

    public decimal? UlnSumaRatNettoSys { get; set; }

    public byte? UlnGenerujRk { get; set; }

    public byte? UlnPodstawaNaliczaniaRk { get; set; }

    public decimal? UlnWartoscGodziwa { get; set; }

    public byte? UlnPrzeliczonoIrr { get; set; }

    public virtual ICollection<UmlPrzedmioty> UmlPrzedmioties { get; set; } = new List<UmlPrzedmioty>();

    public virtual ICollection<UmlRaty> UmlRaties { get; set; } = new List<UmlRaty>();
}

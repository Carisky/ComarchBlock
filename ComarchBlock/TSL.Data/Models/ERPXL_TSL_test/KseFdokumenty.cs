using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KseFdokumenty
{
    public int KsfId { get; set; }

    public short? KsfDokTyp { get; set; }

    public int? KsfDokNumer { get; set; }

    public byte? KsfStatus { get; set; }

    public string? KsfNumer { get; set; }

    public int? KsfTstampWyslania { get; set; }

    public int? KsfOpeWys { get; set; }

    public int? KsfTstampPrzyjecia { get; set; }

    public int? KsfTstampUpo { get; set; }

    public int? KsfOpeUpo { get; set; }

    public string? KsfNrRefSesji { get; set; }

    public string? KsfNrRefDokumentu { get; set; }

    public byte? KsfTypOperacji { get; set; }

    public string? KsfRodzajFaktury { get; set; }

    public string? KsfNipnabywcy { get; set; }

    public string? KsfNipsprzedawcy { get; set; }

    public string? KsfNazwaSprzedawcy { get; set; }

    public string? KsfDokumentObcy { get; set; }

    public decimal? KsfNetto { get; set; }

    public decimal? KsfVat { get; set; }

    public string? KsfWaluta { get; set; }

    public string? KsfOpis { get; set; }

    public byte? KsfOdrzucony { get; set; }

    public int? KsfFrsId { get; set; }

    public byte? KsfKwalifikacja { get; set; }

    public string? KsfStatusWysylki { get; set; }

    public string? KsfUlicaSprzedawcy { get; set; }

    public string? KsfNrDomuSprzedawcy { get; set; }

    public string? KsfNrLokaluSprzedawcy { get; set; }

    public string? KsfMiejscowoscSprzedawcy { get; set; }

    public string? KsfKodPocztowySprzedawcy { get; set; }

    public string? KsfPocztaSprzedawcy { get; set; }
}

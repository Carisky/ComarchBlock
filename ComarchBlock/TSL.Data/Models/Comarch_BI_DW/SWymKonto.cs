using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class SWymKonto
{
    public int KontoId { get; set; }

    public int? KontoParId { get; set; }

    public int? KontoPoprzednikId { get; set; }

    public string? KontoOrgId { get; set; }

    public string? KontoOrgParId { get; set; }

    public string? KontoOrgAtrId { get; set; }

    public int? KontoWymTyp { get; set; }

    public int? KontoWymFirma { get; set; }

    public int? KontoAktywny { get; set; }

    public string? KontoAktualneOrgId { get; set; }

    public string? KontoAktualneOrgParId { get; set; }

    public int? KontoDataOd { get; set; }

    public int? KontoDataDo { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadDeleteId { get; set; }

    public string? KontoNumer { get; set; }

    public string? KontoNazwa { get; set; }

    public string? KontoNazwaDodatkowa { get; set; }

    public string? KontoKntOrgId { get; set; }

    public string? KontoTyp { get; set; }

    public string? KontoTypOgolny { get; set; }

    public string? KontoRozrachunkowe { get; set; }

    public int? KontoPozabilansowe { get; set; }

    public string? KontoAnalityczne { get; set; }

    public string? KontoKlasa { get; set; }

    public string? KontoSaldoDwustronnie { get; set; }

    public string? KontoWaluta { get; set; }

    public string? KontoLisc { get; set; }
}

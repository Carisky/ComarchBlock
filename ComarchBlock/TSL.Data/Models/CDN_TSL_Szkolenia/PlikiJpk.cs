using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PlikiJpk
{
    public int JpkJpkid { get; set; }

    public int JpkProcessState { get; set; }

    public int? JpkMode { get; set; }

    public int? JpkSourceJpkId { get; set; }

    public string? JpkKodOsoby { get; set; }

    public string JpkTyp { get; set; } = null!;

    public string JpkNazwa { get; set; } = null!;

    public DateTime JpkDataUtworzenia { get; set; }

    public int JpkCelZlozenia { get; set; }

    public int JpkWariantFormularza { get; set; }

    public byte[]? JpkXml { get; set; }

    public string? JpkRefNr { get; set; }

    public string JpkPath { get; set; } = null!;

    public int? JpkStatus { get; set; }

    public int? JpkStatusCode { get; set; }

    public string? JpkStatusOpis { get; set; }

    public string? JpkKodUrzedu { get; set; }

    public string? JpkDataWyslania { get; set; }

    public string? JpkDataWplyniecia { get; set; }

    public string? JpkKodOsobyOdbierajacej { get; set; }

    public string? JpkDataOdebrania { get; set; }

    public string? JpkSkrotDokumentu { get; set; }

    public string? JpkSkrotStruktury { get; set; }

    public string? JpkStrukturaLogiczna { get; set; }

    public string? JpkStempelCzasu { get; set; }

    public string? JpkSigningTime { get; set; }

    public string? JpkNazwaPodmiotu { get; set; }

    public string? JpkNip1 { get; set; }

    public DateTime? JpkOkresOd { get; set; }

    public DateTime? JpkOkresDo { get; set; }

    public int? JpkJpkscaId { get; set; }

    public int JpkRodzajWysylki { get; set; }

    public byte[]? JpkPodpisanyXml { get; set; }

    public string? JpkSciezkaPodpisanegoPliku { get; set; }

    public int JpkTypWysylki { get; set; }

    public int? JpkDkNid { get; set; }

    public int? JpkJpkNagId { get; set; }

    public int? JpkRok { get; set; }

    public int? JpkMiesiac { get; set; }

    public int? JpkKwartalna { get; set; }

    public string? JpkKodSystemowy { get; set; }

    public string? JpkKodFormularza { get; set; }

    public string? JpkWersjaSchemy { get; set; }

    public int? JpkSprzedaz { get; set; }

    public int? JpkZakup { get; set; }

    public int? JpkDeklaracja { get; set; }

    public int? JpkEwidencja { get; set; }

    public string? JpkKodFormularzaDekl { get; set; }

    public string? JpkWersjaSchemyDekl { get; set; }

    public string? JpkKodSystemowyDekl { get; set; }
}

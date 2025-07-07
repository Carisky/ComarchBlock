using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Raporty
{
    public short? KrpGidtyp { get; set; }

    public int? KrpGidfirma { get; set; }

    public int KrpGidnumer { get; set; }

    public short? KrpGidlp { get; set; }

    public short? KrpRok { get; set; }

    public string? KrpSeria { get; set; }

    public short? KrpNumer { get; set; }

    public int? KrpDataOtwarcia { get; set; }

    public int? KrpDataZamkniecia { get; set; }

    public string? KrpWaluta { get; set; }

    public decimal? KrpKursL { get; set; }

    public decimal? KrpKursM { get; set; }

    public decimal? KrpStanPocz { get; set; }

    public decimal? KrpPrzychody { get; set; }

    public decimal? KrpRozchody { get; set; }

    public decimal? KrpPrzychodyRk { get; set; }

    public decimal? KrpRozchodyRk { get; set; }

    public decimal? KrpStanPoczWal { get; set; }

    public decimal? KrpPrzychodyWal { get; set; }

    public decimal? KrpRozchodyWal { get; set; }

    public decimal? KrpStanPoczWp { get; set; }

    public decimal? KrpPrzychodyWp { get; set; }

    public decimal? KrpRozchodyWp { get; set; }

    public decimal? KrpPrzychodyWprk { get; set; }

    public decimal? KrpRozchodyWprk { get; set; }

    public decimal? KrpStanPoczWpwal { get; set; }

    public decimal? KrpPrzychodyWpwal { get; set; }

    public decimal? KrpRozchodyWpwal { get; set; }

    public decimal? KrpRoznicaNaliczona { get; set; }

    public decimal? KrpSumaRoznicNal { get; set; }

    public byte? KrpZaksiegowano { get; set; }

    public byte? KrpNieKsiegowac { get; set; }

    public int? KrpDataKsiegowania { get; set; }

    public int? KrpNrWyciagu { get; set; }

    public string? KrpWyciagBankowy { get; set; }

    public short? KrpOpetypZam { get; set; }

    public int? KrpOpefirmaZam { get; set; }

    public int? KrpOpenumerZam { get; set; }

    public short? KrpOpelpZam { get; set; }

    public short? KrpOpetypKs { get; set; }

    public int? KrpOpefirmaKs { get; set; }

    public int? KrpOpenumerKs { get; set; }

    public short? KrpOpelpKs { get; set; }

    public short? KrpStaTyp { get; set; }

    public int? KrpStaFirma { get; set; }

    public int? KrpStaNumer { get; set; }

    public short? KrpStaLp { get; set; }

    public short? KrpNrKursu { get; set; }

    public int? KrpZewnetrznyId { get; set; }

    public int? KrpCzasModyfikacji { get; set; }

    public int? KrpCzasOtwarcia { get; set; }

    public int? KrpCzasZamkniecia { get; set; }

    public byte? KrpRaportBo { get; set; }

    public byte? KrpKsiegujWbo { get; set; }

    public byte? KrpNieRozliczaj { get; set; }

    public int? KrpZewnetrznySys { get; set; }

    public int? KrpPropDataZam { get; set; }

    public int? KrpPropDataCzasZam { get; set; }

    public string? KrpGuid { get; set; }

    public virtual Rejestry? KrpSeriaNavigation { get; set; }
}

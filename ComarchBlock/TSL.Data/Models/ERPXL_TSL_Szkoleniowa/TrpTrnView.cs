using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TrpTrnView
{
    public short TtvGidtyp { get; set; }

    public int TtvGidnumer { get; set; }

    public short TtvGidlp { get; set; }

    public short? TtvKntTyp { get; set; }

    public int? TtvKntNumer { get; set; }

    public short? TtvTyp { get; set; }

    public decimal? TtvKwota { get; set; }

    public decimal? TtvPozostaje { get; set; }

    public string? TtvWaluta { get; set; }

    public short? TtvNrKursu { get; set; }

    public byte? TtvFormaNr { get; set; }

    public int? TtvTermin { get; set; }

    public int? TtvData { get; set; }

    public string? TtvSeria { get; set; }

    public string? TtvDokument { get; set; }

    public string? TtvDokumentObcy { get; set; }

    public byte? TtvBosDc { get; set; }

    public decimal? TtvBoskwota { get; set; }

    public byte? TtvRozliczona { get; set; }

    public int? TtvAktywny { get; set; }

    public byte? TtvZaksiegowano { get; set; }

    public short? TtvStan { get; set; }

    public short? TtvLp { get; set; }

    public byte? TtvStatus { get; set; }

    public short? TtvTrpstatus { get; set; }

    public byte? TtvNieKsiegowac { get; set; }
}

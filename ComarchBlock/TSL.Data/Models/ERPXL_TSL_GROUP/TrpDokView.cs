using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class TrpDokView
{
    public short TrdvGidtyp { get; set; }

    public int? TrdvGidfirma { get; set; }

    public int TrdvGidnumer { get; set; }

    public short TrdvGidlp { get; set; }

    public decimal? TrdvKwota { get; set; }

    public decimal? TrdvPozostaje { get; set; }

    public byte? TrdvRozliczona { get; set; }

    public int? TrdvTermin { get; set; }

    public string? TrdvWaluta { get; set; }

    public short? TrdvKntTyp { get; set; }

    public int? TrdvKntFirma { get; set; }

    public int? TrdvKntNumer { get; set; }

    public short? TrdvKntLp { get; set; }

    public short? TrdvTyp { get; set; }

    public int? TrdvTrnTyp { get; set; }

    public int? TrdvTrnRok { get; set; }

    public string? TrdvTrnSeria { get; set; }

    public int? TrdvTrnNumer { get; set; }

    public int? TrdvTrnLp { get; set; }

    public int? TrdvSpiTyp { get; set; }

    public int? TrdvData { get; set; }

    public int? TrdvZaksiegowano { get; set; }

    public int? TrdvAktywny { get; set; }

    public int? TrdvStan { get; set; }

    public decimal? TrdvKursL { get; set; }

    public decimal? TrdvKursM { get; set; }

    public decimal? TrdvKwotaSys { get; set; }

    public decimal? TrdvPozostajeSys { get; set; }
}

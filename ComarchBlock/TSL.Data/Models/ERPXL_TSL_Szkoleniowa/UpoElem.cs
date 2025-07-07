using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class UpoElem
{
    public short? UpeGidtyp { get; set; }

    public int? UpeGidfirma { get; set; }

    public int UpeGidnumer { get; set; }

    public short UpeGidlp { get; set; }

    public short? UpeDniZwloki { get; set; }

    public decimal? UpeProcOds { get; set; }

    public decimal? UpeKwotaZal { get; set; }

    public decimal? UpeKwotaOds { get; set; }

    public decimal? UpePozostaje { get; set; }

    public short? UpeTrPtyp { get; set; }

    public int? UpeTrPfirma { get; set; }

    public int? UpeTrPnumer { get; set; }

    public short? UpeTrPlp { get; set; }

    public short? UpeStopien { get; set; }

    public short? UpeNumer { get; set; }

    public short? UpeRozTyp { get; set; }

    public int? UpeRozFirma { get; set; }

    public int? UpeRozNumer { get; set; }

    public short? UpeRozLp { get; set; }

    public string? UpeWaluta { get; set; }

    public short? UpeNrKursu { get; set; }

    public decimal? UpeKursM { get; set; }

    public decimal? UpeKursL { get; set; }

    public decimal? UpeKwotaOdsSys { get; set; }

    public short? UpeNazwyLp { get; set; }

    public virtual TraPlat? TraPlat { get; set; }

    public virtual UpoNag UpeGidnumerNavigation { get; set; } = null!;
}

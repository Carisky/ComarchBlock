using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Kbnelem
{
    public int KbneKbnnid { get; set; }

    public short KbneLp { get; set; }

    public short? KbneRwtyp { get; set; }

    public int? KbneRwfirma { get; set; }

    public int? KbneRwnumer { get; set; }

    public short? KbneRwlp { get; set; }

    public short? KbnePwtyp { get; set; }

    public int? KbnePwfirma { get; set; }

    public int? KbnePwnumer { get; set; }

    public short? KbnePwlp { get; set; }

    public decimal? KbneIlosc { get; set; }

    public decimal? KbneCenaRw { get; set; }

    public decimal? KbneWartoscRw { get; set; }

    public int? KbneMagNumerRw { get; set; }

    public decimal? KbneCenaPw { get; set; }

    public decimal? KbneWartoscPw { get; set; }

    public int? KbneMagNumerPw { get; set; }

    public byte? KbneZawiniony { get; set; }

    public decimal? KbneRoznica { get; set; }

    public decimal? KbneCena { get; set; }

    public decimal? KbneWartosc { get; set; }

    public virtual Kbnnag KbneKbnn { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ImtArkuszeElem
{
    public int IaeItaid { get; set; }

    public short IaeLp { get; set; }

    public int? IaeSrtNumer { get; set; }

    public string? IaeMiejsceEwidencja { get; set; }

    public string? IaeMiejsceSpis { get; set; }

    public int? IaePrcNumerEwidencja { get; set; }

    public int? IaePrcNumerSpis { get; set; }

    public byte? IaeIloscSpis { get; set; }

    public byte? IaeIloscEwidencja { get; set; }

    public decimal? IaeWartoscPoczatkowa { get; set; }

    public decimal? IaeWartoscBrutto { get; set; }

    public decimal? IaeWartoscNetto { get; set; }

    public decimal? IaeWartoscPoczatkowaSys { get; set; }

    public decimal? IaeWartoscBruttoSys { get; set; }

    public decimal? IaeWartoscNettoSys { get; set; }

    public string? IaeWaluta { get; set; }

    public string? IaeUwagi { get; set; }

    public virtual ImtArkusze IaeIta { get; set; } = null!;

    public virtual SrtKarty? IaeSrtNumerNavigation { get; set; }
}

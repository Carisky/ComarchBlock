using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KgtWartoscParametrDlaTowaru
{
    public int KwptId { get; set; }

    public string? KwptWartosc { get; set; }

    public string? KwptIdWartosci { get; set; }

    public int? KwptTwrNumer { get; set; }

    public int? KwptParametrKategoriiId { get; set; }

    public virtual KgtParametryKategorii? KwptParametrKategorii { get; set; }

    public virtual TwrKarty? KwptTwrNumerNavigation { get; set; }
}

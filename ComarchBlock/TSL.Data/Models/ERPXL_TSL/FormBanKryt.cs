using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class FormBanKryt
{
    public int FbkId { get; set; }

    public int? FbkFbnid { get; set; }

    public int? FbkFbeid { get; set; }

    public byte? FbkOperatorLog { get; set; }

    public byte? FbkOperator { get; set; }

    public string? FbkWartosc { get; set; }

    public byte? FbkRodzaj { get; set; }

    public virtual FormBanElem? FbkFbe { get; set; }
}

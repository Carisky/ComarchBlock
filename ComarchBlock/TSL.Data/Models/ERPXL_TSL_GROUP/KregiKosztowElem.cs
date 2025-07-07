using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class KregiKosztowElem
{
    public int KkeKknid { get; set; }

    public short KkeLp { get; set; }

    public string? KkeNazwa { get; set; }

    public string? KkeMaskaKonta { get; set; }

    public string? KkeFiltr { get; set; }

    public byte? KkeStronaPrzeciwna { get; set; }

    public virtual KregiKosztowNag KkeKkn { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KonfProdNag
{
    public int KpnId { get; set; }

    public short? KpnDokTyp { get; set; }

    public int? KpnDokFirma { get; set; }

    public int? KpnDokNumer { get; set; }

    public short? KpnDokLp { get; set; }

    public short? KpnTwGtyp { get; set; }

    public int? KpnTwGnumer { get; set; }

    public int? KpnKtpid { get; set; }

    public short? KpnPrdTyp { get; set; }

    public int? KpnPrdNumer { get; set; }

    public int? KpnPteid { get; set; }

    public int? KpnCzasModyfikacji { get; set; }

    public int? KpnOpeNumerM { get; set; }

    public virtual ICollection<KonfProdElem> KonfProdElems { get; set; } = new List<KonfProdElem>();
}

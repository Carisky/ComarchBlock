using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdParametryKj
{
    public int PkjId { get; set; }

    public string? PkjKod { get; set; }

    public string? PkjNazwa { get; set; }

    public int? PkjLp { get; set; }

    public int? PkjOpeW { get; set; }

    public int? PkjDataW { get; set; }

    public int? PkjOpeM { get; set; }

    public int? PkjDataM { get; set; }

    public byte? PkjArchiwalny { get; set; }

    public byte? PkjTyp { get; set; }

    public string? PkjFormat { get; set; }

    public byte? PkjZamknieta { get; set; }

    public virtual ICollection<ProdParamKjnormyObiektow> ProdParamKjnormyObiektows { get; set; } = new List<ProdParamKjnormyObiektow>();
}

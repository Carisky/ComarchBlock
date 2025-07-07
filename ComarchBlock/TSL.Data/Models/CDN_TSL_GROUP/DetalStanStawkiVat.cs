using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DetalStanStawkiVat
{
    public int DssvatDssvatid { get; set; }

    public int DssvatStanDetalId { get; set; }

    public decimal DssvatStawka { get; set; }

    public short DssvatFlaga { get; set; }

    public string DssvatDfsymbol { get; set; } = null!;
}

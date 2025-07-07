using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DmKoszykZakupowSprzedaz
{
    public int SprProdId { get; set; }

    public int SprDokNumerId { get; set; }

    public string SprProdNazwa { get; set; } = null!;
}

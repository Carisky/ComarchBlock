using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Miastum
{
    public int MstMstId { get; set; }

    public string MstNazwa { get; set; } = null!;

    public short? MstWojewodztwo { get; set; }

    public short? MstPowiat { get; set; }

    public short? MstGmina { get; set; }
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class AtstLogKrotki
{
    public int AtlkId { get; set; }

    public string? AtlkData { get; set; }

    public int? AtlkCzas { get; set; }

    public byte? AtlkTypOperacji { get; set; }

    public short? AtlkTypDokumentu { get; set; }

    public short? AtlkTypDokumentZrodlo { get; set; }

    public short? AtlkBlad { get; set; }

    public int? AtlkCzasWystawiania { get; set; }
}

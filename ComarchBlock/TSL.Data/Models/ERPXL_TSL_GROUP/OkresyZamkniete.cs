using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class OkresyZamkniete
{
    public int OzaId { get; set; }

    public int? OzaDataOd { get; set; }

    public int? OzaDataDo { get; set; }

    public int? OzaDataZamkniecia { get; set; }

    public byte? OzaStan { get; set; }

    public short? OzaOpeZtyp { get; set; }

    public int? OzaOpeZfirma { get; set; }

    public int? OzaOpeZnumer { get; set; }

    public short? OzaOpeZlp { get; set; }
}

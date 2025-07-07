using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Wolne
{
    public int? WolGidfirma { get; set; }

    public short WolTyp { get; set; }

    public short WolRok { get; set; }

    public int WolMagNumer { get; set; }

    public short WolMiesiac { get; set; }

    public string WolSeria { get; set; } = null!;

    public int WolDataOd { get; set; }

    public int? WolDataDo { get; set; }

    public int WolNumerOd { get; set; }

    public int? WolNumerDo { get; set; }
}

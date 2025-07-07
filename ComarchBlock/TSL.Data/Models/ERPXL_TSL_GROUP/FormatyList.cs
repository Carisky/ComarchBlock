using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class FormatyList
{
    public string FlsModul { get; set; } = null!;

    public string FlsProcedura { get; set; } = null!;

    public int FlsIdoperatora { get; set; }

    public short FlsIdkontrolki { get; set; }

    public short FlsIdformatu { get; set; }

    public string? FlsNazwaFormatu { get; set; }

    public byte? FlsFlaga { get; set; }

    public string? FlsFormat { get; set; }

    public string? FlsVarLine { get; set; }
}

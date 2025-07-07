using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class OpisWarunki
{
    public short OwrTabela { get; set; }

    public byte? OwrCzyWarunek { get; set; }

    public string? OwrWarunek { get; set; }

    public byte? OwrCzyProcedura { get; set; }

    public string? OwrProcedura { get; set; }

    public byte? OwrAlternatywy { get; set; }
}

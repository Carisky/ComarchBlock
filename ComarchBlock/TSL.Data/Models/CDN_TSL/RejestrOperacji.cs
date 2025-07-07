using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class RejestrOperacji
{
    public long RopRopid { get; set; }

    public int RopObiektTyp { get; set; }

    public int? RopObiektSubTyp { get; set; }

    public int? RopObiektId { get; set; }

    public string? RopObiektNazwa { get; set; }

    public DateTime RopData { get; set; }

    public string? RopOperator { get; set; }

    public int RopOperacjaTyp { get; set; }

    public string? RopOpis { get; set; }
}

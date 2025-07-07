using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KodyJpkv7
{
    public int Kv7Kv7id { get; set; }

    public string Kv7Kod { get; set; } = null!;

    public string Kv7Opis { get; set; } = null!;

    public int Kv7Rodzaj { get; set; }

    public int Kv7Typ { get; set; }

    public string Kv7ZjeId { get; set; } = null!;

    public DateTime Kv7OkresOd { get; set; }

    public DateTime Kv7OkresDo { get; set; }
}

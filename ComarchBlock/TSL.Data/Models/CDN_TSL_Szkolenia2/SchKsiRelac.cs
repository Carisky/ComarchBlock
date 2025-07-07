using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class SchKsiRelac
{
    public int SkrSkrid { get; set; }

    public int SkrSknid { get; set; }

    public int? SkrSknrelId { get; set; }

    public short SkrLp { get; set; }

    public virtual SchKsiNag SkrSkn { get; set; } = null!;

    public virtual SchKsiNag? SkrSknrel { get; set; }
}

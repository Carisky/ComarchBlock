using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AnkWzorzecAnkietyAnkietowani
{
    public int AnkWaAAnkWaAid { get; set; }

    public int AnkWaAAnkWaNid { get; set; }

    public int AnkWaALp { get; set; }

    public short AnkWaAPodmiotTyp { get; set; }

    public int AnkWaAPodId { get; set; }

    public int? AnkWaAOsobaId { get; set; }

    public string AnkWaAOsobaNazwisko { get; set; } = null!;

    public string AnkWaAOsobaTelefon { get; set; } = null!;

    public string AnkWaAKntKod { get; set; } = null!;

    public string AnkWaAKntNazwa { get; set; } = null!;

    public virtual AnkWzorzecAnkietyNag AnkWaAAnkWaN { get; set; } = null!;
}

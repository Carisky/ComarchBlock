using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class SentHistorium
{
    public int SentHSentHid { get; set; }

    public int SentHSentId { get; set; }

    public string SentHKorelacja { get; set; } = null!;

    public string SentHCheckSum { get; set; } = null!;

    public DateTime SentHModificationDate { get; set; }

    public int SentHSentTyp { get; set; }

    public int SentHRodzaj { get; set; }

    public int SentHStatus { get; set; }

    public DateTime SentHDataOperacji { get; set; }

    public string SentHPlik { get; set; } = null!;

    public string SentHOpis { get; set; } = null!;

    public int? SentHOpeId { get; set; }

    public string SentHOpeKod { get; set; } = null!;

    public string SentHOpeNazwisko { get; set; } = null!;

    public virtual SentZgloszenium SentHSent { get; set; } = null!;
}

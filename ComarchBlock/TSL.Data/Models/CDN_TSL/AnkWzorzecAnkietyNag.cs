using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class AnkWzorzecAnkietyNag
{
    public int AnkWaNAnkWaNid { get; set; }

    public string AnkWaNKod { get; set; } = null!;

    public string AnkWaNNazwa { get; set; } = null!;

    public string AnkWaNOpis { get; set; } = null!;

    public byte AnkWaNNieaktywny { get; set; }

    public int? AnkWaNOpeZalId { get; set; }

    public int? AnkWaNStaZalId { get; set; }

    public DateTime AnkWaNTsZal { get; set; }

    public int? AnkWaNOpeModId { get; set; }

    public int? AnkWaNStaModId { get; set; }

    public DateTime AnkWaNTsMod { get; set; }

    public string AnkWaNOpeModKod { get; set; } = null!;

    public string AnkWaNOpeModNazwisko { get; set; } = null!;

    public string AnkWaNOpeZalKod { get; set; } = null!;

    public string AnkWaNOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<AnkWzorzecAnkietyAnkietowani> AnkWzorzecAnkietyAnkietowanis { get; set; } = new List<AnkWzorzecAnkietyAnkietowani>();

    public virtual ICollection<AnkWzorzecAnkietyPyt> AnkWzorzecAnkietyPyts { get; set; } = new List<AnkWzorzecAnkietyPyt>();
}

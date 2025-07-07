using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class AnkWzorzecAnkietyPyt
{
    public int AnkWaPAnkWaPid { get; set; }

    public int AnkWaPAnkWaNid { get; set; }

    public int AnkWaPLp { get; set; }

    public string AnkWaPTresc { get; set; } = null!;

    public string AnkWaPOpis { get; set; } = null!;

    public byte AnkWaPTypPytania { get; set; }

    public byte AnkWaPFormatPytOtwartego { get; set; }

    public byte AnkWaPWielokrotnyWybor { get; set; }

    public int? AnkWaPAnkSonId { get; set; }

    public int AnkWaPWaga { get; set; }

    public byte AnkWaPOdpWymagana { get; set; }

    public byte AnkWaPNieaktywne { get; set; }

    public int? AnkWaPAnkSpId { get; set; }

    public int AnkWaPAnkGpId { get; set; }

    public int AnkWaPGpTreeId { get; set; }

    public int AnkWaPGpParentId { get; set; }

    public int AnkWaPGpParentLp { get; set; }

    public virtual AnkWzorzecAnkietyNag AnkWaPAnkWaN { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class AnkAnkietyPyt
{
    public int AnkAnPAnkAnPid { get; set; }

    public int AnkAnPAnkAnNid { get; set; }

    public int AnkAnPLp { get; set; }

    public string AnkAnPTresc { get; set; } = null!;

    public string AnkAnPOpis { get; set; } = null!;

    public byte AnkAnPTypPytania { get; set; }

    public byte AnkAnPFormatPytOtwartego { get; set; }

    public byte AnkAnPWielokrotnyWybor { get; set; }

    public int? AnkAnPAnkSonId { get; set; }

    public int AnkAnPWaga { get; set; }

    public byte AnkAnPOdpWymagana { get; set; }

    public byte AnkAnPNieaktywne { get; set; }

    public int? AnkAnPOdpowiedzWyb { get; set; }

    public string? AnkAnPOdpowiedz { get; set; }

    public short AnkAnPWypelniajacyTyp { get; set; }

    public int AnkAnPWypelniajacyId { get; set; }

    public int? AnkAnPAnkSpId { get; set; }

    public int AnkAnPAnkGpId { get; set; }

    public int AnkAnPGpTreeId { get; set; }

    public int AnkAnPGpParentId { get; set; }

    public int AnkAnPGpParentLp { get; set; }

    public decimal AnkAnPPunktyZaOdp { get; set; }

    public virtual AnkAnkietyNag AnkAnPAnkAnN { get; set; } = null!;

    public virtual ICollection<AnkAnkietyOdp> AnkAnkietyOdps { get; set; } = new List<AnkAnkietyOdp>();
}

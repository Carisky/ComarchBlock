using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class KntEsklepyPrzedstawiciele
{
    public int KespKespid { get; set; }

    public int KespKntId { get; set; }

    public int KespPrzedstawicielId { get; set; }

    public int KespESklepId { get; set; }

    public byte KespDomyslny { get; set; }

    public byte KespNieAktywny { get; set; }

    public int KespPrzedstawicieleSklepId { get; set; }

    public string KespEmail { get; set; } = null!;

    public string KespNazwisko { get; set; } = null!;

    public virtual ESklepStanowiska KespESklep { get; set; } = null!;

    public virtual Kontrahenci KespKnt { get; set; } = null!;
}

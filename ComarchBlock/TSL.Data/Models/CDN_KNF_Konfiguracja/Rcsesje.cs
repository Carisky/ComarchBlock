using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Rcsesje
{
    public int RcsRcsid { get; set; }

    public int RcsOpeId { get; set; }

    public int RcsStaId { get; set; }

    public int RcsBazId { get; set; }

    public int RcsRckid { get; set; }

    public DateTime RcsTsStart { get; set; }

    public DateTime RcsTsStop { get; set; }

    public byte RcsAktywna { get; set; }

    public byte RcsReczna { get; set; }

    public virtual Bazy RcsBaz { get; set; } = null!;

    public virtual Operatorzy RcsOpe { get; set; } = null!;

    public virtual Rckategorie RcsRck { get; set; } = null!;

    public virtual StanowiskaKomp RcsSta { get; set; } = null!;
}

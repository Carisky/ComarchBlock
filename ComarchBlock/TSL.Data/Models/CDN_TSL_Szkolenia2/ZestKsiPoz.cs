using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ZestKsiPoz
{
    public int ZkpZkpid { get; set; }

    public int? ZkpSfid { get; set; }

    public int ZkpZknid { get; set; }

    public int? ZkpParId { get; set; }

    public string ZkpNumeracja { get; set; } = null!;

    public int ZkpLp { get; set; }

    public string ZkpNazwa { get; set; } = null!;

    public short ZkpZnak { get; set; }

    public string ZkpDefinicja { get; set; } = null!;

    public byte ZkpBrakKontroli { get; set; }

    public short ZkpPoziom { get; set; }

    public byte ZkpLisc { get; set; }

    public string? ZkpNumer { get; set; }

    public string? ZkpSegment { get; set; }

    public virtual ICollection<ZestKsiPoz> InverseZkpPar { get; set; } = new List<ZestKsiPoz>();

    public virtual ICollection<ZestawieniaKontum> ZestawieniaKonta { get; set; } = new List<ZestawieniaKontum>();

    public virtual ZestKsiPoz? ZkpPar { get; set; }

    public virtual ZestKsiNag ZkpZkn { get; set; } = null!;
}

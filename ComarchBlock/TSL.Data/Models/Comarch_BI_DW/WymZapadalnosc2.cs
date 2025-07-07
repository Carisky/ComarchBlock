using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymZapadalnosc2
{
    public int? Zap2TypId { get; set; }

    public int Zap2RowId { get; set; }

    public int Zap2Id { get; set; }

    public int Zap2Zrodgid { get; set; }

    public string Zap2OrgId { get; set; } = null!;

    public string Zap2DirtyOrgId { get; set; } = null!;

    public string Zap2Nazwa { get; set; } = null!;

    public string? Zap2Opis { get; set; }

    public string? Zap2ParDirtyOrgId { get; set; }

    public string? Zap2ParCleanOrgId { get; set; }

    public int? Zap2ParGid { get; set; }

    public DateTime Zap2Tsinsert { get; set; }

    public DateTime Zap2Tsupdate { get; set; }

    public DateTime Zap2TimeFrom { get; set; }

    public DateTime? Zap2TimeTo { get; set; }

    public int? Zap2ChecksumKimball1 { get; set; }

    public int? Zap2ChecksumKimball2 { get; set; }

    public int? Zap2UpdateTransformationId { get; set; }

    public int? Zap2UpdateSubTransformationId { get; set; }

    public int? Zap2InsertTransformationId { get; set; }

    public int? Zap2InsertSubTransformationId { get; set; }

    public byte[] Zap2RowVersion { get; set; } = null!;

    public int? Zap2Od { get; set; }

    public int? Zap2Do { get; set; }

    public string? Zap2TypOrgId { get; set; }

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual WymZapadalnoscTyp? Zap2Typ { get; set; }

    public virtual WymZrodloDanych Zap2Zrodg { get; set; } = null!;
}

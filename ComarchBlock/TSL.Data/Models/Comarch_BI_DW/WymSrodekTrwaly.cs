using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Wymiar przechowujący środki trwałe z systemu.
/// </summary>
public partial class WymSrodekTrwaly
{
    public int SrtRowId { get; set; }

    public int SrtId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int SrtZrodgid { get; set; }

    public string SrtOrgId { get; set; } = null!;

    public string SrtDirtyOrgId { get; set; } = null!;

    public string SrtNazwa { get; set; } = null!;

    public string? SrtOpis { get; set; }

    public string? SrtParDirtyOrgId { get; set; }

    public string? SrtParCleanOrgId { get; set; }

    public int? SrtParGid { get; set; }

    public DateTime SrtTsinsert { get; set; }

    public DateTime SrtTsupdate { get; set; }

    public DateTime SrtTimeFrom { get; set; }

    public DateTime? SrtTimeTo { get; set; }

    public int SrtChecksumKimball1 { get; set; }

    public int SrtChecksumKimball2 { get; set; }

    public int SrtUpdateSubTransformationId { get; set; }

    public int? SrtUpdateTransformationId { get; set; }

    public int SrtInsertSubTransformationId { get; set; }

    public int? SrtInsertTransformationId { get; set; }

    public byte[] SrtRowVersion { get; set; } = null!;

    public string? SrtKsiega { get; set; }

    public string? SrtNrInw { get; set; }

    public string? SrtNrEwid { get; set; }

    public string? SrtAkronim { get; set; }

    public string? SrtRodzaj { get; set; }

    public string? SrtKrst { get; set; }

    public string? SrtMiejsceUzyw { get; set; }

    public string? SrtGrupa { get; set; }

    public string? SrtMetodaAp { get; set; }

    public string? SrtMetodaAb { get; set; }

    public string? SrtRodzajZak { get; set; }

    public string? SrtSposobLikw { get; set; }

    public int SrtDataEksp { get; set; }

    public string? SrtZlikw { get; set; }

    public int SrtDataLikw { get; set; }

    public string? SrtKontoGl { get; set; }

    public string? SrtKontoUm { get; set; }

    public string? SrtKontoAmP { get; set; }

    public string? SrtKontoAmB { get; set; }

    public string? SrtKontoStk { get; set; }

    public decimal? SrtStawka { get; set; }

    public decimal? SrtStawkaAm { get; set; }

    public string? SrtDokZak { get; set; }

    public string? SrtDokLikw { get; set; }

    public string? SrtKntZak { get; set; }

    public string? Hierarchy1Level1Name { get; set; }

    public string? Hierarchy1Level1OrgId { get; set; }

    public int? Hierarchy1Level1Id { get; set; }

    public string? Hierarchy1Level2Name { get; set; }

    public string? Hierarchy1Level2OrgId { get; set; }

    public int? Hierarchy1Level2Id { get; set; }

    public string? Hierarchy1Level3Name { get; set; }

    public string? Hierarchy1Level3OrgId { get; set; }

    public int? Hierarchy1Level3Id { get; set; }

    public string? SrtBiezaceMiejsce { get; set; }

    public virtual WymCzasDzien SrtDataEkspNavigation { get; set; } = null!;

    public virtual WymCzasDzien SrtDataLikwNavigation { get; set; } = null!;

    public virtual WymZrodloDanych SrtZrodg { get; set; } = null!;
}

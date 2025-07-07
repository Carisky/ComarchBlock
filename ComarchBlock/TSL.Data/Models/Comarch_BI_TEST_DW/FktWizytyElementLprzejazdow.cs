using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktWizytyElementLprzejazdow
{
    public int? WzEBudzetId { get; set; }

    public int? WzERejonId { get; set; }

    public int? WzESamId { get; set; }

    public int? WzEKntId { get; set; }

    public int? WzEPrcId { get; set; }

    public long WzEId { get; set; }

    public int WzEZrodgid { get; set; }

    public int WzECzdgid { get; set; }

    public string WzEOrgId { get; set; } = null!;

    public string WzEDirtyOrgId { get; set; } = null!;

    public string? WzEOpis { get; set; }

    public int WzEUpdateTransformationId { get; set; }

    public int? WzEUpdateSubTransformationId { get; set; }

    public int WzEInsertTransformationId { get; set; }

    public int? WzEInsertSubTransformationId { get; set; }

    public DateTime WzETsinsert { get; set; }

    public DateTime WzETsupdate { get; set; }

    public string? WzENazwa { get; set; }

    public string? WzEKod { get; set; }

    public string? WzEStatus { get; set; }

    public decimal? WzEMkilometry { get; set; }

    public decimal? WzEMczasPrzejazdu { get; set; }

    public decimal? WzEMiloscDokHand { get; set; }

    public decimal? WzEMwartoscSprzSum { get; set; }

    public decimal? WzEMiloscDokZam { get; set; }

    public decimal? WzEMwartoscZamSum { get; set; }

    public decimal? WzEMiloscZamSum { get; set; }

    public decimal? WzEMiloscDokOfe { get; set; }

    public decimal? WzEMwartoscNalSum { get; set; }

    public decimal? WzEMiloscWankiet { get; set; }

    public decimal? WzEMiloscKonw { get; set; }

    public decimal? WzEMiloscWkonw { get; set; }

    public decimal? WzEMiloscZadan { get; set; }

    public decimal? WzEMiloscWzadan { get; set; }

    public decimal? WzEMiloscSprzSum { get; set; }

    public int? WzEWelId { get; set; }

    public int? WzEWzwId { get; set; }

    public int WzEAlokacjaId { get; set; }

    public int WzECzwid { get; set; }

    public int WzEPrzId { get; set; }

    public int WzEJczid { get; set; }

    public int WzECzpid { get; set; }

    public int WzEZadid { get; set; }

    public int WzECrmetapId { get; set; }

    public decimal? WzEMiloscKampanii { get; set; }

    public int WzEKonwid { get; set; }

    public int WzECzdrozpKonwId { get; set; }

    public int WzECzdutwElemKonwId { get; set; }

    public int WzECzdutwZadId { get; set; }

    public int WzECzdwykElemKonwId { get; set; }

    public int WzECzdwykZadId { get; set; }

    public int WzECzdzakKonwId { get; set; }

    public decimal? WzEMiloscElemKonw { get; set; }

    public int? WzEMczasKonsultacji { get; set; }

    public int WzEZadkonwId { get; set; }
}

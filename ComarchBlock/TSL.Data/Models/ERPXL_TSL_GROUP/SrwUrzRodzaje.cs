using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrwUrzRodzaje
{
    public int SurId { get; set; }

    public string? SurKod { get; set; }

    public string? SurNazwa { get; set; }

    public int? SurJednostkaPrzebiegu { get; set; }

    public byte? SurDostepnyWmobile { get; set; }

    public int? SurNadrzedny { get; set; }

    public virtual ICollection<SrwUrzRodzPar> SrwUrzRodzPars { get; set; } = new List<SrwUrzRodzPar>();

    public virtual ICollection<SrwUrzRodzTypyP> SrwUrzRodzTypyPs { get; set; } = new List<SrwUrzRodzTypyP>();
}

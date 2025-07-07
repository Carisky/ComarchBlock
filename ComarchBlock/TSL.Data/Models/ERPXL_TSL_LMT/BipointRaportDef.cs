using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class BipointRaportDef
{
    public int BrdId { get; set; }

    public string? BrdNazwa { get; set; }

    public byte? BrdAktywny { get; set; }

    public int? BrdListaId { get; set; }

    public int? BrdFormatkaId { get; set; }

    public int? BrdKontekstId { get; set; }

    public virtual ICollection<BipointRaportElem> BipointRaportElems { get; set; } = new List<BipointRaportElem>();

    public virtual ICollection<BipointRaportOpeCentra> BipointRaportOpeCentras { get; set; } = new List<BipointRaportOpeCentra>();
}

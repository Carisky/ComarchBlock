using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class SlwTransakcje
{
    public int SltId { get; set; }

    public int? SltSlwId { get; set; }

    public byte? SltRodzaj { get; set; }

    public byte? SltKategoriaDaty { get; set; }

    public virtual Slowniki? SltSlw { get; set; }

    public virtual ICollection<SlwTraDokumenty> SlwTraDokumenties { get; set; } = new List<SlwTraDokumenty>();
}

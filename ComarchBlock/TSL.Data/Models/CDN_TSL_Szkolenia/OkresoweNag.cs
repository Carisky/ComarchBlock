using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class OkresoweNag
{
    public int OkNOkNid { get; set; }

    public string OkNSymbol { get; set; } = null!;

    public string OkNNazwa { get; set; } = null!;

    public string OkNUwagi { get; set; } = null!;

    public string OkNDziennik { get; set; } = null!;

    public byte OkNBufor { get; set; }

    public string OkNDokument { get; set; } = null!;

    public int? OkNKatId { get; set; }

    public string OkNKategoria { get; set; } = null!;

    public string OkNWarunek { get; set; } = null!;

    public byte OkNNieAktywny { get; set; }

    public byte OkNHarmonogram { get; set; }

    public byte OkNZakresDat { get; set; }

    public DateTime? OkNDataOd { get; set; }

    public DateTime? OkNDataDo { get; set; }

    public DateTime? OkNTsKsi { get; set; }

    public int? OkNOpeZalId { get; set; }

    public int? OkNStaZalId { get; set; }

    public DateTime OkNTsZal { get; set; }

    public int? OkNOpeModId { get; set; }

    public int? OkNStaModId { get; set; }

    public DateTime OkNTsMod { get; set; }

    public string OkNOpeModKod { get; set; } = null!;

    public string OkNOpeModNazwisko { get; set; } = null!;

    public string OkNOpeZalKod { get; set; } = null!;

    public string OkNOpeZalNazwisko { get; set; } = null!;

    public virtual Kategorie? OkNKat { get; set; }

    public virtual ICollection<OkresoweElem> OkresoweElems { get; set; } = new List<OkresoweElem>();
}

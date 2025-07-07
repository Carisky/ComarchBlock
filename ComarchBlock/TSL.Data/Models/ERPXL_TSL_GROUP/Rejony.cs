using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Rejony
{
    public int RejId { get; set; }

    public int? RejOjciecId { get; set; }

    public string? RejNazwa { get; set; }

    public string? RejOpis { get; set; }

    public int? RejCzasModyfikacji { get; set; }

    public int? RejCzasModyfikacjiS { get; set; }

    public int? RejDataUtworzenia { get; set; }

    public short? RejOpeTyp { get; set; }

    public int? RejOpeFirma { get; set; }

    public int? RejOpeNumer { get; set; }

    public short? RejOpeLp { get; set; }

    public short? RejOpeTypM { get; set; }

    public int? RejOpeFirmaM { get; set; }

    public int? RejOpeNumerM { get; set; }

    public short? RejOpeLpM { get; set; }

    public byte? RejOddzialowy { get; set; }

    public virtual ICollection<KntRejony> KntRejonies { get; set; } = new List<KntRejony>();

    public virtual ICollection<PlanSprzedazyRej> PlanSprzedazyRejs { get; set; } = new List<PlanSprzedazyRej>();

    public virtual ICollection<KntKody> KkrKnPs { get; set; } = new List<KntKody>();
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class RejestracjaZgodFormyKontaktu
{
    public int RzfkRzfkid { get; set; }

    public string RzfkNazwa { get; set; } = null!;

    public Guid? RzfkGuid { get; set; }

    public int? RzfkOpeZalId { get; set; }

    public int? RzfkStaZalId { get; set; }

    public DateTime RzfkTsZal { get; set; }

    public int? RzfkOpeModId { get; set; }

    public int? RzfkStaModId { get; set; }

    public DateTime RzfkTsMod { get; set; }

    public string RzfkOpeModKod { get; set; } = null!;

    public string RzfkOpeModNazwisko { get; set; } = null!;

    public string RzfkOpeZalKod { get; set; } = null!;

    public string RzfkOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<RejestracjaZgodFormyKontaktuJezykObcy> RejestracjaZgodFormyKontaktuJezykObcies { get; set; } = new List<RejestracjaZgodFormyKontaktuJezykObcy>();
}

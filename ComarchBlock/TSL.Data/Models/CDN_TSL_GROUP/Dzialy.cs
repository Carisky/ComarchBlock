using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Dzialy
{
    public int DzlDzlId { get; set; }

    public int? DzlZrgId { get; set; }

    public string DzlKod { get; set; } = null!;

    public string DzlNazwa { get; set; } = null!;

    public int? DzlParentId { get; set; }

    public short DzlNieaktywny { get; set; }

    public string DzlAdresWezla { get; set; } = null!;

    public short DzlPoziom { get; set; }

    public int DzlLisc { get; set; }

    public byte DzlAddMethod { get; set; }

    public int DzlImpId { get; set; }

    public string DzlSymbol { get; set; } = null!;

    public int? DzlLokId { get; set; }

    public byte DzlLast { get; set; }

    public string DzlKonto { get; set; } = null!;

    public string? DzlImportAppId { get; set; }

    public string? DzlImportRowId { get; set; }

    public DateTime? DzlTsExport { get; set; }

    public int? DzlOpeZalId { get; set; }

    public int? DzlStaZalId { get; set; }

    public DateTime DzlTsZal { get; set; }

    public int? DzlOpeModId { get; set; }

    public int? DzlStaModId { get; set; }

    public DateTime DzlTsMod { get; set; }

    public string DzlOpeModKod { get; set; } = null!;

    public string DzlOpeModNazwisko { get; set; } = null!;

    public string DzlOpeZalKod { get; set; } = null!;

    public string DzlOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<DzialZakazy> DzialZakazies { get; set; } = new List<DzialZakazy>();

    public virtual Lokalizacje? DzlLok { get; set; }

    public virtual Dzialy? DzlParent { get; set; }

    public virtual ZestawyRegul? DzlZrg { get; set; }

    public virtual ICollection<Dzialy> InverseDzlParent { get; set; } = new List<Dzialy>();

    public virtual ICollection<ListyPlac> ListyPlacs { get; set; } = new List<ListyPlac>();

    public virtual ICollection<OpisKadry> OpisKadries { get; set; } = new List<OpisKadry>();

    public virtual ICollection<OpisPlace> OpisPlaces { get; set; } = new List<OpisPlace>();

    public virtual ICollection<PracEtaty> PracEtaties { get; set; } = new List<PracEtaty>();

    public virtual ICollection<Pracidx> Pracidxes { get; set; } = new List<Pracidx>();

    public virtual ICollection<Umowy> Umowies { get; set; } = new List<Umowy>();

    public virtual ICollection<Wyplaty> Wyplaties { get; set; } = new List<Wyplaty>();
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PodElem
{
    public short PoeGidtyp { get; set; }

    public int? PoeGidfirma { get; set; }

    public int PoeGidnumer { get; set; }

    public short PoeGidlp { get; set; }

    public short? PoeWlatyp { get; set; }

    public int? PoeWlafirma { get; set; }

    public int? PoeWlanumer { get; set; }

    public short? PoeWlalp { get; set; }

    public short? PoeTypPodatku { get; set; }

    public short? PoeRok { get; set; }

    public short? PoeMiesiac { get; set; }

    public int? PoePozycja { get; set; }

    public short? PoeSubPozycja { get; set; }

    public string? PoeNazwa { get; set; }

    public string? PoeOpis { get; set; }

    public decimal? PoeKwotaL { get; set; }

    public decimal? PoeKwotaM { get; set; }

    public byte? PoeWyswietlajZero { get; set; }

    public int? PoeKntnumer { get; set; }

    public byte? PoeBylKnt { get; set; }

    public int? PoeKnaidGrupy { get; set; }

    public int? PoeKnaid { get; set; }

    public virtual ICollection<PodElemNagListy> PodElemNagListies { get; set; } = new List<PodElemNagListy>();

    public virtual ICollection<PodElemVuegrupy> PodElemVuegrupies { get; set; } = new List<PodElemVuegrupy>();

    public virtual ICollection<PodElemVuepozycje> PodElemVuepozycjes { get; set; } = new List<PodElemVuepozycje>();

    public virtual ICollection<PodSelem> PodSelems { get; set; } = new List<PodSelem>();

    public virtual PodNag PoeGidnumerNavigation { get; set; } = null!;
}

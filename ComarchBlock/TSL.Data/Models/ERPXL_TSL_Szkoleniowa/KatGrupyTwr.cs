using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KatGrupyTwr
{
    public int KgtId { get; set; }

    public int? KgtOjciecId { get; set; }

    public int? KgtIdM { get; set; }

    public string? KgtNazwa { get; set; }

    public int? KgtCzasModyfikacji { get; set; }

    public int? KgtWszystkoPlId { get; set; }

    public byte? KgtLisc { get; set; }

    public string? KgtSciezka { get; set; }

    public byte? KgtPoziom { get; set; }

    public int? KgtWszystkoPlJm { get; set; }

    public int? KgtWszystkoPlCzasR { get; set; }

    public int? KgtWszystkoPlCennik { get; set; }

    public int? KgtWszystkoPlWarGw { get; set; }

    public int? KgtWszystkoPlWarRekl { get; set; }

    public int? KgtWszystkoPlWarZwr { get; set; }

    public virtual ICollection<KgtParametryKategorii> KgtParametryKategoriis { get; set; } = new List<KgtParametryKategorii>();
}

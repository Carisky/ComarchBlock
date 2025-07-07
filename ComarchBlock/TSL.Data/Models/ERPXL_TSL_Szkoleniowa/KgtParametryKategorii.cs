using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KgtParametryKategorii
{
    public int KpkId { get; set; }

    public int? KpkWszystkoPlId { get; set; }

    public int? KpkKategoriaId { get; set; }

    public int? KpkParametrId { get; set; }

    public byte? KpkWymagany { get; set; }

    public byte? KpkWielowartosciowy { get; set; }

    public byte? KpkIleWybracZwielu { get; set; }

    public int? KpkMinimum { get; set; }

    public int? KpkMaksimum { get; set; }

    public byte? KpkCzyZakres { get; set; }

    public byte? KpkPrecyzja { get; set; }

    public string? KpkJednostka { get; set; }

    public virtual ICollection<KgtSlownikiParametruKategorii> KgtSlownikiParametruKategoriis { get; set; } = new List<KgtSlownikiParametruKategorii>();

    public virtual ICollection<KgtWartoscParametrDlaTowaru> KgtWartoscParametrDlaTowarus { get; set; } = new List<KgtWartoscParametrDlaTowaru>();

    public virtual KatGrupyTwr? KpkKategoria { get; set; }

    public virtual KgtParametr? KpkParametr { get; set; }
}

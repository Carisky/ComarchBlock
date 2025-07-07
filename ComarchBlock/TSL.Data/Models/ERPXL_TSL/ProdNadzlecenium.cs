using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdNadzlecenium
{
    public int PnzId { get; set; }

    public int? PnzProjekt { get; set; }

    public int? PnzOddzial { get; set; }

    public int? PnzDataWystawienia { get; set; }

    public int? PnzOpWnumer { get; set; }

    public int? PnzFrsId { get; set; }

    public int? PnzCzasModyfikacji { get; set; }

    public int? PnzOpMnumer { get; set; }

    public short? PnzKntTyp { get; set; }

    public int? PnzKntNumer { get; set; }

    public short? PnzKnDtyp { get; set; }

    public int? PnzKnDnumer { get; set; }

    public string? PnzOpis { get; set; }

    public short? PnzRok { get; set; }

    public byte? PnzMiesiac { get; set; }

    public string? PnzSeria { get; set; }

    public int? PnzNumer { get; set; }

    public short? PnzLp { get; set; }

    public string? PnzDokumentObcy { get; set; }

    public int? PnzDataZamkniecia { get; set; }

    public int? PnzStatus { get; set; }

    public string? PnzUrl { get; set; }

    public byte? PnzPlanWskazaneZasoby { get; set; }

    public virtual ICollection<ProdNadzleceniaLinki> ProdNadzleceniaLinkis { get; set; } = new List<ProdNadzleceniaLinki>();
}

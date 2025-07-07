using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdKalkulacjaKosztu
{
    public int PkkId { get; set; }

    public int? PkkTechnologia { get; set; }

    public short? PkkRok { get; set; }

    public byte? PkkMiesiac { get; set; }

    public string? PkkSeria { get; set; }

    public int? PkkNumer { get; set; }

    public int? PkkFrsId { get; set; }

    public string? PkkOpis { get; set; }

    public int? PkkDataWystawienia { get; set; }

    public int? PkkOpWnumer { get; set; }

    public int? PkkDataZatwierdzenia { get; set; }

    public int? PkkOpZnumer { get; set; }

    public int? PkkDataModyfikacji { get; set; }

    public int? PkkOpMnumer { get; set; }

    public int? PkkDataArchiwizacji { get; set; }

    public int? PkkOpAnumer { get; set; }

    public byte? PkkPodstawaSymulacjiMaterialu { get; set; }

    public byte? PkkKosztyDodatkoweMaterialu { get; set; }

    public byte? PkkPodstawaSymulacjiGniazda { get; set; }

    public byte? PkkKosztyDodatkoweKonfiguratora { get; set; }

    public int? PkkZrodloKosztorysu { get; set; }

    public byte? PkkArchiwalny { get; set; }

    public byte? PkkWgTechDlaMaterialow { get; set; }

    public int? PkkIdWyrobu { get; set; }

    public decimal? PkkIloscWyrobu { get; set; }

    public byte? PkkKolorujZeroweKoszty { get; set; }

    public string? PkkWaluta { get; set; }

    public short? PkkNrKursu { get; set; }

    public short? PkkObiTyp { get; set; }

    public int? PkkObiFirma { get; set; }

    public int? PkkObiNumer { get; set; }

    public short? PkkObiLp { get; set; }

    public virtual ProdTechnologium? PkkTechnologiaNavigation { get; set; }

    public virtual ICollection<ProdKalkulacjaKosztuElem> ProdKalkulacjaKosztuElems { get; set; } = new List<ProdKalkulacjaKosztuElem>();
}

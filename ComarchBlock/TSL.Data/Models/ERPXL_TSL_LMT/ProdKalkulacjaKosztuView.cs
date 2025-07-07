using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdKalkulacjaKosztuView
{
    public int PvkId { get; set; }

    public int? PvkTechnologia { get; set; }

    public short? PvkRok { get; set; }

    public byte? PvkMiesiac { get; set; }

    public string? PvkSeria { get; set; }

    public int? PvkNumer { get; set; }

    public string? PvkNumerDokumentu { get; set; }

    public int? PvkFrsId { get; set; }

    public string? PvkOpis { get; set; }

    public int? PvKDataWystawienia { get; set; }

    public int? PvKOpWnumer { get; set; }

    public string? PvkWystawil { get; set; }

    public int? PvKDataZatwierdzenia { get; set; }

    public int? PvKOpZnumer { get; set; }

    public string? PvkModyfikacja { get; set; }

    public int? PvKDataModyfikacji { get; set; }

    public int? PvKOpMnumer { get; set; }

    public string? PvkZatwierdzil { get; set; }

    public byte? PvKPodstawaSymulacjiMaterialu { get; set; }

    public byte? PvKKosztyDodatkoweMaterialu { get; set; }

    public byte? PvKPodstawaSymulacjiGniazda { get; set; }

    public byte? PvKKosztyDodatkoweKonfiguratora { get; set; }

    public int? PvKZrodloKosztorysu { get; set; }

    public string? PvKWaluta { get; set; }

    public short? PvKNrKursu { get; set; }

    public short? PvKObiTyp { get; set; }

    public int? PvKObiFirma { get; set; }

    public int? PvKObiNumer { get; set; }

    public short? PvKObiLp { get; set; }

    public byte? PvKArchiwalny { get; set; }

    public string? PvkDoDokumentu { get; set; }
}

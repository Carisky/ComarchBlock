using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Pdoczynnosci
{
    public int PdocId { get; set; }

    public string? PdocKategorieOsob { get; set; }

    public string? PdocKategorieDo { get; set; }

    public string? PdocKategorieOdbiorcow { get; set; }

    public string? PdocPlanowaneTerminy { get; set; }

    public int? PdocCzasUtworzenia { get; set; }

    public int? PdocOpeNumerW { get; set; }

    public int? PdocCzasModyfikacji { get; set; }

    public int? PdocOpeNumerM { get; set; }

    public int? PdocKategoria { get; set; }

    public string? PdocCel { get; set; }

    public byte? PdocArchiwalny { get; set; }

    public string? PdocDodatkowe { get; set; }

    public short? PdocAdminTyp { get; set; }

    public int? PdocAdminNumer { get; set; }

    public int? PdocAdminLp { get; set; }

    public int? PdocAdminAdr { get; set; }

    public short? PdocPrzedstTyp { get; set; }

    public int? PdocPrzedstNumer { get; set; }

    public int? PdocPrzedstLp { get; set; }

    public int? PdocPrzedstAdr { get; set; }

    public short? PdocInspTyp { get; set; }

    public int? PdocInspNumer { get; set; }

    public int? PdocInspLp { get; set; }

    public int? PdocInspAdr { get; set; }

    public virtual ICollection<PdoczynnosciKraje> PdoczynnosciKrajes { get; set; } = new List<PdoczynnosciKraje>();
}

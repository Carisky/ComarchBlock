using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdZlecenium
{
    public int PzlId { get; set; }

    public int? PzlProjekt { get; set; }

    public int? PzlOddzial { get; set; }

    public int? PzlDataWystawienia { get; set; }

    public int? PzlOpWnumer { get; set; }

    public int? PzlDataZamkniecia { get; set; }

    public int? PzlFrsId { get; set; }

    public int? PzlOpZnumer { get; set; }

    public int? PzlCzasModyfikacji { get; set; }

    public int? PzlOpMnumer { get; set; }

    public short? PzlKntTyp { get; set; }

    public int? PzlKntNumer { get; set; }

    public short? PzlKnDtyp { get; set; }

    public int? PzlKnDnumer { get; set; }

    public string? PzlNumerSeryjny { get; set; }

    public string? PzlOpis { get; set; }

    public short? PzlRok { get; set; }

    public byte? PzlMiesiac { get; set; }

    public string? PzlSeria { get; set; }

    public int? PzlNumer { get; set; }

    public short? PzlLp { get; set; }

    public byte? PzlZaksiegowano { get; set; }

    public byte? PzlNieKsiegowac { get; set; }

    public int? PzlDataKsiegowania { get; set; }

    public short? PzlSchtyp { get; set; }

    public int? PzlSchnumer { get; set; }

    public string? PzlDziennik { get; set; }

    public short? PzlWsSchtyp { get; set; }

    public int? PzlWsSchnumer { get; set; }

    public byte? PzlWsStosujSchemat { get; set; }

    public string? PzlWsDziennik { get; set; }

    public byte? PzlWsStosujDziennik { get; set; }

    public decimal? PzlKoszt { get; set; }

    public decimal? PzlKosztSurowca { get; set; }

    public byte? PzlPriorytetRez { get; set; }

    public string? PzlDokumentObcy { get; set; }

    public byte? PzlPriorytetZlc { get; set; }

    public int? PzlPlanowacOd { get; set; }

    public byte? PzlRezerwujZasoby { get; set; }

    public int? PzlPrjId { get; set; }

    public byte? PzlKosztUstalony { get; set; }

    public int? PzlFrmNumer { get; set; }

    public byte? PzlStan { get; set; }

    public string? PzlStatus { get; set; }

    public byte? PzlGenDokZatwierdzone { get; set; }

    public byte? PzlDokPrzyjeciaPoDokWydania { get; set; }

    public byte? PzlZwolnioneDoProd { get; set; }

    public byte? PzlRealizacjaWgPlanu { get; set; }

    public byte? PzlPrzesunOperacjePoRealizacji { get; set; }

    public byte? PzlPrzesunNaZwolnionych { get; set; }

    public byte? PzlGenerujZleceniaPrzyPlanowaniu { get; set; }

    public byte? PzlWyborMagazynuNaPozycji { get; set; }

    public byte? PzlStatusAps { get; set; }

    public byte? PzlPlanWskazaneZasoby { get; set; }

    public virtual ICollection<ProdNadzleceniaLinki> ProdNadzleceniaLinkis { get; set; } = new List<ProdNadzleceniaLinki>();

    public virtual ICollection<ProdObiektyDoPlanu> ProdObiektyDoPlanus { get; set; } = new List<ProdObiektyDoPlanu>();

    public virtual ICollection<ProdProcesy> ProdProcesies { get; set; } = new List<ProdProcesy>();

    public virtual ICollection<ProdZlecElem> ProdZlecElems { get; set; } = new List<ProdZlecElem>();
}

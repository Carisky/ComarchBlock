using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Kbnnag
{
    public int KbnnId { get; set; }

    public short? KbnnRok { get; set; }

    public byte? KbnnMiesiac { get; set; }

    public string? KbnnSeria { get; set; }

    public int? KbnnNumer { get; set; }

    public byte? KbnnStan { get; set; }

    public int? KbnnAktywny { get; set; }

    public int? KbnnFrsId { get; set; }

    public int? KbnnFrmNumer { get; set; }

    public int? KbnnDataWystawienia { get; set; }

    public int? KbnnDataModyfikacji { get; set; }

    public int? KbnnDataPotwierdzenia { get; set; }

    public int? KbnnOpeNumerW { get; set; }

    public int? KbnnOpeNumerM { get; set; }

    public int? KbnnOpeNumerZ { get; set; }

    public int? KbnnOpeNumerR { get; set; }

    public string? KbnnCechaOpis { get; set; }

    public string? KbnnUrl { get; set; }

    public string? KbnnOpis { get; set; }

    public int? KbnnDataOd { get; set; }

    public int? KbnnDataDo { get; set; }

    public byte? KbnnFormaNr { get; set; }

    public string? KbnnFormaNazwa { get; set; }

    public int? KbnnTerminPlatnosci { get; set; }

    public decimal? KbnnRoznica { get; set; }

    public decimal? KbnnRoznicaPw { get; set; }

    public decimal? KbnnRoznicaRw { get; set; }

    public decimal? KbnnWartosc { get; set; }

    public decimal? KbnnWartoscNadwyzek { get; set; }

    public decimal? KbnnWartoscBrakow { get; set; }

    public decimal? KbnnWartoscBrakowZawinionych { get; set; }

    public int? KbnnKarNumer { get; set; }

    public byte? KbnnZaksiegowano { get; set; }

    public byte? KbnnNieKsiegowac { get; set; }

    public int? KbnnDataKsiegowania { get; set; }

    public short? KbnnSchTyp { get; set; }

    public int? KbnnSchNumer { get; set; }

    public string? KbnnDziennik { get; set; }

    public byte? KbnnWsStosujSchemat { get; set; }

    public short? KbnnWsSchTyp { get; set; }

    public int? KbnnWsSchNumer { get; set; }

    public string? KbnnWsDziennik { get; set; }

    public byte? KbnnWsStosujDziennik { get; set; }

    public byte? KbnnPlatnosci { get; set; }

    public short? KbnnOpeTypZm { get; set; }

    public int? KbnnOpeNumerZm { get; set; }

    public int? KbnnTstampZm { get; set; }

    public short? KbnnOpeTypZfr { get; set; }

    public int? KbnnOpeNumerZfr { get; set; }

    public int? KbnnTstampZfr { get; set; }

    public byte? KbnnZatwMerytorycznie { get; set; }

    public byte? KbnnZatwFormalnoRach { get; set; }

    public virtual ICollection<Kbnelem> Kbnelems { get; set; } = new List<Kbnelem>();

    public virtual ICollection<Kbnodpowiedzialni> Kbnodpowiedzialnis { get; set; } = new List<Kbnodpowiedzialni>();

    public virtual ICollection<Magazyny> KbnmMagNumers { get; set; } = new List<Magazyny>();

    public virtual ICollection<Serie> KbnsSerNazwas { get; set; } = new List<Serie>();
}

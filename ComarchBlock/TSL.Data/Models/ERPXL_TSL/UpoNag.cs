using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class UpoNag
{
    public short? UpnGidtyp { get; set; }

    public int? UpnGidfirma { get; set; }

    public int UpnGidnumer { get; set; }

    public short? UpnGidlp { get; set; }

    public short? UpnKnttyp { get; set; }

    public int? UpnKntfirma { get; set; }

    public int? UpnKntnumer { get; set; }

    public short? UpnKntlp { get; set; }

    public short? UpnTyp { get; set; }

    public short? UpnRok { get; set; }

    public string? UpnSeria { get; set; }

    public int? UpnNumer { get; set; }

    public int? UpnDataUp { get; set; }

    public int? UpnDataDor { get; set; }

    public decimal? UpnKosztUp { get; set; }

    public byte? UpnRozliczona { get; set; }

    public decimal? UpnKwotaOds { get; set; }

    public string? UpnCechaOpis { get; set; }

    public string? UpnDziennik { get; set; }

    public byte? UpnZaksiegowano { get; set; }

    public byte? UpnNieKsiegowac { get; set; }

    public int? UpnDataKsiegowania { get; set; }

    public short? UpnSchtyp { get; set; }

    public int? UpnSchfirma { get; set; }

    public int? UpnSchnumer { get; set; }

    public short? UpnSchlp { get; set; }

    public int? UpnDokId { get; set; }

    public short? UpnOpeTyp { get; set; }

    public int? UpnOpeFirma { get; set; }

    public int? UpnOpeNumer { get; set; }

    public short? UpnOpeLp { get; set; }

    public short? UpnWsSchtyp { get; set; }

    public int? UpnWsSchnumer { get; set; }

    public byte? UpnWsStosujSchemat { get; set; }

    public string? UpnWsDziennik { get; set; }

    public byte? UpnWsStosujDziennik { get; set; }

    public string? UpnWaluta { get; set; }

    public short? UpnNrKursu { get; set; }

    public decimal? UpnKursM { get; set; }

    public decimal? UpnKursL { get; set; }

    public decimal? UpnKosztUpSys { get; set; }

    public decimal? UpnKwotaOdsSys { get; set; }

    public short? UpnTypKursu { get; set; }

    public int? UpnKaRnumer { get; set; }

    public int? UpnSlwTypOdsetek { get; set; }

    public byte? UpnRodzajTrpTermin { get; set; }

    public byte? UpnGenPlatDlaOds { get; set; }

    public int? UpnAktywny { get; set; }

    public byte? UpnWygenerowaneAutomatycznie { get; set; }

    public byte? UpnZatwierdzoneDoWysylki { get; set; }

    public string? UpnWalutaKosztUp { get; set; }

    public short? UpnNrKursuKosztUp { get; set; }

    public decimal? UpnKursMkosztUp { get; set; }

    public decimal? UpnKursLkosztUp { get; set; }

    public virtual ICollection<UpoElem> UpoElems { get; set; } = new List<UpoElem>();

    public virtual ICollection<UpoOpisy> UpoOpisies { get; set; } = new List<UpoOpisy>();
}

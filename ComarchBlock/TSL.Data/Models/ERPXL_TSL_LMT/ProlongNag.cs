using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProlongNag
{
    public int PrlnId { get; set; }

    public short? PrlnPrlnTyp { get; set; }

    public int? PrlnZrdId { get; set; }

    public byte? PrlnTyp { get; set; }

    public byte? PrlnStatus { get; set; }

    public decimal? PrlnKwota { get; set; }

    public string? PrlnWaluta { get; set; }

    public decimal? PrlnKoszt { get; set; }

    public short? PrlnRok { get; set; }

    public byte? PrlnMiesiac { get; set; }

    public string? PrlnSeria { get; set; }

    public int? PrlnNumer { get; set; }

    public string? PrlnWalutaKosztu { get; set; }

    public short? PrlnNrKursu { get; set; }

    public decimal? PrlnKursM { get; set; }

    public decimal? PrlnKursL { get; set; }

    public decimal? PrlnKwotaOdsetki { get; set; }

    public byte? PrlnTypOdsetki { get; set; }

    public string? PrlnWalutaOdsetki { get; set; }

    public short? PrlnNrKursuOdsetki { get; set; }

    public decimal? PrlnKursModsetki { get; set; }

    public decimal? PrlnKursLodsetki { get; set; }

    public decimal? PrlnKwotaMinOdsetki { get; set; }

    public short? PrlnKnttyp { get; set; }

    public int? PrlnKntfirma { get; set; }

    public int? PrlnKntnumer { get; set; }

    public short? PrlnKntlp { get; set; }

    public int? PrlnTermin { get; set; }

    public int? PrlnTerminMax { get; set; }

    public int? PrlnTerminPrln { get; set; }

    public int? PrlnData { get; set; }

    public string? PrlnTresc { get; set; }

    public string? PrlnCechaOpis { get; set; }

    public string? PrlnDokumentObcy { get; set; }

    public int? PrlnAktywny { get; set; }

    public short? PrlnOpeTypW { get; set; }

    public int? PrlnOpeFirmaW { get; set; }

    public int? PrlnOpeNumerW { get; set; }

    public short? PrlnOpeLpW { get; set; }

    public short? PrlnOpeTypZ { get; set; }

    public int? PrlnOpeFirmaZ { get; set; }

    public int? PrlnOpeNumerZ { get; set; }

    public short? PrlnOpeLpZ { get; set; }

    public short? PrlnKarTyp { get; set; }

    public int? PrlnKarFirma { get; set; }

    public int? PrlnKarNumer { get; set; }

    public short? PrlnKarLp { get; set; }

    public byte? PrlnZaksiegowano { get; set; }

    public byte? PrlnNieKsiegowac { get; set; }

    public int? PrlnDataKsiegowania { get; set; }

    public short? PrlnSchTyp { get; set; }

    public int? PrlnSchNumer { get; set; }

    public string? PrlnDziennik { get; set; }

    public byte? PrlnWsStosujSchemat { get; set; }

    public short? PrlnWsSchTyp { get; set; }

    public int? PrlnWsSchNumer { get; set; }

    public string? PrlnWsDziennik { get; set; }

    public byte? PrlnWsStosujDziennik { get; set; }

    public short? PrlnOpeTypZm { get; set; }

    public int? PrlnOpeNumerZm { get; set; }

    public int? PrlnTstampZm { get; set; }

    public short? PrlnOpeTypZfr { get; set; }

    public int? PrlnOpeNumerZfr { get; set; }

    public int? PrlnTstampZfr { get; set; }

    public byte? PrlnZatwMerytorycznie { get; set; }

    public byte? PrlnZatwFormalnoRach { get; set; }

    public virtual PrlnOpisy? PrlnOpisy { get; set; }

    public virtual ICollection<ProlongElem> ProlongElems { get; set; } = new List<ProlongElem>();
}

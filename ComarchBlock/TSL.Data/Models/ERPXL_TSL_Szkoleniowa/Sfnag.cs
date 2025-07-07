using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Sfnag
{
    public int SfnId { get; set; }

    public string? SfnNazwaFirmy { get; set; }

    public int? SfnDataDo { get; set; }

    public int? SfnDataSporzadzenia { get; set; }

    public int? SfnTyp { get; set; }

    public string? SfnWersjaSchemy { get; set; }

    public int? SfnStatus { get; set; }

    public int? SfnAktywny { get; set; }

    public string? SfnNrReferencyjny { get; set; }

    public string? SfnUpokod { get; set; }

    public string? SfnUpoopis { get; set; }

    public byte[]? SfnUpoxml { get; set; }

    public byte[]? SfnPlikXml { get; set; }

    public byte[]? SfnPlikKonfigXml { get; set; }

    public virtual ICollection<Sfpodpisy> Sfpodpisies { get; set; } = new List<Sfpodpisy>();

    public virtual ICollection<SfzalWlasne> SfzalWlasnes { get; set; } = new List<SfzalWlasne>();

    public virtual ICollection<Sfzalaczniki> Sfzalacznikis { get; set; } = new List<Sfzalaczniki>();
}

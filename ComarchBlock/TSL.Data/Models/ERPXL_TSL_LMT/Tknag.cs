using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Tknag
{
    public short? TknGidtyp { get; set; }

    public int? TknGidfirma { get; set; }

    public int TknGidnumer { get; set; }

    public short? TknGidlp { get; set; }

    public short? TknZwrTyp { get; set; }

    public int? TknZwrFirma { get; set; }

    public int? TknZwrNumer { get; set; }

    public short? TknZwrLp { get; set; }

    public short? TknSpiTyp { get; set; }

    public int? TknSpiFirma { get; set; }

    public int? TknSpiNumer { get; set; }

    public short? TknSpiLp { get; set; }

    public short? TknTrNtyp { get; set; }

    public int? TknTrNfirma { get; set; }

    public int? TknTrNnumer { get; set; }

    public short? TknTrNlp { get; set; }

    public short? TknKntTyp { get; set; }

    public int? TknKntFirma { get; set; }

    public int? TknKntNumer { get; set; }

    public short? TknKntLp { get; set; }

    public short? TknKnAtyp { get; set; }

    public int? TknKnAfirma { get; set; }

    public int? TknKnAnumer { get; set; }

    public short? TknKnAlp { get; set; }

    public short? TknAkwTyp { get; set; }

    public int? TknAkwFirma { get; set; }

    public int? TknAkwNumer { get; set; }

    public short? TknAkwLp { get; set; }

    public short? TknAdWtyp { get; set; }

    public int? TknAdWfirma { get; set; }

    public int? TknAdWnumer { get; set; }

    public short? TknAdWlp { get; set; }

    public short? TknSchTyp { get; set; }

    public int? TknSchFirma { get; set; }

    public int? TknSchNumer { get; set; }

    public short? TknSchLp { get; set; }

    public string? TknDziennik { get; set; }

    public int? TknDataWyst { get; set; }

    public short? TknDoZwrotu { get; set; }

    public int? TknTerminZwrotu { get; set; }

    public short? TknTkntyp { get; set; }

    public short? TknTknrok { get; set; }

    public string? TknTknseria { get; set; }

    public int? TknTknnumer { get; set; }

    public short? TknTknlp { get; set; }

    public string? TknDokumentObcy { get; set; }

    public string? TknNrKorekty { get; set; }

    public short? TknCenaSpr { get; set; }

    public byte? TknFormaNr { get; set; }

    public string? TknFormaNazwa { get; set; }

    public decimal? TknFormaRabat { get; set; }

    public decimal? TknWartosc { get; set; }

    public decimal? TknZaokraglenie { get; set; }

    public decimal? TknWartoscWal { get; set; }

    public decimal? TknZaokraglenieWal { get; set; }

    public string? TknWaluta { get; set; }

    public short? TknNrKursu { get; set; }

    public decimal? TknKursM { get; set; }

    public decimal? TknKursL { get; set; }

    public short? TknMagZtyp { get; set; }

    public int? TknMagZfirma { get; set; }

    public int? TknMagZnumer { get; set; }

    public short? TknMagZlp { get; set; }

    public short? TknMagDtyp { get; set; }

    public int? TknMagDfirma { get; set; }

    public int? TknMagDnumer { get; set; }

    public short? TknMagDlp { get; set; }

    public short? TknOpeTypW { get; set; }

    public int? TknOpeFirmaW { get; set; }

    public int? TknOpeNumerW { get; set; }

    public short? TknOpeLpW { get; set; }

    public short? TknOpeTypZ { get; set; }

    public int? TknOpeFirmaZ { get; set; }

    public int? TknOpeNumerZ { get; set; }

    public short? TknOpeLpZ { get; set; }

    public short? TknOpeTypR { get; set; }

    public int? TknOpeFirmaR { get; set; }

    public int? TknOpeNumerR { get; set; }

    public short? TknOpeLpR { get; set; }

    public short? TknOdoTyp { get; set; }

    public int? TknOdoFirma { get; set; }

    public int? TknOdoNumer { get; set; }

    public short? TknOdoLp { get; set; }

    public int? TknId { get; set; }

    public byte? TknZaksiegowano { get; set; }

    public short? TknLicznikkopii { get; set; }

    public string? TknSposobDostawy { get; set; }

    public int? TknAktywny { get; set; }

    public int? TknRokMiesiac { get; set; }

    public string? TknWsk { get; set; }

    public short? TknKnDtyp { get; set; }

    public int? TknKnDfirma { get; set; }

    public int? TknKnDnumer { get; set; }

    public short? TknKnDlp { get; set; }

    public string? TknUrl { get; set; }

    public virtual ICollection<Tkelem> Tkelems { get; set; } = new List<Tkelem>();
}

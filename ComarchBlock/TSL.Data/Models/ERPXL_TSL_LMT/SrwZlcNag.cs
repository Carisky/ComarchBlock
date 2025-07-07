using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SrwZlcNag
{
    public int SznId { get; set; }

    public short? SznKntTyp { get; set; }

    public int? SznKntNumer { get; set; }

    public short? SznKnAtyp { get; set; }

    public int? SznKnAnumer { get; set; }

    public short? SznKnDtyp { get; set; }

    public int? SznKnDnumer { get; set; }

    public short? SznAdWtyp { get; set; }

    public int? SznAdWnumer { get; set; }

    public short? SznKnPtyp { get; set; }

    public int? SznKnPnumer { get; set; }

    public int? SznAdPnumer { get; set; }

    public int? SznDataWystawienia { get; set; }

    public int? SznGodzinaWystawienia { get; set; }

    public int? SznDataRozpoczecia { get; set; }

    public int? SznGodzinaRozpoczecia { get; set; }

    public short? SznRok { get; set; }

    public byte? SznMiesiac { get; set; }

    public string? SznSeria { get; set; }

    public int? SznNumer { get; set; }

    public string? SznDokumentObcy { get; set; }

    public int? SznFrsId { get; set; }

    public int? SznFrmNumer { get; set; }

    public short? SznExpoNorm { get; set; }

    public short? SznKnStyp { get; set; }

    public int? SznKnSnumer { get; set; }

    public short? SznKnSlp { get; set; }

    public short? SznKnStypD { get; set; }

    public int? SznKnSnumerD { get; set; }

    public short? SznKnSlpD { get; set; }

    public short? SznKnStypP { get; set; }

    public int? SznKnSnumerP { get; set; }

    public short? SznKnSlpP { get; set; }

    public int? SznOpeNumerW { get; set; }

    public int? SznOpeNumerM { get; set; }

    public int? SznOpeNumerP { get; set; }

    public int? SznDataP { get; set; }

    public string? SznOpisP { get; set; }

    public int? SznFiaskoId { get; set; }

    public int? SznOpeNumerZ { get; set; }

    public int? SznDataZ { get; set; }

    public string? SznOpisZ { get; set; }

    public int? SznOpiNumer { get; set; }

    public byte? SznStan { get; set; }

    public string? SznOpis { get; set; }

    public int? SznAktywny { get; set; }

    public short? SznWsk { get; set; }

    public string? SznUrl { get; set; }

    public byte? SznFormaNr { get; set; }

    public string? SznFormaNazwa { get; set; }

    public decimal? SznFormaRabat { get; set; }

    public int? SznTerminPlatnosci { get; set; }

    public string? SznCechaOpis { get; set; }

    public int? SznMagZnumer { get; set; }

    public string? SznFlagaNb { get; set; }

    public string? SznWaluta { get; set; }

    public short? SznNrKursu { get; set; }

    public short? SznCenaSpr { get; set; }

    public byte? SznRezerwujZasoby { get; set; }

    public byte? SznPriorytetRez { get; set; }

    public int? SznDataAktywacjiRez { get; set; }

    public int? SznDataWaznosciRez { get; set; }

    public decimal? SznRabat { get; set; }

    public decimal? SznRabatW { get; set; }

    public decimal? SznRabatPromocyjnyGlobalny { get; set; }

    public int? SznPromocje { get; set; }

    public int? SznSlwStatus { get; set; }

    public int? SznOpeNumerO { get; set; }

    public byte? SznTerminarz { get; set; }

    public int? SznCzasPrzypomnienia { get; set; }

    public byte? SznCzasPrzypomnieniaJedn { get; set; }

    public byte? SznRezZasTylkoAktywne { get; set; }

    public int? SznZewnetrznySys { get; set; }

    public int? SznZewnetrznyId { get; set; }

    public int? SznPrjId { get; set; }

    public int? SznLastMod { get; set; }

    public int? SznBlokadaEdycji { get; set; }

    public virtual ICollection<SrwZlcCzynnosci> SrwZlcCzynnoscis { get; set; } = new List<SrwZlcCzynnosci>();

    public virtual ICollection<SrwZlcKoszty> SrwZlcKoszties { get; set; } = new List<SrwZlcKoszty>();
}

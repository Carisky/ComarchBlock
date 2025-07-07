using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class BudzetPrjNag
{
    public int BpnId { get; set; }

    public string? BpnKod { get; set; }

    public string? BpnNazwa { get; set; }

    public byte? BpnStan { get; set; }

    public short? BpnRok { get; set; }

    public byte? BpnMiesiac { get; set; }

    public string? BpnSeria { get; set; }

    public int? BpnNumer { get; set; }

    public int? BpnWersjaId { get; set; }

    public byte? BpnArchiwalny { get; set; }

    public int? BpnAktywny { get; set; }

    public byte? BpnZamkniety { get; set; }

    public int? BpnStatusId { get; set; }

    public int? BpnPrjId { get; set; }

    public int? BpnUmNid { get; set; }

    public string? BpnUrl { get; set; }

    public string? BpnOpis { get; set; }

    public short? BpnKntTyp { get; set; }

    public int? BpnKntNumer { get; set; }

    public int? BpnDataRozpoczecia { get; set; }

    public int? BpnDataZakonczenia { get; set; }

    public int? BpnDataWystawienia { get; set; }

    public int? BpnDataPotwierdzenia { get; set; }

    public int? BpnOpeNumerW { get; set; }

    public int? BpnOpeNumerM { get; set; }

    public int? BpnOpeNumerZ { get; set; }

    public int? BpnOpeNumerK { get; set; }

    public int? BpnFrsId { get; set; }

    public int? BpnFrmNumer { get; set; }

    public byte? BpnOkresyRozbicia { get; set; }

    public int? BpnCzasModyfikacji { get; set; }

    public string? BpnDokumentObcy { get; set; }

    public int? BpnZmianaStanuId { get; set; }

    public int? BpnDataGwarancji { get; set; }

    public int? BpnDataPrzegladu { get; set; }

    public int? BpnOpeOdpowiedzialny { get; set; }

    public int? BpnCzasTrwania { get; set; }

    public byte? BpnCzasTrwaniaJedn { get; set; }

    public byte? BpnTypRozbicia { get; set; }

    public string? BpnRozbicieSql { get; set; }

    public byte? BpnOpisAnalitycznyDaty { get; set; }

    public byte? BpnZwinPoziom { get; set; }

    public byte? BpnZwinPoziomMax { get; set; }

    public byte? BpnAktualizujKosztyWyr { get; set; }

    public virtual ICollection<BudzetPrjElem> BudzetPrjElems { get; set; } = new List<BudzetPrjElem>();

    public virtual ICollection<BudzetPrjNagWaluty> BudzetPrjNagWaluties { get; set; } = new List<BudzetPrjNagWaluty>();
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PodElemDok
{
    public int PedPonnumer { get; set; }

    public short PedLp { get; set; }

    public short? PedTrptyp { get; set; }

    public int? PedTrpfirma { get; set; }

    public int? PedTrpnumer { get; set; }

    public short? PedTrplp { get; set; }

    public int? PedKnAnumer { get; set; }

    public int? PedKntNumer { get; set; }

    public string? PedNrFaktury { get; set; }

    public int? PedDataWystawienia { get; set; }

    public int? PedTerminPlat { get; set; }

    public byte? PedStronaWd { get; set; }

    public int? PedDataStanuRozliczen { get; set; }

    public int? PedDataWystZd { get; set; }

    public virtual KntAdresy? PedKnAnumerNavigation { get; set; }

    public virtual KntKarty? PedKntNumerNavigation { get; set; }

    public virtual ICollection<PodElemDokVat> PodElemDokVats { get; set; } = new List<PodElemDokVat>();

    public virtual TraPlat? TraPlat { get; set; }
}

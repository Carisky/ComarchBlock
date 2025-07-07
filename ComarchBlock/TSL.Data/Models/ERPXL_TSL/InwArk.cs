using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class InwArk
{
    public int InAId { get; set; }

    public int? InAInNid { get; set; }

    public int? InATstamp { get; set; }

    public short? InAOpeTyp { get; set; }

    public int? InAOpeFirma { get; set; }

    public int? InAOpeNumer { get; set; }

    public short? InAOpeLp { get; set; }

    public short? InAPrzyrostowa { get; set; }

    public string? InANazwa { get; set; }

    public string? InAOpis { get; set; }

    public byte? InAWtrakcieOdczytu { get; set; }

    public int? InAExtId { get; set; }

    public byte? InATylkoNiezerowe { get; set; }

    public int? InAAktywny { get; set; }

    public byte? InAStan { get; set; }

    public int? InAMgOid { get; set; }

    public int? InAMgAidOd { get; set; }

    public int? InAMgAidDo { get; set; }

    public byte? InAPowielanieTwr { get; set; }

    public byte? InAMultiEdycjaOdcz { get; set; }

    public byte? InARealizujWwms { get; set; }

    public byte? InATylkoJlogWms { get; set; }

    public string? InAGuid { get; set; }

    public int? InAPsAid { get; set; }

    public int? InACzasModyfikacji { get; set; }

    public virtual InwNag? InAInN { get; set; }

    public virtual ICollection<InwArkTwr> InwArkTwrs { get; set; } = new List<InwArkTwr>();

    public virtual ICollection<InwOdc> InwOdcs { get; set; } = new List<InwOdc>();
}

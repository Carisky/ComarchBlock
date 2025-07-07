using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class VatMarzaView
{
    public int VmpVaNid { get; set; }

    public int? VmpVanOrgId { get; set; }

    public int VmpVatId { get; set; }

    public int? VmpMrzaGrupa { get; set; }

    public decimal? VmpNettoInne { get; set; }

    public decimal? VmpVatInne { get; set; }

    public decimal? VmpStawkaInne { get; set; }

    public short? VmpFlagaInne { get; set; }

    public decimal? VmpNettoMarza { get; set; }

    public decimal? VmpVatMarza { get; set; }

    public decimal? VmpStawkaMarza { get; set; }

    public short? VmpFlagaMarza { get; set; }
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class BazModulyOperatora
{
    public int BmoBmoId { get; set; }

    public int? BmoOpeId { get; set; }

    public int? BmoBazId { get; set; }

    public string BmoSerwerKlucza { get; set; } = null!;

    public int BmoModulKp { get; set; }

    public int BmoModulKh { get; set; }

    public int BmoModulSt { get; set; }

    public int BmoModulFa { get; set; }

    public int BmoModulHa { get; set; }

    public int BmoModulPk { get; set; }

    public int BmoModulPkp { get; set; }

    public int BmoModulAnl { get; set; }

    public int BmoModulAnlp { get; set; }

    public int BmoModulCrm { get; set; }

    public int BmoModulCrmp { get; set; }

    public int BmoModulKhp { get; set; }

    public int BmoModulSrw { get; set; }

    public int BmoModulObd { get; set; }

    public int BmoModulKb { get; set; }

    public int BmoModulKbp { get; set; }

    public int BmoModulHap { get; set; }

    public int BmoUstawieniaOgolne { get; set; }

    public virtual Bazy? BmoBaz { get; set; }

    public virtual Operatorzy? BmoOpe { get; set; }
}

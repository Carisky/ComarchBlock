using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OpeListaZadanGenerator
{
    public int OpZgOpZgid { get; set; }

    public int OpZgSzablonId { get; set; }

    public int OpZgOpeId { get; set; }

    public int OpZgBazId { get; set; }

    public Guid? OpZgBazaGuid { get; set; }

    public DateTime OpZgTerminZadania { get; set; }

    public DateTime OpZgDataGen { get; set; }
}

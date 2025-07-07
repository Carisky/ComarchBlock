using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class FtpConfiguration
{
    public bool FcfIsGlobalConfiguration { get; set; }

    public bool FcfIsStatic { get; set; }

    public string FcfFcftid { get; set; } = null!;

    public string FcfFcfeidmain { get; set; } = null!;

    public string FcfFcflidmain { get; set; } = null!;

    public int? FcfDaysBackwardInMainInterval { get; set; }

    public int? FcfDaysBackwardInSubIntervalDown { get; set; }

    public int? FcfDaysBackwardInSubIntervalUp { get; set; }

    public string? FcfFcfeidsub { get; set; }

    public string? FcfFcflidsub { get; set; }

    public string? FcfDescription { get; set; }

    public string FcfName { get; set; } = null!;

    public bool FcfIsSystematic { get; set; }

    public bool? FcfIsActive { get; set; }

    public int FcfId { get; set; }

    public bool? FcfContinueOnError { get; set; }

    public bool FcfAnalizePrefixes { get; set; }

    public bool FcfAnalizeExtensions { get; set; }

    public bool FcfAnalizeDirectoryStructure { get; set; }

    public bool FcfAnalizeFileHeaders { get; set; }

    public bool FcfRemoveFromSourceFolder { get; set; }

    public virtual FtpConfigurationExpectedFile FcfFcfeidmainNavigation { get; set; } = null!;

    public virtual FtpConfigurationExpectedFile? FcfFcfeidsubNavigation { get; set; }

    public virtual FtpConfigurationLoadFilesType FcfFcflidmainNavigation { get; set; } = null!;

    public virtual FtpConfigurationLoadFilesType? FcfFcflidsubNavigation { get; set; }

    public virtual FtpConfigurationType FcfFcft { get; set; } = null!;

    public virtual ICollection<TableLink> TableLinks { get; set; } = new List<TableLink>();
}

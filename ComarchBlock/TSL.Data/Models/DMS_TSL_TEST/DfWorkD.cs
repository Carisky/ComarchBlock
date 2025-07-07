using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkD
{
    public int DwsId { get; set; }

    public int DwsDwdid { get; set; }

    public int DwsDdsid { get; set; }

    public DateTime DwsCreateDate { get; set; }

    public int? DwsDcdpersonId { get; set; }

    public int DwsActionType { get; set; }

    public int? DwsNatSosId { get; set; }

    public string? DwsMessage { get; set; }

    public int? DwsDcdreplacementPersonId { get; set; }

    public bool DwsIsCurrent { get; set; }

    public int? DwsTaskRealisationTimeLimitMinutes { get; set; }

    public DateTime? DwsTaskRealisationExpirationTime { get; set; }

    public DateOnly? DwsTaskRealisationSendReminderFromDate { get; set; }

    public bool DwsLimitedPermissions { get; set; }

    public bool DwsIsReturnFromStage { get; set; }

    public int? DwsDcdownerId { get; set; }

    public int? DwsDcdunfrozenBy { get; set; }

    public DateTime? DwsUnfreezeDate { get; set; }

    public bool DwsIsMailSentToPermitted { get; set; }

    public bool DwsIsMailSentToObservers { get; set; }

    public virtual ICollection<DfWork> DfWorks { get; set; } = new List<DfWork>();

    public virtual DfConfOsdictionary? DwsDcdperson { get; set; }

    public virtual DfConfOsdictionary? DwsDcdreplacementPerson { get; set; }

    public virtual DfConfDsdictionary DwsDds { get; set; } = null!;

    public virtual DfWork DwsDwd { get; set; } = null!;
}

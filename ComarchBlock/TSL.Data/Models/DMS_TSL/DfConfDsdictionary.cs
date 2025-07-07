using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfDsdictionary
{
    public int DdsId { get; set; }

    public string? DdsName { get; set; }

    public string? DdsComment1 { get; set; }

    public string? DdsComment2 { get; set; }

    public int? DdsDshid { get; set; }

    public bool DdsArchival { get; set; }

    public int? DdsPropagateAfterTime { get; set; }

    public bool? DdsSkipWorkOff { get; set; }

    public short DdsDesignation { get; set; }

    public int? DdsDdspropagateToStageId { get; set; }

    public bool? DdsPropagationEnabled { get; set; }

    public byte? DdsSendEmailMode { get; set; }

    public byte? DdsSendEmailToObserverMode { get; set; }

    public string? DdsConditions { get; set; }

    public bool? DdsAdditionalPermissions { get; set; }

    public int? DdsDefaultStageId { get; set; }

    public string? DdsDefaultStageName { get; set; }

    public bool? DdsAutoChangeDocOwner { get; set; }

    public string? DdsStageColor { get; set; }

    public bool DdsSendEmailAboutOutstandings { get; set; }

    public int DdsSendEmailAboutOutstandingsDayInterval { get; set; }

    public int DdsSendEmailAboutOutstandingsAtTime { get; set; }

    public bool DdsSendEmailAboutOutstandingsSkipWorkOff { get; set; }

    public bool? DdsSendEmailAboutOutstandingsMode { get; set; }

    public int? DdsSendEmailAboutOutstandingsDaysOfTheWeek { get; set; }

    public bool DdsSendReminderEmail { get; set; }

    public int DdsSendReminderEmailDayInterval { get; set; }

    public bool DdsSendReminderEmailSkipWorkOff { get; set; }

    public int DdsSendReminderEmailAtTime { get; set; }

    public bool? DdsSendReminderEmailMode { get; set; }

    public int? DdsSendReminderEmailDaysOfTheWeek { get; set; }

    public bool DdsTaskRealisationTimeLimit { get; set; }

    public int DdsTaskRealisationTimeLimitMinutes { get; set; }

    public bool DdsTaskRealisationTimeLimitSkipWorkOff { get; set; }

    public bool DdsAllowChangeTaskRealisationTimeLimitOnCurrentStage { get; set; }

    public bool DdsAllowChangeTaskRealisationTimeLimitOnPreviousStage { get; set; }

    public bool DdsAllowExcludingPermissionsOnPreviousStage { get; set; }

    public bool DdsSetInErpxltimetable { get; set; }

    public DateTime? DdsExpiredDocumentReminderSendMailDate { get; set; }

    public DateOnly? DdsDocumentReminderSendMailDate { get; set; }

    public DateOnly? DdsSendMailToPermittedDate { get; set; }

    public DateOnly? DdsSendMailToObserversDate { get; set; }

    public bool DdsDisableReturnDocumentToPreviousStage { get; set; }

    public int? DdsDdsdocumentApprovalStageId { get; set; }

    public bool DdsPropagationAfterAllOperatorsApproval { get; set; }

    public bool DdsPermissionsForOperatorNotWorkingWithDocument { get; set; }

    public int? DdsDkoattachmentControlToOpenAfterDocumentLoadId { get; set; }

    public int? DdsPropagateAfterTimeMinutes { get; set; }

    public int DdsSendEmailDayInterval { get; set; }

    public int DdsSendEmailAtTime { get; set; }

    public bool DdsSendEmailSkipWorkOff { get; set; }

    public int? DdsSendEmailDaysOfTheWeek { get; set; }

    public int DdsSendEmailToObserverDayInterval { get; set; }

    public int DdsSendEmailToObserverAtTime { get; set; }

    public bool DdsSendEmailToObserverSkipWorkOff { get; set; }

    public int? DdsSendEmailToObserverDaysOfTheWeek { get; set; }

    public int? DdsPosition { get; set; }

    public bool DdsTurnOnObserverWhileDocumentLoading { get; set; }

    public Guid? DdsGuid { get; set; }

    public virtual DfConfDshead? DdsDsh { get; set; }

    public virtual ICollection<DfConfDsctrlCondition> DfConfDsctrlConditions { get; set; } = new List<DfConfDsctrlCondition>();

    public virtual ICollection<DfConfDsscheme> DfConfDsschemes { get; set; } = new List<DfConfDsscheme>();

    public virtual ICollection<DfWorkD> DfWorkDs { get; set; } = new List<DfWorkD>();
}

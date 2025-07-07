using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class Subscription
{
    public int SubId { get; set; }

    public int? SubUserId { get; set; }

    public string SubSubscriptionName { get; set; } = null!;

    public int SubWhenFlag { get; set; }

    public DateTime? SubStartDate { get; set; }

    public DateTime? SubEndDate { get; set; }

    public DateTime? SubLastSent { get; set; }

    public int? SubLastSendCode { get; set; }

    public bool SubActive { get; set; }

    public int SubType { get; set; }

    public int? SubReportFormat { get; set; }

    public bool SubRenderPerRecipient { get; set; }

    public string? SubSender { get; set; }

    public bool SubRenderPerUserDatabases { get; set; }

    public bool? SubIsConditionDefine { get; set; }

    public int? SubConditionValueType { get; set; }

    public int? SubConditionComperType { get; set; }

    public int? SubConditionType { get; set; }

    public decimal? SubConditionValue { get; set; }

    public string? SubConditionDefinition { get; set; }

    public bool SubIsPathSet { get; set; }

    public string SubPath { get; set; } = null!;

    public int? SubCompanyId { get; set; }

    public string? SubDataModelParametersValues { get; set; }

    public string? SubEmailSubject { get; set; }

    public bool SubExpandReport { get; set; }

    public bool SubAppendFilters { get; set; }

    public bool SubMergeItems { get; set; }

    public virtual ICollection<ReportsStore> ReportsStores { get; set; } = new List<ReportsStore>();

    public virtual SubscriptionsDescription? SubscriptionsDescription { get; set; }

    public virtual ICollection<SubscriptionsFreeForm> SubscriptionsFreeForms { get; set; } = new List<SubscriptionsFreeForm>();

    public virtual ICollection<SubscriptionsFtpConnection> SubscriptionsFtpConnections { get; set; } = new List<SubscriptionsFtpConnection>();

    public virtual ICollection<SubscriptionsParameter> SubscriptionsParameters { get; set; } = new List<SubscriptionsParameter>();

    public virtual ICollection<SubscriptionsReport> SubscriptionsReports { get; set; } = new List<SubscriptionsReport>();

    public virtual ICollection<SubscriptionsScenario> SubscriptionsScenarios { get; set; } = new List<SubscriptionsScenario>();

    public virtual ICollection<SubscriptionsSchedule> SubscriptionsSchedules { get; set; } = new List<SubscriptionsSchedule>();
}

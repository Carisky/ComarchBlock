using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class DataModel
{
    public int DmoId { get; set; }

    public int DmoServiceId { get; set; }

    public string? DmoUniqueIdentifier { get; set; }

    public int DmoServer { get; set; }

    public int DmoDeployMode { get; set; }

    public int DmoModelId { get; set; }

    public TimeOnly? DmoRefreshTime { get; set; }

    public bool DmoIsMultiCompany { get; set; }

    public int? DmoDefinitionId { get; set; }

    public bool DmoUseDefaultConnection { get; set; }

    public bool DmoDirectQueryMode { get; set; }

    public string? DmoPermissions { get; set; }

    public string DmoModelGuid { get; set; } = null!;

    public bool DmoIsCustomModel { get; set; }

    public virtual ICollection<DataModelsQuery> DataModelsQueries { get; set; } = new List<DataModelsQuery>();

    public virtual DataModelsDefinition? DmoDefinition { get; set; }

    public virtual Connection DmoServerNavigation { get; set; } = null!;

    public virtual ICollection<ReportParameter> ReportParameters { get; set; } = new List<ReportParameter>();

    public virtual ICollection<Company> CdmCompanies { get; set; } = new List<Company>();

    public virtual ICollection<File> DmfFs { get; set; } = new List<File>();

    public virtual ICollection<Report> DmrReps { get; set; } = new List<Report>();
}

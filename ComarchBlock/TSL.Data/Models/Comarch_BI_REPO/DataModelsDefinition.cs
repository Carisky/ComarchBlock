using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class DataModelsDefinition
{
    public int DmdId { get; set; }

    public string? DmdName { get; set; }

    public string? DmdDefinition { get; set; }

    public virtual ICollection<AccountActive> AccountActives { get; set; } = new List<AccountActive>();

    public virtual ICollection<DataModel> DataModels { get; set; } = new List<DataModel>();

    public virtual ICollection<RegistrationUserModel> RegistrationUserModels { get; set; } = new List<RegistrationUserModel>();

    public virtual ICollection<WorkMode> WorkModes { get; set; } = new List<WorkMode>();
}

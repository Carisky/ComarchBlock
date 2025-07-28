using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TSL.Data.Models.ERPXL_TSL;
using ComarchBlock.dto;
using ComarchBlock.entities;

namespace ComarchBlock.utils
{
    public class AppInitializer
    {
        public AppConfig? Config { get; private set; }
        public Dictionary<string, UserGroupEntry> UserGroups { get; private set; } = new();
        public Dictionary<(string Group, string Module, int Hour), int> GroupModuleLimits { get; private set; } = new();
        public Dictionary<string, int> ModuleLimits { get; private set; } = new();
        public Dictionary<string, List<string>> LinkedModules { get; private set; } = new();
        public ERPXL_TSLContext? DbContext { get; private set; }

        private readonly string _connStr = "Server=TSLCOMARCHDB;Database=ERPXL_TSL;User Id=sa_tsl;Password=@nalizyGrudzien24@;TrustServerCertificate=True;";

        public bool Initialize()
        {
            Config = LoadConfig("config.xml");
            if (Config == null)
                return false;

            var options = new DbContextOptionsBuilder<ERPXL_TSLContext>().UseSqlServer(_connStr).Options;
            DbContext = new ERPXL_TSLContext(options);

            if (DbContext == null)
                return false;

            UserGroups = DbContext.UserGroupsDb
                .ToDictionary(x => x.UserName, x => new UserGroupEntry
                {
                    Group = x.Group,
                    WindowsUser = x.WindowsUser
                });

            GroupModuleLimits = DbContext.GroupModuleLimitsDb
                .ToDictionary(x => (x.GroupCode, x.Module, x.Hour), x => x.MaxLicenses);

            ModuleLimits = DbContext.ModuleLimitsDb
                .ToDictionary(x => x.Module, x => x.MaxLicenses);

            LinkedModules = DbContext.LinkedModulesDb
                .AsEnumerable()
                .GroupBy(x => x.ModuleKey)
                .ToDictionary(g => g.Key, g => g.Select(l => l.LinkedModule).ToList());

            return true;
        }

        private static AppConfig? LoadConfig(string path)
        {
            try
            {
                var config = AppConfig.Load(path);
                SessionManager.Log("INFO", $"Loaded config. ActiveUsersCheck = {config.ActiveUsersCheck}");
                return config;
            }
            catch (Exception ex)
            {
                SessionManager.Log("ERROR", $"Failed to load config: {ex.Message}");
                return null;
            }
        }

    }
}

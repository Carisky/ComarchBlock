using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TSL.Data.Models.ERPXL_TSL;
using ComarchBlock.dto;

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

            UserGroups = LoadJson<Dictionary<string, UserGroupEntry>>("UserGroups.json");
            var groupLimitList = LoadJson<List<GroupModuleLimit>>("GroupModuleLimits.json");
            GroupModuleLimits = groupLimitList.ToDictionary(x => (x.GroupCode, x.Module, x.Hour), x => x.MaxLicenses);
            ModuleLimits = LoadJson<Dictionary<string, int>>("ModuleLimits.json");
            LinkedModules = LoadJson<Dictionary<string, List<string>>>("LinkedModules.json");

            var options = new DbContextOptionsBuilder<ERPXL_TSLContext>().UseSqlServer(_connStr).Options;
            DbContext = new ERPXL_TSLContext(options);

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

        private static T LoadJson<T>(string path) where T : new()
        {
            try
            {
                if (!File.Exists(path)) return new();
                var json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<T>(json) ?? new();
            }
            catch (Exception ex)
            {
                SessionManager.Log("ERROR", $"Failed to load {path}: {ex.Message}");
                return new();
            }
        }
    }
}

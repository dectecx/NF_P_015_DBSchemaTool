using NF_P_015_DBSchemaTool.Models;
using System.Collections.Generic;

namespace NF_P_015_DBSchemaTool.ViewModels
{
    public class OverviewVm
    {
        public IList<TableInfo> TableInfos { get; set; } = new List<TableInfo>();
    }
}
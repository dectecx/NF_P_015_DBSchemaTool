using System.Collections.Generic;

namespace NF_P_015_DBSchemaTool.Models
{
    public class TableInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public IList<Column> Columns { get; set; } = new List<Column>();

        public class Column
        {
            public string Name { get; set; }
            public string Description { get; set; }

            // TODO:改成enum或const
            public string ColumnType { get; set; }
            public bool IsPrimaryKey { get; set; }
            public bool NotNull { get; set; }
            public string DefaultValue { get; set; }
            public string Note { get; set; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryGenerator
{
    class QueryBuilder
    {
        private string tableName;
        private string tableColumn;
        private string columnValues;

        public QueryBuilder(string tableName)
        {
            this.tableName = tableName;
        }

        public QueryBuilder(string tableName, string tableColumn, string columnValue)
        {
            this.tableName = tableName;
            this.tableColumn = tableColumn;
            this.columnValues = columnValue;
        }

        public string insertQuery(List<string> columns, List<string> values)
        {
            return $"INSERT INTO {this.tableName} ({String.Join(", ", columns)}) VALUES({String.Join(", ", values.Select(f => "\'" + f + "\'"))});";
        }

        public string listQuery(List<string> columns, List<string> values, List<QueryBuilder> queryData)
        {
            if (!values.Any())
            {
                return $"SELECT {(!columns.Any() ? "*" : String.Join(", ", columns))} FROM {this.tableName};";
            }

            if (!queryData.Any() && !values.Any())
            {
                return $"SELECT {(!columns.Any() ? "*" : String.Join(", ", columns))} FROM {this.tableName};";
            }

            return $"SELECT {(!columns.Any() ? "*" : String.Join(", ", columns))} FROM {this.tableName} {"WHERE " + (String.Join(", ", queryData.Select(f => f.tableColumn + "=" + "\"" + f.columnValues + "\"")))};";
        }

        public string updateQuery(List<QueryBuilder> queryData)
        {
            if (!queryData.Any())
            {
                return "Please select the editable columns and appropriate values";
            }

            var idendifier = queryData.First();

            return $"UPDATE {this.tableName} SET {String.Join(", ", queryData.Select(f => f.tableColumn + "=" + "\"" + f.columnValues + "\""))} WHERE {idendifier.tableName +  "=" + "\"" + idendifier.columnValues + "\""};";
        }

        public string deleteQuery(List<QueryBuilder> queryData)
        {
            if (!queryData.Any())
            {
                return "Please select the deletable columns";
            }

            var idendifier = queryData.First();

            return $"DELETE FROM {this.tableName} WHERE {idendifier.tableName + "=" + "\"" + idendifier.columnValues + "\""};";
        }

        public string truncateTable()
        {
            return $"TRUNCATE TABLE {this.tableName};";
        }

        public string destoryTable()
        {
            return $"DROP TABLE {this.tableName};";
        }

    }
}

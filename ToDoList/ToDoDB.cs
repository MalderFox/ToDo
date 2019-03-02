// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ToDoList {

    /// <summary>
    /// Перечисление столбцов, в которые были сделаны изменения.
    /// </summary>
    [Flags]
    enum RecordColumn {
        Nothing = 0,
        Title = 1,
        Text = 2,
        Level = 4,
        Start = 8
    }

    /// <summary>
    /// Работа с БД.
    /// </summary>
    class ToDoDB {

        readonly string connectionString;

        public ToDoDB() {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(local)\SQLEXPRESS";
            builder.InitialCatalog = "test";
            builder.IntegratedSecurity = true;
            connectionString = builder.ConnectionString;
        }

        public List<Record> GetAll() {
            List<Record> list = new List<Record>();
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                using (SqlCommand command = connection.CreateCommand()) {
                    command.CommandText = "select * from todo";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                        while (reader.Read())
                            list.Add(new Record((int)reader[0],
                                                (string)reader[1],
                                                (string)reader[2],
                                                (Level)reader[3],
                                                (DateTime)reader[4],
                                                reader[5] as DateTime?));
                }
            }
            return list;
        }

        public void AddRecord(Record record) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                using (SqlCommand command = connection.CreateCommand()) {
                    string finishValue = record.Finish == null ? "null" : "'" + record.Finish.ToString() + "'";
                    command.CommandText = "insert into todo values" +
                                          $"('{record.Title}', '{record.Text}', {(int)record.Level}, '{record.Start}', {finishValue})";
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRecord(int recordID) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                using (SqlCommand command = connection.CreateCommand()) {
                    command.CommandText = $"delete from todo where id = {recordID}";
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(int recordID, Record newRecord, RecordColumn columns) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                using (SqlCommand command = connection.CreateCommand()) {
                    List<string> updateList = new List<string>();
                    if (columns.HasFlag(RecordColumn.Title))
                        updateList.Add($"title = '{newRecord.Title}'");
                    if (columns.HasFlag(RecordColumn.Text))
                        updateList.Add($"text = '{newRecord.Text}'");
                    if (columns.HasFlag(RecordColumn.Level))
                        updateList.Add($"level = {(int)newRecord.Level}");
                    if (columns.HasFlag(RecordColumn.Start))
                        updateList.Add($"start = '{newRecord.Title}'");
                    if (updateList.Count > 0) {
                        command.CommandText = $"update todo set {string.Join(",", updateList)} where id = {recordID}";
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// Добавить дату и время, когда запись считается завершённой.
        /// </summary>
        public DateTime Finish(int recordID) {
            DateTime dateTime = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                using (SqlCommand command = connection.CreateCommand()) {
                    command.CommandText = $"update todo set finish = '{dateTime}' where id = {recordID}";
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            return dateTime;
        }

    }

}

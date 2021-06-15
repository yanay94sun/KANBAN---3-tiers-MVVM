﻿using IntroSE.Kanban.Backend.DataAccessLayer.DTOs;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IntroSE.Kanban.Backend.DataAccessLayer
{
    public class TaskDALController : DALController
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);


        private const string TasksTableName = "Tasks";

        public TaskDALController() : base(TasksTableName)
        {

        }


        public List<TaskDTO> SelectAllTasksForColumn(string boardName, string creator, long columnOrdinal)
        {
            string query = $"SELECT * FROM {TasksTableName} " +
                $"WHERE {TaskDTO.CreatorColumnName} = {creator} and {TaskDTO.BoardNameColumnName} = {boardName} and {TaskDTO.ColumnOrdinalColumnName} = {columnOrdinal} ";
            List<TaskDTO> result = Select().Cast<TaskDTO>().ToList();
            return result;
        }


        /// <summary>
        /// Insert new task into the dataBase
        /// </summary>
        /// <param name="DTOobj"></param>
        /// <returns> return true if any record affected </returns>
        public override bool Insert(DTO DTOobj)
        {
            TaskDTO task = (TaskDTO)DTOobj;
            using (var connection = new SQLiteConnection(_connectionString))
            {
                int res = -1;
                SQLiteCommand command = new SQLiteCommand(null, connection);
                try
                {
                    connection.Open();
                    command.CommandText = $"INSERT INTO {TasksTableName} ({TaskDTO.IdColumnName} ,{TaskDTO.ColumnOrdinalColumnName}," +
                        $" {TaskDTO.CreationTimeColumnName}, {TaskDTO.dueDateColumnName}, {TaskDTO.TitleColumnName}, {TaskDTO.DescriptionColumnName}, " +
                        $"{TaskDTO.AssigneeColumnName}, {TaskDTO.BoardNameColumnName}, {TaskDTO.CreatorColumnName}) " +
                        $"VALUES (@idVal, @columnOrdinalVal, @creationTimeVal, @dueTimeVal, @titleVal, @descriptionVal, @assigneeVal, " +
                        $"@boardNameVal, @boardCreatorVal);";

                    SQLiteParameter idParam = new SQLiteParameter(@"idVal", task.TaskID);
                    SQLiteParameter columnOrdParam = new SQLiteParameter(@"columnOrdinalVal", task.ColumnOrdinal);
                    SQLiteParameter creationTimeParam = new SQLiteParameter(@"creationTimeVal", task.CreationTime);
                    SQLiteParameter dueTimeParam = new SQLiteParameter(@"dueTimeVal", task.DueTime);
                    SQLiteParameter titleParam = new SQLiteParameter(@"titleVal", task.Title);
                    SQLiteParameter descriptionParam = new SQLiteParameter(@"descriptionVal", task.Description);
                    SQLiteParameter assigneeParam = new SQLiteParameter(@"assigneeVal", task.Assignee);
                    SQLiteParameter boardNameParam = new SQLiteParameter(@"boardNameVal", task.Boardname);
                    SQLiteParameter boardCreatorParam = new SQLiteParameter(@"boardCreatorVal", task.Creator);


                    command.Parameters.Add(idParam);
                    command.Parameters.Add(columnOrdParam);
                    command.Parameters.Add(creationTimeParam);
                    command.Parameters.Add(dueTimeParam);
                    command.Parameters.Add(titleParam);
                    command.Parameters.Add(descriptionParam);
                    command.Parameters.Add(assigneeParam);
                    command.Parameters.Add(boardNameParam);
                    command.Parameters.Add(boardCreatorParam);
                    command.Prepare();

                    res = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //log error
                    log.Error(e.Message);
                    throw;

                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return res > 0;
            }
        }
        /// <summary> returns the max id in Tasks table </summary>
        internal int GetMaxTaskID()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(null, connection);
                command.CommandText = $"SELECT MAX(taskID) FROM {TasksTableName}";
                SQLiteDataReader dataReader = null;
                try
                {
                    connection.Open();
                    dataReader = command.ExecuteReader();
                    if (!dataReader.Read())
                        return 0;
                    return dataReader.GetInt32(0);
                }
                catch (Exception e)
                {
                    log.Error(e.Message);
                    throw;
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// delete task from the dataBase
        /// </summary>
        /// <param name="DTOobj"></param>
        /// <returns> retrun true if any recored affected </returns>
        public override bool Delete(DTO DTOobj)
        {

            TaskDTO task = (TaskDTO)DTOobj;
            using (var connection = new SQLiteConnection(_connectionString))
            {
                Console.WriteLine(_connectionString);
                int res = -1;
                SQLiteCommand command = new SQLiteCommand(null, connection);
                try
                {
                    connection.Open();
                    command.CommandText = $"DELETE FROM {TasksTableName} WHERE [{TaskDTO.BoardNameColumnName}] = @boardNameVal " +
                $"and [{TaskDTO.CreatorColumnName}] = @boardCreatorVal and [{TaskDTO.IdColumnName}] = @idVal" ;

                    SQLiteParameter creatorParam = new SQLiteParameter("@boardCreatorVal", task.Creator);
                    SQLiteParameter boardnameParam = new SQLiteParameter($"@boardNameVal", task.Boardname);
                    SQLiteParameter columnordinalParam = new SQLiteParameter($"@idVal", task.TaskID);




                    command.Parameters.Add(creatorParam);
                    command.Parameters.Add(boardnameParam);
                    command.Parameters.Add(columnordinalParam);
                    command.Prepare();

                    res = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //log error
                    log.Error(e.Message);
                    throw;
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return res > 0;
            }

        }
        
        protected override DTO ConvertReaderToObject(SQLiteDataReader reader)
        {
            return new TaskDTO(reader.GetString(7), reader.GetString(8), reader.GetInt32(1), reader.GetInt32(0),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(3), reader.GetString(2));
        }
        /// <summary>
        /// Delete all the tasks from the dataBase
        /// </summary>
        /// <returns> return true if any record affected </returns>
        public bool DeleteAllData()
        {
            return DeleteAllData(TasksTableName);
        }

    }
}

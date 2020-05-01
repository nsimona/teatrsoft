using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeatrLibrary.Models;
using Dapper;
using System.Linq;
using static TeatrLibrary.Enums;
using static TeatrLibrary.Structs;
using CsvHelper;
using System.Globalization;
using System.IO;

namespace TeatrLibrary.DataAccess
{
    class SQLConnector : IDataConnection
    {
        readonly string db = "teatrsoft";
        public PersonModel UpsertMember(PersonModel model, CrudAction action)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@statementType", action.ToString());
                parameter.Add("@name", model.Name);
                parameter.Add("@phone", model.Phone);
                parameter.Add("@mail", model.Mail);
                parameter.Add("@position", model.PositionId);
                parameter.Add("@photo", model.Photo);
                parameter.Add("@active", model.Active);

                if (action == CrudAction.create)
                    parameter.Add("@createdId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                else if (action == CrudAction.update)
                    parameter.Add("@id", model.Id);

                connection.Execute("dbo.spUpsertStaffMember", parameter, commandType: CommandType.StoredProcedure);

                if (action == CrudAction.create)
                    model.Id = parameter.Get<int>("@createdId");

                return model;
            }
        }
        public List<PersonModel> GetAllMembers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<PersonModel>("select * from StaffMember").ToList();
            }
        }
        public List<PersonModel> GetMembersByCategory(string category)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<PersonModel>("select * from StaffMember where Active = 1 and PositionId = " +
                    "(select id from Position where name = N'" + category + "')").ToList();
            }
        }
        public List<PersonModel> GetAvailableActors(Nullable<int> productionId = null)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@production_id", productionId);
                return connection.Query<PersonModel>("dbo.spGetAvailableActorsForProduction",
                    parameter,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public ProductionModel UpsertProduction(ProductionModel model, CrudAction action)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                if (action == CrudAction.update) connection.Query($"delete from ProductionActor where production_id = {model.Id}");

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@statementType", action.ToString());
                parameter.Add("@name", model.Name);
                parameter.Add("@premiere", model.Premiere);
                parameter.Add("@author", model.Author);
                parameter.Add("@director_id", model.DirectorId);
                parameter.Add("@description", model.Description);
                parameter.Add("@duration", model.Duration);
                parameter.Add("@poster", model.Poster);
                parameter.Add("@active", model.Active);

                if (action == CrudAction.create)
                    parameter.Add("@createdId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                else if (action == CrudAction.update)
                    parameter.Add("@id", model.Id);

                connection.Execute("dbo.spUpsertProduction", parameter, commandType: CommandType.StoredProcedure);
                if (action == CrudAction.create) model.Id = parameter.Get<int>("@createdId");

                foreach (PersonModel actor in model.Actors)
                {
                    DynamicParameters actorsParameters = new DynamicParameters();
                    actorsParameters.Add("@production_id", model.Id);
                    actorsParameters.Add("@actor_id", actor.Id);
                    connection.Execute("dbo.spUpsertProductionActor", actorsParameters, commandType: CommandType.StoredProcedure);
                }


                List<ProductionEventModel> savedDates = GetProductionDates(connection, model.Id);
                foreach (ProductionEventModel addedEvent in model.Dates)
                {
                    if (addedEvent.Id != 0)
                    {
                        // TODO delete previously saved events
                        if (savedDates.Any(d => d.Id == addedEvent.Id)) continue;
                        else connection.Query($"delete from EventDate where Id = {addedEvent.Id}");
                    }
                    else
                    {
                        DynamicParameters datesParameter = new DynamicParameters();
                        datesParameter.Add("@production_id", model.Id);
                        datesParameter.Add("@scene_id", addedEvent.SceneId);
                        datesParameter.Add("@date", addedEvent.Date);
                        datesParameter.Add("@time", addedEvent.Time);
                        connection.Execute("dbo.spUpsertEventDate", datesParameter, commandType: CommandType.StoredProcedure);
                    }
                }
            }
            return model;
        }
        public List<ProductionModel> GetAllProductions()
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                List<ProductionModel> productions = connection.Query<ProductionModel>("dbo.spGetAllProductions", null, commandType: CommandType.StoredProcedure).ToList();
                foreach (ProductionModel production in productions)
                {
                    production.Dates = GetProductionDates(connection, production.Id);
                    production.Actors = GetProductionActors(connection, production.Id);
                }
                return productions;
            }
        }
        private List<ProductionEventModel> GetProductionDates(IDbConnection connection, int productionId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@production_id", productionId);

            return connection.Query<ProductionEventModel>("dbo.spGetAllDatesForProduction",
                parameters,
                commandType: CommandType.StoredProcedure).ToList();
        }
        private List<PersonModel> GetProductionActors(IDbConnection connection, int productionId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@production_id", productionId);

            return connection.Query<PersonModel>("dbo.spGetAllActorsForProduction",
                parameters,
                commandType: CommandType.StoredProcedure).ToList();
        }
        public List<Position> GetPositions()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<Position>("select * from Position").ToList();
            }
        }
        public List<SceneModel> GetScenes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<SceneModel>("select * from Scene").ToList();
            }
        }
        public SceneModel GetScene(int sceneId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<SceneModel>($"select * from Scene where id={sceneId}").ToList()[0];
            }
        }

        public void ReserveTickets(ProductionEventModel model, List<Seat> seats)
        {
            string reservedSeats = "";
            foreach (Seat s in seats)
                reservedSeats += s.ToString();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@event_id", model.Id);
                parameter.Add("@seats", reservedSeats);
                parameter.Add("@seats_count", seats.Count);
                // TODO - improve SP
                connection.Execute("dbo.spReserveTickets", parameter, commandType: CommandType.StoredProcedure);
            }
        }

        public List<DateTime> GetAllEventDates()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<DateTime>($"select distinct Date from EventDate").ToList();
            }
        }

        public List<ProductionEventModel> GetAllDatesForMonth(int month)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            { 

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@month", month);
                return connection.Query<ProductionEventModel>("dbo.spGetProgramForMonth", parameter, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<ProductionEventModel> GetTodaysPlays(int limit = 3)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@limit", limit);
                return connection.Query<ProductionEventModel>("dbo.spGetTodaysPlays", parameter, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<ProductionEventModel> GetTomorrowsPlays(int limit = 3)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@limit", limit);
                return connection.Query<ProductionEventModel>("dbo.spGetTomorrowsPlays", parameter, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<ProductionModel> GetProductionsList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<ProductionModel>($"select Id, Name from Production").ToList();
            }
        }

        public string GetTotal(DateTime startDate, DateTime endDate, int productionId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@startdate", startDate);
                parameter.Add("@endDate", endDate);
                parameter.Add("@productionId", productionId);
                var records = connection.Query("dbo.spGetTotal", parameter, commandType: CommandType.StoredProcedure).ToList();

                string currentTime = DateTime.Now.ToString("ddMMyy_hhmmss");
                string fileName = $@"teatrsoft_export{currentTime}.csv";
                string directionPath =
                Path.Combine(
                    Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName,
                    "Exports\\" + fileName
                );
                StreamWriter outputFile = new StreamWriter(directionPath, false, new UTF8Encoding(true));
                using (var csv = new CsvWriter(outputFile, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                }
                return fileName;
            }
        }
    }
}

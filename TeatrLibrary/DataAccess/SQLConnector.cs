using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeatrLibrary.Models;
using Dapper;
using System.Linq;

namespace TeatrLibrary.DataAccess
{
    class SQLConnector : IDataConnection
    {
        readonly string db = "teatrsoft";
        public PersonModel AddMember(PersonModel person)
        {
           using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
           {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@statementType", "insert");
                parameter.Add("@name", person.Name);
                parameter.Add("@phone", person.Phone);
                parameter.Add("@mail", person.Mail);
                parameter.Add("@position", person.Position);
                parameter.Add("@photo", person.Photo);
                parameter.Add("@createdId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUpsertStaffMember", parameter, commandType: CommandType.StoredProcedure);

                person.Id = parameter.Get<int>("@createdId");

                return person;
           }
        }
        public void UpdateMember(PersonModel person)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@statementType", "update");
                parameter.Add("@id", person.Id);
                parameter.Add("@name", person.Name);
                parameter.Add("@phone", person.Phone);
                parameter.Add("@mail", person.Mail);
                parameter.Add("@position", person.Position);
                parameter.Add("@photo", person.Photo);
                parameter.Add("@active", person.Active);

                connection.Execute("dbo.spUpsertStaffMember", parameter, commandType: CommandType.StoredProcedure);
            }
        }
        public List<PersonModel> GetAllMembers(string sort = null) 
        {
            List<PersonModel> staffMembers = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var queryMembers = new List<dynamic>();
                if (sort == null)
                    queryMembers = connection.Query("select * from StaffMember").ToList();
                else
                    queryMembers = connection.Query("select * from StaffMember order by name " + sort).ToList();

                foreach (var member in queryMembers)
                {
                    staffMembers.Add(new PersonModel(
                        member.name, 
                        position: member.position_id, 
                        id: member.id, 
                        phone: member.phone, 
                        mail: member.mail, 
                        photo: member.photo, 
                        active: member.active)
                    );
                }

            }
            return staffMembers;
        }
        public List<PersonModel> GetMembersByCategory(string category)
        {
            List<PersonModel> actors = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var queryActors = connection.Query("select * from StaffMember where active = 1 and position_id = " +
                    "(select id from Position where name = N'" + category + "')" ).ToList();
                foreach(var actor in queryActors)
                {
                    actors.Add(new PersonModel(
                        actor.name, 
                        position: actor.position_id, 
                        id: actor.id, 
                        phone: actor.phone, 
                        mail: actor.mail, 
                        photo: actor.photo)
                    );
                }
            }
            return actors;
        }
        public PersonModel GetMember(int id)
        {
            PersonModel person = new PersonModel();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var queryMember = connection.Query("select * from StaffMember where active = 1 and id =" + id).ToList();
                foreach (var member in queryMember)
                {
                    person.Name = member.name;
                    person.Phone = member.phone;
                    person.Mail = member.mail;
                    person.Position = member.position_id;
                    person.Photo = member.photo;
                    person.Id = member.id;
                }
                
            }
            return person;
        }
        public ProductionModel AddProduction(ProductionModel production)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                InsertProduction(connection, production);
                AddActorsToProduction(connection, production);
                AddDatesToProduction(connection, production);
                return production;
            }
            
        }
        public ProductionModel InsertProduction(IDbConnection connection, ProductionModel model)
        {
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@statementType", "insert");
            parameter.Add("@name", model.Name);
            parameter.Add("@premiere", model.Premiere);
            parameter.Add("@author", model.Author);
            parameter.Add("@director_id", model.Director);
            parameter.Add("@description", model.Description);
            parameter.Add("@duration", model.Duration);
            parameter.Add("@poster", model.PosterFileName);
            parameter.Add("@createdId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spUpsertProduction", parameter, commandType: CommandType.StoredProcedure);

            model.Id = parameter.Get<int>("@createdId");
            return model;
        }
        public List<PersonModel> AddActorsToProduction(IDbConnection connection, ProductionModel model)
        {
            foreach (PersonModel actor in model.Actors)
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@statementType", "insert");
                parameter.Add("@production_id", model.Id);
                parameter.Add("@actor_id", actor.Id);
                connection.Execute("dbo.spUpsertProductionActor", parameter, commandType: CommandType.StoredProcedure);
            }
            return model.Actors;
        }
        public List<ProductionEventModel> AddDatesToProduction(IDbConnection connection, ProductionModel model)
        {
            
            foreach (ProductionEventModel addedEvent in model.Dates)
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@statementType", "insert");
                parameter.Add("@production_id", model.Id);
                parameter.Add("@scene_id", addedEvent.Scene);
                parameter.Add("@date", addedEvent.Date);
                parameter.Add("@time", addedEvent.Time);
                connection.Execute("dbo.spUpsertEventDate", parameter, commandType: CommandType.StoredProcedure);
            }
            return model.Dates;
            
        }
        public List<ProductionModel> GetAllProductions()
        {
            List<ProductionModel> productions = new List<ProductionModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var queryProductions = connection.Query("dbo.spGetAllProductions", null, commandType: CommandType.StoredProcedure).ToList();
                foreach (var production in queryProductions)
                {
                    List<ProductionEventModel> events = GetAllEvenetsForProduction(connection, production.id);
                    productions.Add(new ProductionModel(
                        production.id,
                        production.name,
                        production.premiere,
                        production.author,
                        production.director_id,
                        production.description,
                        production.poster,
                        new List<PersonModel>(),
                        events,
                        (short)production.duration,
                        directorName: production.directorName
                    ));
                }

            }
            return productions;
        }

        private List<ProductionEventModel> GetAllEvenetsForProduction(IDbConnection connection, int id)
        {
            List<ProductionEventModel> events = new List<ProductionEventModel>();
            var queryEvents = connection.Query("select * from EventDate where production_id = " + id).ToList();
            foreach(var e in queryEvents)
            {
                events.Add(new ProductionEventModel(e.id, (DateTime)e.date, (TimeSpan)e.time));
            }
            return events;
    }
        public List<Position> GetPositions()
        {
            List<Position> positions = new List<Position>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var queryPositions = connection.Query("select * from Position").ToList();
                foreach (var position in queryPositions)
                {
                    positions.Add(new Position(position.id, position.name));
                }

            }
            return positions;
        }

        public List<SceneModel> GetScenes()
        {
            List<SceneModel> scenes = new List<SceneModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                
                var queryScenes = connection.Query("select * from Scene").ToList();

                foreach (var scene in queryScenes)
                {
                    scenes.Add(
                        new SceneModel(
                            scene.id,
                            scene.name,
                            scene.address,
                            scene.price,
                            scene.seats_count
                       )
                    );
                }

            }
            return scenes;
        }
    }
}

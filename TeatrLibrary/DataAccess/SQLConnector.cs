using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeatrLibrary.Models;
using Dapper;
using System.Linq;

//@id integer,
//@name nvarchar(50),
//	@phone nvarchar(25),
//	@mail varchar(100),
//	@position integer,
//    @picture varbinary(MAX),
//	@active bit,
//    @statementType varchar(20),
//	@createdId int = 0 output

namespace TeatrLibrary.DataAccess
{
    class SQLConnector : IDataConnection
    {
        public PersonModel AddPerson(PersonModel person, string photoPath = null)
        {
           using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("teatrsoft")))
           {
                if(photoPath.Length > 0)
                {
                    // TODO - Copy the picture to PhotoLibrary/StaffMember
                }
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@statementType", "insert");
                parameter.Add("@name", person.Name);
                parameter.Add("@phone", person.Phone);
                parameter.Add("@mail", person.Mail);
                parameter.Add("@position", 1);
                parameter.Add("@photo", person.Photo);
                parameter.Add("@createdId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUpsertStaffMember", parameter, commandType: CommandType.StoredProcedure);

                person.Id = parameter.Get<int>("@createdId");

                return person;
           }
        }
        public List<PersonModel> GetAllMembers() 
        {
            return new List<PersonModel>();
        }
        public List<Position> GetPositions()
        {
            List<Position> positions = new List<Position>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("teatrsoft")))
            {
                var queryPositions = connection.Query("select * from Position").ToList();
                foreach (var position in queryPositions)
                {
                    positions.Add(new Position(position.id, position.name));
                }
                
            }
            return positions;

        }
    }
}

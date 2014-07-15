using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SqlSignalR
{
    public class Info
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Status { get; set; }
    }

    public class JobInfoRepository
    {
        public IEnumerable<Info> GetData()
        {
            using (
                var connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (
                    var command = new SqlCommand(@"SELECT [Id],[Name],[Family],[Status] FROM [dbo].[Info]", connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += dependency_OnChange;

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                        return reader.Cast<IDataRecord>()
                            .Select(x => new Info
                            {
                                Id = x.GetInt32(0),
                                Name = x.GetString(1),
                                Family = x.GetString(2),
                                Status = x.GetString(3)
                            }).ToList();
                }
            }
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            infoHub.Show();
        }
    }
}
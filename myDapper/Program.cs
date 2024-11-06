using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace myDapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection = "Data Source=juliocsantaman;Initial Catalog=TheTaskDB;Integrated Security=True;TrustServerCertificate=True";

            using(var db = new SqlConnection(connection))
            {
                // GET.
                // var sql = "SELECT * FROM dbo.TheTask";

                //foreach (var item in lst)
                //{
                //    Console.WriteLine($"item: {item.Title} - {item.Description} - {item.Priority} - {item.Summary} - {item.CreatedAt}");
                //}

                // GET BY ID.
                //var sql = "SELECT * FROM dbo.TheTask WHERE Id = '46D89227-ECA6-48C1-A78C-867A064BBD9F'";

                //var theTask = db.QueryFirst<TheTask>(sql);
                //Console.WriteLine($"item: {theTask.Title} - {theTask.Description} - {theTask.Priority} - {theTask.Summary} - {theTask.CreatedAt}");

                // CREATE.
                //DateTime today = DateTime.UtcNow;
                //var sql = "INSERT INTO dbo.TheTask (Id, CategoryId, Title, Description, Priority, CreatedAt, Summary) VALUES (@Id, @CategoryId, @Title, @Description, @Priority, @CreatedAt, @Summary)";

                //var parameters = new
                //{
                //    Id = Guid.Parse("8be3dbd9-3d33-49bb-baeb-8fb5fce4a399"),
                //    CategoryId = Guid.Parse("78D2EE38-8CD5-4709-A8DB-C697966575EF"),
                //    Title = "Task with Dapper",
                //    Description = "Desc Dapper",
                //    Priority = 2,
                //    CreatedAt = today,
                //    Summary = "The Summary"
                //};

                //var createdTask = db.Execute(sql, parameters);

                //Console.WriteLine($"Rows affected: {createdTask}");

                // UPDATE.
                //var sql = "UPDATE dbo.TheTask SET Title = @Title WHERE Id = '8BE3DBD9-3D33-49BB-BAEB-8FB5FCE4A399'";

                //var parameters = new
                //{
                //    Title = "Task with Dapper using UPDATE",
                //};

                //var updatedTask = db.Execute(sql, parameters);

                //Console.WriteLine($"Rows affected: {updatedTask}");

                // DELETE.
                var sql = "DELETE FROM dbo.TheTask WHERE Id = '8BE3DBD9-3D33-49BB-BAEB-8FB5FCE4A399'";

                var updatedTask = db.Execute(sql);

                Console.WriteLine($"Rows affected: {updatedTask}");




            }
        }
    }
}

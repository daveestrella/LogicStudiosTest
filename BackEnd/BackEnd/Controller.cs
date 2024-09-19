using Model.Tables;
using System.Data.SqlClient;

namespace BackEnd
{
    public static class Controller
    {
        public static List<Input> GetAllInputs()
        {
            List<Input> inputs = new List<Input>();
            //Esto se saca del appSettings
            string connectionString = "Server=.\\MSSQLLocalDB;Database=DAVID_ESTRELLA;Integrated Security = true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Ejemplo de una consulta
                    SqlCommand command = new SqlCommand("SELECT * FROM Input", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        inputs.Add(
                            new Input()
                            {
                                Id = reader.GetInt32(0),
                                FormId = reader.GetInt32(1),
                                Name = reader.GetString(2),
                                Type = reader.GetString(3)
                            });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return inputs;
        }

        public static List<Form> GetAllForms()
        {
            List<Form> forms = new List<Form>();
            //Esto se saca del appSettings
            string connectionString = "Server=.\\MSSQLLocalDB;Database=DAVID_ESTRELLA;IntegratedSecurity=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa.");

                    // Ejemplo de una consulta
                    SqlCommand command = new SqlCommand("SELECT * FROM Input", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        forms.Add(
                            new Form()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return forms;
        }
    }
}

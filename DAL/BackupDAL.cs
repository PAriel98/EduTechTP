using System.Configuration;
using System.Data.SqlClient;

namespace DAL 
{ 
    public class BackupDAL 
    { 
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["EduTechDB"].ConnectionString;
        public bool RealizarBackup(string rutaDestino)
        {
            string query = $@"BACKUP DATABASE [EduTechDB] TO DISK = '{rutaDestino}' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of EduTechDB';"; 
            using (SqlConnection conexion = new SqlConnection(connectionString)) 
            { 
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                { 
                    conexion.Open(); 
                    cmd.ExecuteNonQuery(); 
                    return true; 
                } 
            } 
        } 
        public bool RealizarRestore(string rutaOrigen) 
        { 
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString) 
            { 
                InitialCatalog = "master" 
            }; 
            string query = $@" ALTER DATABASE [EduTechDB] SET SINGLE\_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE [EduTechDB] FROM DISK = '{rutaOrigen}' WITH REPLACE; ALTER DATABASE [EduTechDB] SET MULTI\_USER;"; 
            using (SqlConnection conexion = new SqlConnection(builder.ConnectionString)) 
            { 
                using (SqlCommand cmd = new SqlCommand(query, conexion)) 
                { 
                    conexion.Open(); 
                    cmd.ExecuteNonQuery(); 
                    return true; 
                } 
            } 
        } 
    } 
}
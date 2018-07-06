using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EscuelaCDIS.Facultades
{
    public partial class facultad_i : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            AgregarFacultad();
        }

        #endregion

        #region Métodos
        public void AgregarFacultad()
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conexión"].ConnectionString;

            var nombre = txt_nombre.Text;
            var codigo = txt_codigo.Text;
            var fecha = txt_fecha.Text;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"INSERT INTO dbo.Facultad VALUES('{nombre}', '{codigo}', '{fecha}')";
            cmd.Connection = conn;

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            System.Threading.Thread.Sleep(3000);

            Response.Redirect("~/Alumnos/alumno_s.aspx");
        }
        #endregion
    }
}
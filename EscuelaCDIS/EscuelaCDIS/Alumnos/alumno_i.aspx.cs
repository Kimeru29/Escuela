using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EscuelaCDIS.Alumnos
{
    public partial class alumno_i : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            AgregarAlumno();
        }
        #endregion

        #region Métodos
        public void AgregarAlumno()
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conexión"].ConnectionString;

            var matricula = txt_matricula.Text;
            var nombre = txt_nombre.Text;
            var fecha = txt_fecha.Text;
            var semestre = txt_semestre.Text;
            var facultad = txt_facultad.Text;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"INSERT INTO dbo.Alumno VALUES({matricula}, '{nombre}', '{fecha}', {semestre}, {facultad})";
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
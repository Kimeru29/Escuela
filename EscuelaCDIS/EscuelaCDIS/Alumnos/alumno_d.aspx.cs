using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscuelaCDIS.Alumnos
{
    public partial class alumno_d : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection() { ConnectionString = ConfigurationManager.ConnectionStrings["conexión"].ConnectionString };
        SqlCommand cmd = new SqlCommand();

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CargarAlumno(int.Parse(Request.QueryString["pMatrícula"]));
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAlumno();
        }
        #endregion

        #region Métodos
        public void CargarAlumno(int matricula)
        {
            var da = new SqlDataAdapter();
            var dtAlumnos = new DataTable();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM dbo.Alumno WHERE matricula = {matricula}";
            cmd.Connection = conn;

            conn.Open();

            da.SelectCommand = cmd;
            da.Fill(dtAlumnos);

            conn.Close();

            lbl_matricula.Text = dtAlumnos.Rows[0]["matricula"].ToString();
            lbl_nombre.Text = dtAlumnos.Rows[0]["nombre"].ToString();
            lbl_fecha.Text = dtAlumnos.Rows[0]["fechaNacimiento"].ToString();
            lbl_semestre.Text = dtAlumnos.Rows[0]["semestre"].ToString();
            lbl_facultad.Text = dtAlumnos.Rows[0]["facultad"].ToString();
        }

        public void EliminarAlumno()
        {
            var matricula = lbl_matricula.Text;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"DELETE FROM dbo.Alumno WHERE matricula = {matricula}";
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
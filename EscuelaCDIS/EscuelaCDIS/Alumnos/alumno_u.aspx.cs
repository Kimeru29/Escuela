using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EscuelaCDIS.Alumnos
{
    public partial class alumno_u : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(){ ConnectionString = ConfigurationManager.ConnectionStrings["conexión"].ConnectionString };
        SqlCommand cmd = new SqlCommand();

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                CargarAlumno(int.Parse(Request.QueryString["pMatrícula"]));
        }

        protected void btnGuardar_Click(object sender, EventArgs e) => ModificarAlumno();

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
            txt_nombre.Text = dtAlumnos.Rows[0]["nombre"].ToString();
            txt_fecha.Text = dtAlumnos.Rows[0]["fechaNacimiento"].ToString();
            txt_semestre.Text = dtAlumnos.Rows[0]["semestre"].ToString();
            txt_facultad.Text = dtAlumnos.Rows[0]["facultad"].ToString();
        }

        public void ModificarAlumno()
        {
            var matricula = lbl_matricula.Text;
            var nombre = txt_nombre.Text;
            var fecha = txt_fecha.Text;
            var semestre = txt_semestre.Text;
            var facultad = txt_facultad.Text;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE dbo.Alumno SET nombre = '{nombre}', fechaNacimiento = '{fecha}', semestre = {semestre}, facultad = {facultad} WHERE matricula = {matricula}";
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
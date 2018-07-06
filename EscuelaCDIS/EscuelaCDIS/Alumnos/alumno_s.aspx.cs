using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Configuration;

namespace EscuelaCDIS.Alumnos
{
    public partial class alumno_s : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grd_alumnos.DataSource = CargarAlumnos();
                grd_alumnos.DataBind();
            }

        }

        protected void grd_alumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
                Response.Redirect($"~/Alumnos/alumno_u.aspx?pMatrícula={e.CommandArgument}");
            else
                Response.Redirect($"~/Alumnos/alumno_d.aspx?pMatrícula={e.CommandArgument}");
        }

        protected void btnAgregar_Click(object sender, EventArgs e) => Response.Redirect("~/Alumnos/alumno_i.aspx");
        #endregion

        #region Métodos
        public DataTable CargarAlumnos()
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var da = new SqlDataAdapter();
            var dtAlumnos = new DataTable();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conexión"].ConnectionString;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.Alumno";
            cmd.Connection = conn;

            conn.Open();

            da.SelectCommand = cmd;
            da.Fill(dtAlumnos);

            conn.Close();

            return dtAlumnos;
        }
        #endregion

    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace EscuelaCDIS.Facultades
{
    public partial class facultad_s : Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grd_facultades.DataSource = CargarFacultades();
                grd_facultades.DataBind();
            }
        }

        protected void grd_facultades_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
                Response.Redirect($"~/Facultades/facultad_u?pId={e.CommandArgument}");
            else
                Response.Redirect($"~/Facultades/facultad_d?pId={e.CommandArgument}");
        }

        protected void btnGuardar_Click(object sender, EventArgs e) => Response.Redirect("~/Facultades/facultad_i.aspx");

        #endregion
        #region Métodos
        public DataTable CargarFacultades()
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var da = new SqlDataAdapter();
            var dtFacultades = new DataTable();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conexión"].ConnectionString; ;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.Facultad";
            cmd.Connection = conn;

            conn.Open();

            da.SelectCommand = cmd;
            da.Fill(dtFacultades);

            conn.Close();

            return dtFacultades;
        }
        #endregion
    }
}
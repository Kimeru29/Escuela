using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace EscuelaCDIS.Facultades
{
    public partial class facultad_d : Page
    {
        SqlConnection conn = new SqlConnection() { ConnectionString = ConfigurationManager.ConnectionStrings["conexión"].ConnectionString };
        SqlCommand cmd = new SqlCommand();

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                CargarFacultad(int.Parse(Request.QueryString["pId"]));
        }

        protected void btnEliminar_Click(object sender, EventArgs e) => EliminarFacultad();
        #endregion

        #region Métodos
        public void CargarFacultad(int id)
        {
            var da = new SqlDataAdapter();
            var dtFacultades = new DataTable();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conexión"].ConnectionString;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM dbo.Facultad WHERE id_facultad = {id}";
            cmd.Connection = conn;

            conn.Open();

            da.SelectCommand = cmd;
            da.Fill(dtFacultades);

            conn.Close();


            lbl_id.Text = dtFacultades.Rows[0]["id_facultad"].ToString();
            lbl_nombre.Text = dtFacultades.Rows[0]["nombre"].ToString();
            lbl_fecha.Text = dtFacultades.Rows[0]["fechaCreacion"].ToString();
            lbl_codigo.Text = dtFacultades.Rows[0]["codigo"].ToString();
        }

        //Lo que hice fué activar el cascade delete en la FK de Alumno, lo ideal sería crear una tabla en un schema temporal con los alumnos eliminados
        //por cascade, pero por motivos de solo la actividad supuse que sería hacer reingeniería.
        protected void EliminarFacultad()
        {
            var id = lbl_id.Text;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"DELETE FROM dbo.Facultad WHERE id_facultad = {id}";
            cmd.Connection = conn;

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            System.Threading.Thread.Sleep(3000);

            Response.Redirect("~/Facultades/facultad_s.aspx");
        }
        #endregion
    }
}
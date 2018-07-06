using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscuelaCDIS.Facultades
{
    public partial class facultad_u : Page
    {
        SqlConnection conn = new SqlConnection() { ConnectionString = ConfigurationManager.ConnectionStrings["conexión"].ConnectionString };
        SqlCommand cmd = new SqlCommand();

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                CargarFacultad(int.Parse(Request.QueryString["pId"]));
        }

        protected void btnGuardar_Click(object sender, EventArgs e) => ModificarFacultad();
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
            txt_nombre.Text = dtFacultades.Rows[0]["nombre"].ToString();
            txt_fecha.Text = dtFacultades.Rows[0]["fechaCreacion"].ToString();
            txt_codigo.Text = dtFacultades.Rows[0]["codigo"].ToString();
        }

        public void ModificarFacultad()
        {
            var nombre = txt_nombre.Text;
            var fecha = txt_fecha.Text;
            var codigo = txt_codigo.Text;
            var id = lbl_id.Text ;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE dbo.Facultad SET nombre = '{nombre}', fechaCreacion = '{fecha}', codigo = '{codigo}' WHERE id_facultad = {id}";
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
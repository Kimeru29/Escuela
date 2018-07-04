using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscuelaCDIS.Alumnos
{
    public partial class alumno_s : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grd_alumnos.DataSource = CargarAlumnos();
                grd_alumnos.DataBind();
            }
                
        }

        public DataTable CargarAlumnos()
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var da = new SqlDataAdapter();
            var dtAlumnos = new DataTable();

            conn.ConnectionString = @"Server=DESKTOP-JA9IPI9\SQL2016;Database=EscuelaCDIS;Trusted_connection=true";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.Alumno";
            cmd.Connection = conn;
            
            conn.Open();

            da.SelectCommand = cmd;
            da.Fill(dtAlumnos);

            conn.Close();

            return dtAlumnos;           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISSD_TP4_DLP3_DAI5_clase03
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
                string sql = "select * from UsuarioTipos";
                SqlConnection connection = new SqlConnection(cadenaConexion);
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DropDownList1.DataSource = reader;
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataTextField = "Descripcion";
                DropDownList1.DataBind();
                connection.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text != "" && TextBox2.Text != "" && DropDownList1.SelectedValue != "")
                {
                    string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
                    string sql = $@"insert into Usuarios (username, password, IdUsuarioTipo)
                        values ('{TextBox1.Text}', '{TextBox2.Text}', '{DropDownList1.SelectedValue}')";
                    using (SqlConnection connection = new SqlConnection(cadenaConexion))
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alerta", $"alert('Complete todos los controles.');", true);
                }
            }
            catch (Exception ex) {
                ClientScript.RegisterStartupScript(this.GetType(), "alerta", $"alert('{ex.Message}');", true);
            }
            
        }
    }
}
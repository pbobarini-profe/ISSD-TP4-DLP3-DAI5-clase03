using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISSD_TP4_DLP3_DAI5_clase03
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
                SqlConnection connection = new SqlConnection(cadenaConexion);
                connection.Open();
                //cargarListBox(connection);
                connection.Close();
                string sql = "select * from UsuarioTipos";
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
        private void cargarListBox(SqlConnection connection)
        {
            ListBox1.Items.Clear();
            string sql = "select * from Usuarios";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            ListBox1.DataSource = reader;
            ListBox1.DataValueField = "Id";
            ListBox1.DataTextField = "username";
            ListBox1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text != "" && TextBox2.Text != "")
                {
                    string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
                    string sql = $@"update Usuarios set 
                        username = '{TextBox1.Text}', 
                        password = '{TextBox2.Text}', 
                        IdUsuarioTipo = '{DropDownList1.SelectedValue}'
                        where id = '{ListBox1.SelectedValue}'";
                    using (SqlConnection connection = new SqlConnection(cadenaConexion))
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        //cargarListBox(connection);
                        ListBox1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alerta", $"alert('{ex.Message}');", true);
            }
        }
    }
}
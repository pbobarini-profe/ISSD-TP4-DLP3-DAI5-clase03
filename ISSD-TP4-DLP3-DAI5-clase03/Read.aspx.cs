using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISSD_TP4_DLP3_DAI5_clase03
{
    public partial class Read : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            string sql = @"select usuarios.id as idUsuario, username, password, idUsuarioTipo, descripcion from Usuarios
            inner join UsuarioTipos on usuariotipos.id = usuarios.id";
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            //Cabecera label
            Label1.Text = "IdUsuario - Username - Password - Tipo Usuario <br/> <hr/>";
            
            //Cabecera Table
            TableHeaderRow row = new TableHeaderRow();
            row.Cells.Add(new TableHeaderCell { Text = "ID" });
            row.Cells.Add(new TableHeaderCell { Text = "Username" });
            row.Cells.Add(new TableHeaderCell { Text = "Password" });
            row.Cells.Add(new TableHeaderCell { Text = "Tipo Usuario" });
            Table1.Rows.Add(row);

            while (reader.Read()) {
                //llenar label
                Label1.Text += $"{reader["idUsuario"].ToString()} - {reader["username"].ToString()} - {reader["password"].ToString()} - {reader["idUsuarioTipo"].ToString()} - {reader["descripcion"].ToString()} <br/>";

                //llenar tabla
                TableRow fila = new TableRow();
                fila.Cells.Add(new TableCell { Text = $"{reader["idUsuario"].ToString()}" });
                fila.Cells.Add(new TableCell { Text = $"{reader["username"].ToString()}" });
                fila.Cells.Add(new TableCell { Text = $"{reader["password"].ToString()}" });
                fila.Cells.Add(new TableCell { Text = $"{reader["idUsuarioTipo"].ToString()}-{reader["descripcion"].ToString()}" });
                Table1.Rows.Add(fila);
            }

            connection.Close();
        }
    }
}
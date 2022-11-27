using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gridview
{
    public partial class Form : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HQ54VJP\\SQLEXPRESS01;Integrated Security=True; Database=Northwind;");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Search", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@input", SearchTxt.Text);
            cmd.Parameters.Add(new SqlParameter()
            {
                Direction = ParameterDirection.Output,
                ParameterName = "@response",
                SqlDbType = SqlDbType.Int
            });
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@response"].Value.ToString() == "1")
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                GridTable.DataSource = dt;
                GridTable.DataBind();
                Lbl.Text = "";
            }
            else
            {

                Lbl.Text = "Not Found!";
                GridTable.DataSource = null;
                GridTable.DataBind();
            }
            con.Close();

        }
    }
}
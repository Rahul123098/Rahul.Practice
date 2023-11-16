using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Rahul.Practice
{
    public partial class UserShow : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=RAHUL\\SQLEXPRESS;initial Catalog=DB00_07;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridShow();

            }
        }

        public void GridShow()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblData join tblgender on dgender=gid join tblqualification on dqualification=qid", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gvusers.DataSource = dt;
            gvusers.DataBind();


        }



        protected void gvusers_RowCommand(object sender, GridViewCommandEventArgs e)

        {
            if (e.CommandName == "A")

            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from tblData where did='" + e.CommandArgument + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                DataBind();
            }

            else if (e.CommandName == "B")
            {

                Response.Redirect("Registration.aspx?pp=" +e.CommandArgument);
            
            }


        }
        
    }
}
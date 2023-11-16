using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Rahul.Practice
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=RAHUL\\SQLEXPRESS;initial Catalog=DB00_07;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bindgender();
                BindQualification();

            }

            if (Request.QueryString["pp"] != null && Request.QueryString["pp"].ToString()!="")

            {
                if (!IsPostBack)
                {

                    Edit();



                }

            }


        }

        public void Edit()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbldata where did='" + Request.QueryString["pp"] +"'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            txtname.Text = dt.Rows[0]["dname"].ToString();
            rblgender.SelectedValue = dt.Rows[0]["dgender"].ToString();
            txtemail.Text = dt.Rows[0]["demail"].ToString();
            txtpassword.Text = dt.Rows[0]["dpassword"].ToString();
            ddlqualification.SelectedValue = dt.Rows[0]["dqualification"].ToString();
            btnsubmit.Text = "Update";
        }

        public void Bindgender()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblgender",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            rblgender.DataValueField = "gid";
            rblgender.DataTextField = "gname";
            rblgender.DataSource = dt;
            rblgender.DataBind();
            
        }


        public void BindQualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblqualification",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ddlqualification.DataValueField = "qid";
            ddlqualification.DataTextField = "qname";
            ddlqualification.DataSource = dt;
            ddlqualification.DataBind();
            ddlqualification.Items.Insert(0,new ListItem("--Select--","0"));
        }




        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            if (btnsubmit.Text == "Submit")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tbldata(dname,dgender,demail,dpassword,dqualification)values('" + txtname.Text + "','" + rblgender.SelectedValue + "','" + txtemail.Text + "','" + txtpassword.Text + "','" + ddlqualification.SelectedValue + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("UserShow.aspx");
            }

            else if (btnsubmit.Text == "Update")
            {


                con.Open();
                SqlCommand cmdd = new SqlCommand("Update tbldata set dname='" + txtname.Text + "', dgender='" + rblgender.SelectedValue + "',demail='" + txtemail.Text + "',dpassword='" + txtpassword.Text + "',dqualification='" + ddlqualification.SelectedValue + "' where did='" + Request.QueryString["pp"] +"'", con);
                cmdd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("UserShow.aspx");





            }
        }
    }
}
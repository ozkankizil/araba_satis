using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using asp_araba_satis_sitesi_deneme.Classes;
using System.Data;

namespace asp_araba_satis_sitesi_deneme
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand commandLogIn = new SqlCommand("Select * from TUsers where strUserMail=@pmail and strUserPassword=@ppassword", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();

            string shaPassword = Sha256Converter.ComputeSha256Hash(TextBox2.Text);
            commandLogIn.Parameters.AddWithValue("@pmail", TextBox1.Text);
            commandLogIn.Parameters.AddWithValue("@ppassword", shaPassword);
            
            SqlDataReader dataReader = commandLogIn.ExecuteReader();

            if (dataReader.Read())
            {
                Response.Write("Giriş başarılı");
                Response.Redirect("CarList.aspx");


            }
            else
            {
                Response.Write("Giriş hatalı");
            }
            dataReader.Close();

                
        }
    }
}
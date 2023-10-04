using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using asp_araba_satis_sitesi_deneme.Classes;


namespace asp_araba_satis_sitesi_deneme
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string newPass = Sha256Converter.ComputeSha256Hash(TextBox2.Text);

            SqlCommand commandRegister = new SqlCommand("Insert into TUsers (strUserMail, strUserPassword) values (@pmail, @ppassword)", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();

            commandRegister.Parameters.AddWithValue("@pmail", TextBox1.Text);
            commandRegister.Parameters.AddWithValue("@ppassword", newPass);

            commandRegister.ExecuteNonQuery();

        }
    }
}
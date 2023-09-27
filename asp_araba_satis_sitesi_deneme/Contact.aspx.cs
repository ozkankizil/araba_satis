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
    public partial class Iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into TContact (strContactMessage, strContactMail, strContactName) values (@pmessage, @pmail, @pname)", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();
            commandAdd.Parameters.AddWithValue("@pmessage", TextBox1.Text);
            commandAdd.Parameters.AddWithValue("@pmail", TextBox2.Text);
            commandAdd.Parameters.AddWithValue("@pname", TextBox3.Text);
            commandAdd.ExecuteNonQuery();


        }
    }
}
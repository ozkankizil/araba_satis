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
    public partial class AddCarsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand commandListCarBrand = new SqlCommand("Select * from TBrands", SqlConnectionClass.connection);
                SqlConnectionClass.CheckConnection();
                SqlDataReader dataReader = commandListCarBrand.ExecuteReader();
                DropDownList1.DataTextField = "strBrandName";
                DropDownList1.DataValueField = "intBrandID";
                DropDownList1.DataSource = dataReader;
                DropDownList1.DataBind();
                dataReader.Close();

                SqlCommand commandListFuelType = new SqlCommand("Select * from TFuelTypes", SqlConnectionClass.connection);
                SqlConnectionClass.CheckConnection();
                SqlDataReader dataReaderFuelType = commandListFuelType.ExecuteReader();
                DropDownList2.DataTextField = "type";
                DropDownList2.DataValueField = "id";
                DropDownList2.DataSource = dataReaderFuelType;
                DropDownList2.DataBind();
                dataReaderFuelType.Close();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("insert into TCars (strCarModel, intCarBrandID, intCarFuelType, strCarDescription, intCarContact, strCarSeller, strCarPhoto, intCarPrice) values (@pmodel, @pbrand, @pfuel, @pdescription, @pcontact, @pseller, @pphoto, @pprice)", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();
            commandAdd.Parameters.AddWithValue("@pmodel", TextBox1.Text);
            commandAdd.Parameters.AddWithValue("@pbrand", Convert.ToInt32(DropDownList1.SelectedValue));
            commandAdd.Parameters.AddWithValue("@pfuel", DropDownList2.SelectedValue);
            commandAdd.Parameters.AddWithValue("@pdescription", TextBox3.Text);
            commandAdd.Parameters.AddWithValue("@pcontact", TextBox5.Text);
            commandAdd.Parameters.AddWithValue("@pseller", TextBox4.Text);
            commandAdd.Parameters.AddWithValue("@pphoto", TextBox2.Text);
            commandAdd.Parameters.AddWithValue("@pprice", TextBox6.Text);

            commandAdd.ExecuteNonQuery();
        }
    }
}
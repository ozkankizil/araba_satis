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
    public partial class CarList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandList = new SqlCommand("Select intCarID, strCarModel, intCarBrandID, intCarFuelType, strCarDescription, intCarContact, strCarSeller, strCarPhoto, intCarPrice, intStatus, intBrandID, strBrandName from TCars inner join TBrands on TCars.intCarBrandID=TBrands.intBrandID where intStatus=@pcon", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();
            commandList.Parameters.AddWithValue("@pcon", 1);
            
            SqlDataReader dataReader= commandList.ExecuteReader();

            DataList1.DataSource = dataReader;

            DataList1.DataBind();
            dataReader.Close();
        }
    }
}
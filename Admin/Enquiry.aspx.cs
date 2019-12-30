using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Enquiry : System.Web.UI.Page
{
    BLLEnquiry enquiry = new BLLEnquiry();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadGrid();
        }
    }

    private void LoadGrid()
    {
        DataTable dt = enquiry.GetAllEnquiry();
        if (dt.Rows.Count != 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int enquiryid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            int i = enquiry.DeleteMsg(enquiryid);
            if (i > 0)
            {
                LoadGrid();
            }
        }
        catch (Exception ex)
        {
            throw (ex);
        }

    }
}
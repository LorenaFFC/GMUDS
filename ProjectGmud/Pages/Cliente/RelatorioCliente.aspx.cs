using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectGmud.Pages.Cliente
{
    public partial class RelatorioCliente : System.Web.UI.Page
    {
        public int linha;
        public string UserId;
        private SqlConnection SQLConnection;
        private SqlCommand SQLCommand;
        private SqlDataReader SQLReader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bindGridView();
        }

        protected void RELATORIOCLIENTE_SelectedIndexChanged(object sender, GridViewPageEventArgs e)
        {
            RELATORIOCLIENTE.PageIndex = e.NewPageIndex;
            bindGridView(); //bindgridview will get the data source and bind it again


        }

        private void bindGridView()
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connStrig;
            connStrig = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
            SQLConnection = new SqlConnection(connStrig.ToString());
            string QueryCliente = "SELECT * FROM GMUDS..Cliente ";
            //open conection
            SQLConnection.Open();
            //SQLCommand = new SqlCommand(consulta, SQLConnection);
            SqlDataAdapter sqlData = new SqlDataAdapter(QueryCliente, SQLConnection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            RELATORIOCLIENTE.DataSource = dtbl;
            RELATORIOCLIENTE.DataBind();
        }

        protected void RELATORIOCLIENTEEXCEL(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.csv");
            Response.Charset = "";
            Response.ContentType = "text/csv";

            //To Export all pages.
            RELATORIOCLIENTE.AllowPaging = false;
            this.bindGridView();

            StringBuilder sb = new StringBuilder();
            foreach (TableCell cell in RELATORIOCLIENTE.HeaderRow.Cells)
            {
                //Append data with separator.
                sb.Append(cell.Text + ',');
            }
            //Append new line character.
            sb.Append("\r\n");

            foreach (GridViewRow row in RELATORIOCLIENTE.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    //Append data with separator.
                    sb.Append(cell.Text + ',');
                }
                //Append new line character.
                sb.Append("\r\n");
            }

            Response.Output.Write(sb.ToString());
            Response.Flush();
            Response.End();
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            RELATORIOCLIENTE.PageIndex = e.NewPageIndex;
            this.bindGridView();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the
            /* specified ASP.NET server control at run time. */
        }
    }
}
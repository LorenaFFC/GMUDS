using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectGmud.Pages.Gmud
{
    public partial class RelatorioGmud : System.Web.UI.Page
    {
        public int linha;
        public string UserId;
        private SqlConnection SQLConnection;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                gridRelatorioGmud();
        }

        protected void RELATORIOGMUD_SelectedIndexChanged(object sender, GridViewPageEventArgs e)
        {
            RELATORIOGMUD.PageIndex = e.NewPageIndex;
            gridRelatorioGmud(); //bindgridview will get the data source and bind it again
        }
        private void gridRelatorioGmud()
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connStrig;
            connStrig = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
            SQLConnection = new SqlConnection(connStrig.ToString());
            string QueryCliente = "SELECT id, Descricao, DataInicio, DataFim, StatusGmud FROM GMUDS..Gmud ";
            //open conection
            SQLConnection.Open();
            //SQLCommand = new SqlCommand(consulta, SQLConnection);
            SqlDataAdapter sqlData = new SqlDataAdapter(QueryCliente, SQLConnection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            RELATORIOGMUD.DataSource = dtbl;
            RELATORIOGMUD.DataBind();
        }


        // FUNCTION EXPORTAR RELATORIO
        protected void RELATORIOGMUDEXCEL(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.csv");
            Response.Charset = "";
            Response.ContentType = "text/csv";

            //To Export all pages.
            RELATORIOGMUD.AllowPaging = false;
            this.gridRelatorioGmud();

            StringBuilder sb = new StringBuilder();
            foreach (TableCell cell in RELATORIOGMUD.HeaderRow.Cells)
            {
                //Append data with separator.
                sb.Append(cell.Text + ',');
            }
            //Append new line character.
            sb.Append("\r\n");

            foreach (GridViewRow row in RELATORIOGMUD.Rows)
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
            RELATORIOGMUD.PageIndex = e.NewPageIndex;
            this.gridRelatorioGmud();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the
            /* specified ASP.NET server control at run time. */
        }

    }
}
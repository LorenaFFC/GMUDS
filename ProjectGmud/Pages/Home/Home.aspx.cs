using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectGmud.Pages.Home
{
    public partial class Home : System.Web.UI.Page
    {
        public int linha;
        public string UserId;
        private SqlConnection SQLConnection;
        private SqlCommand SQLCommand;
        private SqlDataReader SQLReader;
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connStrig;
            connStrig = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
            SQLConnection = new SqlConnection(connStrig.ToString());

            string consulta = "SELECT * FROM GMUDS.dbo.Prestador";
            string testeconsulta = "SELECT GC.CNPJ , GC.RazaoSocial, GP.nome, GP.status, GG.DESCRICAO ,GG.STATUS FROM GMUDS..Cliente GC WITH(NOLOCK) INNER JOIN GMUDS..Gmud GG WITH(NOLOCK) ON GC.id = GG.idcliente INNER JOIN GMUDS..Prestador GP WITH(NOLOCK) ON GG.idPrestador = GP.id";
            //open conection
            SQLConnection.Open();
            //SQLCommand = new SqlCommand(consulta, SQLConnection);
            SqlDataAdapter sqlData = new SqlDataAdapter(testeconsulta, SQLConnection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            TABELACONSULTA.DataSource = dtbl;
            TABELACONSULTA.DataBind();


        }


        protected void Unnamed1_Click(object sender, EventArgs e)
        {
        }
    }
}

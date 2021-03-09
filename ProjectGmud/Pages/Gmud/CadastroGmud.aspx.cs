using ProjectGmud.PO.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectGmud.Pages.Gmud
{
    public partial class CadastroGmud : System.Web.UI.Page
    {
        private SqlConnection SQLConnection;
        private SqlCommand SQLCommand;
        private SqlDataReader SQLReader;
        public string cnpjj = "";
        public string CPFPrest = "";
        public int UserId = 0;
        public int PrestadorId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Array listStatus = Enum.GetValues(typeof(StatusGmud));
                foreach (StatusGmud statusGmud in listStatus)
                {
                    selectStatusGmud.Items.Add(new ListItem(statusGmud.ToString()));
                }
            }

        }

        protected void btnSaveGmud_Click(object sender, EventArgs e)
        {
          
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connStrig;
            connStrig = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
            SQLConnection = new SqlConnection(connStrig.ToString());

            try
            {
                CPFPrest = txtCpfPrestador.Text.Trim();
                cnpjj = txtcnpjclientebusca.Text.Trim();
                int iddd = btnbuscar_Click(cnpjj);
                int idPrestador = buscarPrestador(CPFPrest);
                //  Response.Write("<script> alert('" + iddd + "'); </script>");
                string SQLQuery = "INSERT INTO GMUDS.dbo.Gmud ( Descricao, DataInicio, DataFim, idcliente,idPrestador, Status)" +
                   "VALUES ('" + txtDescricao.Text.Trim() + "','" + txtInicio.Text.Trim() + "','" + txtFim.Text.Trim() + "', '" + iddd + "', '" + idPrestador + "', '" + selectStatusGmud.Value.Trim() + "')";


                SQLCommand = new SqlCommand(SQLQuery, SQLConnection);
                // Perform insertion
                SQLConnection.Open();
                SQLCommand.ExecuteNonQuery();
                SQLConnection.Close();
            }
            catch (Exception error)
            {
                Response.Write("<script> alert('" + error.Message + "'); </script>");
            }
        }

        protected int  btnbuscar_Click(string cnpj )
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connStrig;
            connStrig = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
            SQLConnection = new SqlConnection(connStrig.ToString());

            try
            {
                string SQLbuscaID = "select id from GMUDS.dbo.Cliente Where CNPJ = '" + cnpj + "'";
                SQLCommand = new SqlCommand(SQLbuscaID, SQLConnection);

                SQLConnection.Open();


                SQLReader = SQLCommand.ExecuteReader();
                while (SQLReader.Read())
                {
                    UserId = (int)SQLReader["id"];
                   
                }
                SQLConnection.Close();
                return UserId;
            }
            catch (Exception error)
            {
                Response.Write("<script> alert('" + error.Message + "'); </script>");
            }
            return UserId;
        }

        protected int buscarPrestador(string cpf)
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connStrig;
            connStrig = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
            SQLConnection = new SqlConnection(connStrig.ToString());

            try
            {
                string SQLbuscaIDPrestador = "select id from GMUDS.dbo.Prestador Where CPF = '" + cpf + "'";
                SQLCommand = new SqlCommand(SQLbuscaIDPrestador, SQLConnection);

                SQLConnection.Open();


                SQLReader = SQLCommand.ExecuteReader();
                while (SQLReader.Read())
                {
                    PrestadorId = (int)SQLReader["id"];

                }
                SQLConnection.Close();
                return PrestadorId;
            }
            catch (Exception error)
            {
                Response.Write("<script> alert('" + error.Message + "'); </script>");
            }
            return PrestadorId;
        }
    }
}


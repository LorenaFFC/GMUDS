﻿using ProjectGmud.PO.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectGmud.Pages.Prestador
{
    public partial class CadastroPrestador : System.Web.UI.Page
    {
        private SqlConnection SQLConnection;
        private SqlCommand SQLCommand;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Array listStatus = Enum.GetValues(typeof(StatusFuncionario));
                foreach (StatusFuncionario statusPrestador in listStatus)
                {
                    selectStatusPrestador.Items.Add(new ListItem(statusPrestador.ToString()));
                }
            }
        }

        protected void btnSavePrestador_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connStrig;
            connStrig = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
            SQLConnection = new SqlConnection(connStrig.ToString());

            

            string SQLQuery = "INSERT INTO GMUDS.dbo.Prestador ( nome, CPF, CNPJ, DtAdmissao,VlrHra,status)" +
                   "VALUES ('" + txPNome.Text.Trim() + "','" + txPCPF.Text.Trim() + "','" + txPCNPJ.Text.Trim() + "', '" + txPAdmissao.Text.Trim() + "', '" + txpVlrHra.Text.Trim()+ "', '" + selectStatusPrestador.Value.Trim()  + "')";



            SQLCommand = new SqlCommand(SQLQuery, SQLConnection);
            // Perform insertion
            SQLConnection.Open();
            SQLCommand.ExecuteNonQuery();
            SQLConnection.Close();


        }
    }
}

using ProjectGmud.PO.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectGmud.Pages.Cliente
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!Page.IsPostBack)
            {
                Array listUf = Enum.GetValues(typeof(UF));
                foreach (UF uf in listUf)
                {
                    selectUF.Items.Add(new ListItem(uf.ToString()));
                }
            }

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Validação de Campos
            try
            {
                
                if (txtCNPJ.Text != null
                    && txtCNPJ.Text != ""
                    && txtCidade.Text != null
                    && txtCidade.Text != ""
                    && txtEndereco.Text != null
                    && txtEndereco.Text != ""
                    && txtRS.Text != null
                    && txtRS.Text != ""
                    && selectUF.Value != ""
                    && selectUF.Value != null )
                {
              
                    // capturar a string de conexão
                    System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
                    System.Configuration.ConnectionStringSettings connStrig;
                    connStrig = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
                    // Cria um objeto de conexão 
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = connStrig.ToString();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into GMUDS.dbo.Cliente (CNPJ, RazaoSocial, Endereco, Cidade, UF, Data) values (@CNPJ, @RazaoSocial, @Endereco, @Cidade, @UF,@Data)";
                    cmd.Parameters.AddWithValue("CNPJ", txtCNPJ.Text);
                    cmd.Parameters.AddWithValue("RazaoSocial", txtRS.Text);
                    cmd.Parameters.AddWithValue("Endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("Cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("UF", selectUF.Value);
                    cmd.Parameters.AddWithValue("Data", date.SelectedDate) ;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    throw new Exception("Campos em Branco");
                }
            }
            catch (Exception erro)
            {
                Response.Write("<script> alert('" + erro.Message + "'); </script>");
            }
        }

  
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;


namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = "Server=DESKTOP-8TA92CI;Database=DBWF;Trusted_Connection=True;MultipleActiveResultSets=true";
        private string strSql = string.Empty;

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            strSql = "INSERT INTO FUNCIONARIOS (ID, NOME, ENDERECO, CEP, BAIRRO, CIDADE, UF, TELEFONE) VALUES (@ID, @NOME, @ENDERECO, @CEP, @BAIRRO, @CIDADE, @UF, @TELEFONE)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("ID", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("NOME", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("ENDERECO", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = mskCep.Text;
            comando.Parameters.Add("BAIRRO", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("CIDADE", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("UF", SqlDbType.VarChar).Value = txtUF.Text;
            comando.Parameters.Add("TELEFONE", SqlDbType.VarChar).Value = mskTelefone.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            strSql = "select * from FUNCIONARIOS where ID=@ID";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@ID", SqlDbType.Int).Value = tstIdBuscar.Text;

            try
            {
                if (tstIdBuscar.Text == string.Empty)
                {
                    throw new Exception("Você precisa digita um ID");
                }

                sqlCon.Open();
                /*
                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false) {

                    throw new Exception("Id não cadastrado!");
                }

                txtId.Text = Convert.ToString(dr["ID"]);
                txtNome.Text = Convert.ToString(dr["NOME"]);
                txtEndereco.Text = Convert.ToString(dr["ENDERECO"]);
                mskCep.Text = Convert.ToString(dr["CEP"]);
                txtBairro.Text = Convert.ToString(dr["BAIRRO"]);
                txtCidade.Text = Convert.ToString(dr["CIDADE"]);
                txtUF.Text = Convert.ToString(dr["UF"]);
                mskTelefone.Text = Convert.ToString(dr["TELEFONE"]);
                */

                using (SqlDataReader dr = comando.ExecuteReader())
                {
                    if (dr.HasRows) // Verifica se há linhas no SqlDataReader
                    {
                        while (dr.Read()) // Lê cada linha
                        {
                            txtId.Text = Convert.ToString(dr["ID"]);
                            txtNome.Text = Convert.ToString(dr["NOME"]);
                            txtEndereco.Text = Convert.ToString(dr["ENDERECO"]);
                            mskCep.Text = Convert.ToString(dr["CEP"]);
                            txtBairro.Text = Convert.ToString(dr["BAIRRO"]);
                            txtCidade.Text = Convert.ToString(dr["CIDADE"]);
                            txtUF.Text = Convert.ToString(dr["UF"]);
                            mskTelefone.Text = Convert.ToString(dr["TELEFONE"]);
                        }
                    }
                    else
                    {
                        // Lida com o caso quando não há dados presentes
                        txtId.Text = "Nenhum dado encontrado";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }


        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            strSql = "update FUNCIONARIOS set ID=@ID, NOME=@NOME, ENDERECO=@ENDERECO, CEP=@CEP, " +
                "BAIRRO=@BAIRRO, CIDADE=@CIDADE, UF=@UF, TELEFONE=@TELEFONE where ID=@IDBUSCAR";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("IDBUSCAR", SqlDbType.Int).Value = tstIdBuscar.Text;

            comando.Parameters.Add("ID", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("NOME", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("ENDERECO", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = mskCep.Text;
            comando.Parameters.Add("BAIRRO", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("CIDADE", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("UF", SqlDbType.VarChar).Value = txtUF.Text;
            comando.Parameters.Add("TELEFONE", SqlDbType.VarChar).Value = mskTelefone.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }






        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este funcionério?", "Cuidado", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!");
            }
            else{
                strSql = "delete from FUNCIONARIO where ID=@ID";
                sqlCon = new SqlConnection(strSql);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@ID", SqlDbType.Int).Value = tstIdBuscar.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Funcionário deletado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using Teste.DAL;
using Teste.Models;

namespace Teste
{
    public partial class frmTDM_CadastroSocio : Form
    {
        private MySqlConnection mConn;
        private string foto = null;        

        public frmTDM_CadastroSocio()
        {
            InitializeComponent();
            if (mskDtCadastroSocio.Text == "  /  /")
            {
                mskDtCadastroSocio.Text = DateTime.Now.ToShortDateString();
            }
            mskDtAtualizacaoSocio.Text = DateTime.Now.ToShortDateString();
            mskDtAdesao.Text = DateTime.Now.ToShortDateString();
            mConn = new MySqlConnection("Server=localhost;User Id=root;Database=TresDeMaio_DB;password=102910");

        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            bool gravou = false;
            try
            {
                SocioDAL sDal = new SocioDAL();
                Socio S = new Socio
                {
                    Titulo = int.Parse(txtTitulo.Text),
                    DataAdesao = DateTime.Parse(mskDtAdesao.Text),
                    Cpf = mskCpf.Text,
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    OrgaoExpedidor = txtOrgaoExpedidor.Text,
                    UfOrgaoExpedidor = cmbUfOrgaoExpedidor.Text,
                    DataExpedicao = DateTime.Parse(mskDtExpedicao.Text),
                    Situacao = txtSituacao.Text,
                    DataNascimento = DateTime.Parse(mskDtNascimentoSocio.Text),
                    FoneResidencial = mskResidencial.Text,
                    FoneCelular = mskCelular.Text,
                    FoneComercial = mskComercial.Text,
                    Email = txtEmail.Text,
                    DataCadastro = DateTime.Parse(mskDtCadastroSocio.Text),
                    DataAtualizacao = DateTime.Parse(mskDtAtualizacaoSocio.Text),
                    Ativo = bool.Parse(ckbSocioAtivo.Checked.ToString()),
                    Obs = txtAdicionaisObs.Text,
                    PathImagem = foto
                };
                if (lblId.Text.Equals("idSocio"))
                {
                    gravou = sDal.InsertSocio(S);
                    if (gravou)
                    {
                        Endereco E = new Endereco()
                        {
                            Cep = mskCep.Text,
                            Rua = txtRua.Text,
                            Numero = int.Parse(txtNumero.Text),
                            Bairro = txtBairro.Text,
                            Cidade = txtCidade.Text,
                            Uf = cmbUfEndereco.Text,
                            Complemento = txtComplemento.Text,
                            IdSocio = ReturnIdGeradoSocio()
                        };
                        EnderecoDAL eDal = new EnderecoDAL();
                        eDal.InsertEndereco(E);
                    }
                }                
            }
            catch
            {
                frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados.", 2);
                frmErro.Show();
            }
            if (gravou)
            {
                Limpar();
                LimparDependente();
            }
        }       

        private void mskDtAdesao_Leave(object sender, EventArgs e)
        {
            mskCpf.Focus();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            ckbSocioAtivo.Focus();
        }

        private void Limpar()
        {
            // tab sócio
            //-----------------------------------------------------------------------------
            txtTitulo.Text = "";
            mskDtAdesao.Text = DateTime.Now.ToShortDateString();
            mskCpf.Text = "";
            txtNome.Text = "";
            txtRg.Text = "";
            txtOrgaoExpedidor.Text = "";
            cmbUfOrgaoExpedidor.SelectedIndex = -1;
            mskDtExpedicao.Text = "";
            txtSituacao.Text = "";
            mskDtNascimentoSocio.Text = "";

            mskCep.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cmbUfEndereco.SelectedIndex = -1;
            txtComplemento.Text = "";

            mskResidencial.Text = "";
            mskCelular.Text = "";
            mskComercial.Text = "";
            txtEmail.Text = "";
            mskDtCadastroSocio.Text = DateTime.Now.ToShortDateString();
            mskDtAtualizacaoSocio.Text = DateTime.Now.ToShortDateString();
            ckbSocioAtivo.Checked = true;            

            // tab dependentes
            //-----------------------------------------------------------------------------
            mskCpfDependente.Text = "";
            txtNomeDependente.Text = "";
            txtObservacaoDependente.Text = "";
            mskDtNascimentoDependente.Text = "";
            txtParentesco.Text = "";
            txtNumeroDependente.Text = "";
            mskFoneDependente.Text = "";
            lstDependentes.Items.Clear();

            // tab adicionais
            //-----------------------------------------------------------------------------
            txtAdicionaisObs.Text = "";

            // retorna para tab sócios
            tabControl1.SelectedTab = tabPage1;

            lblId.Text = "idSocio";
            picImagemSocio.Image = Properties.Resources.imgCadSocio;
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            LimparDependente();
        }

        private void cmdCarregarImagem_Click(object sender, EventArgs e)
        {            
            ofdImagem.Title = "Abrir Foto";
            ofdImagem.Filter = "JPG(*.jpg)|*.jpg" + "|All files(*.*)|*.*";

            if (ofdImagem.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picImagemSocio.Image = new Bitmap(ofdImagem.OpenFile());
                    foto = ofdImagem.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar a foto:" + ex.Message);
                }
            }
            ofdImagem.Dispose();
        }

        //private void InsertSocio()
        //{
        //    bool erro = false;
        //    try
        //    {
        //        // abre conexão com banco
        //        mConn.Open();
        //    }
        //    catch (System.Exception e)
        //    {
        //        MessageBox.Show(e.Message.ToString());
        //    }

        //    // verifica se a conexão está aberta
        //    if (mConn.State == ConnectionState.Open)
        //    {
        //        MySqlCommand comm = mConn.CreateCommand();

        //        comm.CommandText = "INSERT INTO Socio(Titulo, CPF, Nome, Rg, OrgaoExpedidor, UFOrgaoExpedidor," +
        //        " DataExpedicao, DataNascimento, DataAdesao, DataCadastro, DataAtualizacao, FoneResidencial, FoneCelular, FoneComercial," +
        //        "Email, Obs, Situacao, UltPagamento, Ativo)" +
        //        "VALUES" +
        //        "(@Titulo, @CPF, @Nome, @Rg, @OrgaoExpedidor, @UFOrgaoExpedidor, @DataExpedicao, @DataNascimento, @DataAdesao," +
        //        "@DataCadastro, @DataAtualizacao, @FoneResidencial, @FoneCelular, @FoneComercial, @Email, @Obs, @Situacao, @UltPagamento, @Ativo)";

        //        try
        //        {
        //            comm.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
        //            comm.Parameters.AddWithValue("@CPF", mskCpf.Text.ToString());
        //            comm.Parameters.AddWithValue("@Nome", txtNome.Text.ToString());
        //            comm.Parameters.AddWithValue("@Rg", txtRg.Text.ToString());
        //            comm.Parameters.AddWithValue("@OrgaoExpedidor", txtOrgaoExpedidor.Text.ToString());
        //            comm.Parameters.AddWithValue("@UFOrgaoExpedidor", cmbUfOrgaoExpedidor.Text.ToString());
        //            comm.Parameters.AddWithValue("@DataExpedicao", DateTime.Parse(mskDtExpedicao.Text).ToString("yyyy-MM-dd HH:mm:ssss"));
        //            comm.Parameters.AddWithValue("@DataNascimento", DateTime.Parse(mskDtNascimentoSocio.Text).ToString("yyyy-MM-dd HH:mm:ssss"));
        //            comm.Parameters.AddWithValue("@DataAdesao", DateTime.Parse(mskDtAdesao.Text).ToString("yyyy-MM-dd HH:mm:ssss"));
        //            comm.Parameters.AddWithValue("@DataCadastro", DateTime.Parse(mskDtCadastroSocio.Text).ToString("yyyy-MM-dd HH:mm:ssss"));
        //            comm.Parameters.AddWithValue("@DataAtualizacao", DateTime.Parse(mskDtAtualizacaoSocio.Text).ToString("yyyy-MM-dd HH:mm:ssss"));
        //            comm.Parameters.AddWithValue("@FoneResidencial", mskResidencial.Text.ToString());
        //            comm.Parameters.AddWithValue("@FoneCelular", mskCelular.Text.ToString());
        //            comm.Parameters.AddWithValue("@FoneComercial", mskComercial.Text.ToString());
        //            comm.Parameters.AddWithValue("@Email", txtEmail.Text.ToString());
        //            comm.Parameters.AddWithValue("@Obs", txtAdicionaisObs.Text.ToString());
        //            comm.Parameters.AddWithValue("@Situacao", txtSituacao.Text);
        //            comm.Parameters.AddWithValue("@UltPagamento", "");
        //            comm.Parameters.AddWithValue("@Ativo", ckbSocioAtivo.Checked);
        //            comm.ExecuteNonQuery();
        //        }
        //        catch (SystemException e)
        //        {
        //            //MessageBox.Show(e.Message.ToString());
        //            frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados!", 2);
        //            frmErro.Show();
        //            erro = true;
        //        }

        //    }
        //    mConn.Close();
        //    if (erro == false)
        //    {
        //        InsertEndereco(ReturnIdGeradoSocio());
        //    }
        //}

        //private void InsertEndereco(long idSocio)
        //{
        //    bool erro = false;

        //    string query = "INSERT INTO Endereco(Cep, Rua, Numero, Bairro, Cidade," +
        //                   " UF, Complemento, IdSocio)" +
        //                   "VALUES" +
        //                   "(@Cep, @Rua, @Numero, @Bairro, @Cidade, @UF, @Complemento, @IdSocio)";

        //    try
        //    {
        //        // abre conexão com banco
        //        mConn.Open();
        //    }
        //    catch (System.Exception e)
        //    {
        //        MessageBox.Show(e.Message.ToString());
        //    }

        //    MySqlCommand comm = mConn.CreateCommand();
        //    comm.CommandText = query;

        //    try
        //    {
        //        comm.Parameters.AddWithValue("@Cep", mskCep.Text.ToString());
        //        comm.Parameters.AddWithValue("@Rua", txtRua.Text.ToString());
        //        comm.Parameters.AddWithValue("@Numero", txtNumero.Text.ToString());
        //        comm.Parameters.AddWithValue("@Bairro", txtBairro.Text.ToString());
        //        comm.Parameters.AddWithValue("@Cidade", txtCidade.Text.ToString());
        //        comm.Parameters.AddWithValue("@UF", cmbUfEndereco.Text.ToString());
        //        comm.Parameters.AddWithValue("@Complemento", txtComplemento.Text.ToString());
        //        comm.Parameters.AddWithValue("@IdSocio", idSocio);
        //        comm.ExecuteNonQuery();
        //    }
        //    catch (SystemException e)
        //    {
        //        frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Erro! Revise os dados!", 2);
        //        frmErro.Show();
        //        erro = true;
        //    }
        //    mConn.Close();
        //    if (erro == false)
        //    {
        //        frmTDM_Menssagem frmSucesso = new frmTDM_Menssagem("Cadastrado com sucesso!", 1);
        //        frmSucesso.Show();
        //        Limpar();
        //    }
        //}

        //private void InsertDependente()
        //{
        //    ListViewItem item;
        //    bool erro = false;
        //    try
        //    {
        //        // abre conexão com banco
        //        mConn.Open();
        //    }
        //    catch (System.Exception e)
        //    {
        //        MessageBox.Show(e.Message.ToString());
        //    }

        //    // verifica se a conexão está aberta
        //    if (mConn.State == ConnectionState.Open)
        //    {
        //        MySqlCommand comm = mConn.CreateCommand();

        //        comm.CommandText = "INSERT INTO Dependente(Cpf, Nome, Obs, DataNascimento, Parentesco, Numero, Fone, DataInclusao, IdSocio)" +
        //        "VALUES" +
        //        "(@Cpf, @Nome, @Obs, @DataNascimento, @Parentesco, @Numero, @Fone, @DataInclusao, @IdSocio)";

        //        try
        //        {
        //            comm.Parameters.AddWithValue("@Cpf", mskCpfDependente.Text.ToString());
        //            comm.Parameters.AddWithValue("@Nome", txtNomeDependente.Text.ToString());
        //            comm.Parameters.AddWithValue("@Obs", txtObservacaoDependente.Text.ToString());
        //            comm.Parameters.AddWithValue("@DataNascimento", DateTime.Parse(mskDtNascimentoDependente.Text).ToString("yyyy-MM-dd HH:mm:ssss"));
        //            comm.Parameters.AddWithValue("@Parentesco", txtParentesco.Text.ToString());
        //            comm.Parameters.AddWithValue("@Numero", txtNumeroDependente.Text.ToString());
        //            comm.Parameters.AddWithValue("@Fone", mskFoneDependente.Text.ToString());
        //            comm.Parameters.AddWithValue("@DataInclusao", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ssss"));
        //            comm.Parameters.AddWithValue("@IdSocio", lblId.Text.ToString());
        //            comm.ExecuteNonQuery();

        //            item = new ListViewItem();
        //            item.Text = txtNomeDependente.Text;
        //            item.SubItems.Add(txtParentesco.Text);
        //            item.SubItems.Add(mskFoneDependente.Text);
        //            item.SubItems.Add(mskDtNascimentoDependente.Text);
        //            item.SubItems.Add(txtNumeroDependente.Text);
        //            item.SubItems.Add(txtObservacaoDependente.Text);
        //            lstDependentes.Items.Add(item);

        //        }
        //        catch (SystemException e)
        //        {
        //            erro = true;
        //            frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados!" + e.Message, 2);
        //            frmErro.Show();
        //        }
        //        if (!erro)
        //        {
        //            frmTDM_Menssagem frmSucesso = new frmTDM_Menssagem("Adicionado com sucesso!", 1);
        //            frmSucesso.Show();
        //            LimparDependente();
        //        }
        //    }
        //    mConn.Close();
        //}

        private void LimparDependente()
        {
            mskCpfDependente.Text = "";
            txtNomeDependente.Text = "";
            txtObservacaoDependente.Text = "";
            mskDtNascimentoDependente.Text = "";
            txtParentesco.Text = "";
            txtNumeroDependente.Text = "";
            mskFoneDependente.Text = "";
        }

        private int ReturnIdGeradoSocio()
        {
            int id = 0;
            try
            {
                // abre conexão com banco
                mConn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            try
            {
                string sql = "SELECT MAX(ID) FROM Socio";
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    id = rd.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            mConn.Close();
            return id;
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Trim() != "")
            {
                RetornaSocioByTitulo();
            }
        }

        private void RetornaSocioByTitulo()
        {
            long id = 0;
            try
            {
                // abre conexão com banco
                mConn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            try
            {
                string sql = "SELECT * FROM Socio WHERE Titulo=" + int.Parse(txtTitulo.Text);
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    id = long.Parse(rd["Id"].ToString());

                    lblId.Text = id.ToString();
                    mskDtAdesao.Text = rd["DataAdesao"].ToString();
                    mskCpf.Text = rd["Cpf"].ToString();
                    txtNome.Text = rd["Nome"].ToString();
                    txtRg.Text = rd["Rg"].ToString();
                    txtOrgaoExpedidor.Text = rd["OrgaoExpedidor"].ToString();
                    cmbUfOrgaoExpedidor.Text = rd["UFOrgaoExpedidor"].ToString();
                    mskDtExpedicao.Text = rd["DataExpedicao"].ToString();
                    txtSituacao.Text = rd["Situacao"].ToString();
                    mskDtNascimentoSocio.Text = rd["DataNascimento"].ToString();
                    mskResidencial.Text = rd["FoneResidencial"].ToString();
                    mskCelular.Text = rd["FoneCelular"].ToString();
                    mskComercial.Text = rd["FoneComercial"].ToString();
                    txtEmail.Text = rd["Email"].ToString();
                    mskDtCadastroSocio.Text = rd["DataCadastro"].ToString();
                    mskDtAtualizacaoSocio.Text = rd["DataAtualizacao"].ToString();
                    ckbSocioAtivo.Checked = bool.Parse(rd["Ativo"].ToString());
                    lblUltPgto.Text = rd["UltPagamento"].ToString();
                    txtAdicionaisObs.Text = rd["Obs"].ToString();
                    if(rd["PathImagem"].ToString() != "")
                    {
                        picImagemSocio.Image = new Bitmap(rd["PathImagem"].ToString());
                    }                    
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
            RetornaEnderecoSocio(id);
            RetornaDependentes(id);
        }

        private void RetornaEnderecoSocio(long IdSocio)
        {
            try
            {
                // abre conexão com banco
                mConn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            try
            {
                string sql = "SELECT * FROM Endereco WHERE IdSocio=" + IdSocio;
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    mskCep.Text = rd["Cep"].ToString();
                    txtRua.Text = rd["Rua"].ToString();
                    txtNumero.Text = rd["Numero"].ToString();
                    txtBairro.Text = rd["Bairro"].ToString();
                    txtCidade.Text = rd["Cidade"].ToString();
                    cmbUfEndereco.Text = rd["Uf"].ToString();
                    txtComplemento.Text = rd["Complemento"].ToString();
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
        }

        private void RetornaDependentes(long IdSocio)
        {
            ListViewItem item;
            lstDependentes.Items.Clear();
            try
            {
                // abre conexão com banco
                mConn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            try
            {
                string sql = "SELECT * FROM Dependente WHERE IdSocio=" + IdSocio;
                var cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    item = new ListViewItem();
                    item.Text = rd["Nome"].ToString();
                    item.SubItems.Add(rd["Parentesco"].ToString());
                    item.SubItems.Add(rd["Fone"].ToString());
                    item.SubItems.Add(rd["DataNascimento"].ToString());
                    item.SubItems.Add(rd["Numero"].ToString());
                    item.SubItems.Add(rd["Obs"].ToString());
                    lstDependentes.Items.Add(item);
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
            mConn.Close();
        }


        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            ListViewItem item;            
            DependenteDAL dDal = new DependenteDAL();
            bool gravou = false;

            if (lblId.Text.Equals("idSocio"))
            {
                MessageBox.Show("Nenhum sócio selecionado.", "Mensagem");
                // retorna para tab sócios
                tabControl1.SelectedTab = tabPage1;
                txtTitulo.Focus();
            }
            else
            {
                Dependente d = new Dependente
                {
                    Cpf = mskCpfDependente.Text,
                    Nome = txtNomeDependente.Text,
                    Obs = txtObservacaoDependente.Text,
                    DataNascimento = DateTime.Parse(mskDtNascimentoDependente.Text),
                    Parentesco = txtParentesco.Text,
                    Numero = int.Parse(txtNumeroDependente.Text),
                    Fone = mskFoneDependente.Text,
                    IdSocio = int.Parse(lblId.Text)
                };

                gravou = dDal.InsertDependente(d);
                if (gravou)
                {
                    item = new ListViewItem();
                    item.Text = txtNomeDependente.Text;
                    item.SubItems.Add(txtParentesco.Text);
                    item.SubItems.Add(mskFoneDependente.Text);
                    item.SubItems.Add(mskDtNascimentoDependente.Text);
                    item.SubItems.Add(txtNumeroDependente.Text);
                    item.SubItems.Add(txtObservacaoDependente.Text);
                    lstDependentes.Items.Add(item);                    

                    frmTDM_Menssagem frmSucesso = new frmTDM_Menssagem("Adicionado com sucesso!", 1);
                    frmSucesso.Show();
                    LimparDependente();
                }
            }
        }


        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            Limpar();
            LimparDependente();
        }

        private void frmTDM_CadastroSocio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}

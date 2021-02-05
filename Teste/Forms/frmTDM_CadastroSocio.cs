using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Teste.DAL;
using Teste.Forms;
using Teste.Funcoes;
using Teste.Models;

namespace Teste
{
    public partial class frmTDM_CadastroSocio : Form
    {
        private MySqlConnection mConn;
        private string foto = null;
        string strConexao = Connection.Conexao();
        public frmTDM_CadastroSocio(string usuario)
        {
            InitializeComponent();
            if (mskDtCadastroSocio.Text == "  /  /")
            {
                mskDtCadastroSocio.Text = DateTime.Now.ToShortDateString();
            }
            lblUsuario.Text = usuario;
            mskDtAtualizacaoSocio.Text = DateTime.Now.ToShortDateString();
            mskDtAdesao.Text = DateTime.Now.ToShortDateString();
            mConn = new MySqlConnection(strConexao);

        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Equals("idSocio"))
            {
                InserirSocio();
            }
            else
            {
                AtualizarSocio();
            }
        }

        private void InserirSocio()
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
            catch (SystemException ex)
            {
                string exception = ex.Message.ToString();
                frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados.", 2, exception);
                frmErro.Show();
            }
            if (gravou)
            {
                tabControl1.SelectedTab = tabPage1;
                frmTDM_Menssagem frm = new frmTDM_Menssagem("Cadastrado com sucesso!", 1, "");
                frm.Show();
                Limpar();
                LimparDependente();
            }
        }

        private void AtualizarSocio()
        {

            bool gravou = false;
            try
            {
                SocioDAL sDal = new SocioDAL();
                Socio S = new Socio
                {
                    Id = int.Parse(lblId.Text),
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
                    DataAtualizacao = DateTime.Now,
                    Ativo = bool.Parse(ckbSocioAtivo.Checked.ToString()),
                    Obs = txtAdicionaisObs.Text,
                    PathImagem = foto
                };
                if (!lblId.Text.Equals("idSocio"))
                {
                    gravou = sDal.UpdatedSocio(S);
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
                            IdSocio = int.Parse(lblId.Text)
                        };
                        EnderecoDAL eDal = new EnderecoDAL();
                        eDal.UpdateEndereco(E);
                    }
                }
            }
            catch (SystemException ex)
            {
                string exception = ex.Message.ToString();
                frmTDM_Menssagem frmErro = new frmTDM_Menssagem("Revise os dados.", 2, exception);
                frmErro.Show();
            }
            if (gravou)
            {
                tabControl1.SelectedTab = tabPage1;
                frmTDM_Menssagem frm = new frmTDM_Menssagem("Cadastrado com sucesso!", 1, "");
                frm.Show();
                Limpar();
                LimparDependente();
            }
        }



        private void mskDtAdesao_Leave(object sender, EventArgs e)
        {
            Validacoes v = new Validacoes();
            if (mskDtAdesao.Text.Length == 10)
            {
                if (v.ValidaData(mskDtAdesao.Text) == false)
                {
                    MessageBox.Show("Data inválida.", "Mensagem");
                    mskDtAdesao.Focus();
                    return;
                }
            }
            if (mskDtAdesao.Text == "  /  /")
            {
                MessageBox.Show("Data de vencimento inválida.", "Mensagem");
                mskDtAdesao.Focus();
                return;
            }
            if (mskDtAdesao.Text.Length != 10)
            {
                MessageBox.Show("Data inválida.", "Mensagem");
                mskDtAdesao.Focus();
                return;
            }
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
            lblNome.Text = "-";
            lblNome.Visible = false;

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

        private void LimparDependente()
        {
            mskCpfDependente.Text = "";
            txtNomeDependente.Text = "";
            txtObservacaoDependente.Text = "";
            mskDtNascimentoDependente.Text = "";
            txtParentesco.Text = "";
            txtNumeroDependente.Text = "";
            mskFoneDependente.Text = "";
            lblIdDependente.Text = "idDependente";
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

                    lblNome.Text = rd["Nome"].ToString();
                    lblNome.Visible = true;

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
                    if (rd["PathImagem"].ToString() != "")
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
                    item.SubItems.Add(rd["Id"].ToString());
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
            string cpf = mskCpfDependente.Text.Replace(",", ".");
            if (cpf.Equals("   .   .   -"))
            {
                MessageBox.Show("Informe o CPF.", "Mensagem");
                return;
            }
            try
            {
                if (lblIdDependente.Text.Equals("idDependente"))
                {
                    AdicionarDependente();
                }
                else
                {
                    AtualizarDependente();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdicionarDependente()
        {
            DependenteDAL dDal = new DependenteDAL();
            bool gravou = false;

            if (lblId.Text.Equals("idSocio"))
            {
                MessageBox.Show("Nenhum sócio selecionado.\n" +
                    "Cadastro em andamento, primeiro finalizar o cadastro do sócio\n" +
                    "para fazer inclusão dos dependentes.", "Mensagem");
                // retorna para tab sócios                
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
                    RetornaDependentes(long.Parse(lblId.Text));
                    frmTDM_Menssagem frmSucesso = new frmTDM_Menssagem("Adicionado com sucesso!", 1, "");
                    frmSucesso.Show();
                    LimparDependente();
                }
            }
        }

        private void AtualizarDependente()
        {
            DependenteDAL dDal = new DependenteDAL();
            bool gravou = false;

            if (lblId.Text.Equals("idSocio"))
            {
                MessageBox.Show("Nenhum sócio selecionado.\n" +
                    "Cadastro em andamento, primeiro finalizar o cadastro do sócio\n" +
                    "para fazer inclusão dos dependentes.", "Mensagem");
                // retorna para tab sócios                
            }
            else
            {
                Dependente d = new Dependente
                {
                    Id = int.Parse(lblIdDependente.Text),
                    Cpf = mskCpfDependente.Text,
                    Nome = txtNomeDependente.Text,
                    Obs = txtObservacaoDependente.Text,
                    DataNascimento = DateTime.Parse(mskDtNascimentoDependente.Text),
                    Parentesco = txtParentesco.Text,
                    Numero = int.Parse(txtNumeroDependente.Text),
                    Fone = mskFoneDependente.Text,
                };

                gravou = dDal.UpdateDependente(d);
                if (gravou)
                {
                    RetornaDependentes(int.Parse(lblId.Text));

                    frmTDM_Menssagem frmSucesso = new frmTDM_Menssagem("Atualizado com sucesso!", 1, "");
                    frmSucesso.ShowDialog();
                    LimparDependente();
                }
            }
        }


        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Deseja limpar a tela e iniciar novo cadastro?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Limpar();
                    LimparDependente();
                }
            }
        }

        private void frmTDM_CadastroSocio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void lstDependentes_DoubleClick(object sender, EventArgs e)
        {
            long id = long.Parse(lstDependentes.FocusedItem.SubItems[6].Text);
            DependenteDAL dDal = new DependenteDAL();
            Dependente d = dDal.RetornaDepentendeByID(id);
            lblIdDependente.Text = d.Id.ToString();
            mskCpfDependente.Text = d.Cpf.ToString();
            txtNomeDependente.Text = d.Nome.ToString();
            txtObservacaoDependente.Text = d.Obs.ToString();
            mskDtNascimentoDependente.Text = d.DataNascimento.ToString();
            txtParentesco.Text = d.Parentesco.ToString();
            txtNumeroDependente.Text = d.Numero.ToString();
            mskFoneDependente.Text = d.Fone.ToString();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (lblIdDependente.Text.Equals("idDependente"))
            {
                MessageBox.Show("Selecione o dependente.", "Mensagem");
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show($"Deseja excluir o dependente\n {txtNomeDependente.Text} ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        int id = int.Parse(lblIdDependente.Text);
                        int idSocio = int.Parse(lblId.Text);
                        bool deletado = false;
                        DependenteDAL dDal = new DependenteDAL();
                        deletado = dDal.DeletaDependente(id);
                        if (deletado)
                        {
                            lstDependentes.Items.Clear();
                            RetornaDependentes(idSocio);
                            LimparDependente();
                            frmTDM_Menssagem frm = new frmTDM_Menssagem("Dependente excluído.", 1, "");
                            frm.Show();
                        }
                        LimparDependente();
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            string cep = mskCep.Text.Replace(".", "");
            cep = cep.Replace(",", "");
            //LocalizarCEP();
            if (cep != "     -")
            {
                BuscaCep();
            }
        }

        private void BuscaCep()
        {
            string cep = mskCep.Text.Replace(".", "");
            cep = cep.Replace(",", "");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cep + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();
            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indisponível");
                return; // Sai da rotina
            }
            try
            {
                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        MessageBox.Show("CEP não encontrado");
                                        //mskCep.Focus();
                                        return;
                                    }
                                }

                                //Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtRua.Text = valor[1];
                                }

                                //Complemento
                                if (cont == 3)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    //txtComplemento.Text = valor[1];
                                }

                                //Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtBairro.Text = valor[1];
                                }

                                //Cidade
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtCidade.Text = valor[1];
                                }

                                //Estado (UF)
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    cmbUfEndereco.Text = valor[1].Substring(1, 2);
                                }
                                cont++;
                            }
                        }
                    }
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void LocalizarCEP()
        //{
        //    string cep = mskCep.Text.Replace(".", "");
        //    cep = cep.Replace(",", "");
        //    cep = cep.Replace("-", "");
        //    try
        //    {
        //        Address endereco = SearchZip.GetAddress(cep);
        //        if (endereco.Zip != null)
        //        {
        //            txtRua.Text = endereco.Street;
        //            txtBairro.Text = endereco.District;
        //            txtCidade.Text = endereco.City;
        //            cmbUfEndereco.Text = endereco.State;
        //        }
        //    }
        //    catch (SystemException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void cmdRemoverImagem_Click(object sender, EventArgs e)
        {
            picImagemSocio.Image = Properties.Resources.imgCadSocio;
            foto = null;
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            string cpf = mskCpf.Text.Replace(".", "");
            cpf = cpf.Replace(",", "");
            if (cpf != "         -")
            {
                SocioDAL sDal = new SocioDAL();
                Socio s = sDal.RetornaSocioByCpf(mskCpf.Text);
                if (s.Titulo != 0)
                {
                    txtTitulo.Text = s.Titulo.ToString();
                    txtTitulo_Leave(null, null);
                }
            }
        }

        private void cmdPesquisaSocio_Click(object sender, EventArgs e)
        {
            Socio s = Singleton<Socio>.Instance();
            frmTDM_PesquisaSocio frm;
            if (txtNome.Text.Trim() != "")
            {
                frm = new frmTDM_PesquisaSocio(txtNome.Text.Trim());
            }
            else
            {
                frm = new frmTDM_PesquisaSocio();
            }
            frm.ShowDialog();
            txtTitulo.Text = s.Titulo.ToString();
            txtTitulo_Leave(null, null);
        }

        private void mskDtExpedicao_Leave(object sender, EventArgs e)
        {
            Validacoes v = new Validacoes();
            if (mskDtExpedicao.Text.Length == 10)
            {
                if (v.ValidaData(mskDtExpedicao.Text) == false)
                {
                    MessageBox.Show("Data inválida.", "Mensagem");
                    mskDtExpedicao.Focus();
                    return;
                }
            }
            if (mskDtExpedicao.Text == "  /  /")
            {
                MessageBox.Show("Data de vencimento inválida.", "Mensagem");
                mskDtExpedicao.Focus();
                return;
            }
            if (mskDtExpedicao.Text.Length != 10)
            {
                MessageBox.Show("Data inválida.", "Mensagem");
                mskDtExpedicao.Focus();
                return;
            }
        }

        private void mskDtNascimentoSocio_Leave(object sender, EventArgs e)
        {
            Validacoes v = new Validacoes();
            if (mskDtNascimentoSocio.Text.Length == 10)
            {
                if (v.ValidaData(mskDtNascimentoSocio.Text) == false)
                {
                    MessageBox.Show("Data inválida.", "Mensagem");
                    mskDtNascimentoSocio.Focus();
                    return;
                }
            }
            if (mskDtNascimentoSocio.Text == "  /  /")
            {
                MessageBox.Show("Data de vencimento inválida.", "Mensagem");
                mskDtNascimentoSocio.Focus();
                return;
            }
            if (mskDtNascimentoSocio.Text.Length != 10)
            {
                MessageBox.Show("Data inválida.", "Mensagem");
                mskDtNascimentoSocio.Focus();
                return;
            }
        }

        private void mskDtNascimentoDependente_Leave(object sender, EventArgs e)
        {
            Validacoes v = new Validacoes();
            if (mskDtNascimentoDependente.Text.Length == 10)
            {
                if (v.ValidaData(mskDtNascimentoDependente.Text) == false)
                {
                    MessageBox.Show("Data inválida.", "Mensagem");
                    mskDtNascimentoDependente.Focus();
                    return;
                }
            }
            if (mskDtNascimentoDependente.Text == "  /  /")
            {
                MessageBox.Show("Data de vencimento inválida.", "Mensagem");
                mskDtNascimentoDependente.Focus();
                return;
            }
            if (mskDtNascimentoDependente.Text.Length != 10)
            {
                MessageBox.Show("Data inválida.", "Mensagem");
                mskDtNascimentoDependente.Focus();
                return;
            }
        }

        private void cmdLimparDependentes_Click(object sender, EventArgs e)
        {
            mskCpfDependente.Text = "";
            txtNomeDependente.Text = "";
            txtObservacaoDependente.Text = "";
            mskDtNascimentoDependente.Text = "";
            txtParentesco.Text = "";
            txtNumeroDependente.Text = "";
            mskFoneDependente.Text = "";
            lblIdDependente.Text = "idDependente";
        }
    }
}

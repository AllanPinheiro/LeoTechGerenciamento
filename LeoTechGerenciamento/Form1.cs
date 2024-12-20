using LeoTechAssistenciaTecnica;
using System.Windows.Forms;

namespace LeoTechGerenciamento
{
    public partial class Form1 : Form
    {
        private readonly ProdutoService produtoService;
        private readonly ClienteService clienteService;
        private ServicoService servicoService;
        private SaidaServicoService saidaServicoService;

        public Form1()
        {
            InitializeComponent();
            produtoService = new ProdutoService("produtos.json");
            AtualizarListBoxEstoque();
            clienteService = new ClienteService("clientes.json");
            AtualizarListBoxClientes();
            servicoService = new ServicoService("servicos.json");
            AtualizarListBoxServicos();
            saidaServicoService = new SaidaServicoService("saidas.json");
            AtualizarListBoxSaidas();
            AtualizarHistorico();

        }
        // Metodo Atualizar List
        private void AtualizarListBoxEstoque()
        {
            lstBoxEstoque.DataSource = null;
            lstBoxEstoque.DataSource = produtoService.ObterTodos();
        }
        // Btn Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Btn Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Metodo Limpar Campos Estoque
        private void LimparCamposEstoque()
        {
            numIdEstoque.Value = 0;
            txtNomeEstoque.Clear();
            txtDescEstoque.Clear();
            numQuantEstoque.Value = 0;
        }
        // Btn Cadastrar Estoque
        private void btnCadastrarEstoque_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidosEstoque())
            {
                return;
            }

            var produto = new Produto
            {
                Id = (int)numIdEstoque.Value,
                NomeDoProduto = txtNomeEstoque.Text,
                Descricao = txtDescEstoque.Text,
                Quantidade = (int)numQuantEstoque.Value
            };

            if (produtoService.AdicionarProduto(produto))
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCamposEstoque();
                AtualizarListBoxEstoque();
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("J� existe um produto com este ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparCamposEstoque();
            }
        }

        // Evento para quando o usu�rio seleciona um item no ListBox
        private void listBoxEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxEstoque.SelectedItem != null)
            {
                // Obt�m o item selecionado no ListBox (presume que seja do tipo Produto)
                var produtoSelecionado = (Produto)lstBoxEstoque.SelectedItem;

                // Preenche os campos com os dados do produto selecionado
                numIdEstoque.Value = produtoSelecionado.Id;
                txtNomeEstoque.Text = produtoSelecionado.NomeDoProduto;
                txtDescEstoque.Text = produtoSelecionado.Descricao;
                numQuantEstoque.Value = produtoSelecionado.Quantidade;
            }
        }

        // Btn Excluir Estoque
        private void btnExcluirEstoque_Click(object sender, EventArgs e)
        {
            int id = (int)numIdEstoque.Value;

            if (produtoService.ExcluirProduto(id))
            {
                LimparCamposEstoque();
                MessageBox.Show("Produto exclu�do com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBoxEstoque();
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Produto n�o encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Btn Atualizar Estoque
        private void btnAtualizarEstoque_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidosEstoque())
            {
                return;
            }

            int id = (int)numIdEstoque.Value;

            var produtoAtualizado = new Produto
            {
                NomeDoProduto = txtNomeEstoque.Text,
                Descricao = txtDescEstoque.Text,
                Quantidade = (int)numQuantEstoque.Value
            };

            if (produtoService.AtualizarProduto(id, produtoAtualizado))
            {
                LimparCamposEstoque();
                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBoxEstoque();
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Produto n�o encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //-----------------------------------------------------------------------------------------------
        // Metodo Atualizar List Cliente
        private void AtualizarListBoxClientes()
        {
            lstBoxCliente.DataSource = null;
            lstBoxCliente.DataSource = clienteService.ObterTodos();
        }
        // Btn Cadastrar Cliente
        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidosCliente())
            {
                return;
            }

            var cliente = new Cliente
            {
                Id = (int)numIdCliente.Value,
                Nome = txtNomeCliente.Text,
                Telefone = txtTelefoneCliente.Text,
                Email = txtEmailCliente.Text,
                Cpf = txtCpfCliente.Text
            };

            if (clienteService.AdicionarCliente(cliente))
            {
                AtualizarListBoxClientes();
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCamposClientes();
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("J� existe um cliente com este ID ou CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparCamposClientes();
            }
        }

        // Evento para quando o usu�rio seleciona um item no ListBox
        private void listBoxcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxCliente.SelectedItem != null)
            {
                var clienteSelecionado = (Cliente)lstBoxCliente.SelectedItem;

                numIdCliente.Value = clienteSelecionado.Id;
                txtNomeCliente.Text = clienteSelecionado.Nome;
                txtTelefoneCliente.Text = clienteSelecionado.Telefone;
                txtEmailCliente.Text = clienteSelecionado.Email;
                txtCpfCliente.Text = clienteSelecionado.Cpf;
            }
        }

        // Btn Atualizar Cliente
        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidosCliente())
            {
                return;
            }

            int id = (int)numIdCliente.Value;

            var clienteAtualizado = new Cliente
            {
                Nome = txtNomeCliente.Text,
                Telefone = txtTelefoneCliente.Text,
                Email = txtEmailCliente.Text,
                Cpf = txtCpfCliente.Text
            };

            if (clienteService.AtualizarCliente(id, clienteAtualizado))
            {
                LimparCamposClientes();
                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBoxClientes();
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Cliente n�o encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Btn Excluir Cliente
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            int id = int.Parse(numIdCliente.Text);

            if (clienteService.ExcluirCliente(id))
            {
                LimparCamposClientes();
                MessageBox.Show("Cliente exclu�do com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBoxClientes();
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Cliente n�o encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparCamposClientes();
            }
        }
        // Metodo Limpar Campos Cliente
        private void LimparCamposClientes()
        {
            numIdCliente.Value = 0;
            txtNomeCliente.Clear();
            txtTelefoneCliente.Clear();
            txtEmailCliente.Clear();
            txtCpfCliente.Clear();
        }

        // -----------------------------------------------------------------------------------------
        // Metodo Atualizar Entrada
        private void AtualizarListBoxServicos()
        {
            lstBoxEntrada.DataSource = null;
            lstBoxEntrada.DataSource = servicoService.ObterTodos();
        }
        // Btn Adicionar Entrada
        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidosServico())
            {
                return;
            }

            var servico = new Servico
            {
                Id = (int)numIdEntrada.Value,
                NomeCliente = txtNomeEntrada.Text,
                TipoServico = txtTipoEntrada.Text,
                DataEntrada = txtDataEntradaEntrada.Text,
                DataSaida = txtDataSaidaEntrada.Text,
                Obs = txtObsEntrada.Text
            };

            if (servicoService.AdicionarServico(servico))
            {
                AtualizarListBoxServicos();
                LimparCamposServicos();
                MessageBox.Show("Servi�o cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("J� existe um servi�o com este ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento para quando o usu�rio seleciona um item no ListBox
        private void listBoxEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxEntrada.SelectedItem != null)
            {
                var entradaSelecionado = (Servico)lstBoxEntrada.SelectedItem;

                numIdEntrada.Value = entradaSelecionado.Id;
                txtNomeEntrada.Text = entradaSelecionado.NomeCliente;
                txtTipoEntrada.Text = entradaSelecionado.TipoServico;
                txtDataEntradaEntrada.Text = entradaSelecionado.DataEntrada;
                txtDataSaidaEntrada.Text = entradaSelecionado.DataSaida;
                txtObsEntrada.Text = entradaSelecionado.Obs;
            }
        }
        // Btn Atualizar Entrada
        private void btnAtualizarServico_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidosServico())
            {
                return;
            }

            int id = (int)numIdEntrada.Value;

            var servicoAtualizado = new Servico
            {
                NomeCliente = txtNomeEntrada.Text,
                TipoServico = txtTipoEntrada.Text,
                DataEntrada = txtDataEntradaEntrada.Text,
                DataSaida = txtDataSaidaEntrada.Text,
                Obs = txtObsEntrada.Text
            };

            if (servicoService.AtualizarServico(id, servicoAtualizado))
            {
                AtualizarListBoxServicos();
                LimparCamposServicos();
                MessageBox.Show("Servi�o atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Servi�o n�o encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Btn Excluir Entrada
        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            int id = (int)numIdEntrada.Value;

            if (servicoService.ExcluirServico(id))
            {
                AtualizarListBoxServicos();
                LimparCamposServicos();
                MessageBox.Show("Servi�o exclu�do com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Servi�o n�o encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Metodo Limpar Campos Entrada
        private void LimparCamposServicos()
        {
            numIdEntrada.Value = 0;
            txtNomeEntrada.Clear();
            txtTipoEntrada.Clear();
            txtDataEntradaEntrada.Clear();
            txtDataSaidaEntrada.Clear();
            txtObsEntrada.Clear();
        }

        // ---------------------------------------------------------------------------------
        private void AtualizarListBoxSaidas()
        {
            lstBoxSaida.DataSource = null;
            lstBoxSaida.DataSource = saidaServicoService.ObterTodos();
        }
        private void btnAdicionarSaida_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidosSaida())
            {
                return;
            }

            var saida = new SaidaServico
            {
                Id = (int)numIdSaida.Value,
                NomeCliente = txtNomeSaida.Text,
                TipoServico = txtTipoSaida.Text,
                DataEntrada = txtDataEntradaSaida.Text,
                DataSaida = txtDataSaidaSaida.Text,
                Obs = txtObsSaida.Text
            };

            if (saidaServicoService.AdicionarSaida(saida))
            {
                AtualizarListBoxSaidas();
                LimparCamposSaidas();
                MessageBox.Show("Sa�da cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("J� existe uma sa�da com este ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento para quando o usu�rio seleciona um item no ListBox
        private void listBoxSaida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxSaida.SelectedItem != null)
            {
                // Obt�m o item selecionado no ListBox (presume que seja do tipo Produto)
                var saidaSelecionados = (SaidaServico)lstBoxSaida.SelectedItem;

                // Preenche os campos com os dados do produto selecionado
                numIdSaida.Value = saidaSelecionados.Id;
                txtNomeSaida.Text = saidaSelecionados.NomeCliente;
                txtTipoSaida.Text = saidaSelecionados.TipoServico;
                txtDataEntradaSaida.Text = saidaSelecionados.DataEntrada;
                txtDataSaidaSaida.Text = saidaSelecionados.DataSaida;
                txtObsSaida.Text = saidaSelecionados.Obs;
            }
        }


        private void btnAtualizarSaida_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidosSaida())
            {
                return;
            }

            int id = (int)numIdSaida.Value;

            var saidaAtualizada = new SaidaServico
            {
                NomeCliente = txtNomeSaida.Text,
                TipoServico = txtTipoSaida.Text,
                DataEntrada = txtDataEntradaSaida.Text,
                DataSaida = txtDataSaidaSaida.Text,
                Obs = txtObsSaida.Text
            };

            if (saidaServicoService.AtualizarSaida(id, saidaAtualizada))
            {
                AtualizarListBoxSaidas();
                LimparCamposSaidas();
                MessageBox.Show("Sa�da atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Sa�da n�o encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirSaida_Click(object sender, EventArgs e)
        {
            int id = int.Parse(numIdSaida.Text);

            if (saidaServicoService.ExcluirSaida(id))
            {
                AtualizarListBoxSaidas();
                LimparCamposSaidas();
                MessageBox.Show("Sa�da exclu�da com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Sa�da n�o encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimparCamposSaidas()
        {
            numIdSaida.Value = 0;
            txtNomeSaida.Clear();
            txtTipoSaida.Clear();
            txtObsSaida.Clear();
            txtDataEntradaSaida.Clear();
            txtDataSaidaSaida.Clear();
        }

        // -----------------------------------------------------------------------------------------
        private void AtualizarHistorico()
        {
            int totalEstoque = produtoService.ObterTodos().Count;
            int totalClientes = clienteService.ObterTodos().Count;
            int totalEntradas = servicoService.ObterTodos().Count;
            int totalSaidas = saidaServicoService.ObterTodos().Count;

            lblStatusHistorico.Text =
                $"Resumo do Sistema:\n\n" +
                $"- Produtos no Estoque: {totalEstoque}\n\n" +
                $"- Clientes Cadastrados: {totalClientes}\n\n" +
                $"- Servi�os de Entrada: {totalEntradas}\n\n" +
                $"- Servi�os de Sa�da: {totalSaidas}";
        }

        // --------------------------------------------------------------------------------------
        private bool CamposPreenchidosEstoque()
        {
            if (numIdEstoque.Value == 0)
            {
                MessageBox.Show("O campo 'ID' � obrigat�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CamposPreenchidosCliente()
        {
            if (numIdCliente.Value == 0)
            {
                MessageBox.Show("O campo 'ID' � obrigat�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CamposPreenchidosServico()
        {
            if (numIdEntrada.Value == 0)
            {
                MessageBox.Show("O campo 'ID' � obrigat�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CamposPreenchidosSaida()
        {
            if (numIdSaida.Value == 0)
            {
                MessageBox.Show("O campo 'ID' � obrigat�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

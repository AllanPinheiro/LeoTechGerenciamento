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
                MessageBox.Show("Já existe um produto com este ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparCamposEstoque();
            }
        }
        // Btn Excluir Estoque
        private void btnExcluirEstoque_Click(object sender, EventArgs e)
        {
            int id = (int)numIdEstoque.Value;

            if (produtoService.ExcluirProduto(id))
            {
                LimparCamposEstoque();
                MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBoxEstoque();
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Já existe um cliente com este ID ou CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparCamposClientes();
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
                MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Btn Excluir Cliente
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            int id = int.Parse(numIdCliente.Text);

            if (clienteService.ExcluirCliente(id))
            {
                LimparCamposClientes();
                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBoxClientes();
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Serviço cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Já existe um serviço com este ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Serviço atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Serviço não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Serviço excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Serviço não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Saída cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Já existe uma saída com este ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Saída atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Saída não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirSaida_Click(object sender, EventArgs e)
        {
            int id = int.Parse(numIdSaida.Text);

            if (saidaServicoService.ExcluirSaida(id))
            {
                AtualizarListBoxSaidas();
                LimparCamposSaidas();
                MessageBox.Show("Saída excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarHistorico();
            }
            else
            {
                MessageBox.Show("Saída não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                $"- Produtos no Estoque: {totalEstoque}\n" +
                $"- Clientes Cadastrados: {totalClientes}\n" +
                $"- Serviços de Entrada: {totalEntradas}\n" +
                $"- Serviços de Saída: {totalSaidas}";
        }

        // --------------------------------------------------------------------------------------
        private bool CamposPreenchidosEstoque()
        {
            if (string.IsNullOrWhiteSpace(txtNomeEstoque.Text))
            {
                MessageBox.Show("O campo 'Nome do Produto' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescEstoque.Text))
            {
                MessageBox.Show("O campo 'Descrição' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numIdEstoque.Value == 0)
            {
                MessageBox.Show("O campo 'ID' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numQuantEstoque.Value == 0)
            {
                MessageBox.Show("O campo 'Quantidade' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           return true;
        }

        private bool CamposPreenchidosCliente()
        {
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("O campo 'Nome do Cliente' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefoneCliente.Text))
            {
                MessageBox.Show("O campo 'Telefone' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numIdCliente.Value == 0)
            {
                MessageBox.Show("O campo 'ID' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CamposPreenchidosServico()
        {
            if (string.IsNullOrWhiteSpace(txtNomeEntrada.Text))
            {
                MessageBox.Show("O campo 'Nome do Cliente' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTipoEntrada.Text))
            {
                MessageBox.Show("O campo 'Tipo de Serviço' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDataEntradaEntrada.Text))
            {
                MessageBox.Show("O campo 'Data de Entrada' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDataSaidaEntrada.Text))
            {
                MessageBox.Show("O campo 'Data de Saída' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numIdEntrada.Value == 0)
            {
                MessageBox.Show("O campo 'ID' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CamposPreenchidosSaida()
        {
            if (string.IsNullOrWhiteSpace(txtNomeSaida.Text))
            {
                MessageBox.Show("O campo 'Nome do Cliente' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTipoSaida.Text))
            {
                MessageBox.Show("O campo 'Tipo de Serviço' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDataEntradaSaida.Text))
            {
                MessageBox.Show("O campo 'Data de Entrada' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDataSaidaSaida.Text))
            {
                MessageBox.Show("O campo 'Data de Saída' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numIdSaida.Value == 0)
            {
                MessageBox.Show("O campo 'ID' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

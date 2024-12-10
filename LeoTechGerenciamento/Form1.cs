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
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        // Metodo Atualizar List
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
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var servico = new Servico
            {
                Id = (int)numIdEntrada.Value,
                NomeCliente = txtNomeEntrada.Text,
                TipoServico = txtTipoEntrada.Text,
                DataEntrada = dateEntrada.Value,
                DataSaida = dateSaidaEntrada.Value,
                Obs = txtObsEntrada.Text
            };

            if (servico.DataEntrada > servico.DataSaida)
            {
                MessageBox.Show("A Data de Entrada não pode ser maior que a Data de Saída.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)numIdEntrada.Value;

            var servicoAtualizado = new Servico
            {
                NomeCliente = txtNomeEntrada.Text,
                TipoServico = txtTipoEntrada.Text,
                DataEntrada = dateEntrada.Value,
                DataSaida = dateSaidaEntrada.Value,
                Obs = txtObsEntrada.Text
            };

            if (servicoAtualizado.DataEntrada > servicoAtualizado.DataSaida)
            {
                MessageBox.Show("A Data de Entrada não pode ser maior que a Data de Saída.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            dateEntrada.Value = DateTime.Now;
            dateSaidaEntrada.Value = DateTime.Now;
            txtObsEntrada.Clear();
        }

        private void AtualizarListBoxSaidas()
        {
            lstBoxSaida.DataSource = null;
            lstBoxSaida.DataSource = saidaServicoService.ObterTodos();
        }
        private void btnAdicionarSaida_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidosSaida())
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var saida = new SaidaServico
            {
                Id = (int)numIdSaida.Value,
                NomeCliente = txtNomeSaida.Text,
                TipoServico = txtTipoSaida.Text,
                DataSaida = dateSaidaSaida.Value,
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
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)numIdSaida.Value;

            var saidaAtualizada = new SaidaServico
            {
                NomeCliente = txtNomeSaida.Text,
                TipoServico = txtTipoSaida.Text,
                DataSaida = dateSaidaSaida.Value,
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
            dateEntradaSaida.Value = DateTime.Now;
            dateSaidaSaida.Value = DateTime.Now;
        }

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

        private bool CamposPreenchidosEstoque()
        {
            return !string.IsNullOrWhiteSpace(txtNomeEstoque.Text) &&
                   !string.IsNullOrWhiteSpace(txtDescEstoque.Text) &&
                   numIdEstoque.Value > 0 &&
                   numQuantEstoque.Value > 0;
        }

        private bool CamposPreenchidosCliente()
        {
            return !string.IsNullOrWhiteSpace(txtNomeCliente.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelefoneCliente.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmailCliente.Text) &&
                   !string.IsNullOrWhiteSpace(txtCpfCliente.Text) &&
                   numIdCliente.Value > 0;
        }

        private bool CamposPreenchidosServico()
        {
            return !string.IsNullOrWhiteSpace(txtNomeEntrada.Text) &&
                   !string.IsNullOrWhiteSpace(txtTipoEntrada.Text) &&
                   dateEntrada.Value != null &&
                   dateSaidaEntrada.Value != null &&
                   !string.IsNullOrWhiteSpace(txtObsEntrada.Text) &&
                   numIdEntrada.Value > 0;
        }

        private bool CamposPreenchidosSaida()
        {
            return !string.IsNullOrWhiteSpace(txtNomeSaida.Text) &&
                   !string.IsNullOrWhiteSpace(txtTipoSaida.Text) &&
                   dateSaidaSaida.Value != null &&
                   !string.IsNullOrWhiteSpace(txtObsSaida.Text) &&
                   numIdSaida.Value > 0;
        }
    }
}

﻿namespace LeoTechGerenciamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lstBoxEstoque = new ListBox();
            btnCadastrarEstoque = new Button();
            numIdEstoque = new NumericUpDown();
            numQuantEstoque = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            btnExcluirEstoque = new Button();
            txtDescEstoque = new TextBox();
            label9 = new Label();
            txtNomeEstoque = new TextBox();
            label10 = new Label();
            btnAtulizarEstoque = new Button();
            tabPage2 = new TabPage();
            txtCpfCliente = new TextBox();
            label11 = new Label();
            txtNomeCliente = new TextBox();
            numIdCliente = new NumericUpDown();
            lstBoxCliente = new ListBox();
            label12 = new Label();
            btnAdicionarCliente = new Button();
            btnExcluirCliente = new Button();
            btnAtualizarCliente = new Button();
            label6 = new Label();
            txtEmailCliente = new TextBox();
            label5 = new Label();
            txtTelefoneCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabPage3 = new TabPage();
            lstBoxEntrada = new ListBox();
            txtObsEntrada = new TextBox();
            label19 = new Label();
            dateSaidaEntrada = new DateTimePicker();
            label16 = new Label();
            label14 = new Label();
            dateEntrada = new DateTimePicker();
            label13 = new Label();
            numIdEntrada = new NumericUpDown();
            btnAdicionarentrada = new Button();
            btnExcluirEntrada = new Button();
            btnAtualizarEntrada = new Button();
            label15 = new Label();
            txtTipoEntrada = new TextBox();
            label17 = new Label();
            txtNomeEntrada = new TextBox();
            label18 = new Label();
            tabPage4 = new TabPage();
            lstBoxSaida = new ListBox();
            txtObsSaida = new TextBox();
            label20 = new Label();
            dateSaidaSaida = new DateTimePicker();
            label21 = new Label();
            label22 = new Label();
            dateEntradaSaida = new DateTimePicker();
            label23 = new Label();
            numIdSaida = new NumericUpDown();
            btnAdicinarSaida = new Button();
            btnExcluirSaida = new Button();
            btnAtualizarSaida = new Button();
            label24 = new Label();
            txtTipoSaida = new TextBox();
            label25 = new Label();
            txtNomeSaida = new TextBox();
            label26 = new Label();
            tabPage5 = new TabPage();
            label32 = new Label();
            lblStatusHistorico = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnFechar = new Button();
            btnMinimizar = new Button();
            label36 = new Label();
            label37 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIdEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantEstoque).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIdCliente).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIdEntrada).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIdSaida).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleRole = AccessibleRole.None;
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(44, 132);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(915, 444);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lstBoxEstoque);
            tabPage1.Controls.Add(btnCadastrarEstoque);
            tabPage1.Controls.Add(numIdEstoque);
            tabPage1.Controls.Add(numQuantEstoque);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnExcluirEstoque);
            tabPage1.Controls.Add(txtDescEstoque);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtNomeEstoque);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(btnAtulizarEstoque);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(907, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Estoque";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstBoxEstoque
            // 
            lstBoxEstoque.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBoxEstoque.FormattingEnabled = true;
            lstBoxEstoque.HorizontalScrollbar = true;
            lstBoxEstoque.ItemHeight = 34;
            lstBoxEstoque.Location = new Point(0, 46);
            lstBoxEstoque.Name = "lstBoxEstoque";
            lstBoxEstoque.ScrollAlwaysVisible = true;
            lstBoxEstoque.Size = new Size(907, 242);
            lstBoxEstoque.TabIndex = 23;
            // 
            // btnCadastrarEstoque
            // 
            btnCadastrarEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarEstoque.Location = new Point(571, 363);
            btnCadastrarEstoque.Name = "btnCadastrarEstoque";
            btnCadastrarEstoque.Size = new Size(336, 44);
            btnCadastrarEstoque.TabIndex = 20;
            btnCadastrarEstoque.Text = "Cadastrar Produto";
            btnCadastrarEstoque.UseVisualStyleBackColor = true;
            btnCadastrarEstoque.Click += btnCadastrarEstoque_Click;
            // 
            // numIdEstoque
            // 
            numIdEstoque.Location = new Point(0, 334);
            numIdEstoque.Name = "numIdEstoque";
            numIdEstoque.Size = new Size(91, 23);
            numIdEstoque.TabIndex = 19;
            // 
            // numQuantEstoque
            // 
            numQuantEstoque.Location = new Point(694, 334);
            numQuantEstoque.Name = "numQuantEstoque";
            numQuantEstoque.Size = new Size(213, 23);
            numQuantEstoque.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 306);
            label7.Name = "label7";
            label7.Size = new Size(30, 25);
            label7.TabIndex = 16;
            label7.Text = "Id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(694, 306);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 14;
            label8.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 18);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 0;
            label2.Text = "Produto Do Estoque";
            // 
            // btnExcluirEstoque
            // 
            btnExcluirEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirEstoque.Location = new Point(342, 363);
            btnExcluirEstoque.Name = "btnExcluirEstoque";
            btnExcluirEstoque.Size = new Size(223, 44);
            btnExcluirEstoque.TabIndex = 7;
            btnExcluirEstoque.Text = "Excluir Produto";
            btnExcluirEstoque.UseVisualStyleBackColor = true;
            btnExcluirEstoque.Click += btnExcluirEstoque_Click;
            // 
            // txtDescEstoque
            // 
            txtDescEstoque.Location = new Point(397, 334);
            txtDescEstoque.Name = "txtDescEstoque";
            txtDescEstoque.Size = new Size(291, 23);
            txtDescEstoque.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(397, 306);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 12;
            label9.Text = "Descrição";
            // 
            // txtNomeEstoque
            // 
            txtNomeEstoque.Location = new Point(97, 334);
            txtNomeEstoque.Name = "txtNomeEstoque";
            txtNomeEstoque.Size = new Size(294, 23);
            txtNomeEstoque.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(97, 306);
            label10.Name = "label10";
            label10.Size = new Size(177, 25);
            label10.TabIndex = 10;
            label10.Text = "Nome Do Produto";
            // 
            // btnAtulizarEstoque
            // 
            btnAtulizarEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtulizarEstoque.Location = new Point(0, 363);
            btnAtulizarEstoque.Name = "btnAtulizarEstoque";
            btnAtulizarEstoque.Size = new Size(336, 44);
            btnAtulizarEstoque.TabIndex = 6;
            btnAtulizarEstoque.Text = "Atualizar Produto";
            btnAtulizarEstoque.UseVisualStyleBackColor = true;
            btnAtulizarEstoque.Click += btnAtualizarEstoque_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(txtCpfCliente);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtNomeCliente);
            tabPage2.Controls.Add(numIdCliente);
            tabPage2.Controls.Add(lstBoxCliente);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(btnAdicionarCliente);
            tabPage2.Controls.Add(btnExcluirCliente);
            tabPage2.Controls.Add(btnAtualizarCliente);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtEmailCliente);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtTelefoneCliente);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(907, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Clientes";
            // 
            // txtCpfCliente
            // 
            txtCpfCliente.Location = new Point(739, 333);
            txtCpfCliente.Name = "txtCpfCliente";
            txtCpfCliente.Size = new Size(168, 23);
            txtCpfCliente.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(739, 305);
            label11.Name = "label11";
            label11.Size = new Size(46, 25);
            label11.TabIndex = 25;
            label11.Text = "CPF";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(97, 334);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(300, 23);
            txtNomeCliente.TabIndex = 24;
            // 
            // numIdCliente
            // 
            numIdCliente.Location = new Point(0, 334);
            numIdCliente.Name = "numIdCliente";
            numIdCliente.Size = new Size(91, 23);
            numIdCliente.TabIndex = 23;
            // 
            // lstBoxCliente
            // 
            lstBoxCliente.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBoxCliente.FormattingEnabled = true;
            lstBoxCliente.HorizontalScrollbar = true;
            lstBoxCliente.ItemHeight = 34;
            lstBoxCliente.Location = new Point(0, 46);
            lstBoxCliente.Name = "lstBoxCliente";
            lstBoxCliente.ScrollAlwaysVisible = true;
            lstBoxCliente.Size = new Size(907, 242);
            lstBoxCliente.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 18);
            label12.Name = "label12";
            label12.Size = new Size(195, 25);
            label12.TabIndex = 19;
            label12.Text = "Clientes Cadastrados";
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarCliente.Location = new Point(571, 363);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(336, 44);
            btnAdicionarCliente.TabIndex = 15;
            btnAdicionarCliente.Text = "Adicionar Cliente";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirCliente.Location = new Point(342, 363);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(223, 44);
            btnExcluirCliente.TabIndex = 13;
            btnExcluirCliente.Text = "Excluir Cliente";
            btnExcluirCliente.UseVisualStyleBackColor = true;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // btnAtualizarCliente
            // 
            btnAtualizarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizarCliente.Location = new Point(0, 363);
            btnAtualizarCliente.Name = "btnAtualizarCliente";
            btnAtualizarCliente.Size = new Size(336, 44);
            btnAtualizarCliente.TabIndex = 12;
            btnAtualizarCliente.Text = "Atualizar Cliente";
            btnAtualizarCliente.UseVisualStyleBackColor = true;
            btnAtualizarCliente.Click += btnAtualizarCliente_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 306);
            label6.Name = "label6";
            label6.Size = new Size(30, 25);
            label6.TabIndex = 7;
            label6.Text = "Id";
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(571, 334);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(162, 23);
            txtEmailCliente.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(571, 306);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(403, 334);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(162, 23);
            txtTelefoneCliente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(403, 306);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 3;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 306);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 1;
            label3.Text = "Nome";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Controls.Add(lstBoxEntrada);
            tabPage3.Controls.Add(txtObsEntrada);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(dateSaidaEntrada);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(dateEntrada);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(numIdEntrada);
            tabPage3.Controls.Add(btnAdicionarentrada);
            tabPage3.Controls.Add(btnExcluirEntrada);
            tabPage3.Controls.Add(btnAtualizarEntrada);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(txtTipoEntrada);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(txtNomeEntrada);
            tabPage3.Controls.Add(label18);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(907, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Entrada";
            // 
            // lstBoxEntrada
            // 
            lstBoxEntrada.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBoxEntrada.FormattingEnabled = true;
            lstBoxEntrada.HorizontalScrollbar = true;
            lstBoxEntrada.ItemHeight = 34;
            lstBoxEntrada.Location = new Point(0, 46);
            lstBoxEntrada.Name = "lstBoxEntrada";
            lstBoxEntrada.ScrollAlwaysVisible = true;
            lstBoxEntrada.Size = new Size(907, 242);
            lstBoxEntrada.TabIndex = 42;
            // 
            // txtObsEntrada
            // 
            txtObsEntrada.Location = new Point(512, 334);
            txtObsEntrada.Name = "txtObsEntrada";
            txtObsEntrada.Size = new Size(395, 23);
            txtObsEntrada.TabIndex = 41;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(455, 332);
            label19.Name = "label19";
            label19.Size = new Size(51, 25);
            label19.TabIndex = 40;
            label19.Text = "Obs:";
            // 
            // dateSaidaEntrada
            // 
            dateSaidaEntrada.Format = DateTimePickerFormat.Short;
            dateSaidaEntrada.Location = new Point(353, 334);
            dateSaidaEntrada.Name = "dateSaidaEntrada";
            dateSaidaEntrada.Size = new Size(96, 23);
            dateSaidaEntrada.TabIndex = 39;
            dateSaidaEntrada.Value = new DateTime(2024, 12, 10, 12, 36, 42, 0);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(241, 334);
            label16.Name = "label16";
            label16.Size = new Size(106, 25);
            label16.TabIndex = 38;
            label16.Text = "Data Saida";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(0, 334);
            label14.Name = "label14";
            label14.Size = new Size(127, 25);
            label14.TabIndex = 37;
            label14.Text = "Data Entrada";
            // 
            // dateEntrada
            // 
            dateEntrada.Format = DateTimePickerFormat.Short;
            dateEntrada.Location = new Point(133, 336);
            dateEntrada.Name = "dateEntrada";
            dateEntrada.Size = new Size(102, 23);
            dateEntrada.TabIndex = 36;
            dateEntrada.Value = new DateTime(2024, 12, 10, 12, 36, 30, 0);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(6, 18);
            label13.Name = "label13";
            label13.Size = new Size(189, 25);
            label13.TabIndex = 35;
            label13.Text = "Entrada De Serviços";
            // 
            // numIdEntrada
            // 
            numIdEntrada.Location = new Point(36, 298);
            numIdEntrada.Name = "numIdEntrada";
            numIdEntrada.Size = new Size(87, 23);
            numIdEntrada.TabIndex = 32;
            // 
            // btnAdicionarentrada
            // 
            btnAdicionarentrada.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarentrada.Location = new Point(571, 363);
            btnAdicionarentrada.Name = "btnAdicionarentrada";
            btnAdicionarentrada.Size = new Size(336, 44);
            btnAdicionarentrada.TabIndex = 31;
            btnAdicionarentrada.Text = "Adicionar Entrada";
            btnAdicionarentrada.UseVisualStyleBackColor = true;
            btnAdicionarentrada.Click += btnAdicionarServico_Click;
            // 
            // btnExcluirEntrada
            // 
            btnExcluirEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirEntrada.Location = new Point(342, 363);
            btnExcluirEntrada.Name = "btnExcluirEntrada";
            btnExcluirEntrada.Size = new Size(223, 44);
            btnExcluirEntrada.TabIndex = 29;
            btnExcluirEntrada.Text = "Excluir Entrada";
            btnExcluirEntrada.UseVisualStyleBackColor = true;
            btnExcluirEntrada.Click += btnExcluirServico_Click;
            // 
            // btnAtualizarEntrada
            // 
            btnAtualizarEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizarEntrada.Location = new Point(0, 363);
            btnAtualizarEntrada.Name = "btnAtualizarEntrada";
            btnAtualizarEntrada.Size = new Size(336, 44);
            btnAtualizarEntrada.TabIndex = 28;
            btnAtualizarEntrada.Text = "Atualizar Entrada";
            btnAtualizarEntrada.UseVisualStyleBackColor = true;
            btnAtualizarEntrada.Click += btnAtualizarServico_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(0, 297);
            label15.Name = "label15";
            label15.Size = new Size(30, 25);
            label15.TabIndex = 26;
            label15.Text = "Id";
            // 
            // txtTipoEntrada
            // 
            txtTipoEntrada.Location = new Point(687, 299);
            txtTipoEntrada.Name = "txtTipoEntrada";
            txtTipoEntrada.Size = new Size(220, 23);
            txtTipoEntrada.TabIndex = 23;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(524, 299);
            label17.Name = "label17";
            label17.Size = new Size(157, 25);
            label17.TabIndex = 22;
            label17.Text = "Tipo De Serviço:";
            // 
            // txtNomeEntrada
            // 
            txtNomeEntrada.Location = new Point(272, 298);
            txtNomeEntrada.Name = "txtNomeEntrada";
            txtNomeEntrada.Size = new Size(246, 23);
            txtNomeEntrada.TabIndex = 21;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(129, 299);
            label18.Name = "label18";
            label18.Size = new Size(137, 25);
            label18.TabIndex = 20;
            label18.Text = "Nome Cliente:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lstBoxSaida);
            tabPage4.Controls.Add(txtObsSaida);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(dateSaidaSaida);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(dateEntradaSaida);
            tabPage4.Controls.Add(label23);
            tabPage4.Controls.Add(numIdSaida);
            tabPage4.Controls.Add(btnAdicinarSaida);
            tabPage4.Controls.Add(btnExcluirSaida);
            tabPage4.Controls.Add(btnAtualizarSaida);
            tabPage4.Controls.Add(label24);
            tabPage4.Controls.Add(txtTipoSaida);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(txtNomeSaida);
            tabPage4.Controls.Add(label26);
            tabPage4.Location = new Point(4, 27);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(907, 413);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Saida";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstBoxSaida
            // 
            lstBoxSaida.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBoxSaida.FormattingEnabled = true;
            lstBoxSaida.HorizontalScrollbar = true;
            lstBoxSaida.ItemHeight = 34;
            lstBoxSaida.Location = new Point(0, 46);
            lstBoxSaida.Name = "lstBoxSaida";
            lstBoxSaida.ScrollAlwaysVisible = true;
            lstBoxSaida.Size = new Size(907, 242);
            lstBoxSaida.TabIndex = 60;
            // 
            // txtObsSaida
            // 
            txtObsSaida.Location = new Point(512, 334);
            txtObsSaida.Name = "txtObsSaida";
            txtObsSaida.Size = new Size(395, 23);
            txtObsSaida.TabIndex = 59;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(455, 332);
            label20.Name = "label20";
            label20.Size = new Size(51, 25);
            label20.TabIndex = 58;
            label20.Text = "Obs:";
            // 
            // dateSaidaSaida
            // 
            dateSaidaSaida.Format = DateTimePickerFormat.Short;
            dateSaidaSaida.Location = new Point(353, 334);
            dateSaidaSaida.Name = "dateSaidaSaida";
            dateSaidaSaida.Size = new Size(96, 23);
            dateSaidaSaida.TabIndex = 57;
            dateSaidaSaida.Value = new DateTime(2024, 12, 10, 12, 36, 55, 0);
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(241, 334);
            label21.Name = "label21";
            label21.Size = new Size(106, 25);
            label21.TabIndex = 56;
            label21.Text = "Data Saida";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(0, 334);
            label22.Name = "label22";
            label22.Size = new Size(127, 25);
            label22.TabIndex = 55;
            label22.Text = "Data Entrada";
            // 
            // dateEntradaSaida
            // 
            dateEntradaSaida.Format = DateTimePickerFormat.Short;
            dateEntradaSaida.Location = new Point(133, 336);
            dateEntradaSaida.Name = "dateEntradaSaida";
            dateEntradaSaida.Size = new Size(102, 23);
            dateEntradaSaida.TabIndex = 54;
            dateEntradaSaida.Value = new DateTime(2024, 12, 10, 12, 37, 0, 0);
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(6, 18);
            label23.Name = "label23";
            label23.Size = new Size(168, 25);
            label23.TabIndex = 53;
            label23.Text = "Saida De Serviços";
            // 
            // numIdSaida
            // 
            numIdSaida.Location = new Point(36, 298);
            numIdSaida.Name = "numIdSaida";
            numIdSaida.Size = new Size(87, 23);
            numIdSaida.TabIndex = 52;
            // 
            // btnAdicinarSaida
            // 
            btnAdicinarSaida.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicinarSaida.Location = new Point(571, 363);
            btnAdicinarSaida.Name = "btnAdicinarSaida";
            btnAdicinarSaida.Size = new Size(336, 44);
            btnAdicinarSaida.TabIndex = 51;
            btnAdicinarSaida.Text = "Adicionar Saida";
            btnAdicinarSaida.UseVisualStyleBackColor = true;
            btnAdicinarSaida.Click += btnAdicionarSaida_Click;
            // 
            // btnExcluirSaida
            // 
            btnExcluirSaida.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirSaida.Location = new Point(342, 363);
            btnExcluirSaida.Name = "btnExcluirSaida";
            btnExcluirSaida.Size = new Size(223, 44);
            btnExcluirSaida.TabIndex = 49;
            btnExcluirSaida.Text = "Excluir Saida";
            btnExcluirSaida.UseVisualStyleBackColor = true;
            btnExcluirSaida.Click += btnExcluirSaida_Click;
            // 
            // btnAtualizarSaida
            // 
            btnAtualizarSaida.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizarSaida.Location = new Point(0, 363);
            btnAtualizarSaida.Name = "btnAtualizarSaida";
            btnAtualizarSaida.Size = new Size(336, 44);
            btnAtualizarSaida.TabIndex = 48;
            btnAtualizarSaida.Text = "Atualizar Saida";
            btnAtualizarSaida.UseVisualStyleBackColor = true;
            btnAtualizarSaida.Click += btnAtualizarSaida_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(0, 297);
            label24.Name = "label24";
            label24.Size = new Size(30, 25);
            label24.TabIndex = 47;
            label24.Text = "Id";
            // 
            // txtTipoSaida
            // 
            txtTipoSaida.Location = new Point(687, 299);
            txtTipoSaida.Name = "txtTipoSaida";
            txtTipoSaida.Size = new Size(220, 23);
            txtTipoSaida.TabIndex = 46;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(524, 299);
            label25.Name = "label25";
            label25.Size = new Size(157, 25);
            label25.TabIndex = 45;
            label25.Text = "Tipo De Serviço:";
            // 
            // txtNomeSaida
            // 
            txtNomeSaida.Location = new Point(272, 298);
            txtNomeSaida.Name = "txtNomeSaida";
            txtNomeSaida.Size = new Size(246, 23);
            txtNomeSaida.TabIndex = 44;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(129, 299);
            label26.Name = "label26";
            label26.Size = new Size(137, 25);
            label26.TabIndex = 43;
            label26.Text = "Nome Cliente:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label32);
            tabPage5.Controls.Add(lblStatusHistorico);
            tabPage5.Location = new Point(4, 27);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(907, 413);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Histórico";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(12, 23);
            label32.Name = "label32";
            label32.Size = new Size(0, 37);
            label32.TabIndex = 67;
            // 
            // lblStatusHistorico
            // 
            lblStatusHistorico.AutoSize = true;
            lblStatusHistorico.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusHistorico.Location = new Point(6, 3);
            lblStatusHistorico.Name = "lblStatusHistorico";
            lblStatusHistorico.Size = new Size(0, 37);
            lblStatusHistorico.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 32);
            label1.Name = "label1";
            label1.Size = new Size(481, 45);
            label1.TabIndex = 1;
            label1.Text = "LeoTech - Assistência Técnica";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(888, 32);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(71, 51);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(811, 32);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(71, 51);
            btnMinimizar.TabIndex = 4;
            btnMinimizar.Text = "–";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(969, 588);
            label36.Name = "label36";
            label36.Size = new Size(22, 15);
            label36.TabIndex = 5;
            label36.Text = "1.0";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(12, 588);
            label37.Name = "label37";
            label37.Size = new Size(156, 15);
            label37.TabIndex = 6;
            label37.Text = "Developed by Allan Pinheiro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1003, 612);
            Controls.Add(label37);
            Controls.Add(label36);
            Controls.Add(btnMinimizar);
            Controls.Add(btnFechar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIdEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantEstoque).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIdCliente).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIdEntrada).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIdSaida).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnFechar;
        private Button btnMinimizar;
        private Label label2;
        private Button btnAtulizarEstoque;
        private Button btnExcluirEstoque;
        private TextBox txtTelefoneCliente;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox txtEmailCliente;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox txtDescEstoque;
        private Label label9;
        private Label label10;
        private Button btnExcluirCliente;
        private Button btnAtualizarCliente;
        private Button btnCadastrarEstoque;
        private NumericUpDown numQuantEstoque;
        private Button btnAdicionarCliente;
        private Label label12;
        private Label label13;
        private NumericUpDown numIdEntrada;
        private Button btnAdicionarentrada;
        private Button btnExcluirEntrada;
        private Button btnAtualizarEntrada;
        private Label label15;
        private TextBox txtTipoEntrada;
        private Label label17;
        private TextBox txtNomeEntrada;
        private Label label18;
        private Label label14;
        private DateTimePicker dateEntrada;
        private Label label16;
        private DateTimePicker dateSaidaEntrada;
        private TextBox txtObsEntrada;
        private Label label19;
        private TextBox txtObsSaida;
        private Label label20;
        private DateTimePicker dateSaidaSaida;
        private Label label21;
        private Label label22;
        private DateTimePicker dateEntradaSaida;
        private Label label23;
        private NumericUpDown numIdSaida;
        private Button btnAdicinarSaida;
        private Button btnExcluirSaida;
        private Button btnAtualizarSaida;
        private Label label24;
        private TextBox txtTipoSaida;
        private Label label25;
        private TextBox txtNomeSaida;
        private Label label26;
        private ListBox lstBoxCliente;
        private ListBox lstBoxEntrada;
        private ListBox lstBoxSaida;
        private NumericUpDown numIdEstoque;
        private TextBox txtNomeEstoque;
        private TextBox txtCpfCliente;
        private Label label11;
        private TextBox txtNomeCliente;
        private NumericUpDown numIdCliente;
        private ListBox lstBoxEstoque;
        private Label label36;
        private Label label37;
        private Label label32;
        private Label lblStatusHistorico;
    }
}
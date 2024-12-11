using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace LeoTechAssistenciaTecnica
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} --- Nome Do Cliente: {Nome.ToUpper()} --- Telefone: {Telefone} --- Email: {Email.ToUpper()} --- CPF: {Cpf}";
        }
    }

    public class ClienteService
    {
        private readonly string caminhoArquivoJson;
        private List<Cliente> clientes;

        public ClienteService(string caminho)
        {
            caminhoArquivoJson = caminho;
            CarregarClientes();
        }

        
        private void CarregarClientes()
        {
            if (File.Exists(caminhoArquivoJson))
            {
                var json = File.ReadAllText(caminhoArquivoJson);
                clientes = JsonConvert.DeserializeObject<List<Cliente>>(json) ?? new List<Cliente>();
            }
            else
            {
                clientes = new List<Cliente>();
            }
        }

        
        private void SalvarClientes()
        {
            var json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
            File.WriteAllText(caminhoArquivoJson, json);
        }

        
        public List<Cliente> ObterTodos()
        {
            return clientes;
        }

        
        public bool AdicionarCliente(Cliente novoCliente)
        {
            if (clientes.Any(c => c.Id == novoCliente.Id || c.Cpf == novoCliente.Cpf))
            {
                return false; // Cliente com ID ou CPF duplicado
            }

            clientes.Add(novoCliente);
            SalvarClientes();
            return true;
        }

        
        public bool AtualizarCliente(int id, Cliente clienteAtualizado)
        {
            var clienteExistente = clientes.FirstOrDefault(c => c.Id == id);

            if (clienteExistente == null)
            {
                return false; // Cliente não encontrado
            }

            clienteExistente.Nome = clienteAtualizado.Nome;
            clienteExistente.Telefone = clienteAtualizado.Telefone;
            clienteExistente.Email = clienteAtualizado.Email;
            clienteExistente.Cpf = clienteAtualizado.Cpf;

            SalvarClientes();
            return true;
        }

        
        public bool ExcluirCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                return false; // Cliente não encontrado
            }

            clientes.Remove(cliente);
            SalvarClientes();
            return true;
        }
    }
}

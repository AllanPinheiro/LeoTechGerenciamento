using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace LeoTechAssistenciaTecnica
{
    public class Servico
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string TipoServico { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public string Obs {  get; set; }

        public override string ToString()
        {
            return $"ID: {Id} --- Nome Do Cliente: {NomeCliente.ToUpper()} --- Tipo De Serviço: {TipoServico.ToUpper()} --- Data Entrada: {DataEntrada} --- Data Saida: {DataSaida} --- Obs: {Obs}";
        }
    }

    public class ServicoService
    {
        private readonly string caminhoArquivoJson;
        private List<Servico> servicos;

        public ServicoService(string caminho)
        {
            caminhoArquivoJson = caminho;
            CarregarServicos();
        }

        
        private void CarregarServicos()
        {
            if (File.Exists(caminhoArquivoJson))
            {
                var json = File.ReadAllText(caminhoArquivoJson);
                servicos = JsonConvert.DeserializeObject<List<Servico>>(json) ?? new List<Servico>();
            }
            else
            {
                servicos = new List<Servico>();
            }
        }

        
        private void SalvarServicos()
        {
            var json = JsonConvert.SerializeObject(servicos, Formatting.Indented);
            File.WriteAllText(caminhoArquivoJson, json);
        }

        
        public List<Servico> ObterTodos()
        {
            return servicos;
        }

        
        public bool AdicionarServico(Servico novoServico)
        {
            if (servicos.Any(s => s.Id == novoServico.Id))
            {
                return false; // Serviço com ID duplicado
            }

            servicos.Add(novoServico);
            SalvarServicos();
            return true;
        }

        
        public bool AtualizarServico(int id, Servico servicoAtualizado)
        {
            var servicoExistente = servicos.FirstOrDefault(s => s.Id == id);

            if (servicoExistente == null)
            {
                return false; // Serviço não encontrado
            }

            servicoExistente.NomeCliente = servicoAtualizado.NomeCliente;
            servicoExistente.TipoServico = servicoAtualizado.TipoServico;
            servicoExistente.DataEntrada = servicoAtualizado.DataEntrada;
            servicoExistente.DataSaida = servicoAtualizado.DataSaida;
            servicoExistente.Obs = servicoAtualizado.Obs;

            SalvarServicos();
            return true;
        }

        
        public bool ExcluirServico(int id)
        {
            var servico = servicos.FirstOrDefault(s => s.Id == id);

            if (servico == null)
            {
                return false; // Serviço não encontrado
            }

            servicos.Remove(servico);
            SalvarServicos();
            return true;
        }
    }
}

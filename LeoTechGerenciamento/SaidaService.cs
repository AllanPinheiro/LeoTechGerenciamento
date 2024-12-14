using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace LeoTechAssistenciaTecnica
{
    public class SaidaServico
    {
        public int Id { get; set; }
        public string? NomeCliente { get; set; }
        public string? TipoServico { get; set; }
        public  string? DataEntrada { get; set; }
        public string? DataSaida { get; set; }
        public string? Obs { get; set; } // Campo adicional para observações

        public override string ToString()
        {
            return $"ID:  {Id} --- Nome Do Cliente:  {NomeCliente.ToUpper()} --- Tipo De Serviço:  {TipoServico.ToUpper()} --- Data Entrada:  {DataEntrada} --- Data Saida:  {DataSaida} --- Obs:  {Obs}";
        }
    }

    public class SaidaServicoService
    {
        private readonly string caminhoArquivoJson;
        private List<SaidaServico> saidas;

        public SaidaServicoService(string caminho)
        {
            caminhoArquivoJson = caminho;
            CarregarSaidas();
        }

        
        private void CarregarSaidas()
        {
            if (File.Exists(caminhoArquivoJson))
            {
                var json = File.ReadAllText(caminhoArquivoJson);
                saidas = JsonConvert.DeserializeObject<List<SaidaServico>>(json) ?? new List<SaidaServico>();
            }
            else
            {
                saidas = new List<SaidaServico>();
            }
        }

        
        private void SalvarSaidas()
        {
            var json = JsonConvert.SerializeObject(saidas, Formatting.Indented);
            File.WriteAllText(caminhoArquivoJson, json);
        }

        
        public List<SaidaServico> ObterTodos()
        {
            return saidas;
        }

        
        public bool AdicionarSaida(SaidaServico novaSaida)
        {
            if (saidas.Any(s => s.Id == novaSaida.Id))
            {
                return false; // Saída com ID duplicado
            }

            saidas.Add(novaSaida);
            SalvarSaidas();
            return true;
        }

      
        public bool AtualizarSaida(int id, SaidaServico saidaAtualizada)
        {
            var saidaExistente = saidas.FirstOrDefault(s => s.Id == id);

            if (saidaExistente == null)
            {
                return false; // Saída não encontrada
            }

            saidaExistente.NomeCliente = saidaAtualizada.NomeCliente;
            saidaExistente.TipoServico = saidaAtualizada.TipoServico;
            saidaExistente.DataSaida = saidaAtualizada.DataSaida;
            saidaExistente.DataEntrada = saidaAtualizada.DataEntrada;
            saidaExistente.Obs = saidaAtualizada.Obs;

            SalvarSaidas();
            return true;
        }

        
        public bool ExcluirSaida(int id)
        {
            var saida = saidas.FirstOrDefault(s => s.Id == id);

            if (saida == null)
            {
                return false; // Saída não encontrada
            }

            saidas.Remove(saida);
            SalvarSaidas();
            return true;
        }
    }
}

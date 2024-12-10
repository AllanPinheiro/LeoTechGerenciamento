using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DocumentFormat.OpenXml.Office2010.Excel;
using Newtonsoft.Json;

namespace LeoTechAssistenciaTecnica
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeDoProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} --- Nome Do Produto: {NomeDoProduto.ToUpper()} --- Descrição: {Descricao.ToUpper()} --- Quantidade: {Quantidade} UN";
        }
    }


    public class ProdutoService
    {
        private readonly string caminhoArquivoJson;
        private List<Produto> produtos;

        public ProdutoService(string caminho)
        {
            caminhoArquivoJson = caminho;
            CarregarProdutos();
        }

        
        private void CarregarProdutos()
        {
            if (File.Exists(caminhoArquivoJson))
            {
                var json = File.ReadAllText(caminhoArquivoJson);
                produtos = JsonConvert.DeserializeObject<List<Produto>>(json) ?? new List<Produto>();
            }
            else
            {
                produtos = new List<Produto>();
            }
        }

        
        private void SalvarProdutos()
        {
            var json = JsonConvert.SerializeObject(produtos, Formatting.Indented);
            File.WriteAllText(caminhoArquivoJson, json);
        }

        
        public List<Produto> ObterTodos()
        {
            return produtos;
        }

        
        public bool AdicionarProduto(Produto novoProduto)
        {
            if (produtos.Any(p => p.Id == novoProduto.Id))
            {
                return false; // Produto com ID duplicado
            }

            produtos.Add(novoProduto);
            SalvarProdutos();
            return true;
        }

        
        public bool AtualizarProduto(int id, Produto produtoAtualizado)
        {
            var produtoExistente = produtos.FirstOrDefault(p => p.Id == id);

            if (produtoExistente == null)
            {
                return false; // Produto não encontrado
            }

            produtoExistente.NomeDoProduto = produtoAtualizado.NomeDoProduto;
            produtoExistente.Descricao = produtoAtualizado.Descricao;
            produtoExistente.Quantidade = produtoAtualizado.Quantidade;

            SalvarProdutos();
            return true;
        }

        
        public bool ExcluirProduto(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
            {
                return false; // Produto não encontrado
            }

            produtos.Remove(produto);
            SalvarProdutos();
            return true;
        }

    }
}

using Dev.Business.Interfaces;
using Dev.Business.Models;
using Dev.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace Dev.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        public async Task Adicionar(Fornecedor fornecedor)
        {
            // Validar o estado da entidade!
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor) 
                && !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco))
                return;

            // Validar se não existe duplicidade de documento

            return;
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor))
                return;
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco))
                return;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Threading.Tasks;

namespace WebAPI.Repository
{
    public class PagamentoRepository : IPagamento
    {
        public Task<object> DeletePorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<object> ObterPagamentoId(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

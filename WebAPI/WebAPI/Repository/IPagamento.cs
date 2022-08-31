using System;
using System.Threading.Tasks;

namespace WebAPI.Repository
{
    public interface IPagamento
    {
        Task<Object> ObterPagamentoId();
    }
}

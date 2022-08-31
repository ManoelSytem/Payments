using System;
using System.Threading.Tasks;

namespace WebAPI.Repository
{
    public interface IPagamento
    {
        Task<Object> ObterPorId(Guid id);
        Task<Object> DeletePorId(Guid id);
    }
}

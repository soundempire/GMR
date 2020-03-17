using GMR.BLL.Abstractions.Models;
using System.Threading.Tasks;

namespace GMR.BLL.Abstractions.Services
{
    public interface ITransactionService
    {
        Task<TransactionModel> GetTransactionAsync(long id);

        Task<TransactionModel> AddTransactionAsync(TransactionModel transaction);

        Task<TransactionModel> UpdateTransactionAsync(TransactionModel transaction);

        Task RemoveTransactionAsync(long id);

    }
}

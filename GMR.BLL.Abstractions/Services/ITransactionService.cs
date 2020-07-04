using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMR.BLL
{
    public interface ITransactionService
    {
        Task<TransactionModel> GetTransactionAsync(long id);

        Task<IEnumerable<TransactionModel>> GetTransactionsAsync(long contractorId);

        Task<TransactionModel> AddTransactionAsync(TransactionModel transaction);

        Task<TransactionModel> UpdateTransactionAsync(TransactionModel transaction);

        Task RemoveTransactionAsync(long id);
    }
}

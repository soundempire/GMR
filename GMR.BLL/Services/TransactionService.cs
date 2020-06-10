using GMR.DAL;
using System;
using System.Threading.Tasks;

namespace GMR.BLL.Services
{
    public class TransactionService : ITransactionService, IDisposable
    {
        private readonly IRepository<Transaction> _transactionRepository;

        public TransactionService(IRepository<Transaction> transactionRepository)
            => _transactionRepository = transactionRepository;

        public async Task<TransactionModel> GetTransactionAsync(long id)
        {
            var dataModel = await _transactionRepository.GetAsync(id);
            return Mapper.Map<Transaction, TransactionModel>(dataModel);
        }

        public async Task<TransactionModel> AddTransactionAsync(TransactionModel transaction)
        {
            var newTransaction = Mapper.Map<TransactionModel, Transaction>(transaction);

            var transactionEntity = await _transactionRepository.CreateAsync(newTransaction);

            return Mapper.Map<Transaction, TransactionModel>(transactionEntity);
        }

        public async Task<TransactionModel> UpdateTransactionAsync(TransactionModel transaction)
        {
            var trn = Mapper.Map<TransactionModel, Transaction>(transaction);

            await _transactionRepository.UpdateAsync(trn);

            return Mapper.Map<Transaction, TransactionModel>(trn);
        }

        public async Task RemoveTransactionAsync(long id)
            => await _transactionRepository.DeleteAsync(id);


        public void Dispose() => _transactionRepository.Dispose();
    }
}

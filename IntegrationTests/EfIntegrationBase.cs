namespace IntegrationTests
{
    using System;
    using System.Transactions;
    using Xunit;
    public abstract class EfIntegrationBase : IClassFixture<IntegrationFixture>, IDisposable
    {
        private readonly TransactionScope _scope;

        protected EfIntegrationBase()
        {
            _scope = new TransactionScope(TransactionScopeOption.RequiresNew);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _scope?.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
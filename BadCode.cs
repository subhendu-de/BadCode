using System;
namespace Badcode
{
    /// <summary>
    /// Calculate interest
    /// </summary>
    public class AccountInterestService
    {
        public async Task<decimal> Calculate(Guid userId, decimal amount, int type, decimal rate, int? years = null)
        {
            decimal result;
            var accountCreatedDate = await GetAccountCreatedDate(userId);
            var isLoyalCustomer = accountCreatedDate < DateTime.UtcNow.AddYears(-5);
            if (isLoyalCustomer)
            {
                rate += 0.5M;
            }
            if (type == 1) // Saving account
            {
                result = (amount * rate) / 100;
            }
            else if (type == 2) // Super saving account
            {
                result = ((amount * rate) / 100) * 2;
            }
            else if (type == 3) // Fixed deposit
            {
                result = ((amount * rate) / 100) * (int)years;
            }
            else
            {
                throw new NotImplementedException();
            }
            return result;
        }

        private async Task<DateTime> GetAccountCreatedDate(Guid userId)
        {
            // Logic
        }
    }
}

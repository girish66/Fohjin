namespace Fohjin.DDD.Domain.ValueObjects
{
    public class AccountNumber
    {
        public string Number { get; private set; }

        public AccountNumber(string number)
        {
            Number = number;
        }
    }
}
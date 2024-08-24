using Dima.core.Enums;

namespace Dima.core.Models;

public class Transaction
{
    public long Id { get; set; }
    public string Titulo { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? PaidOrReceivedAt { get; set; }

    public decimal Amount { get; set; }
    public TransactionEnum Type { get; set; } = TransactionEnum.Withdraw;
    public Category Category { get; set; } = null!;

    public string UserId { get; set; } = string.Empty;
}

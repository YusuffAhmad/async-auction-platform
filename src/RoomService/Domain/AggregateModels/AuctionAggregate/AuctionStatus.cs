namespace RoomService.Domain.AggregateModels.AuctionAggregate;

/// <summary>
/// Enum representing the status of an auction.
/// </summary>
public enum AuctionStatus
{
    Pending,
    Active,
    Cancelled,
    Completed,
    ReserveNotMet,
    PaymentPending,
    Paid,
    Failed,
    Disputed
}
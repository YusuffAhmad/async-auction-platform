﻿namespace InvoiceService.Domain.AggregateModels
{
    public class Invoice
    {
        public Guid InvoiceId { get; set; }
        public string AuctionId { get; set; }
        public AuctionItemDetails ItemDetails { get; set; }
        public BidderInfo HighestBidder { get; set; }
        public decimal WinningBidAmount { get; set; }
        public PaymentTerms PaymentTerms { get; set; }
        public DateTime AuctionCompletionDate { get; set; }
        public string BillingAddress { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string PaymentInstructions { get; set; }
        public string RefundPolicy { get; set; }
    }
}

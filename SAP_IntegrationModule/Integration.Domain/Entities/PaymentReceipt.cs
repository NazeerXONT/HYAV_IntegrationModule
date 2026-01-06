namespace Integration.Domain.Entities;

public sealed class PaymentReceipt : BaseAuditableEntity
{
    // Primary Key Components
    public long RecID { get; set; }
    public string BusinessUnit { get; set; } = string.Empty;
    public string TerritoryCode { get; set; } = string.Empty;
    public string PaymentSource { get; set; } = string.Empty;
    public string PaymentReference { get; set; } = string.Empty;

    // Core Payment Info
    public string RetailerCode { get; set; } = string.Empty;
    public string ExecutiveCode { get; set; } = string.Empty;
    public string PaymentMethodCode { get; set; } = string.Empty; // Cash, Cheque, Credit Card
    public DateTime? PaymentDate { get; set; }
    public decimal PaymentValue { get; set; }
    public decimal OriginalPaymentValue { get; set; }
    public string Status { get; set; } = "1";

    // Cheque / Bank Details
    public string ChequeNumber { get; set; } = string.Empty;
    public string BankCode { get; set; } = string.Empty;
    public string BankAccountName { get; set; } = string.Empty;
    public string BankAccountNumber { get; set; } = string.Empty;
    public decimal BankSortCode { get; set; }
    public DateTime? BankingDate { get; set; }

    // Credit Card Details
    public string CreditCardType { get; set; } = string.Empty;
    public string CreditCardNo { get; set; } = string.Empty;
    public DateTime? ExpiryDate { get; set; }

    // Sales Reference & Tracking
    public string SalesCategoryCode { get; set; } = string.Empty;
    public int RefInvoiceNo { get; set; } // Direct link to SalesInvoiceHeader.InvoiceNo
    public decimal ReceiptNo { get; set; }
    public string BookReceiptNo { get; set; } = string.Empty;

    // Visit / Route Context
    public int VisitNumber { get; set; }
    public string RouteCode { get; set; } = string.Empty;
    public string UserReference1 { get; set; } = string.Empty;

    // Geo-Location (PDA tracking)
    public decimal Longitude { get; set; }
    public decimal Latitude { get; set; }

    // System / Source Tracking
    public string UploadedSource { get; set; } = string.Empty;
    public string UpdateSource { get; set; } = "0";
    public string CashBankBookCode { get; set; } = string.Empty;
    public decimal VoucherValue { get; set; }
}

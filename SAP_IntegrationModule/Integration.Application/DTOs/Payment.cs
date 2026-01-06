using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.Application.DTOs;

public sealed class PaymentRequestDto
{
    public PaymentHeaderDto? Header { get; set; }
    public List<PaymentItemDto>? Items { get; set; }
}

public sealed class PaymentHeaderDto
{
    public string? CompanyCode { get; set; }
    public DateTime PostingDate { get; set; }
    public string? CurrencyIso { get; set; }
    public string? ReferenceDocumentNo { get; set; }
}

public sealed class PaymentItemDto
{
    public string? Customer { get; set; }
    public string? GlAccount { get; set; }
    public string? ProfitCenter { get; set; }
    public decimal Amount { get; set; }
}

public sealed class PaymentResponseDto
{
    public bool IsSuccess { get; set; } // Mapped from E_RESULT (1=true, 0=false)
    public string? Reason { get; set; } // E_REASON
    public string? DocumentNumber { get; set; } // SAP Document Number
}

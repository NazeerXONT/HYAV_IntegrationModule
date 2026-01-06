using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.Application.DTOs;

public sealed class SalesInvoiceRequestDto
{
    public int OrderNo { get; set; }
}

public sealed class SalesInvoiceResponseDto
{
    public int OrderNo { get; set; }
    public DateTime InvoiceDate { get; set; }

    /// O - Open, P - Partial processed, C - Completely processed
    public string? Status { get; set; }

    public decimal TotalInvoiceValue { get; set; }
}

SELECT InvoiceId, Total,
       DATEPART(QUARTER, InvoiceDate) AS Quarter,
       DATEPART(MONTH, InvoiceDate) AS Month,
       DATEPART(YEAR, InvoiceDate) AS Year,
       DATEPART(DAY, InvoiceDate) AS Day
  FROM Invoice;
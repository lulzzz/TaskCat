﻿namespace TaskCat.Lib.Invoice
{
    using System.Threading.Tasks;
    using Data.Entity;
    using Data.Lib.Invoice;

    internal interface IInvoiceService
    {
        Task<TResponse> Generate<TRequest, TResponse>()
            where TRequest : InvoiceRequestBase
            where TResponse : InvoiceBase, IInvoiceFor<TRequest>, new();
    }
}
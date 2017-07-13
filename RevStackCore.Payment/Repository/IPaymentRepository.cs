﻿using RevStackCore.Payment.Model;
using System.Collections.Generic;

namespace RevStackCore.Payment.Repository
{
    public interface IPaymentRepository
    {
        T Charge<T>(ICharge charge) where T : IPayment;
        T Authorize<T>(IAuthorize authorize) where T : IPayment;
        T Capture<T>(ICapture capture) where T : IPayment;
        T Credit<T>(ICredit credit) where T : IPayment;
        T Void<T>(IVoid @void) where T : IPayment;
        T Get<T>() where T : IEnumerable<IPayment>;
        T GetById<T>(ITransactionDetails transactionDetails) where T : IPayment;
    }
}

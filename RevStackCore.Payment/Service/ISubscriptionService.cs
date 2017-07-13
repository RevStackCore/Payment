﻿using RevStackCore.Payment.Model;

namespace RevStackCore.Payment.Service
{
    public interface ISubscriptionService
    {
        T Subscribe<T>(ISubscribe subscribe) where T : ISubscription;
        T Update<T>(IUpdateSubscription subscription) where T : ISubscription;
        T Cancel<T>(ICancelSubscription subscription) where T : ISubscription;
    }
}

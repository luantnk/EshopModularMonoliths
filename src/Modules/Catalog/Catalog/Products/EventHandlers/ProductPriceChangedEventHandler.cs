﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Products.EventHandlers
{
    public class ProductPriceChangedEventHandler(ILogger<ProductPriceChangedEventHandler> logger) : INotificationHandler<ProductPriceChangedEvent>
    {
        public Task Handle(ProductPriceChangedEvent notification, CancellationToken cancellationToken)
        {
            // TODO: publish product price changed intergration event for update basket prices
            logger.LogInformation("Domain Event handled: {DomainEvent}", notification.GetType);
            return Task.CompletedTask;  
        }
    }
}

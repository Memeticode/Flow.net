﻿using Flow.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Flow
{
    public interface IExecutionContext : ILogger
    {
        object this[string name] { get; set; }

        IDictionary<string, object> GetState();

        IExecutionContext New();
        IExecutionContext New(IPayload result);
        IPayload Result { get; }
    }
}

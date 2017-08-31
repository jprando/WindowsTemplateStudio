﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

using Microsoft.Templates.Core.Diagnostics;

namespace Microsoft.Templates.Core.Test.Diagnostics
{
    public sealed class TelemetryFixture : IDisposable
    {
        public TelemetryService Telemetry { get; }

        public TelemetryFixture()
        {
            Telemetry = TelemetryService.Current;
        }

        public void Dispose()
        {
            TelemetryService.Current.Dispose();
        }
    }
}

﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Resource.Fluent;
using Microsoft.Azure.Test.HttpRecorder;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Tests
{
    public class TestDelayProvider : DelayProvider
    {
        public override async Task Delay(int milliseconds, CancellationToken cancellationToken)
        {
            if (HttpMockServer.Mode != HttpRecorderMode.Playback)
            {
                await base.Delay(milliseconds, cancellationToken);
            }
        }
    }
}
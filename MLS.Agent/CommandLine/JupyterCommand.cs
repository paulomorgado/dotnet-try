// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Threading.Tasks;

namespace MLS.Agent.CommandLine
{
    public static class JupyterCommand
    {
        public static Task<int> Do(
            JupyterOptions options,
            IConsole console,
            CommandLineParser.StartServer startServer = null,
            InvocationContext context = null)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            startServer?.Invoke(new StartupOptions(), context);

            return Task.FromResult(0);
        }
    }
}
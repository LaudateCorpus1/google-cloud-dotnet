﻿// Copyright 2018 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Microsoft.Extensions.Logging;
using System;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// <see cref="ILogger"/> for Google Cloud Logging.
    /// </summary>
    [Obsolete("Use Google.Cloud.Diagnostics.Common.GoogleLogger instead.")]
    public sealed class GoogleLogger : ILogger
    {
        private readonly Common.GoogleLogger _logger;

        internal GoogleLogger(Common.GoogleLogger logger) => _logger = GaxPreconditions.CheckNotNull(logger, nameof(logger));

        /// <inheritdoc />
        public IDisposable BeginScope<TState>(TState state) => _logger.BeginScope(state);

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel) => _logger.IsEnabled(logLevel);

        /// <inheritdoc />
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter) =>
            _logger.Log(logLevel, eventId, state, exception, formatter);

        /// <summary>
        /// For diagnostic purposes. Builds and returns the URL where the entries logged by
        /// this <see cref="GoogleLogger"/> can be seen on the Google Cloud Logging Console.
        /// </summary>
        public Uri GetGcpConsoleLogsUrl() => _logger.GetGcpConsoleLogsUrl();
    }
}

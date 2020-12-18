﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Microsoft.Bot.Builder.Runtime.Plugins;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Microsoft.Bot.Builder.Runtime.Tests.Plugins
{
    public class BotPluginLoadContextTests
    {
        [Fact]
        public void Constructor_Succeeds()
        {
            IConfiguration configuration = TestDataGenerator.BuildConfigurationRoot();

            var context = new BotPluginLoadContext(configuration);

            Assert.NotNull(context.Configuration);
            Assert.NotNull(context.Services);
            Assert.Empty(context.Services);
        }

        [Fact]
        public void Constructor_Throws_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(
                "configuration",
                () => new BotPluginLoadContext(configuration: null));
        }
    }
}

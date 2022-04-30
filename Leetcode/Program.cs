// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Leetcode;

class Program
{
    static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices(services => {
                services.AddHostedService<Worker>();
            });
    }
    static async Task Main(string[] args)
    {
        await CreateHostBuilder(args).Build().RunAsync();
    }
}


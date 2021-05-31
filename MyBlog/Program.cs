﻿namespace MyBlog
{
    using System;
    using System.Threading.Tasks;
    using Statiq.App;
    using Statiq.Web;

    public static class Program
    {
        public static async Task<int> Main(string[] args) =>
          await Bootstrapper.Factory
              .CreateWeb(args)
              .RunAsync()
              .ConfigureAwait(true);

    }
}

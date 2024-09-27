﻿using System;

namespace ProgessiveExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger loggerFile = new FileLogger();
            ProductService productService1 = new ProductService(loggerFile);
            productService1.Log("First log entry.");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Spreads.Tests.CSProfile {
    class Program {
        static void Main(string[] args) {
            var srlzr = new SpreadsDBSerializer();
            var sw = new Stopwatch();
            sw.Start();
            decimal d;
            for (int i = 0; i < 10000000; i++) {
                d = srlzr.Deserialize<decimal>(srlzr.Serialize(1.0M));
            }
            sw.Stop();
            Console.WriteLine("Double: " + sw.ElapsedMilliseconds);

            //sw.Restart();
            //DateTime dt = DateTime.Now;
            //for (int i = 0; i < 10000000; i++) {
            //    dt = srlzr.Deserialize<DateTime>(srlzr.Serialize(dt));
            //}
            //sw.Stop();
            //Console.WriteLine("DateTime: " + sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
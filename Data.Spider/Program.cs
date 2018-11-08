using DotnetSpider.Core;
using DotnetSpider.Core.Scheduler;
using Spider.Pipe;
using Spider.Processor;
using System;
using System.Collections.Generic;

namespace Data.Spider
{
    class Program
    {
        static void Main(string[] args)
        {
            AtzucheEntitySpider dDengEntitySpider = new AtzucheEntitySpider();
            dDengEntitySpider.AddPageProcessor(new AtzucheProcessor());//控制器
            dDengEntitySpider.AddPipeline(new AtzuchePipe());//回调
            dDengEntitySpider.ThreadNum = 1;
            dDengEntitySpider.Run();
            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}

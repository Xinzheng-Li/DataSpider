using DotnetSpider.Core;
using DotnetSpider.Core.Pipeline;
using Spider.Entity;
using System;
using System.Collections.Generic;

namespace Spider.Pipe
{
    public class AtzuchePipe : BasePipeline
    {
        public override void Process(IEnumerable<ResultItems> resultItems, ISpider spider)
        {
            var result = new List<AtzucheModel>();
            foreach (var resultItem in resultItems)
            {
                Console.WriteLine((resultItem.Results["AtzucheList"] as List<AtzucheModel>).Count);
                foreach (var item in (resultItem.Results["AtzucheList"] as List<AtzucheModel>))
                {
                    result.Add(new AtzucheModel()
                    {
                        carNo = item.carNo
                    });
                    Console.WriteLine($"{item.carNo}:{item.type} ");
                }
            }
        }
    }
}

using DotnetSpider.Core;
using DotnetSpider.Core.Processor;
using Newtonsoft.Json;
using Spider.Entity;
using System;
using System.Collections.Generic;

namespace Spider.Processor
{
    public class AtzucheProcessor : IPageProcessor
    {
        public void Process(Page page, ISpider spider)
        {
            List<AtzucheModel> list = new List<AtzucheModel>();
            var html = page.Selectable.JsonPath("$.data.content").GetValue();
            list = JsonConvert.DeserializeObject<List<AtzucheModel>>(html);
            page.AddResultItem("AtzucheList", list);
        }
    }
}

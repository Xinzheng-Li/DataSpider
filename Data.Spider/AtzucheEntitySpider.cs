using DotnetSpider.Core;
using DotnetSpider.Extension;
using DotnetSpider.Extension.Pipeline;
using Spider.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Spider
{
    public class AtzucheEntitySpider:EntitySpider
    {
        protected override void MyInit(params string[] arguments)
        {
            AddPipeline(new SqlServerEntityPipeline("Server=.;Database=AuzucheSpider;uid=sa;pwd=123;MultipleActiveResultSets=true"));//注意连接字符串中数据库不能带 .  亲测报错。。。
            AddStartUrl("http://www.atzuche.com/car/searchListMap/2?cityCode=330100&sceneCode=U002&filterCondition%5Blon%5D=120.219294&filterCondition%5Blat%5D=30.259258&filterCondition%5Bseq%5D=4&pageNum=1&pageSize=0");
            AddEntityType<AtzucheModel>();//如添加此实体类，框架将会根据此实体类上面的特性选择进行匹配，匹配成功后插入数据库，固可以省略Processor和Pipe，或者不使用此句，通过控制器和回调自定义存储方法
        }

        public AtzucheEntitySpider() : base("AuzucheSpider", new Site
        {
            CycleRetryTimes = 1,
            SleepTime = 200,
            Headers = new Dictionary<string, string>()
            {
                {"Accept","application/json, text/javascript, */*; q=0.01" },
                {"Accept-Encoding","gzip, deflate" },
                {"gzip, deflate","zh-CN,zh;q=0.9" },
                {"X-Requested-With","XMLHttpRequest" },
                { "Referer", "http://www.atzuche.com/hz/car/search"},
                { "Connection","keep-alive" },
                { "Content-Type","application/json;charset=UTF-8" },
                { "Host","www.atzuche.com"},
                { "User-Agent","Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36"}
            }
        })
        {
        }
    }
}

using DotnetSpider.Core;
using DotnetSpider.Core.Downloader;
using System;
using System.Threading.Tasks;

namespace Spider.Downloader
{
    public class AtzucheDownloader : BaseDownloader
    {
        //protected override Page DowloadContent(Request request, ISpider spider)
        //{
        //    return new HttpClientDownloader().Download(request, spider);
        //}

        //v2.5.0+ version
        protected override Task<Page> DowloadContent(Request request, ISpider spider)
        {
            return new HttpClientDownloader().Download(request, spider);
        }
    }
}

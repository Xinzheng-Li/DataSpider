using System;
using DotnetSpider;
using DotnetSpider.Core.Selector;
using DotnetSpider.Extension.Model;
using DotnetSpider.Extension.Model.Attribute;

namespace Spider.Entity
{
    [EntityTable("CarWinsSpider", "AtzucheCar", EntityTable.Today)]
    [EntitySelector(Expression = "$.data.content[*]", Type = SelectorType.JsonPath)]

    public class AtzucheModel : SpiderEntity
    {
        /// <summary>
        　　/// 车辆编号
        　　/// </summary>
        [PropertyDefine(Expression = "$.carNo", Type = SelectorType.JsonPath)]
        public int carNo { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        //[ReplaceFormatter(NewValue = "", OldValue = "\r")]
        //[ReplaceFormatter(NewValue = "", OldValue = "\t")]
        //[ReplaceFormatter(NewValue = "", OldValue = "&nbsp;")]
        //[ReplaceFormatter(NewValue = "", OldValue = "\n")]
        //[ReplaceFormatter(NewValue = "", OldValue = "\"")]
        //[ReplaceFormatter(NewValue = "", OldValue = " ")]
        [PropertyDefine(Expression = "$.brand", Type = SelectorType.JsonPath)]
        public string brand { get; set; }
        /// <summary>
        　　/// 地址
        　　/// </summary>
        [PropertyDefine(Expression = "$.carAddr", Type = SelectorType.JsonPath)]
        public string carAddr { get; set; }
        /// <summary>
        　　/// 车系
        　　/// </summary>
        [PropertyDefine(Expression = "$.type", Type = SelectorType.JsonPath)]
        public string type { get; set; }
        /// <summary>
        　　/// 排量
        　　/// </summary>
        [PropertyDefine(Expression = "$.sweptVolum", Type = SelectorType.JsonPath)]
        public string sweptVolum { get; set; }
        /// <summary>
        　　/// 图片
        　　/// </summary>
        [PropertyDefine(Expression = "$.coverPic", Type = SelectorType.JsonPath)]
        public string coverPic { get; set; }
        /// <summary>
        　　/// 日租金
        　　/// </summary>
        [PropertyDefine(Expression = "$.dayPrice", Type = SelectorType.JsonPath)]
        public int dayPrice { get; set; }
        /// <summary>
        　　/// 公里数
        　　/// </summary>
        [PropertyDefine(Expression = "$.distance", Type = SelectorType.JsonPath)]
        public string distance { get; set; }
        /// <summary>
        　　/// 评分
        　　/// </summary>
        [PropertyDefine(Expression = "$.evalScore", Type = SelectorType.JsonPath)]
        public string evalScore { get; set; }
        [PropertyDefine(Expression = "$.gbType", Type = SelectorType.JsonPath)]
        public string gbType { get; set; }
        /// <summary>
        　　/// 车牌
        　　/// </summary>
        [PropertyDefine(Expression = "$.plateNum", Type = SelectorType.JsonPath)]
        public string plateNum { get; set; }
        [PropertyDefine(Expression = "$.replyTag", Type = SelectorType.JsonPath)]
        public string replyTag { get; set; }
        [PropertyDefine(Expression = "$.transCount", Type = SelectorType.JsonPath)]
        public string transCount { get; set; }
        /// <summary>
        　　/// 年款
        　　/// </summary>
        [PropertyDefine(Expression = "$.year", Type = SelectorType.JsonPath)]
        public int year { get; set; }
        [PropertyDefine(Expression = "$.isPrivilege", Type = SelectorType.JsonPath)]
        public int isPrivilege { get; set; }
        [PropertyDefine(Expression = "$.isRecommend", Type = SelectorType.JsonPath)]
        public int isRecommend { get; set; }
        [PropertyDefine(Expression = "$.isUpgrade", Type = SelectorType.JsonPath)]
        public int isUpgrade { get; set; }
        [PropertyDefine(Expression = "$.lat", Type = SelectorType.JsonPath)]
        public string lat { get; set; }
        [PropertyDefine(Expression = "$.lon", Type = SelectorType.JsonPath)]
        public string lon { get; set; }
        [PropertyDefine(Expression = "$.queryId", Type = SelectorType.JsonPath)]
        public string queryId { get; set; }
        [PropertyDefine(Expression = "$.supplyCarService", Type = SelectorType.JsonPath)]
        public int supplyCarService { get; set; }
        [PropertyDefine(Expression = "$.freeCarService", Type = SelectorType.JsonPath)]
        public int freeCarService { get; set; }
        [PropertyDefine(Expression = "$.isShenMaCar", Type = SelectorType.JsonPath)]
        public int isShenMaCar { get; set; }
        [PropertyDefine(Expression = "$.supportGetReturn", Type = SelectorType.JsonPath)]
        public int supportGetReturn { get; set; }
        [PropertyDefine(Expression = "$.confirmation", Type = SelectorType.JsonPath)]
        public int confirmation { get; set; }
    }
}

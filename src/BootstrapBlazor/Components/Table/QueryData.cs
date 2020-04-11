﻿using System.Collections.Generic;

namespace BootstrapBlazor.Components
{
    /// <summary>
    /// 表格查询数据类
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public class QueryData<TItem> where TItem : class, new()
    {
        /// <summary>
        /// 获得/设置 要显示页码的数据集合
        /// </summary>
        public IEnumerable<TItem> Items { get; set; } = new TItem[0];

        /// <summary>
        /// 获得/设置 数据集合总数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 获得/设置 当前页码
        /// </summary>
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 获得/设置 每页显示数据数量
        /// </summary>
        public int PageItems { get; set; } = QueryPageOptions.DefaultPageItems;
    }
}

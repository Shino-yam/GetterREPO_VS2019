using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterREPO
{
    /// <summary>
    /// RSSのitemプロパティ
    /// </summary>
    class RssItem
    {
        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 詳細
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// リンクurl
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 発行日
        /// </summary>
        public string PubDate { get; set; }

        /// <summary>
        /// 発行日(日本語)
        /// </summary>
        public string PubDateJp { get; set; }
    }
}

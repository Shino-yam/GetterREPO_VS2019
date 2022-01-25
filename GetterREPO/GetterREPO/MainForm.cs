using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GetterREPO
{
    /// <summary>
    /// メインフォームクラス
    /// </summary>
    public partial class MainForm : Form
    {
        // RSS item を保持するリスト
        List<RssItem> rssItemInfos = new List<RssItem>();

        // メニュー展開フラグ
        Boolean isMenuOpen = false;


        /// <summary>
        /// 起動時に呼び出す関数
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // TODO: webView にマウスホイールイベントを追加したい
            //webViewNews.MouseWheel += new MouseEventHandler(webViewNews_MouseWheel);
            this.MouseWheel += new MouseEventHandler(webViewNews_MouseWheel);

            // 設定パネルを引っ込めておく
            panelMenu.Location = new System.Drawing.Point(-450, 0);
            
            // 初回準備完了チェック
            FirstCheck ck = new FirstCheck();
            bool isReady = ck.isReady;
            if (!isReady)
            {
                // 初回準備ができていないので、設定フォームを表示する
                FirstSettingForm firstForm = new FirstSettingForm();
                firstForm.ShowDialog();
                // 初期設定フォームの戻り値を評価
                if (!firstForm.isCompleteFirstSetting)
                {
                    // プログラムを終了する
                    this.Close();
                    Application.Exit();
                }
                else
                {
                    this.Focus();
                }
            }

            // ローカルDBからユーザ情報の取得を試みる
            if (!ck.GetUserData())
            {
                MessageBox.Show(CommonVariables.MSSG_USERDATA_WRONG, "ユーザ情報の確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                // TODO: 設定変更を依頼する


            }

            textBoxNickname.Text = CommonVariables.NickName;
            textBoxNewsSavePath.Text = CommonVariables.UsePath;

            // Feed をサーバから取得
            this.getFeedFromServer();

        }

        private MouseEventHandler webViewNews_MouseWheel(object v, object sender, MouseEventArgs mouseEventArgs, object e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Feedデータのダウンロード
        /// </summary>
        private void getFeedFromServer()
        {
            // サーバからの取得
            ServerConnector sv = new ServerConnector();
            List<string[]> feeds = new List<string[]> { };  
            feeds = sv.GetRss();


            // TODO: 取得したFeed情報をローカルDBに保存する


            // List の上限を設定
            rssItemInfos.Capacity = 5000;

            //
            foreach (string[] row in feeds)
            {
                int itesCount = rssItemInfos.Count;
                this.getRssList(row[0]);
            }
            // リストボックスに一覧を表示
            foreach (RssItem item in rssItemInfos)
            {
                listBoxFeed.Items.Add($"{item.Title}");
            }
        }

        /// <summary>
        /// RSS一覧を取得し、リストボックスに表示
        /// RSS1.0, RSS2.0 で処理を分岐させている
        /// </summary>
        /// <param name="rssUrl">RSSのurl</param>
        private void getRssList(string rssUrl)
        {
            // RSS(xml)パース
            try
            {
                if (rssUrl.Length <= 0)
                {
                    // 引き渡されたurlが空白の時は、以降の処理を行わない
                    return;
                }

                string rss = rssUrl;
                using (WebClient wc = new WebClient())
                {
                    // いったん、対象のurlのコンテンツを文字列として読み込む
                    // 文字列中のxmlを抽出し、パーサに渡す
                    // (xmlがhtml内に入っている場合があるため：CodeZine など)
                    wc.Encoding = System.Text.Encoding.UTF8;
                    string contents = wc.DownloadString(rss);

                    if (contents.Contains("http://purl.org/rss/1.0/"))
                    {
                        // RSS 1.0

                        XmlDocument xd = new XmlDocument();
                        xd.LoadXml(contents);
                        var nsmgr = new XmlNamespaceManager(xd.NameTable);
                        nsmgr.AddNamespace("rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#");
                        nsmgr.AddNamespace("rss", "http://purl.org/rss/1.0/");
                        nsmgr.AddNamespace("dc", "http://purl.org/dc/elements/1.1/");
                        foreach (XmlElement node in xd.SelectNodes("/rdf:RDF/rss:item", nsmgr))
                        {
                            RssItem itemInfo = new RssItem();

                            itemInfo.Title = node.SelectNodes("rss:title", nsmgr)[0].InnerText;
                            itemInfo.Link = node.SelectNodes("rss:link", nsmgr)[0].InnerText;
                            itemInfo.Description = node.SelectNodes("rss:description", nsmgr)[0].InnerText;
                            DateTime dt = Convert.ToDateTime(DateTime.Parse(node.SelectNodes("dc:date", nsmgr)[0].InnerText));
                            itemInfo.PubDate = $"{dt.Year.ToString("0000")}-{dt.Month.ToString("00")}-{dt.Day.ToString("00")}T{dt.Hour.ToString("00")}:{dt.Minute.ToString("00")}:{dt.Second.ToString("00")}.{dt.Millisecond.ToString("000")}Z";
                            itemInfo.PubDateJp = $"{dt.Year}年{dt.Month}月{dt.Day}日{dt.Hour.ToString("00")}時{dt.Minute.ToString("00")}分";
                        }

                        // リストボックスに一覧を表示
                        foreach (RssItem item in rssItemInfos)
                        {
                            listBoxFeed.Items.Add($"{item.Title}");
                        }
                    }
                    else if (contents.Contains("rss version=\"2.0\""))
                    {
                        // RSS 2.0


                        Match mc = Regex.Match(contents, @"<rss\s(.|\n)*?</rss>");
                        XElement element = XElement.Parse(mc.Value);

                        // channelを取得する
                        XElement channelElement = element.Element("channel");

                        string title = channelElement.Element("title").Value;
                        string description = channelElement.Element("description").Value;
                        string Link = channelElement.Element("link").Value;
                        string pubdate = channelElement.Element("pubDate").Value;

                        // itemを取得する
                        IEnumerable<XElement> elementItems = channelElement.Elements("item");

                        foreach (XElement elmItem in elementItems)
                        {
                            // エラー検出フラグ
                            bool isError = false;
                            RssItem itemInfo = new RssItem();
                            if (elmItem.Element("title") == null)
                            {
                                itemInfo.Title = null;
                            }
                            else
                            {
                                if (elmItem.Element("title").Value.Length <= 200)
                                {
                                    itemInfo.Title = elmItem.Element("title").Value;
                                }
                                else
                                {
                                    isError = true;
                                }
                            }

                            if (elmItem.Element("link") == null)
                            {
                                itemInfo.Link = null;
                            }
                            else
                            {
                                if (elmItem.Element("link").Value.Length <= 300)
                                {
                                    itemInfo.Link = elmItem.Element("link").Value;
                                }
                                else
                                {
                                    isError = true;
                                }
                            }

                            if (elmItem.Element("description") == null)
                            {
                                itemInfo.Description = null;
                            }
                            else
                            {
                                itemInfo.Description = elmItem.Element("description").Value;
                            }

                            if (elmItem.Element("pubDate") == null)
                            {
                                itemInfo.PubDate = null;
                            }
                            else
                            {
                                DateTime dt = Convert.ToDateTime(elmItem.Element("pubDate").Value);
                                itemInfo.PubDate = $"{dt.Year.ToString("0000")}-{dt.Month.ToString("00")}-{dt.Day.ToString("00")}T{dt.Hour.ToString("00")}:{dt.Minute.ToString("00")}:{dt.Second.ToString("00")}.{dt.Millisecond.ToString("000")}Z";
                                itemInfo.PubDateJp = $"{dt.Year}年{dt.Month}月{dt.Day}日{dt.Hour.ToString("00")}時{dt.Minute.ToString("00")}分";
                            }

                            // エラー検出がなければリストに加える
                            if (!isError)
                            {
                                rssItemInfos.Add(itemInfo);
                                isError = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }
        
        /// <summary>
        /// 検索，保存機能の有効化と無効化
        /// </summary>
        /// <param name="state">true: 有効化，false: 無効化</param>
        private void SetStateOfSearchAndSave(bool state)
        {
            textBoxSearch.Enabled = state;
            buttonSave.Enabled = state;
            buttonSearch.Enabled = state;
            return;
        }

        /// <summary>
        /// ニュース保存ボタンクリックイベント【未実装】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TODO: ニュース保存処理の実装

            MessageBox.Show(CommonVariables.MSSG_UNDER_CONSTRUCTION, "未実装イベント", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 検索ボタンクリックイベント【未実装】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // TODO: 検索処理の実装

            MessageBox.Show(CommonVariables.MSSG_UNDER_CONSTRUCTION, "未実装イベント", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    
        /// <summary>
        /// リストボックスクリック時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxFeed_Click(Object sender, EventArgs e)
        {
            // リストの何番目をクリックしたかを取得
            int selectedIndex = listBoxFeed.SelectedIndex;

            // Webブラウザにフォーカスを移す
            webViewNews.Focus();

            // 該当のニュースを表示
            textBoxDescription.Text = $"[{rssItemInfos[selectedIndex].PubDateJp}] {rssItemInfos[selectedIndex].Title}\r\n{rssItemInfos[selectedIndex].Description}\r\n{rssItemInfos[selectedIndex].Link}";
            webViewNews.Source = new Uri(rssItemInfos[selectedIndex].Link);

        }

        /// <summary>
        /// メニュー展開ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenu_Click(Object sender, EventArgs e)
        {
            if (this.isMenuOpen)
            {
                // 現在メニューが開いている → 閉じる
                for (int i = 7; i >= -457; i -= 10)
                {
                    panelMenu.Location = new System.Drawing.Point(i, 5);
                }
                buttonMenu.Text = "👉";
                this.isMenuOpen = false;
                this.SetStateOfSearchAndSave(true);
            }
            else
            {
                // 現在メニューが閉じている → 開く
                for (int i = -457; i < 7; i += 50)
                {
                    panelMenu.Location = new System.Drawing.Point(i, 5);
                }
                buttonMenu.Text = "👈";
                this.isMenuOpen = true;
                this.SetStateOfSearchAndSave(false);
            }
        }

        /// <summary>
        /// ニックネーム変更中止ボタンクリックイベント【未実装】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNicknameChnageCancel_Click(object sender, EventArgs e)
        {
            // TODO: ニックネーム変更中止処理の実装

            MessageBox.Show(CommonVariables.MSSG_UNDER_CONSTRUCTION, "未実装イベント", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// ニュース保存パス変更ボタンクリックイベント【未実装】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectNewsSavePath_Click(object sender, EventArgs e)
        {
            // TODO: ニュース保存パス変更処理の実装

            MessageBox.Show(CommonVariables.MSSG_UNDER_CONSTRUCTION, "未実装イベント", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// ニュース保存パス変更中止ボタンクリックイベント【未実装】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectNewsSavePathCancel_Click(object sender, EventArgs e)
        {
            // TODO: ニュース保存パス変更中止処理の実装

            MessageBox.Show(CommonVariables.MSSG_UNDER_CONSTRUCTION, "未実装イベント", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 変更を反映ボタンクリックイベント【未実装】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            // TODO: 変更を反映処理の実装

            MessageBox.Show(CommonVariables.MSSG_UNDER_CONSTRUCTION, "未実装イベント", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 中止(元に戻す)ボタンクリックイベント【未実装】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // TODO: 中止(元に戻す)処理の実装

            MessageBox.Show(CommonVariables.MSSG_UNDER_CONSTRUCTION, "未実装イベント", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// webView内でのマウスホイールイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webViewNews_MouseWheel(Object sender, MouseEventArgs e)
        {
            int delta = e.Delta;

            // TODO: 本来はwebViewのスクロールを、マウスホイールで行えるようにしたかった

        }

        /// <summary>
        /// webViewにfocusされた際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webViewNews_Enter(object sender, EventArgs e)
        {
            // NOP
        }
        


    }
}

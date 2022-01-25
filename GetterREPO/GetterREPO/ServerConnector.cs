using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace GetterREPO
{
    /// <summary>
    /// サーバとのやり取りを行うクラス
    /// </summary>
    class ServerConnector
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ServerConnector()
        {
            // NOP
        }

        /// <summary>
        /// ニックネームの設定を試みる
        /// </summary>
        /// <param name="nickName">ニックネーム</param>
        /// <returns>結果</returns>
        public string SetNickName(string nickName)
        {

            Encoding encode = Encoding.GetEncoding("UTF-8");
            string postStr = $"nickname={HttpUtility.UrlEncode(nickName, encode)}";
            byte[] postBytes = Encoding.ASCII.GetBytes(postStr);

            WebRequest request = WebRequest.Create($"{CommonVariables.SERVER_URL}{CommonVariables.SET_NICKNAME}");
            request.Method = "POST";
            request.ContentLength = postBytes.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            Stream reqStream = request.GetRequestStream();
            // 送信する
            reqStream.Write(postBytes, 0, postBytes.Length);
            reqStream.Close();
            // 受信する
            WebResponse response = request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(resStream, encode);
            string result = reader.ReadToEnd();
            reader.Close();

            return result;
        }

        /// <summary>
        /// Feedの取得
        /// </summary>
        /// <returns>Feedのリスト(CSV形式)</returns>
        public List<string[]> GetRss()
        {
            Encoding encode = Encoding.GetEncoding("UTF-8");
            WebRequest request = WebRequest.Create($"{CommonVariables.SERVER_URL}{CommonVariables.GET_FEED}");
            WebResponse response = request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(resStream, encode);
            string result = reader.ReadToEnd().Replace("\"", "");
            reader.Close();

            List<string[]> ret = new List<string[]> { };
            foreach (string row in result.Split('\n'))
            {
                ret.Add(row.Split(','));
            }

            return ret;
        }








    }
}

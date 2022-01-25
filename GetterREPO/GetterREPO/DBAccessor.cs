using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace GetterREPO
{
    /// <summary>
    /// DB(SQLite) を操作するクラス
    /// </summary>
    class DBAccessor
    {
        // DB操作コネクション
        private SQLiteConnection con = null;
        // DB操作インスタンス
        private SQLiteCommand cmd = null;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DBAccessor()
        {
            string dbFilePath = $@"{CommonVariables.UsePath}\{CommonVariables.DB_FILE_NAME}";
            // ファイルが存在しないときは作成する
            bool isFIrstTime = false;
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
                isFIrstTime = true;
            }
            // DBファイルを開く
            this.con = new SQLiteConnection($"Data Source ={dbFilePath}");
            this.con.Open();
            this.cmd = this.con.CreateCommand();
            // 初回はテーブルを作成する
            if (isFIrstTime)
            {
                MakeTables();
            }
        }

        /// <summary>
        /// テーブルを作成する(初回のみ)
        /// </summary>
        private void MakeTables()
        {
            try
            {
                string sql = "CREATE TABLE user (usernumber varchar(20), nickname varchar(20));";
                sql += "CREATE TABLE feed (url varchar(2000), datetime varchar(14));";
                sql += "CREATE TABLE news (url varchar(2000), getdatetime datetime, body text, filepath varchar(260), memo varchar(1000));";
                sql += "CREATE TABLE temp (link varchar(2000), title varchar(1000), pubdate datetime);";
                this.cmd.CommandText = sql;
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // TODO: エラーログに記録
            }
            finally
            {
                // NOP (後のユーザ情報登録でDBを閉じる)
            }
        }

        /// <summary>
        /// 問い合わせ(結果の帰ってくるもの)
        /// </summary>
        /// <param name="sql">SQL文字列</param>
        /// <returns>問い合わせ結果List</returns>
        public List<Object[]> ExecuteQuery(string sql)
        {
            // 問い合わせ結果格納変数
            List<Object[]> ret = new List<object[]> { };
            try
            {
                this.cmd.CommandText = sql;
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        object[] data = Enumerable.Range(0, reader.FieldCount).Select(i => reader[i]).ToArray();
                        ret.Add(data);
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: エラーログに記録
            }
            return ret;
        }

        /// <summary>
        /// 問い合わせ(結果の無いもの)
        /// </summary>
        /// <param name="">SQL文字列</param>
        /// <returns>true: 成功 , false: 失敗</returns>
        public bool ExecuteNonQuery(string sql)
        {
            bool isSuccess = false;
            try
            {
                this.cmd.CommandText = sql;
                this.cmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                // TODO: エラーログに記録
            }
            return isSuccess;
        }

        /// <summary>
        /// ユーザ情報の登録
        /// </summary>
        /// <param name="userNumber">ユーザNo.</param>
        /// <param name="nickName">ニックネーム</param>
        /// <returns>true: 成功 , false: 失敗</returns>
        public bool RegistUser(string userNumber, string nickName)
        {
            bool isSuccess = false;
            try
            {
                this.cmd.CommandType = System.Data.CommandType.Text;
                this.cmd.CommandText = "INSERT INTO user (usernumber, nickname) VALUES (@USERNUMBER, @NICKNAME);";
                this.cmd.Parameters.Add(new SQLiteParameter("@USERNUMBER", CommonVariables.UserNumber));
                this.cmd.Parameters.Add(new SQLiteParameter("@NICKNAME", CommonVariables.NickName));
                this.cmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                // TODO: エラーログに記録
            }
            finally
            {
                this.DbClose();
            }
            return isSuccess;
        }

        /// <summary>
        /// ニュースの保存【未実装】
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="datetime">ニュースの年月日時刻</param>
        /// <param name="body">ニュース本文</param>
        /// <returns></returns>
        public bool SaveNews(string url, string datetime, string body)
        {
            // TODO: ニュースをdbに保存する

            return true;
        }



        /// <summary>
        /// DB接続をCloseする
        /// </summary>
        public void DbClose()
        {
            con.Close();
        }
    }
}

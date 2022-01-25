using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace GetterREPO
{
    /// <summary>
    /// 初回チェックの処理クラス
    /// </summary>
    public class FirstCheck
    {
        // 利用準備ができているかのフラグ
        public bool isReady { get; set; } = false;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FirstCheck()
        {
            // exeファイルと同階層に設定ファイルが存在するか
            // 存在すれば、内容が書かれているか
            string result = "";
            if (File.Exists(CommonVariables.SettingFilePath))
            {
                using (var sr = new StreamReader(CommonVariables.SettingFilePath))
                {
                    result = sr.ReadLine();
                }
            }
            if (result == null)
            {
                // ファイルは存在するが、中身がない
                this.isReady = false;
            }
            else if (result.Length > 0)
            {
                // ファイルが存在し、中身がある
                this.isReady = true;
                CommonVariables.UsePath = result;
            }
            else
            {
                // 上記以外
                this.isReady = false;
            }
        }

        /// <summary>
        /// ローカルDBからユーザ情報を取得
        /// </summary>
        /// <returns>rue:取得できた false:取得に失敗した</returns>
        public bool GetUserData()
        {
            // ローカルDBからユーザ情報を取得
            DBAccessor db = new DBAccessor();
            List<Object[]> userData = db.ExecuteQuery("SELECT usernumber, nickname FROM user LIMIT 1");
            bool retValue = false;
            if (userData.Count == 1)
            {
                CommonVariables.UserNumber = (string)userData[0][0];
                CommonVariables.NickName = (string)userData[0][1];
                retValue = true;
            }
            else
            {
                // NOP
            }
            db.DbClose();
            return retValue;
        }



    }
}

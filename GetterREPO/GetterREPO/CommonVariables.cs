using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterREPO
{
    /// <summary>
    /// 共通変数のクラス
    /// </summary>
    public class CommonVariables
    {
        //
        // 定数
        //
        // サーバーurl
        public const string SERVER_URL = @"https://fromkyo.tokyo/";
        public const string SET_NICKNAME = @"registNickName.php";
        public const string GET_FEED = @"getFeed.php";
        // 設定ファイル名
        public const string SETTING_FILE_NAME = @"GetterREPO.setting";
        // SQLite のデータベースファイル名
        public const string DB_FILE_NAME = @"grdb.db";
        // メッセージ
        public const string MSSG_FIRSTSETTING_CANCEL = "設定が完了していませんがよろしいですか？(プログラムを終了します)";
        public const string MSSG_NICKNAME_EMPTY = "ニックネームが未入力です";
        public const string MSSG_NICKNAME_ALREADYTEXIST = "入力したニックネームは使用できません";
        public const string MSSG_ACCEPT = "初期設定を確定します。よろしいですか？";
        public const string MSSG_USERDATA_REGISTFAIL = "ユーザ情報の登録に失敗しました";
        public const string MSSG_USERDATA_WRONG = "ローカルDBに設定されているユーザ情報が不正です";

        public const string MSSG_UNDER_CONSTRUCTION = "未実装です";




        //
        // 変数
        //
        // exeファイルのあるパス
        public static string ExePath { get; set; } = null;
        // 設定ファイルのあるパス
        public static string SettingFilePath { get; set; } = null;
        // ユーザーNo.
        public static string UserNumber { get; set; } = null;
        // ニックネーム
        public static string NickName { get; set; } = null;
        // 使用するパス
        public static string UsePath { get; set; } = null;
        




    }
}

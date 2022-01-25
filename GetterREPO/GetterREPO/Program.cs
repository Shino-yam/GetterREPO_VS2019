using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetterREPO
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // exeファイルのあるパスを取得 → 設定ファイル名を取得
            CommonVariables.ExePath = Environment.CurrentDirectory;
            CommonVariables.SettingFilePath = $@"{CommonVariables.ExePath}\{CommonVariables.SETTING_FILE_NAME}";
            // もともとあったコード
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

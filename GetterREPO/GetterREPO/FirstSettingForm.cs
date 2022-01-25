using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace GetterREPO
{
    /// <summary>
    /// 初期設定フォームクラス
    /// </summary>
    public partial class FirstSettingForm : Form
    {

        // 初期設定完了フラグ
        public bool isCompleteFirstSetting { get; set; } = false;
        // ニックネーム設定完了フラグ
        private bool isCompleteSetNickName { get; set; } = false;
        // ファイル保存パス設定完了フラグ
        private bool isCompleteSetFilePath { get; set; }  = false;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FirstSettingForm()
        {
            InitializeComponent();

            // 設定完了フラグを false にする
            this.isCompleteFirstSetting = false;
            this.isCompleteSetNickName = false;
            this.isCompleteSetFilePath = false;
            // 決定ボタンを非活性化する
            buttonAccept.Enabled = false;
            // ファイルパス選択を非活性化する
            groupBoxFilePath.Enabled = false;
            // ニックネーム入力テキストボックスにフォーカス
            textBoxNickName.Focus();
        }

        /// <summary>
        /// ニックネーム決定ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAcceptNickName_Click(object sender, EventArgs e)
        {
            string nickName = textBoxNickName.Text;
            if (nickName.Length <= 0)
            {
                MessageBox.Show(CommonVariables.MSSG_NICKNAME_EMPTY, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.isCompleteSetNickName = false;
                groupBoxFilePath.Enabled = false;
                textBoxNickName.Focus();
                return;
            }

            ServerConnector sv = new ServerConnector();
            string response = sv.SetNickName(nickName);

            if (response.Contains("Err"))
            {
                string errorCode = response.Split(':')[0];
                string errorMessage = "";
                switch (errorCode)
                {
                    case "Err0000":
                        errorMessage = CommonVariables.MSSG_NICKNAME_EMPTY;
                        break;
                    case "Err1000":
                        errorMessage = CommonVariables.MSSG_NICKNAME_ALREADYTEXIST;
                        break;
                    default:
                        // NOP
                        break;
                }
                if (errorMessage.Length > 0)
                {
                    MessageBox.Show(errorMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.isCompleteSetNickName = false;
                    groupBoxFilePath.Enabled = false;
                    textBoxNickName.Focus();
                }
            }
            else if (response.Contains("OK"))
            {
                CommonVariables.UserNumber = response.Split('#')[1];
                CommonVariables.NickName = nickName;
                this.isCompleteSetNickName = true;
                groupBoxNickName.Enabled = false;
                this.isCompleteSetNickName = true;
                groupBoxFilePath.Enabled = true;
                buttonSelectFilePath.Focus();
            }
        }

        /// <summary>
        /// ファイルパス選択ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectFilePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    textBoxFilePath.Text = fbd.SelectedPath;
                    CommonVariables.UsePath = fbd.SelectedPath;
                    this.isCompleteSetFilePath = true;
                    buttonAccept.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 決定ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(CommonVariables.MSSG_ACCEPT, "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                // 初期設定の処理
                using (var sw = new StreamWriter(CommonVariables.SettingFilePath))
                {
                    sw.WriteLine(textBoxFilePath.Text);
                }
                // DBの準備
                DBAccessor db = new DBAccessor();
                if (!db.RegistUser(CommonVariables.UserNumber, CommonVariables.NickName))
                {
                    MessageBox.Show(CommonVariables.MSSG_USERDATA_REGISTFAIL, "報告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // 再登録処理
                    this.isCompleteFirstSetting = false;
                    this.isCompleteSetNickName = false;
                    buttonAccept.Enabled = false;
                    groupBoxNickName.Enabled = true;
                    textBoxNickName.Focus();
                }
                this.Close();
            }
            else
            {
                this.isCompleteSetFilePath = false;
                buttonSelectFilePath.Focus();
            }
        }

        /// <summary>
        /// キャンセルボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // フォームを閉じるイベントに処理を任せる
            this.Close();
        }

        /// <summary>
        /// 「閉じる」ボタン押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool isComplete = this.isCompleteSetNickName && this.isCompleteSetFilePath;

            if (!isComplete)
            {
                DialogResult result = MessageBox.Show(CommonVariables.MSSG_FIRSTSETTING_CANCEL, 
                    "確認",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.OK)
                {
                    // 終了しても良い
                    this.isCompleteFirstSetting = false;
                }
                else
                {
                    // イベントキャンセル
                    e.Cancel = true;
                }
            }
            else
            {
                this.isCompleteFirstSetting = true;
            }
        }
    }
}

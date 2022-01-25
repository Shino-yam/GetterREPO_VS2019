
namespace GetterREPO
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.webViewNews = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            this.listBoxFeed = new System.Windows.Forms.ListBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.groupBoxNicknameChange = new System.Windows.Forms.GroupBox();
            this.buttonNicknameChnageCancel = new System.Windows.Forms.Button();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.groupBoxSavePathChange = new System.Windows.Forms.GroupBox();
            this.buttonSelectNewsSavePathCancel = new System.Windows.Forms.Button();
            this.textBoxNewsSavePath = new System.Windows.Forms.TextBox();
            this.buttonSelectNewsSavePath = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewNews)).BeginInit();
            this.groupBoxNicknameChange.SuspendLayout();
            this.groupBoxSavePathChange.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSearch.Location = new System.Drawing.Point(51, 5);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(965, 31);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSearch.Location = new System.Drawing.Point(1020, 5);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(122, 31);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "ニュース検索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // webViewNews
            // 
            this.webViewNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webViewNews.Location = new System.Drawing.Point(263, 197);
            this.webViewNews.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.webViewNews.MinimumSize = new System.Drawing.Size(9, 10);
            this.webViewNews.Name = "webViewNews";
            this.webViewNews.Size = new System.Drawing.Size(1015, 511);
            this.webViewNews.TabIndex = 4;
            this.webViewNews.Enter += new System.EventHandler(this.webViewNews_Enter);
            // 
            // listBoxFeed
            // 
            this.listBoxFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFeed.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxFeed.FormattingEnabled = true;
            this.listBoxFeed.HorizontalScrollbar = true;
            this.listBoxFeed.ItemHeight = 20;
            this.listBoxFeed.Location = new System.Drawing.Point(51, 56);
            this.listBoxFeed.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.listBoxFeed.Name = "listBoxFeed";
            this.listBoxFeed.Size = new System.Drawing.Size(210, 644);
            this.listBoxFeed.TabIndex = 5;
            this.listBoxFeed.Click += new System.EventHandler(this.listBoxFeed_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDescription.Location = new System.Drawing.Point(265, 38);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(74, 20);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "記事の概要";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDescription.Location = new System.Drawing.Point(267, 61);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(1011, 131);
            this.textBoxDescription.TabIndex = 7;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonMenu.Location = new System.Drawing.Point(455, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(45, 184);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.Text = "👉";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // groupBoxNicknameChange
            // 
            this.groupBoxNicknameChange.Controls.Add(this.buttonNicknameChnageCancel);
            this.groupBoxNicknameChange.Controls.Add(this.textBoxNickname);
            this.groupBoxNicknameChange.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxNicknameChange.Location = new System.Drawing.Point(5, 7);
            this.groupBoxNicknameChange.Name = "groupBoxNicknameChange";
            this.groupBoxNicknameChange.Size = new System.Drawing.Size(441, 116);
            this.groupBoxNicknameChange.TabIndex = 5;
            this.groupBoxNicknameChange.TabStop = false;
            this.groupBoxNicknameChange.Text = "ニックネームの変更";
            // 
            // buttonNicknameChnageCancel
            // 
            this.buttonNicknameChnageCancel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNicknameChnageCancel.Location = new System.Drawing.Point(225, 63);
            this.buttonNicknameChnageCancel.Name = "buttonNicknameChnageCancel";
            this.buttonNicknameChnageCancel.Size = new System.Drawing.Size(210, 40);
            this.buttonNicknameChnageCancel.TabIndex = 2;
            this.buttonNicknameChnageCancel.Text = "中止(もとに戻す)";
            this.buttonNicknameChnageCancel.UseVisualStyleBackColor = true;
            this.buttonNicknameChnageCancel.Click += new System.EventHandler(this.buttonNicknameChnageCancel_Click);
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNickname.Location = new System.Drawing.Point(6, 26);
            this.textBoxNickname.MaxLength = 20;
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(429, 31);
            this.textBoxNickname.TabIndex = 0;
            // 
            // groupBoxSavePathChange
            // 
            this.groupBoxSavePathChange.Controls.Add(this.buttonSelectNewsSavePathCancel);
            this.groupBoxSavePathChange.Controls.Add(this.textBoxNewsSavePath);
            this.groupBoxSavePathChange.Controls.Add(this.buttonSelectNewsSavePath);
            this.groupBoxSavePathChange.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxSavePathChange.Location = new System.Drawing.Point(5, 129);
            this.groupBoxSavePathChange.Name = "groupBoxSavePathChange";
            this.groupBoxSavePathChange.Size = new System.Drawing.Size(441, 116);
            this.groupBoxSavePathChange.TabIndex = 6;
            this.groupBoxSavePathChange.TabStop = false;
            this.groupBoxSavePathChange.Text = "ニュース保存パスの変更";
            // 
            // buttonSelectNewsSavePathCancel
            // 
            this.buttonSelectNewsSavePathCancel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSelectNewsSavePathCancel.Location = new System.Drawing.Point(225, 63);
            this.buttonSelectNewsSavePathCancel.Name = "buttonSelectNewsSavePathCancel";
            this.buttonSelectNewsSavePathCancel.Size = new System.Drawing.Size(210, 40);
            this.buttonSelectNewsSavePathCancel.TabIndex = 2;
            this.buttonSelectNewsSavePathCancel.Text = "中止(もとに戻す)";
            this.buttonSelectNewsSavePathCancel.UseVisualStyleBackColor = true;
            this.buttonSelectNewsSavePathCancel.Click += new System.EventHandler(this.buttonSelectNewsSavePathCancel_Click);
            // 
            // textBoxNewsSavePath
            // 
            this.textBoxNewsSavePath.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNewsSavePath.Location = new System.Drawing.Point(6, 26);
            this.textBoxNewsSavePath.Name = "textBoxNewsSavePath";
            this.textBoxNewsSavePath.Size = new System.Drawing.Size(429, 31);
            this.textBoxNewsSavePath.TabIndex = 0;
            // 
            // buttonSelectNewsSavePath
            // 
            this.buttonSelectNewsSavePath.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSelectNewsSavePath.Location = new System.Drawing.Point(6, 63);
            this.buttonSelectNewsSavePath.Name = "buttonSelectNewsSavePath";
            this.buttonSelectNewsSavePath.Size = new System.Drawing.Size(210, 40);
            this.buttonSelectNewsSavePath.TabIndex = 1;
            this.buttonSelectNewsSavePath.Text = "ニュース保存パスの変更";
            this.buttonSelectNewsSavePath.UseVisualStyleBackColor = true;
            this.buttonSelectNewsSavePath.Click += new System.EventHandler(this.buttonSelectNewsSavePath_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAccept.Location = new System.Drawing.Point(11, 654);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(210, 40);
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "変更を反映";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCancel.Location = new System.Drawing.Point(230, 654);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(210, 40);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "中止(もとに戻す)";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.Controls.Add(this.buttonCancel);
            this.panelMenu.Controls.Add(this.buttonAccept);
            this.panelMenu.Controls.Add(this.groupBoxSavePathChange);
            this.panelMenu.Controls.Add(this.groupBoxNicknameChange);
            this.panelMenu.Controls.Add(this.buttonMenu);
            this.panelMenu.Location = new System.Drawing.Point(7, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(500, 703);
            this.panelMenu.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSave.Location = new System.Drawing.Point(1156, 5);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 31);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "ニュース保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.listBoxFeed);
            this.Controls.Add(this.webViewNews);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "MainForm";
            this.Text = "GetterREPO - ニュース収集アプリケーション";
            ((System.ComponentModel.ISupportInitialize)(this.webViewNews)).EndInit();
            this.groupBoxNicknameChange.ResumeLayout(false);
            this.groupBoxNicknameChange.PerformLayout();
            this.groupBoxSavePathChange.ResumeLayout(false);
            this.groupBoxSavePathChange.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView webViewNews;
        private System.Windows.Forms.ListBox listBoxFeed;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.GroupBox groupBoxNicknameChange;
        private System.Windows.Forms.Button buttonNicknameChnageCancel;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.GroupBox groupBoxSavePathChange;
        private System.Windows.Forms.Button buttonSelectNewsSavePathCancel;
        private System.Windows.Forms.TextBox textBoxNewsSavePath;
        private System.Windows.Forms.Button buttonSelectNewsSavePath;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonSave;
    }
}


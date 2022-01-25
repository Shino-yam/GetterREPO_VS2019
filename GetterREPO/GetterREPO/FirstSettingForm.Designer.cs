
namespace GetterREPO
{
    partial class FirstSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDescription = new System.Windows.Forms.Label();
            this.groupBoxNickName = new System.Windows.Forms.GroupBox();
            this.buttonAcceptNickName = new System.Windows.Forms.Button();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.groupBoxFilePath = new System.Windows.Forms.GroupBox();
            this.buttonSelectFilePath = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxNickName.SuspendLayout();
            this.groupBoxFilePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDescription.Location = new System.Drawing.Point(26, 18);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(692, 48);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "GetterREPO の利用のための設定を行います。";
            // 
            // groupBoxNickName
            // 
            this.groupBoxNickName.Controls.Add(this.buttonAcceptNickName);
            this.groupBoxNickName.Controls.Add(this.textBoxNickName);
            this.groupBoxNickName.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxNickName.Location = new System.Drawing.Point(35, 90);
            this.groupBoxNickName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxNickName.Name = "groupBoxNickName";
            this.groupBoxNickName.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxNickName.Size = new System.Drawing.Size(1350, 160);
            this.groupBoxNickName.TabIndex = 1;
            this.groupBoxNickName.TabStop = false;
            this.groupBoxNickName.Text = "ニックネームを決めてください(半角英数字20文字まで)";
            // 
            // buttonAcceptNickName
            // 
            this.buttonAcceptNickName.Location = new System.Drawing.Point(1008, 60);
            this.buttonAcceptNickName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonAcceptNickName.Name = "buttonAcceptNickName";
            this.buttonAcceptNickName.Size = new System.Drawing.Size(293, 62);
            this.buttonAcceptNickName.TabIndex = 1;
            this.buttonAcceptNickName.Text = "決定";
            this.buttonAcceptNickName.UseVisualStyleBackColor = true;
            this.buttonAcceptNickName.Click += new System.EventHandler(this.buttonAcceptNickName_Click);
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxNickName.Location = new System.Drawing.Point(37, 60);
            this.textBoxNickName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxNickName.MaxLength = 20;
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(550, 55);
            this.textBoxNickName.TabIndex = 0;
            this.textBoxNickName.WordWrap = false;
            // 
            // groupBoxFilePath
            // 
            this.groupBoxFilePath.Controls.Add(this.buttonSelectFilePath);
            this.groupBoxFilePath.Controls.Add(this.textBoxFilePath);
            this.groupBoxFilePath.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxFilePath.Location = new System.Drawing.Point(35, 262);
            this.groupBoxFilePath.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxFilePath.Name = "groupBoxFilePath";
            this.groupBoxFilePath.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxFilePath.Size = new System.Drawing.Size(1350, 158);
            this.groupBoxFilePath.TabIndex = 2;
            this.groupBoxFilePath.TabStop = false;
            this.groupBoxFilePath.Text = "ファイルの保存場所を決めてください";
            // 
            // buttonSelectFilePath
            // 
            this.buttonSelectFilePath.Location = new System.Drawing.Point(1008, 60);
            this.buttonSelectFilePath.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonSelectFilePath.Name = "buttonSelectFilePath";
            this.buttonSelectFilePath.Size = new System.Drawing.Size(293, 62);
            this.buttonSelectFilePath.TabIndex = 2;
            this.buttonSelectFilePath.Text = "選択";
            this.buttonSelectFilePath.UseVisualStyleBackColor = true;
            this.buttonSelectFilePath.Click += new System.EventHandler(this.buttonSelectFilePath_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxFilePath.Location = new System.Drawing.Point(37, 60);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxFilePath.MaxLength = 20;
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(953, 55);
            this.textBoxFilePath.TabIndex = 0;
            this.textBoxFilePath.WordWrap = false;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAccept.Location = new System.Drawing.Point(737, 462);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(293, 62);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "決定";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCancel.Location = new System.Drawing.Point(1042, 462);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(293, 62);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FirstSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1424, 564);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxFilePath);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxNickName);
            this.Controls.Add(this.labelDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstSettingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "初回設定を行います - GetterREPO";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstSettingForm_FormClosing);
            this.groupBoxNickName.ResumeLayout(false);
            this.groupBoxNickName.PerformLayout();
            this.groupBoxFilePath.ResumeLayout(false);
            this.groupBoxFilePath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.GroupBox groupBoxNickName;
        private System.Windows.Forms.TextBox textBoxNickName;
        private System.Windows.Forms.Button buttonAcceptNickName;
        private System.Windows.Forms.GroupBox groupBoxFilePath;
        private System.Windows.Forms.Button buttonSelectFilePath;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonCancel;
    }
}
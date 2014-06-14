namespace CreateKankouJittusekiTableApp
{
    partial class CreateKankouJittusekiTableAppForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.SelectFolderTextBox = new System.Windows.Forms.TextBox();
            this.SelectCreateFolderTextBox = new System.Windows.Forms.TextBox();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.SelectCreateFolderButton = new System.Windows.Forms.Button();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.selectFolderFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.selectCreateFolderFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // SelectFolderTextBox
            // 
            this.SelectFolderTextBox.Location = new System.Drawing.Point(12, 12);
            this.SelectFolderTextBox.Name = "SelectFolderTextBox";
            this.SelectFolderTextBox.Size = new System.Drawing.Size(355, 19);
            this.SelectFolderTextBox.TabIndex = 0;
            // 
            // SelectCreateFolderTextBox
            // 
            this.SelectCreateFolderTextBox.Location = new System.Drawing.Point(12, 37);
            this.SelectCreateFolderTextBox.Name = "SelectCreateFolderTextBox";
            this.SelectCreateFolderTextBox.Size = new System.Drawing.Size(355, 19);
            this.SelectCreateFolderTextBox.TabIndex = 1;
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Location = new System.Drawing.Point(373, 12);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(100, 19);
            this.SelectFolderButton.TabIndex = 2;
            this.SelectFolderButton.Text = "フォルダ選択";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // SelectCreateFolderButton
            // 
            this.SelectCreateFolderButton.Location = new System.Drawing.Point(373, 37);
            this.SelectCreateFolderButton.Name = "SelectCreateFolderButton";
            this.SelectCreateFolderButton.Size = new System.Drawing.Size(100, 19);
            this.SelectCreateFolderButton.TabIndex = 3;
            this.SelectCreateFolderButton.Text = "作成先の選択";
            this.SelectCreateFolderButton.UseVisualStyleBackColor = true;
            this.SelectCreateFolderButton.Click += new System.EventHandler(this.SelectCreateFolderButton_Click);
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(373, 62);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(100, 21);
            this.CreateTableButton.TabIndex = 4;
            this.CreateTableButton.Text = "作成";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // CreateKankouJittusekiTableAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 96);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.SelectCreateFolderButton);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.SelectCreateFolderTextBox);
            this.Controls.Add(this.SelectFolderTextBox);
            this.Name = "CreateKankouJittusekiTableAppForm";
            this.Text = "完工実績表作成アプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SelectFolderTextBox;
        private System.Windows.Forms.TextBox SelectCreateFolderTextBox;
        private System.Windows.Forms.Button SelectFolderButton;
        private System.Windows.Forms.Button SelectCreateFolderButton;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.FolderBrowserDialog selectFolderFBD;
        private System.Windows.Forms.FolderBrowserDialog selectCreateFolderFBD;
    }
}


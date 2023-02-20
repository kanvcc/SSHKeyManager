namespace SSHKeyManager
{
    partial class SSHKey管理工具
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBoxConfig = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBzId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBzName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrivatekey = new System.Windows.Forms.TextBox();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.txtPublickey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxConfig
            // 
            this.lstBoxConfig.FormattingEnabled = true;
            this.lstBoxConfig.ItemHeight = 12;
            this.lstBoxConfig.Location = new System.Drawing.Point(13, 22);
            this.lstBoxConfig.Name = "lstBoxConfig";
            this.lstBoxConfig.Size = new System.Drawing.Size(97, 388);
            this.lstBoxConfig.TabIndex = 0;
            this.lstBoxConfig.SelectedValueChanged += new System.EventHandler(this.lstBoxConfig_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "业务Id";
            // 
            // txtBzId
            // 
            this.txtBzId.Location = new System.Drawing.Point(126, 38);
            this.txtBzId.Name = "txtBzId";
            this.txtBzId.Size = new System.Drawing.Size(248, 21);
            this.txtBzId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "业务名称";
            // 
            // txtBzName
            // 
            this.txtBzName.Location = new System.Drawing.Point(126, 85);
            this.txtBzName.Name = "txtBzName";
            this.txtBzName.Size = new System.Drawing.Size(248, 21);
            this.txtBzName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "登录账号(*)";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(126, 135);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(248, 21);
            this.txtAccount.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "私钥(*)";
            // 
            // txtPrivatekey
            // 
            this.txtPrivatekey.Location = new System.Drawing.Point(126, 311);
            this.txtPrivatekey.Multiline = true;
            this.txtPrivatekey.Name = "txtPrivatekey";
            this.txtPrivatekey.Size = new System.Drawing.Size(248, 99);
            this.txtPrivatekey.TabIndex = 2;
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Location = new System.Drawing.Point(124, 166);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(107, 12);
            this.lblPublicKey.TabIndex = 1;
            this.lblPublicKey.Text = "公钥（双击复制*）";
            this.lblPublicKey.Click += new System.EventHandler(this.lblPublicKey_Click);
            // 
            // txtPublickey
            // 
            this.txtPublickey.Location = new System.Drawing.Point(126, 192);
            this.txtPublickey.Multiline = true;
            this.txtPublickey.Name = "txtPublickey";
            this.txtPublickey.Size = new System.Drawing.Size(248, 88);
            this.txtPublickey.TabIndex = 2;
            this.txtPublickey.DoubleClick += new System.EventHandler(this.txtPublickey_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "1.新增创建共用左侧文本框";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(415, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 46);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(415, 38);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(195, 46);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "创建";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(415, 194);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(195, 41);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "切换环境";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(415, 241);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(195, 41);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "还原配置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoEllipsis = true;
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(413, 338);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(197, 24);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "2.点击切换后，id_rsa和id_rsa.puh\r\n会被覆盖";
            // 
            // lbl3
            // 
            this.lbl3.AutoEllipsis = true;
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(413, 374);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(185, 36);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "3.点击还原配置，会重置id_rsa和\r\nid_rsa.puh为使用软件时最初读取\r\n的配置";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(415, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 46);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SSHKey管理工具
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPublickey);
            this.Controls.Add(this.lblPublicKey);
            this.Controls.Add(this.txtPrivatekey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBzName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBzId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxConfig);
            this.Name = "SSHKey管理工具";
            this.Text = "SSHKey管理工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBzId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBzName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrivatekey;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.TextBox txtPublickey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnDelete;
    }
}


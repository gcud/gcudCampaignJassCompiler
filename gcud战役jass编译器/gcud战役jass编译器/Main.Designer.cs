namespace gcud战役jass编译器
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.War3RootPathLabel = new System.Windows.Forms.Label();
            this.War3RootPathTextBox = new System.Windows.Forms.TextBox();
            this.CopyBJToDesktopButton = new System.Windows.Forms.Button();
            this.CompileButton = new System.Windows.Forms.Button();
            this.CampaignPathTextBox = new System.Windows.Forms.TextBox();
            this.CampaignPathLabel = new System.Windows.Forms.Label();
            this.EntryFunctionNameTextBox = new System.Windows.Forms.TextBox();
            this.EntryFunctionNameLabel = new System.Windows.Forms.Label();
            this.CompileOptionLabel = new System.Windows.Forms.Label();
            this.RemoveBlankCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveBlankLineCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveCommentCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SaveConfigButton = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.ExplainButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ViewUpdateLogButton = new System.Windows.Forms.Button();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // War3RootPathLabel
            // 
            this.War3RootPathLabel.AutoSize = true;
            this.War3RootPathLabel.Location = new System.Drawing.Point(18, 12);
            this.War3RootPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.War3RootPathLabel.Name = "War3RootPathLabel";
            this.War3RootPathLabel.Size = new System.Drawing.Size(98, 18);
            this.War3RootPathLabel.TabIndex = 0;
            this.War3RootPathLabel.Text = "魔兽根路径";
            // 
            // War3RootPathTextBox
            // 
            this.War3RootPathTextBox.Location = new System.Drawing.Point(123, 9);
            this.War3RootPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.War3RootPathTextBox.Name = "War3RootPathTextBox";
            this.War3RootPathTextBox.Size = new System.Drawing.Size(934, 28);
            this.War3RootPathTextBox.TabIndex = 1;
            this.War3RootPathTextBox.Text = "E:\\Game\\War3\\War3_1.27CN";
            // 
            // CopyBJToDesktopButton
            // 
            this.CopyBJToDesktopButton.Location = new System.Drawing.Point(439, 213);
            this.CopyBJToDesktopButton.Margin = new System.Windows.Forms.Padding(4);
            this.CopyBJToDesktopButton.Name = "CopyBJToDesktopButton";
            this.CopyBJToDesktopButton.Size = new System.Drawing.Size(196, 34);
            this.CopyBJToDesktopButton.TabIndex = 2;
            this.CopyBJToDesktopButton.Text = "复制压缩的bj到桌面";
            this.CopyBJToDesktopButton.UseVisualStyleBackColor = true;
            this.CopyBJToDesktopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompileButton
            // 
            this.CompileButton.Location = new System.Drawing.Point(428, 519);
            this.CompileButton.Margin = new System.Windows.Forms.Padding(4);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(246, 34);
            this.CompileButton.TabIndex = 4;
            this.CompileButton.Text = "生成编译后的bj";
            this.CompileButton.UseVisualStyleBackColor = true;
            this.CompileButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // CampaignPathTextBox
            // 
            this.CampaignPathTextBox.Location = new System.Drawing.Point(123, 111);
            this.CampaignPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CampaignPathTextBox.Name = "CampaignPathTextBox";
            this.CampaignPathTextBox.Size = new System.Drawing.Size(934, 28);
            this.CampaignPathTextBox.TabIndex = 8;
            this.CampaignPathTextBox.Text = "ReignOfChaos";
            // 
            // CampaignPathLabel
            // 
            this.CampaignPathLabel.AutoSize = true;
            this.CampaignPathLabel.Location = new System.Drawing.Point(18, 114);
            this.CampaignPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CampaignPathLabel.Name = "CampaignPathLabel";
            this.CampaignPathLabel.Size = new System.Drawing.Size(80, 18);
            this.CampaignPathLabel.TabIndex = 7;
            this.CampaignPathLabel.Text = "战役目录";
            // 
            // EntryFunctionNameTextBox
            // 
            this.EntryFunctionNameTextBox.Location = new System.Drawing.Point(123, 321);
            this.EntryFunctionNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EntryFunctionNameTextBox.Name = "EntryFunctionNameTextBox";
            this.EntryFunctionNameTextBox.Size = new System.Drawing.Size(934, 28);
            this.EntryFunctionNameTextBox.TabIndex = 11;
            this.EntryFunctionNameTextBox.Text = "InitReignofChaos_gcud";
            // 
            // EntryFunctionNameLabel
            // 
            this.EntryFunctionNameLabel.AutoSize = true;
            this.EntryFunctionNameLabel.Location = new System.Drawing.Point(17, 324);
            this.EntryFunctionNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EntryFunctionNameLabel.Name = "EntryFunctionNameLabel";
            this.EntryFunctionNameLabel.Size = new System.Drawing.Size(98, 18);
            this.EntryFunctionNameLabel.TabIndex = 10;
            this.EntryFunctionNameLabel.Text = "入口函数名";
            // 
            // CompileOptionLabel
            // 
            this.CompileOptionLabel.AutoSize = true;
            this.CompileOptionLabel.Location = new System.Drawing.Point(18, 423);
            this.CompileOptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompileOptionLabel.Name = "CompileOptionLabel";
            this.CompileOptionLabel.Size = new System.Drawing.Size(80, 18);
            this.CompileOptionLabel.TabIndex = 12;
            this.CompileOptionLabel.Text = "编译选项";
            // 
            // RemoveBlankCheckBox
            // 
            this.RemoveBlankCheckBox.AutoSize = true;
            this.RemoveBlankCheckBox.Checked = true;
            this.RemoveBlankCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RemoveBlankCheckBox.Location = new System.Drawing.Point(123, 423);
            this.RemoveBlankCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveBlankCheckBox.Name = "RemoveBlankCheckBox";
            this.RemoveBlankCheckBox.Size = new System.Drawing.Size(142, 22);
            this.RemoveBlankCheckBox.TabIndex = 13;
            this.RemoveBlankCheckBox.Text = "移除空白字符";
            this.RemoveBlankCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveBlankLineCheckBox
            // 
            this.RemoveBlankLineCheckBox.AutoSize = true;
            this.RemoveBlankLineCheckBox.Checked = true;
            this.RemoveBlankLineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RemoveBlankLineCheckBox.Location = new System.Drawing.Point(273, 423);
            this.RemoveBlankLineCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveBlankLineCheckBox.Name = "RemoveBlankLineCheckBox";
            this.RemoveBlankLineCheckBox.Size = new System.Drawing.Size(106, 22);
            this.RemoveBlankLineCheckBox.TabIndex = 14;
            this.RemoveBlankLineCheckBox.Text = "移除空行";
            this.RemoveBlankLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveCommentCheckBox
            // 
            this.RemoveCommentCheckBox.AutoSize = true;
            this.RemoveCommentCheckBox.Checked = true;
            this.RemoveCommentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RemoveCommentCheckBox.Location = new System.Drawing.Point(387, 423);
            this.RemoveCommentCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveCommentCheckBox.Name = "RemoveCommentCheckBox";
            this.RemoveCommentCheckBox.Size = new System.Drawing.Size(106, 22);
            this.RemoveCommentCheckBox.TabIndex = 15;
            this.RemoveCommentCheckBox.Text = "移除注释";
            this.RemoveCommentCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(705, 423);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(178, 22);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "简化名称(还没做)";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // SaveConfigButton
            // 
            this.SaveConfigButton.Location = new System.Drawing.Point(240, 519);
            this.SaveConfigButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveConfigButton.Name = "SaveConfigButton";
            this.SaveConfigButton.Size = new System.Drawing.Size(124, 34);
            this.SaveConfigButton.TabIndex = 17;
            this.SaveConfigButton.Text = "保存配置";
            this.SaveConfigButton.UseVisualStyleBackColor = true;
            this.SaveConfigButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(501, 423);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(196, 22);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "使用新语法(还没做)";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            // 
            // ExplainButton
            // 
            this.ExplainButton.Location = new System.Drawing.Point(931, 519);
            this.ExplainButton.Name = "ExplainButton";
            this.ExplainButton.Size = new System.Drawing.Size(87, 34);
            this.ExplainButton.TabIndex = 19;
            this.ExplainButton.Text = "说明";
            this.ExplainButton.UseVisualStyleBackColor = true;
            this.ExplainButton.Click += new System.EventHandler(this.ExplainButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(18, 528);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(80, 18);
            this.VersionLabel.TabIndex = 20;
            this.VersionLabel.Text = "20180701";
            // 
            // ViewUpdateLogButton
            // 
            this.ViewUpdateLogButton.Location = new System.Drawing.Point(738, 519);
            this.ViewUpdateLogButton.Name = "ViewUpdateLogButton";
            this.ViewUpdateLogButton.Size = new System.Drawing.Size(131, 34);
            this.ViewUpdateLogButton.TabIndex = 21;
            this.ViewUpdateLogButton.Text = "查看更新日志";
            this.ViewUpdateLogButton.UseVisualStyleBackColor = true;
            this.ViewUpdateLogButton.Click += new System.EventHandler(this.ViewUpdateLogButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 593);
            this.Controls.Add(this.ViewUpdateLogButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ExplainButton);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.SaveConfigButton);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.RemoveCommentCheckBox);
            this.Controls.Add(this.RemoveBlankLineCheckBox);
            this.Controls.Add(this.RemoveBlankCheckBox);
            this.Controls.Add(this.CompileOptionLabel);
            this.Controls.Add(this.EntryFunctionNameTextBox);
            this.Controls.Add(this.EntryFunctionNameLabel);
            this.Controls.Add(this.CampaignPathTextBox);
            this.Controls.Add(this.CampaignPathLabel);
            this.Controls.Add(this.CompileButton);
            this.Controls.Add(this.CopyBJToDesktopButton);
            this.Controls.Add(this.War3RootPathTextBox);
            this.Controls.Add(this.War3RootPathLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gcud战役jass编译器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label War3RootPathLabel;
        private System.Windows.Forms.TextBox War3RootPathTextBox;
        private System.Windows.Forms.Button CopyBJToDesktopButton;
        private System.Windows.Forms.Button CompileButton;
        private System.Windows.Forms.TextBox CampaignPathTextBox;
        private System.Windows.Forms.Label CampaignPathLabel;
        private System.Windows.Forms.TextBox EntryFunctionNameTextBox;
        private System.Windows.Forms.Label EntryFunctionNameLabel;
        private System.Windows.Forms.Label CompileOptionLabel;
        private System.Windows.Forms.CheckBox RemoveBlankCheckBox;
        private System.Windows.Forms.CheckBox RemoveBlankLineCheckBox;
        private System.Windows.Forms.CheckBox RemoveCommentCheckBox;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button SaveConfigButton;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button ExplainButton;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button ViewUpdateLogButton;
        private System.Windows.Forms.ToolTip Tips;
    }
}


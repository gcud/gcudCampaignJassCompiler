using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
namespace gcud战役jass编译器
{
    public partial class Main : Form
    {
        readonly string CurrentPath = Directory.GetCurrentDirectory();
        readonly string NowLanguage = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
        Dictionary<string, string> AllLanguageText;
        public Main()
        {
            InitializeComponent();
        }
        public string CampaignPath
        {
            get
            { return War3RootPathTextBox.Text + "/Campaigns/" + CampaignPathTextBox.Text + "/"; }
        }

        public string DesktopPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }
        public string BJPath
        {
            get
            {
                return CurrentPath + "/" + "jass/blizzard_base.txt";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string FilePath = DesktopPath + "/" + Path.GetFileName(BJPath);
            File.Copy(BJPath, FilePath, true);
            MessageBox.Show("blizzrd_base.txt已经复制到桌面");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            CompileButton.Enabled = false;
            //移除空白字符
            bool RemoveBlankCharacter = RemoveBlankCheckBox.Checked;
            //移除空行
            bool RemoveBlankLine = RemoveBlankLineCheckBox.Checked;
            //移除注释
            bool RemoveComment = RemoveCommentCheckBox.Checked;
            //简化名称,暂时不做
            //bool SimplifyName = checkBox4.Checked;
            List<string> Variable = new List<string>(), CommonFunction = new List<string>(), Function = new List<string>(), Filter = new List<string>(), Skill = new List<string>(), Trigger = new List<string>(), Init = new List<string>();
            string[] jassList = { "Variable", "CommonFunction",  "Filter", "Function","Skill", "Trigger", "Init" };
            foreach (string item in jassList)
            {
                string JassFile = CampaignPath + "/jass/" + item + ".txt";
                if (File.Exists(JassFile))
                {
                    StreamReader s = new StreamReader(JassFile);
                    string line;
                    while ((line = s.ReadLine()) != null)
                    {

                        if (RemoveBlankCharacter)
                        {
                            line = line.Trim();
                        }
                        if (RemoveBlankLine && line == "")
                        {
                            continue;
                        }
                        if (RemoveComment && line.TrimStart()[0] == '/')
                        {
                            continue;
                        }
                        switch (item)
                        {
                            case "Variable":
                                Variable.Add(line);
                                break;
                            case "CommonFunction":
                                CommonFunction.Add(line);
                                break;
                            case "Filter":
                                Filter.Add(line);
                                break;
                            case "Function":
                                Function.Add(line);
                                break;
                            case "Skill":
                                Skill.Add(line);
                                break;
                            case "Trigger":
                                Trigger.Add(line);
                                break;
                            case "Init":
                                Init.Add(line);
                                break;
                        }
                    }
                    s.Close();

                }
                else
                {
                    MessageBox.Show(String.Format(AllLanguageText["NoJassFile"], item + ".txt"));
                    CompileButton.Enabled = true;
                    return;
                }
            }
            string bjAddInit = "call " + EntryFunctionNameTextBox.Text + "()";
            List<string> bj = new List<string>(File.ReadAllLines(BJPath));
            //组合写的jass
            CommonFunction.AddRange(Filter);
            CommonFunction.AddRange(Function);
            CommonFunction.AddRange(Skill);
            CommonFunction.AddRange(Trigger);
            CommonFunction.AddRange(Init);
            //插入变量
            bj.InsertRange(1, Variable);
            //插入组合后的jass
            bj.InsertRange(6342 + Variable.Count, CommonFunction);
            //插入初始化语句
            bj.Insert(6352 + Variable.Count + CommonFunction.Count, bjAddInit);
            File.WriteAllLines(DesktopPath + "/blizzard.j", bj);
            MessageBox.Show(AllLanguageText["CompileFinishTips"]);
            CompileButton.Enabled = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            System.Collections.Specialized.NameValueCollection Settings = ConfigurationManager.AppSettings;
            string LanguageFileText = "Language\\Display\\" + NowLanguage + ".txt";
            //检测当前语言环境文件是否存在
            if (File.Exists(LanguageFileText))
            {
                //设置版本
                VersionLabel.Text = Settings["Version"];
                //读取语言文件
                AllLanguageText = Language.ReadLanguageFile(LanguageFileText);
                //界面语言赋值
                Text = AllLanguageText["TitleText"];
                War3RootPathLabel.Text = AllLanguageText["War3RootPathLabelText"];
                CampaignPathLabel.Text = AllLanguageText["CampaignPathLabelText"];
                CopyBJToDesktopButton.Text = AllLanguageText["CopyBJToDesktopButtonText"];
                EntryFunctionNameLabel.Text = AllLanguageText["EntryFunctionNameLabelText"];
                CompileOptionLabel.Text = AllLanguageText["CompileOptionLabelText"];
                SaveConfigButton.Text = AllLanguageText["SaveConfigButtonText"];
                CompileButton.Text = AllLanguageText["CreateCompiledJassButtonText"];
                ViewUpdateLogButton.Text = AllLanguageText["ViewUpdateLogButtonText"];
                ExplainButton.Text = AllLanguageText["ExplainButtonText"];
                //提示赋值
                Tips.SetToolTip(CampaignPathLabel, AllLanguageText["CampaignPathTipsLabelText"]);
                Tips.SetToolTip(CopyBJToDesktopButton, AllLanguageText["CopyBJToDesktopTipsLabelText"]);
                Tips.SetToolTip(CompileButton, AllLanguageText["FileExplainLabelText"]);
                //读取设置
                War3RootPathTextBox.Text = Settings["War3Path"];
                CampaignPathTextBox.Text = Settings["CampaignPath"];
                EntryFunctionNameTextBox.Text = Settings["EntryFunctionName"];
                RemoveBlankCheckBox.Checked = Boolean.Parse(Settings["RemoveBlank"]);
                RemoveBlankLineCheckBox.Checked = Boolean.Parse(Settings["RemoveBlankLine"]);
                RemoveCommentCheckBox.Checked = Boolean.Parse(Settings["RemoveComment"]);
                //检测基础jass是否存在
                if (!File.Exists(CurrentPath + "/jass/blizzard_base.txt"))
                {
                    MessageBox.Show(String.Format(AllLanguageText["NoJassFile"], "blizzard_base.txt"));
                    Environment.Exit(100000);
                }
            }
            else
            {
                MessageBox.Show("检测到系统环境的语言文件不存在,你可以将本软件Language/Display下的任意语言文件使用谷歌翻译制作一份" + NowLanguage + ".txt放到里面");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection kcc = cfa.AppSettings.Settings;
            kcc["War3Path"].Value = War3RootPathTextBox.Text;
            kcc["CampaignPath"].Value = CampaignPathTextBox.Text;
            kcc["EntryFunctionName"].Value = EntryFunctionNameTextBox.Text;
            kcc["RemoveBlank"].Value = RemoveBlankCheckBox.Checked.ToString();
            kcc["RemoveBlankLine"].Value = RemoveBlankLineCheckBox.Checked.ToString();
            kcc["RemoveComment"].Value = RemoveCommentCheckBox.Checked.ToString();
            cfa.Save();
            MessageBox.Show("已保存");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (MessageBox.Show(AllLanguageText["ExitTips"], AllLanguageText["ExitTipsTitle"], MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void ViewUpdateLogButton_Click(object sender, EventArgs e)
        {
            string FilePath = Application.StartupPath + "/Language/UpdateLog/" + NowLanguage + ".txt";
            if (File.Exists(FilePath))
            {
                System.Diagnostics.Process.Start(FilePath);
            }
            else
            {
                MessageBox.Show(AllLanguageText["NoUpdateLogWithMyLanguage"]);
            }
        }

        private void ExplainButton_Click(object sender, EventArgs e)
        {
            string FilePath = Application.StartupPath + "/Language/Explain/" + NowLanguage + ".txt";
            if (File.Exists(FilePath))
            {
                System.Diagnostics.Process.Start(FilePath);
            }
            else
            {
                MessageBox.Show(AllLanguageText["NoExplainWithMyLanguage"]);
            }
        }
    }
}

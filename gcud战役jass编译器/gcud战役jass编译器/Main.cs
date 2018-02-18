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
namespace gcud战役jass编译器
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public string CampaignPath
        {
            get
            { return textBox1.Text + "/Campaigns/" + textBox2.Text + "/"; }
        }
        public string CurrentPath
        {
            get
            {
                return Directory.GetCurrentDirectory();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还没做");
            //string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string jassPath = CurrentPath + "/" + "jass/blizzard_base.j";
            //List<string> a = new List<string>();
            //string[] b = File.ReadAllLines(jassPath);
            //foreach (string c in b)
            //{
            //    if (c[0] != '/')
            //    {
            //        a.Add(c);
            //    }
            //}
            //File.WriteAllLines(DesktopPath + "/a.txt", a); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //移除空白字符
            bool RemoveBlankCharacter = checkBox1.Checked;
            //移除空行
            bool RemoveBlankLine = checkBox2.Checked;
            //移除注释
            bool RemoveComment = checkBox3.Checked;
            //简化名称,暂时不做
            bool SimplifyName = checkBox4.Checked;
            List<string> Variable = new List<string>(), Function = new List<string>(), Filter = new List<string>(), Skill = new List<string>(), Trigger = new List<string>(), Init = new List<string>();
            string[] jassList = { "Variable", "Function", "Filter", "Skill", "Trigger", "Init" };
            foreach (string item in jassList)
            {
                StreamReader s = new StreamReader(CampaignPath + "/jass/" + item + ".txt");
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
                        case "Function":
                            Function.Add(line);
                            break;
                        case "Filter":
                            Filter.Add(line);
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
            string bjAddInit = "call "+textBox3.Text+"()";
            List<string> bj = new List<string>(File.ReadAllLines(BJPath));
            bj.InsertRange(1, Variable);
            bj.InsertRange(6342+Variable.Count, Function);
            bj.InsertRange(6342 + Variable.Count+Function.Count, Filter);
            bj.InsertRange(6342 + Variable.Count + Function.Count + Filter.Count, Skill);
            bj.InsertRange(6342 + Variable.Count + Function.Count + Filter.Count+ Skill.Count, Trigger);
            bj.InsertRange(6342 + Variable.Count + Function.Count + Filter.Count + Skill.Count + Trigger.Count, Init);
            bj.Insert(6352 + Variable.Count + Function.Count + Filter.Count + Skill.Count + Trigger.Count+Init.Count, bjAddInit);
            File.WriteAllLines(DesktopPath + "/blizzard.j", bj);
            MessageBox.Show("已编译blizzard.j并保存到桌面");
        }
    }
}

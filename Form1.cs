using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodemaoVisitor
{
    public partial class Form1 : Form
    {
        private bool resolved = false;
        
        public Form1()
        {
            InitializeComponent();
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            btnGenerate.Enabled = resolved;
            btnCopy.Enabled = resolved;
        }

        private void Copy()
        {
            Clipboard.SetText(tbxFinalPreview.Text);
            MessageBox.Show("已复制到剪贴板！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Refresh(string fileName)
        {
            bool success = Engine.Instance.Scan(fileName, out string result);
            if (success)
            {
                tbxFilePath.Text = fileName;
            }
            tbxFormatPreview.Text = result;
        }

        private void btnFileChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.Title = "选择一个文本文件";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Refresh(dialog.FileName);
            }
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            bool success = Engine.Instance.Resolve(tbxFormatPreview.Text,
                out string format, out FormatResolvedObject[] resolvedObjects, 
                out FormatResolvedObject[] combined);
            if (success)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var obj in combined)
                {
                    sb.AppendLine(obj.ToString());
                }
                //MessageBox.Show(format);
                //MessageBox.Show(sb.ToString());
                MessageBox.Show("解析完成！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Engine.Instance.Save(format, combined);
                resolved = true;
                UpdateButtons();
            }
            else
            {
                MessageBox.Show("解析失败！");
            }
        }

        private void btnManageDicts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能暂未实装！", "敬请期待", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnManageDefaultValues_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能暂未实装！", "敬请期待", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateConfigForm configForm = new GenerateConfigForm();
            configForm.LoadEvent += () =>
            {
                configForm.AddRows(Engine.Instance.SavedResolvedObjects, o => o.DisplayKey);
            };
            List<string> configs = new List<string>();
            configForm.ConfirmButton.Click += (o, args) =>
            {
                configs = configForm.GetConfigs();
            };
            configForm.ShowDialog(this);
            string res = Engine.Instance.Translate(Engine.Instance.Format, Engine.Instance.SavedResolvedObjects, configs);
            tbxFinalPreview.Text = res;
            if (cbxAutoCopy.Checked && res != "INVALID")
            {
                Copy();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void tbxFormatPreview_TextChanged(object sender, EventArgs e)
        {
            resolved = false;
            UpdateButtons();
        }

        private void btnEditFile_Click(object sender, EventArgs e)
        {
            // Open and edit the file
            using (Process process = new Process())
            {
                process.StartInfo.FileName = tbxFilePath.Text;
                // Check if the file exists
                if (!File.Exists(tbxFilePath.Text))
                {
                    MessageBox.Show("请先选择一个文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                process.Start();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbxFilePath.Text))
            {
                MessageBox.Show("请先选择一个文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Refresh(tbxFilePath.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 设置Border颜色为黑色
            //tbxFinalPreview.Bor = Color.Black;
#if DEBUG
	        tbxFormatPreview.Text = "示例：" + Environment.NewLine +
	                                "{学生昵称}{家长称谓}{午别}好，咱们已经参加了预售活动锁定了礼品，很高兴{学生昵称}选择继续和我们一起前进，我也给{学生昵称}把后续的安排都规划好了，按照我们的节奏来就可以啦，咱的预售礼品我也已经登记好了！" + Environment.NewLine +
	                                "今天定金活动14点准时开启，扫码后用{学生昵称}上课手机号登录支付300定金锁定创赛辅导券2张，前5000名额外赠送实物礼品编程猫定制书包*1，名额有限，您付好了跟我说下，我来及时备注登记哦！" + Environment.NewLine +
	                                "定金链接：https://marketing.codemao.cn/activity/year-config?id=104&shenkong";
#endif
        }
    }
}
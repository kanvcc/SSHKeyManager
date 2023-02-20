using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSHKeyManager
{
    public partial class SSHKey管理工具 : Form
    {
        Config CurConfig;
        string RootPath;
        public SSHKey管理工具()
        {

            InitializeComponent();
            string _strCurJson = "sshkeys.json".GetFileContext();
            if (_strCurJson == "" || _strCurJson == "{}")
            {
                InitJson();
            }
            else
            {
                CurConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(_strCurJson);
            }
            InitialControl();
        }

        private void InitJson()
        {
            var _dirs = Directory.GetDirectories(@"C:\Users");
            List<Tuple<string, DateTime>> tuples = new List<Tuple<string, DateTime>>();
            foreach (var item in _dirs)
            {
                tuples.Add(new Tuple<string, DateTime>(item, Directory.GetLastWriteTime(item)));
            }
            RootPath = tuples.FindAll(x => x.Item1 != @"C:\Users\Public").OrderByDescending(x => x.Item2).First().Item1 + @"\.ssh";
            string _strPrivateKey = $"{RootPath}/id_rsa".GetFileContext();
            string _strPublickKey = $"{RootPath}/id_rsa.pub".GetFileContext();
            SpEntity spEntity = new SpEntity
            {
                Id = Guid.NewGuid().ToString(),
                Account = _strPublickKey.Split(' ')[2],
                BzName = "默认",
                BzId = "0",
                PrivateKey = _strPrivateKey,
                PublickKey = _strPublickKey,
                isDefault = true
            };
            CurConfig = new Config
            {
                RootPath = RootPath,
                AllConfigs =
                new List<SpEntity>
                {
                    spEntity
                },
                CurConfig = spEntity
            };
            File.WriteAllText("sshkeys.json", Newtonsoft.Json.JsonConvert.SerializeObject(CurConfig), Encoding.Default);
        }
        /// <summary>
        /// 初始化列表控件
        /// </summary>
        private void InitialControl()
        {
            lstBoxConfig.DataSource = null;
            lstBoxConfig.DataSource = CurConfig.AllConfigs;
            lstBoxConfig.DisplayMember = "BzName";
            lstBoxConfig.ValueMember = "Id";
            lstBoxConfig.SelectedIndex = CurConfig.AllConfigs.Select(x => x.Id).ToList().IndexOf(CurConfig.CurConfig.Id);
        }
        private class Config
        {
            /// <summary>
            /// 当前使用的环境配置
            /// </summary>
            public SpEntity CurConfig { get; set; }
            /// <summary>
            /// C盘中私钥、公钥所在文件夹
            /// </summary>
            public string RootPath { get; set; }
            /// <summary>
            /// 所有环境配置
            /// </summary>
            public List<SpEntity> AllConfigs { get; set; }
        }
        /// <summary>
        /// 环境配置
        /// </summary>
        private class SpEntity
        {
            /// <summary>
            /// 随机编号（取GUID转换为字符串）
            /// </summary>
            public string Id { get; set; }
            /// <summary>
            /// 业务编号
            /// </summary>
            public string BzId { get; set; }
            /// <summary>
            /// 业务名称
            /// </summary>
            public string BzName { get; set; }
            /// <summary>
            /// 登录账号
            /// </summary>
            public string Account { get; set; }
            /// <summary>
            /// 私钥
            /// </summary>
            public string PrivateKey { get; set; }
            /// <summary>
            /// 公钥
            /// </summary>
            public string PublickKey { get; set; }
            /// <summary>
            /// 是否初始项
            /// </summary>
            public bool isDefault { get; set; }
        }
        /// <summary>
        /// 点击创建按钮响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region 自动创建

            #endregion
            if (txtPrivatekey.Text.Length == 0 || txtAccount.Text.Length == 0 || txtPublickey.Text.Length == 0)
            {
                MessageBox.Show("完善必填项信息");
                return;
            }
            if (CurConfig.AllConfigs.Exists(x => x.BzName == txtBzName.Text) && CurConfig.AllConfigs.Exists(x => x.Account == txtAccount.Text))
            {
                MessageBox.Show("存在业务名称和账号相同的配置，保存失败");
                return;
            }
            int keyBits = 2048;
            string keyComment = txtAccount.Text;
            var keygen = new SshKeyGenerator.SshKeyGenerator(keyBits);
            string _strPrivate = keygen.ToPrivateKey();
            string _strPublicKey = keygen.ToRfcPublicKey(keyComment);
            SpEntity spEntity = new SpEntity
            {
                Id = Guid.NewGuid().ToString(),
                Account = txtAccount.Text,
                BzId = txtBzId.Text,
                BzName = txtBzName.Text,
                PrivateKey = _strPrivate,
                PublickKey = _strPublicKey
            };
            CurConfig.AllConfigs.Add(spEntity);
            File.WriteAllText("sshkeys.json", Newtonsoft.Json.JsonConvert.SerializeObject(CurConfig), Encoding.Default);
            InitialControl();
            MessageBox.Show("创建成功");
        }
        /// <summary>
        /// 点击修改按钮响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstBoxConfig.SelectedValue is SpEntity)
            {
                return;
            }
            if (txtPrivatekey.Text.Length == 0 || txtAccount.Text.Length == 0 || txtPublickey.Text.Length == 0)
            {
                MessageBox.Show("完善必填项信息");
                return;
            }
            if (CurConfig.AllConfigs.Exists(x => x.BzName == txtBzName.Text && x.Id != lstBoxConfig.SelectedValue.ToString())
                && CurConfig.AllConfigs.Exists(x => x.Account == txtAccount.Text && x.Id != lstBoxConfig.SelectedValue.ToString()))
            {
                MessageBox.Show("存在业务名称和账号相同的配置，保存失败");
                return;
            }
            var _curSpEntity = CurConfig.AllConfigs.Find(x => x.Id == lstBoxConfig.SelectedValue.ToString());
            _curSpEntity.Account = txtAccount.Text;
            _curSpEntity.BzId = txtBzId.Text;
            _curSpEntity.BzName = txtBzName.Text;
            _curSpEntity.PrivateKey = txtPrivatekey.Text;
            _curSpEntity.PublickKey = txtPublickey.Text;
            File.WriteAllText("sshkeys.json", Newtonsoft.Json.JsonConvert.SerializeObject(CurConfig), Encoding.Default);
            InitialControl();
            MessageBox.Show("修改成功");
        }
        /// <summary>
        /// 公钥文本框双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPublickey_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPublickey.Text);
            MessageBox.Show("复制成功");
        }

        private void lstBoxConfig_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstBoxConfig.SelectedItem == null || lstBoxConfig.SelectedValue is SpEntity)
            {
                return;
            }
            var _curSpEntity = CurConfig.AllConfigs.Find(x => x.Id == lstBoxConfig.SelectedValue.ToString());
            txtAccount.Text = _curSpEntity.Account;
            txtBzId.Text = _curSpEntity.BzId;
            txtBzName.Text = _curSpEntity.BzName;
            txtPrivatekey.Text = _curSpEntity.PrivateKey;
            txtPublickey.Text = _curSpEntity.PublickKey;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lstBoxConfig.SelectedValue is SpEntity)
            {
                return;
            }
            CurConfig.CurConfig = CurConfig.AllConfigs.Find(x => x.Id == lstBoxConfig.SelectedValue.ToString());
            File.WriteAllText("sshkeys.json", Newtonsoft.Json.JsonConvert.SerializeObject(CurConfig), Encoding.Default);
            InitialControl();
            File.WriteAllText(CurConfig.RootPath + @"\id_rsa", CurConfig.CurConfig.PrivateKey, Encoding.Default);
            File.WriteAllText(CurConfig.RootPath + @"\id_rsa.pub", CurConfig.CurConfig.PublickKey, Encoding.Default);
            MessageBox.Show("切换成功");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CurConfig.CurConfig = CurConfig.AllConfigs.Find(x => x.isDefault);
            File.WriteAllText("sshkeys.json", Newtonsoft.Json.JsonConvert.SerializeObject(CurConfig), Encoding.Default);
            InitialControl();
            File.WriteAllText(CurConfig.RootPath + @"\id_rsa", CurConfig.CurConfig.PrivateKey, Encoding.Default);
            File.WriteAllText(CurConfig.RootPath + @"\id_rsa.pub", CurConfig.CurConfig.PublickKey, Encoding.Default);
            MessageBox.Show("重置成功");
        }

        private void lblPublicKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPublickey.Text);
            MessageBox.Show("复制成功");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBoxConfig.SelectedValue is SpEntity)
            {
                return;
            }
            if (CurConfig.CurConfig.Id == lstBoxConfig.SelectedValue.ToString())
            {
                MessageBox.Show("不能删除正在使用的配置");
                return;
            }
            CurConfig.AllConfigs = CurConfig.AllConfigs.FindAll(x => x.Id != lstBoxConfig.SelectedValue.ToString());
            File.WriteAllText("sshkeys.json", Newtonsoft.Json.JsonConvert.SerializeObject(CurConfig), Encoding.Default);
            InitialControl();
            MessageBox.Show("删除成功");
        }
    }
}

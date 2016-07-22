using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace BuildBoost
{
	public partial class BuildEasyBoostForm : Form
	{
		public BuildEasyBoostForm()
		{
			m_bStartEvent = false;
			InitializeComponent();
			setAllControlEnable(false);
			setAllControlData();
		}
		private void btn_start_Click(object sender, EventArgs e)
		{
			if (!checkInput()) return;

			string op = getOptionString();

			string fileName = Path.GetRandomFileName();
			fileName = fileName.Remove(fileName.IndexOf("."), 3);
			fileName += ".bat";
			FileStream fs = File.Create(fileName);
			StreamWriter writer = new StreamWriter(fs);
			writer.Write(op);
			writer.Write("\npause");
			writer.Close();

			BuildBoost.Program.g_MainForm.Visible = false;

			Process proc = new Process();
			proc.StartInfo.FileName = fileName;
			proc.StartInfo.UseShellExecute = true;
			proc.Start();
			proc.WaitForExit();

			File.Delete(fileName);
			BuildBoost.Program.g_MainForm.Visible = true;

			return;
		}
		private bool checkInput()
		{
			if (!checkBox_thread_multi.Checked && !checkBox_thread_single.Checked)
			{
				MessageBox.Show("--threading 选项至少有一个被选中。");
				return false;
			}

			if (!checkBox_link_shared.Checked && !checkBox_link_static.Checked)
			{
				MessageBox.Show("--link 选项至少有一个被选中。");
				return false;
			}

			if (!checkBox_rtl_shared.Checked && !checkBox_rtl_static.Checked)
			{
				MessageBox.Show("--runtime-link 选项至少有一个被选中。");
				return false;
			}


			if (!checkBox_debug.Checked && !checkBox_release.Checked)
			{
				MessageBox.Show("debug/release 选项至少有一个被选中。");
				return false;
			}

			if (toolsetCombo.Items.Count <= 0)
			{
				MessageBox.Show("本机没有检测到 visual studio 版本。");
				return false;
			}

			if (!radioButton_32.Checked && !radioButton_64.Checked)
			{
				MessageBox.Show("address-model 选项至少有一个被选中。");
				return false;
			}

			int i = 0;
			foreach(ListViewItem item in lib_list.Items)
			{
				if (item.Checked) ++i;
			}

			if (i == 0)
			{
				MessageBox.Show("至少选中一个library。");
				return false;
			}
			return true;
		}
		private string makeStageDir()
		{
			string path = m_sBoostPath;
			if (radioButton_32.Checked)
			{
				path += "\\stage\\win32\\" + toolsetCombo.SelectedItem.ToString() + "\\";
			}
			else
			{
				path += "\\stage\\x64\\" + toolsetCombo.SelectedItem.ToString() + "\\";
			}
			return " --stagedir=" + path;
		}
		private void btn_set_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fdlg = new FolderBrowserDialog();
			if (DialogResult.OK != fdlg.ShowDialog()) return;
			m_sBoostPath = fdlg.SelectedPath;
			textBox_path.Text = m_sBoostPath;
			Environment.CurrentDirectory = m_sBoostPath;

			if (!File.Exists(m_sBoostPath + "\\bjam.exe"))
			{
				MessageBox.Show("没有找到bjam.exe文件，请重新选择正确路径。如果路径无误，请运行bootstrap.bat生成bjam.exe文件。");
				return;
			}

			setAllControlEnable(true);

			initLibarayList();
			initMSVCList();
			m_bStartEvent = true;
			return;
		}
		private void initLibarayList()
		{
			if (!File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\libraries"))
			{
				MessageBox.Show("没有找到libraries文件，请在命令行运行 bjam.exe --show-libaraies命令来重新制做。");
				return;
			}
			StreamReader reader = new StreamReader("libraries");
			string sLine = reader.ReadLine();
			while (sLine != null)
			{
				ListViewItem item = new ListViewItem();
				item.Text = sLine;
				lib_list.Items.Add(item);
				sLine = reader.ReadLine();
			}
			reader.Close();
			return;
		}
		private void initMSVCList()
		{
			string path = "SOFTWARE\\Microsoft\\VisualStudio";
			RegistryKey hVs = Registry.LocalMachine.OpenSubKey(path);
			string[] names = hVs.GetSubKeyNames();
			foreach (string name in names)
			{
				RegistryKey sub = Registry.LocalMachine.OpenSubKey(path + "\\" + name + "\\setup\\vs");
				if (sub == null) continue;
				string exe = sub.GetValue("EnvironmentPath").ToString();
				if (!File.Exists(exe)) continue;
				toolsetCombo.Items.Add("msvc-" + name);
			}
			if (toolsetCombo.Items.Count > 0)
				toolsetCombo.SelectedIndex = 0;
		}
		private void setAllControlEnable(bool bEanble)
		{
			toolsetCombo.Enabled = bEanble;
			checkBox_link_static.Enabled = bEanble;
			checkBox_link_shared.Enabled = bEanble;
			checkBox_rtl_shared.Enabled = bEanble;
			checkBox_rtl_static.Enabled = bEanble;
			checkBox_thread_multi.Enabled = bEanble;
			checkBox_thread_single.Enabled = bEanble;
			checkBox_debug.Enabled = bEanble;
			checkBox_release.Enabled = bEanble;
			btn_start.Enabled = bEanble;
			lib_list.Enabled = bEanble;
			checkBox_selall.Enabled = bEanble;
			radioButton_32.Enabled = bEanble;
			radioButton_64.Enabled = bEanble;
		}
		private void setAllControlData()
		{
			checkBox_debug.Checked = true;
			checkBox_release.Checked = true;

			checkBox_link_shared.Checked = false;
			checkBox_link_static.Checked = true;

			checkBox_rtl_shared.Checked = true;
			checkBox_rtl_static.Checked = false;

			checkBox_thread_multi.Checked = true;
			checkBox_thread_single.Checked = false;

			radioButton_32.Checked = true;
			radioButton_64.Checked = false;
		}
		private string m_sBoostPath { get; set; }
		private void checkBox_selall_CheckedChanged(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lib_list.Items)
				item.Checked = (sender as CheckBox).Checked;
		}
		private string getThreading()
		{
			string op = "";
			if (checkBox_thread_multi.Checked)
				op += " threading=multi";
			if (checkBox_thread_single.Checked)
				op += " threading=single";
			return op;
		}
		private string getLink()
		{
			string op = "";
			if (checkBox_link_shared.Checked)
				op += " link=shared";
			if (checkBox_link_static.Checked)
				op += " link=static";
			return op;
		}
		private string getRuntimeLink()
		{
			string op = "";
			if (checkBox_link_shared.Checked)
				op += " runtime-link=shared";
			if (checkBox_link_static.Checked)
				op += " runtime-link=static";
			return op;
		}
		private string getDebugRelease()
		{
			string op = "";
			if (checkBox_debug.Checked)
				op += " debug";
			if (checkBox_release.Checked)
				op += " release";
			return op;
		}
		private string getAddressModel()
		{
			string op = "";
			if (radioButton_32.Checked)
				op += "";
			else// if (checkBox_release.Checked)
				op += " address-model=64";
			return op;
		}
		private string getToolset()
		{
			return " --toolset=" + toolsetCombo.SelectedItem.ToString();
		}
		private string getLibraries()
		{
			string op = "";
			foreach (ListViewItem item in lib_list.Items)
			{
				if (item.Checked)
					op += " --with-" + item.Text;
			}
			return op;
		}

		private void optionChanged(object sender, EventArgs e)
		{
			textBox_cmd.Text = getOptionString();
		}
		private string getOptionString()
		{
			if (m_bStartEvent)
				return "bjam stage architecture=x86" + getToolset() + makeStageDir() +
				getLink() + getRuntimeLink() + getThreading() + getDebugRelease() +
				getAddressModel() + getLibraries();
			return "";
		}
		private bool m_bStartEvent;

	}
}

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

namespace BuildBoost
{
	public partial class BuildEasyBoostForm : Form
	{
		public BuildEasyBoostForm()
		{
			InitializeComponent();
			SetAllControlEnable(false);
		}

		private void btn_start_Click(object sender, EventArgs e)
		{

		}

		private void btn_set_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fdlg = new FolderBrowserDialog();
			fdlg.ShowDialog();
			textBox_path.Text = fdlg.SelectedPath;
			Environment.CurrentDirectory = fdlg.SelectedPath;

			if (!File.Exists(fdlg.SelectedPath + "\\bjam.exe"))
				MessageBox.Show("没有找到bjam.exe文件，请重新选择正确路径。如果路径无误，请运行bootstrap.bat生成bjam.exe文件。");
			else
				SetAllControlEnable(true);

			ArrayList ar = new ArrayList();
			initLibarayList(ref ar);

			return;
		}

		private bool initLibarayList(ref ArrayList ar)
		{
			if (!File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\libraries"))
			{
				MessageBox.Show("没有找到libraries文件，请在命令行运行 bjam.exe --show-libaraies命令来重新制做。");
				return false;
			}
			StreamReader reader = new StreamReader("libraries");
			string sLine = reader.ReadLine();
			while (sLine != null)
			{
				ar.Add(sLine);
				sLine = reader.ReadLine();
			}
			return true;
		}

		private void SetAllControlEnable(bool bEanble)
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
		}
	}
}

namespace BuildBoost
{
	partial class BuildEasyBoostForm
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
			this.lib_list = new System.Windows.Forms.ListView();
			this.toolsetCombo = new System.Windows.Forms.ComboBox();
			this.checkBox_debug = new System.Windows.Forms.CheckBox();
			this.checkBox_release = new System.Windows.Forms.CheckBox();
			this.checkBox_rtl_shared = new System.Windows.Forms.CheckBox();
			this.checkBox_rtl_static = new System.Windows.Forms.CheckBox();
			this.checkBox_thread_multi = new System.Windows.Forms.CheckBox();
			this.checkBox_thread_single = new System.Windows.Forms.CheckBox();
			this.checkBox_link_shared = new System.Windows.Forms.CheckBox();
			this.checkBox_link_static = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btn_start = new System.Windows.Forms.Button();
			this.btn_set = new System.Windows.Forms.Button();
			this.textBox_path = new System.Windows.Forms.TextBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.textBox_cmd = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// lib_list
			// 
			this.lib_list.Location = new System.Drawing.Point(20, 21);
			this.lib_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lib_list.Name = "lib_list";
			this.lib_list.Size = new System.Drawing.Size(125, 344);
			this.lib_list.TabIndex = 1;
			this.lib_list.UseCompatibleStateImageBehavior = false;
			// 
			// toolsetCombo
			// 
			this.toolsetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolsetCombo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolsetCombo.FormattingEnabled = true;
			this.toolsetCombo.Location = new System.Drawing.Point(51, 25);
			this.toolsetCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolsetCombo.Name = "toolsetCombo";
			this.toolsetCombo.Size = new System.Drawing.Size(202, 27);
			this.toolsetCombo.TabIndex = 0;
			// 
			// checkBox_debug
			// 
			this.checkBox_debug.AutoSize = true;
			this.checkBox_debug.Location = new System.Drawing.Point(51, 26);
			this.checkBox_debug.Name = "checkBox_debug";
			this.checkBox_debug.Size = new System.Drawing.Size(71, 23);
			this.checkBox_debug.TabIndex = 0;
			this.checkBox_debug.Text = "debug";
			this.checkBox_debug.UseVisualStyleBackColor = true;
			// 
			// checkBox_release
			// 
			this.checkBox_release.AutoSize = true;
			this.checkBox_release.Location = new System.Drawing.Point(190, 26);
			this.checkBox_release.Name = "checkBox_release";
			this.checkBox_release.Size = new System.Drawing.Size(77, 23);
			this.checkBox_release.TabIndex = 1;
			this.checkBox_release.Text = "release";
			this.checkBox_release.UseVisualStyleBackColor = true;
			// 
			// checkBox_rtl_shared
			// 
			this.checkBox_rtl_shared.AutoSize = true;
			this.checkBox_rtl_shared.Location = new System.Drawing.Point(51, 26);
			this.checkBox_rtl_shared.Name = "checkBox_rtl_shared";
			this.checkBox_rtl_shared.Size = new System.Drawing.Size(74, 23);
			this.checkBox_rtl_shared.TabIndex = 0;
			this.checkBox_rtl_shared.Text = "shared";
			this.checkBox_rtl_shared.UseVisualStyleBackColor = true;
			// 
			// checkBox_rtl_static
			// 
			this.checkBox_rtl_static.AutoSize = true;
			this.checkBox_rtl_static.Location = new System.Drawing.Point(187, 26);
			this.checkBox_rtl_static.Name = "checkBox_rtl_static";
			this.checkBox_rtl_static.Size = new System.Drawing.Size(66, 23);
			this.checkBox_rtl_static.TabIndex = 1;
			this.checkBox_rtl_static.Text = "static";
			this.checkBox_rtl_static.UseVisualStyleBackColor = true;
			// 
			// checkBox_thread_multi
			// 
			this.checkBox_thread_multi.AutoSize = true;
			this.checkBox_thread_multi.Location = new System.Drawing.Point(51, 26);
			this.checkBox_thread_multi.Name = "checkBox_thread_multi";
			this.checkBox_thread_multi.Size = new System.Drawing.Size(67, 23);
			this.checkBox_thread_multi.TabIndex = 0;
			this.checkBox_thread_multi.Text = "multi";
			this.checkBox_thread_multi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.checkBox_thread_multi.UseVisualStyleBackColor = true;
			// 
			// checkBox_thread_single
			// 
			this.checkBox_thread_single.AutoSize = true;
			this.checkBox_thread_single.Location = new System.Drawing.Point(187, 26);
			this.checkBox_thread_single.Name = "checkBox_thread_single";
			this.checkBox_thread_single.Size = new System.Drawing.Size(69, 23);
			this.checkBox_thread_single.TabIndex = 1;
			this.checkBox_thread_single.Text = "single";
			this.checkBox_thread_single.UseVisualStyleBackColor = true;
			// 
			// checkBox_link_shared
			// 
			this.checkBox_link_shared.AutoSize = true;
			this.checkBox_link_shared.Location = new System.Drawing.Point(51, 26);
			this.checkBox_link_shared.Name = "checkBox_link_shared";
			this.checkBox_link_shared.Size = new System.Drawing.Size(74, 23);
			this.checkBox_link_shared.TabIndex = 0;
			this.checkBox_link_shared.Text = "shared";
			this.checkBox_link_shared.UseVisualStyleBackColor = true;
			// 
			// checkBox_link_static
			// 
			this.checkBox_link_static.AutoSize = true;
			this.checkBox_link_static.Location = new System.Drawing.Point(190, 26);
			this.checkBox_link_static.Name = "checkBox_link_static";
			this.checkBox_link_static.Size = new System.Drawing.Size(66, 23);
			this.checkBox_link_static.TabIndex = 1;
			this.checkBox_link_static.Text = "static";
			this.checkBox_link_static.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox_link_static);
			this.groupBox1.Controls.Add(this.checkBox_link_shared);
			this.groupBox1.Location = new System.Drawing.Point(152, 231);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(299, 64);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "--link";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBox_rtl_static);
			this.groupBox2.Controls.Add(this.checkBox_rtl_shared);
			this.groupBox2.Location = new System.Drawing.Point(152, 161);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(299, 64);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "--runtime-link";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.checkBox_thread_multi);
			this.groupBox3.Controls.Add(this.checkBox_thread_single);
			this.groupBox3.Location = new System.Drawing.Point(152, 91);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(299, 64);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "--threading";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.toolsetCombo);
			this.groupBox4.Location = new System.Drawing.Point(152, 21);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(299, 64);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "--toolset";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.checkBox_release);
			this.groupBox5.Controls.Add(this.checkBox_debug);
			this.groupBox5.Location = new System.Drawing.Point(152, 301);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(299, 64);
			this.groupBox5.TabIndex = 7;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "debug/release";
			// 
			// btn_start
			// 
			this.btn_start.Location = new System.Drawing.Point(342, 535);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(109, 34);
			this.btn_start.TabIndex = 2;
			this.btn_start.Text = "start";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// btn_set
			// 
			this.btn_set.Location = new System.Drawing.Point(20, 373);
			this.btn_set.Name = "btn_set";
			this.btn_set.Size = new System.Drawing.Size(125, 38);
			this.btn_set.TabIndex = 0;
			this.btn_set.Text = "set boost path";
			this.btn_set.UseVisualStyleBackColor = true;
			this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
			// 
			// textBox_path
			// 
			this.textBox_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_path.Enabled = false;
			this.textBox_path.Location = new System.Drawing.Point(152, 380);
			this.textBox_path.Name = "textBox_path";
			this.textBox_path.Size = new System.Drawing.Size(299, 20);
			this.textBox_path.TabIndex = 10;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.textBox_cmd);
			this.groupBox6.Location = new System.Drawing.Point(20, 417);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(431, 112);
			this.groupBox6.TabIndex = 11;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "command line";
			// 
			// textBox_cmd
			// 
			this.textBox_cmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_cmd.Enabled = false;
			this.textBox_cmd.Location = new System.Drawing.Point(6, 20);
			this.textBox_cmd.Multiline = true;
			this.textBox_cmd.Name = "textBox_cmd";
			this.textBox_cmd.Size = new System.Drawing.Size(419, 86);
			this.textBox_cmd.TabIndex = 0;
			// 
			// BuildEasyBoostForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 581);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.textBox_path);
			this.Controls.Add(this.btn_set);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lib_list);
			this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BuildEasyBoostForm";
			this.Text = "BuildEasyBoost";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lib_list;
		private System.Windows.Forms.ComboBox toolsetCombo;
		private System.Windows.Forms.CheckBox checkBox_debug;
		private System.Windows.Forms.CheckBox checkBox_release;
		private System.Windows.Forms.CheckBox checkBox_rtl_shared;
		private System.Windows.Forms.CheckBox checkBox_rtl_static;
		private System.Windows.Forms.CheckBox checkBox_thread_multi;
		private System.Windows.Forms.CheckBox checkBox_thread_single;
		private System.Windows.Forms.CheckBox checkBox_link_shared;
		private System.Windows.Forms.CheckBox checkBox_link_static;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Button btn_set;
		private System.Windows.Forms.TextBox textBox_path;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox textBox_cmd;
	}
}


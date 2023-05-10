using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace dawcore
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}
		void ListBox1DoubleClick(object sender, EventArgs e)
		{
			/*
Off system messages
Title
Color
Print text
Input text
Clear screen
Pause
Exit
Start
Shutdown
*/
			if (listBox1.SelectedItem.Equals("Off system messages") == true)
			{
				richTextBox1.Text = richTextBox1.Text + "\n@echo off";
			}
			if (listBox1.SelectedItem.Equals("Clear screen") == true)
			{
				richTextBox1.Text = richTextBox1.Text + "\ncls";
			}
			if (listBox1.SelectedItem.Equals("Pause") == true)
			{
				richTextBox1.Text = richTextBox1.Text + "\npause";
			}
			if (listBox1.SelectedItem.Equals("Exit") == true)
			{
				richTextBox1.Text = richTextBox1.Text + "\nexit";
			}
			if (listBox1.SelectedItem.Equals("Shutdown") == true)
			{
				richTextBox1.Text = richTextBox1.Text + "\nshutdown";
			}
			if (listBox1.SelectedItem.Equals("Start") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel2.Show();
			}
			if (listBox1.SelectedItem.Equals("Title") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel3.Show();
			}
			if (listBox1.SelectedItem.Equals("Print text") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel4.Show();
			}
			if (listBox1.SelectedItem.Equals("Input text") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel5.Show();
			}
			if (listBox1.SelectedItem.Equals("Color") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel6.Show();
			}
			if (listBox1.SelectedItem.Equals("Timer") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel7.Show();
			}
			if (listBox1.SelectedItem.Equals("Function") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel8.Show();
			}
			if (listBox1.SelectedItem.Equals("Run function") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel9.Show();
			}
			if (listBox1.SelectedItem.Equals("If") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel10.Show();
			}
			if (listBox1.SelectedItem.Equals("Else") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel11.Show();
			}
			if (listBox1.SelectedItem.Equals("Comment") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel12.Show();
			}
			if (listBox1.SelectedItem.Equals("Close") == true)
			{
				richTextBox1.ReadOnly = true;
				listBox1.Enabled = false;
				panel13.Show();
			}
		}
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
			textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			if (File.Exists(textBox1.Text))
			{
				File.WriteAllLines(textBox1.Text, richTextBox1.Lines);
			}
		}
		void PictureBox4Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
		}
		void SaveFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			File.WriteAllLines(saveFileDialog1.FileName, richTextBox1.Lines);
			textBox1.Text = saveFileDialog1.FileName;
		}
		void PictureBox3Click(object sender, EventArgs e)
		{
			if (Directory.Exists("Debug"))
			{
				File.WriteAllLines("Debug\\project.bat", richTextBox1.Lines);
				Process p1 = new Process();
				p1.StartInfo.FileName = "Debug\\project.bat";
				p1.Start();
			}
			else
			{
				Directory.CreateDirectory("Debug");
				File.WriteAllLines("Debug\\project.bat", richTextBox1.Lines);
				Process p2 = new Process();
				p2.StartInfo.FileName = "Debug\\project.bat";
				p2.Start();
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			openFileDialog2.ShowDialog();
		}
		void OpenFileDialog2FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			textBox2.Text = openFileDialog2.FileName;
		}
		void Button2Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\nstart " + textBox2.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel2.Hide();
		}
		void Button3Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\ntitle " + textBox3.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel3.Hide();
		}
		void Button4Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\necho " + textBox4.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel4.Hide();
		}
		void Button5Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\nset /p " + textBox5.Text + "=" + textBox6.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel5.Hide();
		}
		void Button6Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\ncolor " + textBox8.Text + textBox7.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel6.Hide();
		}
		void Label1Click(object sender, EventArgs e)
		{
			Process p = new Process();
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.FileName = "cmd.exe";
			p.StartInfo.Arguments = "/C " + "color ?";
			p.StartInfo.CreateNoWindow = false;
			p.Start();
		}
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		void Button7Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\nping -n " + numericUpDown1.Value +  " " + textBox9.Text + ">nul";
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel7.Hide();
		}
		void Button8Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\n:" + textBox10.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel8.Hide();
		}
		void Button9Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\ngoto " + textBox11.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel9.Hide();
		}
		void Button10Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\nif %" + textBox12.Text + "%==" + textBox13.Text + " " + textBox14.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel10.Hide();
		}
		void Button11Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\nif not defined " + textBox17.Text + " " + textBox15.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel11.Hide();
		}
		void Button12Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\n:: " + textBox18.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel12.Hide();
		}
		void Button13Click(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text + "\ntaskkill \\f \\im " + textBox16.Text;
			richTextBox1.ReadOnly = false;
			listBox1.Enabled = true;
			panel13.Hide();
		}
	}
}

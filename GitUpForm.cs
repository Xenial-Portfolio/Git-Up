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

namespace GitUp
{
    public partial class GitUpForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private List<string> _commandFileList = new List<string>();
        private List<string> _commandList = new List<string>();
        private List<string> _argsFileList = new List<string>();

        public GitUpForm()
        {
            InitializeComponent();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void MoveForm()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void ExecuteFileButton_Click(object sender, EventArgs e)
        {
            LogsTextBox.Clear();
            var cmd = new Process();
            var path = _commandFileList[CommandFileComboBox.SelectedIndex - 1];

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            foreach (var command in GetFileCommands(path))
                cmd.StandardInput.WriteLine(command);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            LogsTextBox.Text += cmd.StandardOutput.ReadToEnd();
        }

        private string[] GetFileCommands(string fileLocation)
        {
            return File.ReadAllLines(fileLocation);
        }

        private void GitUpForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists($"{Directory.GetCurrentDirectory()}/Commands"))
                Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}/Commands");

            if (!Directory.Exists($"{Directory.GetCurrentDirectory()}/Git"))
                Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}/Git");

            if (!Directory.Exists($"{Directory.GetCurrentDirectory()}/Args"))
                Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}/Args");

            UpdateFileList();
            UpdateArgsFileList();
        }

        private void ReloadListsButton_Click(object sender, EventArgs e)
        {
            UpdateFileList();
            UpdateArgsFileList();
        }

        private void UpdateFileList()
        {
            CommandFileComboBox.Items.Clear();
            _commandFileList.Clear();

            foreach (var file in Directory.EnumerateFiles($"{Directory.GetCurrentDirectory()}/Commands"))
            {
                if (!file.Contains(".cm")) continue;
                _commandFileList.Add(file);
            }

            foreach (var path in _commandFileList)
            {
                var splitPath = path.Split('\\');
                var name = splitPath[splitPath.Length - 1];
                CommandFileComboBox.Items.Add(name.Replace(".cm", string.Empty));
            }
        }

        private void ExecuteQuickCMDButton_Click(object sender, EventArgs e)
        {
            LogsTextBox.Clear();
            var commandPath = _commandList[CommandComboBox.SelectedIndex];

            var cmd = new Process();
            var command = $"git {GetFileCommands(commandPath)[0]} ";

            if (ArgOneComboBox.SelectedIndex != -1 && _argsFileList.Count > 0)
            {
                var argOne = _argsFileList[ArgOneComboBox.SelectedIndex];
                command += $"{GetFileCommands(argOne)[0]} {ArgOneInputTextBox.Text} ";
            }

            if (ArgTwoComboBox.SelectedIndex != -1 && _argsFileList.Count > 0)
            {
                var argTwo = _argsFileList[ArgTwoComboBox.SelectedIndex];
                command += $"{GetFileCommands(argTwo)[0]} {ArgTwoInputTextBox.Text}";
            }

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(command);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            LogsTextBox.Text += cmd.StandardOutput.ReadToEnd();
        }

        private void UpdateArgsFileList()
        {
            CommandComboBox.Items.Clear();
            ArgOneComboBox.Items.Clear();
            ArgTwoComboBox.Items.Clear();

            _argsFileList.Clear();
            _commandList.Clear();

            foreach (var file in Directory.EnumerateFiles($"{Directory.GetCurrentDirectory()}/Git"))
            {
                if (!file.Contains(".cm")) continue;
                _commandList.Add(file);
            }

            foreach (var file in Directory.EnumerateFiles($"{Directory.GetCurrentDirectory()}/Args"))
            {
                if (!file.Contains(".cm")) continue;
                _argsFileList.Add(file);
            }

            foreach (var path in _commandList)
            {
                var splitPath = path.Split('\\');
                var name = splitPath[splitPath.Length - 1];
                CommandComboBox.Items.Add(name.Replace(".cm", string.Empty));
            }

            foreach (var path in _argsFileList)
            {
                var splitPath = path.Split('\\');
                var name = splitPath[splitPath.Length - 1];
                ArgOneComboBox.Items.Add(name.Replace(".cm", string.Empty));
                ArgTwoComboBox.Items.Add(name.Replace(".cm", string.Empty));
            }
        }
    }
}

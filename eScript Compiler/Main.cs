using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Ookii.Dialogs;

namespace eScript_Compiler
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Text = "eScript Compiler v";
            Text += ProductVersion;
            Text += " Made By Scripter Molester";

            btn_CompileScript.Enabled = false;
            btn_lastScript.Enabled = false;
            btn_CompileDir.Enabled = false;
            btn_lastFolder.Enabled = false;
            btn_CompileAll.Enabled = false;
            btn_SaveLog.Enabled = false;
            tree_folders.Enabled = false;

            lastScripts = new Dictionary<string, string>();
        }

        public static string  ecompilerPath = String.Empty;
        public static string compilerLog = String.Empty;

        public Dictionary<string, string> lastScripts;

        //public string lastScript = String.Empty; //Script file.
        public string lastFolder = String.Empty; //Directory scripts.

        private void btn_ChooseEcompiler_Click(object sender, EventArgs e)
        {
            OpenFileDialog ecompiler = new OpenFileDialog();
            ecompiler.Filter = "Ecompiler (ecompile.exe)|ecompile.exe";
            if (ecompiler.ShowDialog() == DialogResult.OK)
            {
                ecompilerPath = ecompiler.FileName;
                txt_ecompilePath.Text = ecompilerPath;
                btn_CompileScript.Enabled = true;
                btn_CompileDir.Enabled = true;
                btn_CompileAll.Enabled = true;
                btn_ChooseEcompiler.Enabled = false;
            }

        }

        ProcessStartInfo ecompile = new ProcessStartInfo();

        private void btn_CompileScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog scriptFile = new OpenFileDialog();
            scriptFile.Filter = "Script File (*.src)|*.src";

            int lengthTemp, tempValue;
            string temp;

            if (scriptFile.ShowDialog() == DialogResult.OK)
            {
                ecompile.FileName = ecompilerPath;
                ecompile.Arguments = "\"" + scriptFile.FileName + "\"" + " -Ecfgpath "; // + ecompilerPath.Replace(".exe", ".cfg");
                ecompile.UseShellExecute = false;
                ecompile.CreateNoWindow = true;
                ecompile.ErrorDialog = false;
                ecompile.RedirectStandardInput = false;
                ecompile.RedirectStandardOutput = true;

                //lastScript = scriptFile.FileName;
                lengthTemp = (scriptFile.FileName.Length - ( scriptFile.FileName.LastIndexOf('\\') + 1)) - 4;
                temp = scriptFile.FileName.Substring(scriptFile.FileName.LastIndexOf('\\') + 1, lengthTemp);
                lastScripts.Add(temp,scriptFile.FileName);

                if (!btn_lastScript.Enabled)
                    btn_lastScript.Enabled = true;
                if (!tree_folders.Enabled)
                    tree_folders.Enabled = true;

                compileScripts();
            }
        }

        private void btn_lastScript_Click(object sender, EventArgs e)
        {
            LastScripts lastScript = new LastScripts();
            lastScript.ScriptCronology(lastScripts);

            lastScript.ShowDialog();

            /* Vecchia Versione
            ecompile.FileName = ecompilerPath;
            ecompile.Arguments = "\"" + lastScript + "\"" + " -Ecfgpath " + ecompilerPath.Replace(".exe", ".cfg");
            ecompile.UseShellExecute = false;
            ecompile.CreateNoWindow = true;
            ecompile.ErrorDialog = false;
            ecompile.RedirectStandardInput = false;
            ecompile.RedirectStandardOutput = true;

            compileScripts();
            */
        }

        public void compileLastScript(string scriptFile)
        {
            ecompile.FileName = ecompilerPath;
            ecompile.Arguments = "\"" + scriptFile + "\"" + " -Ecfgpath " + ecompilerPath.Replace(".exe", ".cfg");
            ecompile.UseShellExecute = false;
            ecompile.CreateNoWindow = true;
            ecompile.ErrorDialog = false;
            ecompile.RedirectStandardInput = false;
            ecompile.RedirectStandardOutput = true;

            compileScripts();
        }

        private void btn_CompileDir_Click(object sender, EventArgs e)
        {

            VistaFolderBrowserDialog scriptDir = new VistaFolderBrowserDialog();

            if (!VistaFolderBrowserDialog.IsVistaFolderDialogSupported)
                MessageBox.Show(this, "Because you are not using Windows Vista or later, the regular folder browser dialog will be used. Please use Windows Vista to see the new dialog.", "Sample folder browser dialog");

           // FolderBrowserDialog scriptDir = new FolderBrowserDialog();

            if (scriptDir.ShowDialog() == DialogResult.OK)
            {
                ecompile.FileName = ecompilerPath;
                ecompile.Arguments = "-r \"" + scriptDir.SelectedPath + "\"" + " -Ecfgpath " + ecompilerPath.Replace(".exe", ".cfg");
                ecompile.UseShellExecute = false;
                ecompile.CreateNoWindow = true;
                ecompile.ErrorDialog = false;
                ecompile.RedirectStandardInput = false;
                ecompile.RedirectStandardOutput = true;

                lastFolder = scriptDir.SelectedPath;

                ListDirectory(lastFolder);

                compileScripts();

                if (!btn_lastFolder.Enabled)
                    btn_lastFolder.Enabled = true;
                if (!tree_folders.Enabled)
                    tree_folders.Enabled = true;
            }
        }

        private void ListDirectory(string path)
        {
            tree_folders.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            tree_folders.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
            {
                if (file.ToString().Contains("src") || file.ToString().Contains("inc"))
                    directoryNode.Nodes.Add(new TreeNode(file.Name));
            }
            return directoryNode;
        }

        private void btn_lastFolder_Click(object sender, EventArgs e)
        {
            ecompile.FileName = ecompilerPath;
            ecompile.Arguments = "-r \"" + lastFolder + "\"" + " -Ecfgpath " + ecompilerPath.Replace(".exe", ".cfg");
            ecompile.UseShellExecute = false;
            ecompile.CreateNoWindow = true;
            ecompile.ErrorDialog = false;
            ecompile.RedirectStandardInput = false;
            ecompile.RedirectStandardOutput = true;

            compileScripts();
        }

        private void btn_CompileAll_Click(object sender, EventArgs e)
        {
            ecompile.FileName = ecompilerPath;
            ecompile.Arguments = "-A -b" + " -Ecfgpath " + ecompilerPath.Replace(".exe", ".cfg");
            ecompile.UseShellExecute = false;
            ecompile.CreateNoWindow = true;
            ecompile.ErrorDialog = false;
            ecompile.RedirectStandardInput = false;
            ecompile.RedirectStandardOutput = true;

            compileScripts();
        }

        private void btn_SaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "eScript Compiler LOG (*.log)|*.log";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = File.CreateText(sfd.FileName);
                tw.Write(rtb_TextEcompile.Text);
                tw.Flush();
                tw.Close();
            }
        }

        private void compileScripts()
        {
            btn_CompileScript.Enabled = false;
            btn_CompileDir.Enabled = false;
            btn_CompileAll.Enabled = false;
            btn_SaveLog.Enabled = false;

            rtb_TextEcompile.Clear();
            rtb_TextEcompile.Text = "EScript Compiler v1.12\nCopyright (C) 1993-2009 Eric N. Swanson\neScript Compiler GUI v1.00\nCopyright (C) 2013 Scripter Molester\n\n";

            bw_Compiler.WorkerReportsProgress = true;
            bw_Compiler.RunWorkerAsync();
        }

        private void bw_Compiler_DoWork(object sender, DoWorkEventArgs e)
        {
            string outputLine;
            Process startCompiler = new Process();
            startCompiler.StartInfo = ecompile;
            startCompiler.Start();

            while (!startCompiler.StandardOutput.EndOfStream)
            {
                outputLine = startCompiler.StandardOutput.ReadLine() + '\n';
                bw_Compiler.ReportProgress(0, outputLine);
            }

            startCompiler.WaitForExit();
            startCompiler.Close();
        }

        private void bw_Compiler_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            rtb_TextEcompile.AppendText((string)e.UserState);
            rtb_TextEcompile.ScrollToCaret();
        }

        private void bw_Compiler_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_CompileScript.Enabled = true;
            btn_CompileDir.Enabled = true;
            btn_CompileAll.Enabled = true;
            btn_SaveLog.Enabled = true;
        }

        private void tree_folders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = tree_folders.SelectedNode;
            string path = lastFolder.Substring(0, lastFolder.LastIndexOf("\\"));

            if (node.Text.Contains("src") || node.Text.Contains("inc"))
            {
                ecompile.FileName = ecompilerPath;
                ecompile.Arguments = "\"" + path + "\\" + node.FullPath + "\"" + " -Ecfgpath " + ecompilerPath.Replace(".exe", ".cfg");
                ecompile.UseShellExecute = false;
                ecompile.CreateNoWindow = true;
                ecompile.ErrorDialog = false;
                ecompile.RedirectStandardInput = false;
                ecompile.RedirectStandardOutput = true;

                compileScripts();
            }
            else
            {
                ecompile.FileName = ecompilerPath;
                ecompile.Arguments = "-r \"" + path + "\\" + node.FullPath + "\"" + " -Ecfgpath " + ecompilerPath.Replace(".exe", ".cfg");
                ecompile.UseShellExecute = false;
                ecompile.CreateNoWindow = true;
                ecompile.ErrorDialog = false;
                ecompile.RedirectStandardInput = false;
                ecompile.RedirectStandardOutput = true;

                compileScripts();
            }
        }
    }
}

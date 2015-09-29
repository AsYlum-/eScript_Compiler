using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eScript_Compiler
{
    public partial class LastScripts : Form
    {
        public LastScripts()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> scripts;

        public void ScriptCronology(Dictionary<string, string> scriptFiles)
        {
            scripts = scriptFiles;

            foreach (KeyValuePair<string, string> pair in scripts)
            {
                lst_scriptsCron.Items.Add(pair.Key);
            }
        }

        private void lst_scriptsCron_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main compile = new Main();

            string scriptFile = scripts[Convert.ToString(lst_scriptsCron.SelectedItem)];

            compile.compileLastScript(scriptFile);
        }
    }
}

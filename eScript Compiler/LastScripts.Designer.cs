namespace eScript_Compiler
{
    partial class LastScripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LastScripts));
            this.lst_scriptsCron = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_scriptsCron
            // 
            this.lst_scriptsCron.FormattingEnabled = true;
            this.lst_scriptsCron.Location = new System.Drawing.Point(0, 0);
            this.lst_scriptsCron.Name = "lst_scriptsCron";
            this.lst_scriptsCron.Size = new System.Drawing.Size(190, 225);
            this.lst_scriptsCron.TabIndex = 0;
            this.lst_scriptsCron.SelectedIndexChanged += new System.EventHandler(this.lst_scriptsCron_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close Window";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LastScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst_scriptsCron);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LastScripts";
            this.Text = "Last Scripts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_scriptsCron;
        private System.Windows.Forms.Button button1;
    }
}
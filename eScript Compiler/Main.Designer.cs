namespace eScript_Compiler
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_CompileScript = new System.Windows.Forms.Button();
            this.btn_CompileDir = new System.Windows.Forms.Button();
            this.btn_CompileAll = new System.Windows.Forms.Button();
            this.btn_SaveLog = new System.Windows.Forms.Button();
            this.rtb_TextEcompile = new System.Windows.Forms.RichTextBox();
            this.txt_ecompilePath = new System.Windows.Forms.TextBox();
            this.btn_ChooseEcompiler = new System.Windows.Forms.Button();
            this.bw_Compiler = new System.ComponentModel.BackgroundWorker();
            this.btn_lastScript = new System.Windows.Forms.Button();
            this.btn_lastFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tree_folders = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btn_CompileScript
            // 
            this.btn_CompileScript.Location = new System.Drawing.Point(12, 40);
            this.btn_CompileScript.Name = "btn_CompileScript";
            this.btn_CompileScript.Size = new System.Drawing.Size(110, 33);
            this.btn_CompileScript.TabIndex = 0;
            this.btn_CompileScript.Text = "Compile a Script";
            this.btn_CompileScript.UseVisualStyleBackColor = true;
            this.btn_CompileScript.Click += new System.EventHandler(this.btn_CompileScript_Click);
            // 
            // btn_CompileDir
            // 
            this.btn_CompileDir.Location = new System.Drawing.Point(230, 40);
            this.btn_CompileDir.Name = "btn_CompileDir";
            this.btn_CompileDir.Size = new System.Drawing.Size(110, 33);
            this.btn_CompileDir.TabIndex = 1;
            this.btn_CompileDir.Text = "Compile a Directory";
            this.btn_CompileDir.UseVisualStyleBackColor = true;
            this.btn_CompileDir.Click += new System.EventHandler(this.btn_CompileDir_Click);
            // 
            // btn_CompileAll
            // 
            this.btn_CompileAll.Location = new System.Drawing.Point(452, 40);
            this.btn_CompileAll.Name = "btn_CompileAll";
            this.btn_CompileAll.Size = new System.Drawing.Size(110, 33);
            this.btn_CompileAll.TabIndex = 2;
            this.btn_CompileAll.Text = "Compile All Script";
            this.btn_CompileAll.UseVisualStyleBackColor = true;
            this.btn_CompileAll.Click += new System.EventHandler(this.btn_CompileAll_Click);
            // 
            // btn_SaveLog
            // 
            this.btn_SaveLog.Location = new System.Drawing.Point(568, 40);
            this.btn_SaveLog.Name = "btn_SaveLog";
            this.btn_SaveLog.Size = new System.Drawing.Size(110, 33);
            this.btn_SaveLog.TabIndex = 3;
            this.btn_SaveLog.Text = "Save the Log";
            this.btn_SaveLog.UseVisualStyleBackColor = true;
            this.btn_SaveLog.Click += new System.EventHandler(this.btn_SaveLog_Click);
            // 
            // rtb_TextEcompile
            // 
            this.rtb_TextEcompile.BackColor = System.Drawing.Color.White;
            this.rtb_TextEcompile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_TextEcompile.Location = new System.Drawing.Point(140, 79);
            this.rtb_TextEcompile.Name = "rtb_TextEcompile";
            this.rtb_TextEcompile.ReadOnly = true;
            this.rtb_TextEcompile.Size = new System.Drawing.Size(538, 271);
            this.rtb_TextEcompile.TabIndex = 4;
            this.rtb_TextEcompile.Text = "";
            // 
            // txt_ecompilePath
            // 
            this.txt_ecompilePath.Location = new System.Drawing.Point(12, 12);
            this.txt_ecompilePath.Name = "txt_ecompilePath";
            this.txt_ecompilePath.ReadOnly = true;
            this.txt_ecompilePath.Size = new System.Drawing.Size(532, 20);
            this.txt_ecompilePath.TabIndex = 5;
            // 
            // btn_ChooseEcompiler
            // 
            this.btn_ChooseEcompiler.Location = new System.Drawing.Point(568, 12);
            this.btn_ChooseEcompiler.Name = "btn_ChooseEcompiler";
            this.btn_ChooseEcompiler.Size = new System.Drawing.Size(110, 20);
            this.btn_ChooseEcompiler.TabIndex = 6;
            this.btn_ChooseEcompiler.Text = "Choose ecompiler";
            this.btn_ChooseEcompiler.UseVisualStyleBackColor = true;
            this.btn_ChooseEcompiler.Click += new System.EventHandler(this.btn_ChooseEcompiler_Click);
            // 
            // bw_Compiler
            // 
            this.bw_Compiler.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_Compiler_DoWork);
            this.bw_Compiler.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_Compiler_ProgressChanged);
            this.bw_Compiler.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_Compiler_RunWorkerCompleted);
            // 
            // btn_lastScript
            // 
            this.btn_lastScript.Location = new System.Drawing.Point(140, 40);
            this.btn_lastScript.Name = "btn_lastScript";
            this.btn_lastScript.Size = new System.Drawing.Size(67, 33);
            this.btn_lastScript.TabIndex = 7;
            this.btn_lastScript.Text = "Last Script";
            this.btn_lastScript.UseVisualStyleBackColor = true;
            this.btn_lastScript.Click += new System.EventHandler(this.btn_lastScript_Click);
            // 
            // btn_lastFolder
            // 
            this.btn_lastFolder.Location = new System.Drawing.Point(361, 40);
            this.btn_lastFolder.Name = "btn_lastFolder";
            this.btn_lastFolder.Size = new System.Drawing.Size(67, 33);
            this.btn_lastFolder.TabIndex = 8;
            this.btn_lastFolder.Text = "Last Folder";
            this.btn_lastFolder.UseVisualStyleBackColor = true;
            this.btn_lastFolder.Click += new System.EventHandler(this.btn_lastFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Last Scripts / Folders";
            // 
            // tree_folders
            // 
            this.tree_folders.Location = new System.Drawing.Point(12, 125);
            this.tree_folders.Name = "tree_folders";
            this.tree_folders.Size = new System.Drawing.Size(110, 225);
            this.tree_folders.TabIndex = 11;
            this.tree_folders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tree_folders_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 362);
            this.Controls.Add(this.tree_folders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_lastFolder);
            this.Controls.Add(this.btn_lastScript);
            this.Controls.Add(this.btn_ChooseEcompiler);
            this.Controls.Add(this.txt_ecompilePath);
            this.Controls.Add(this.rtb_TextEcompile);
            this.Controls.Add(this.btn_SaveLog);
            this.Controls.Add(this.btn_CompileAll);
            this.Controls.Add(this.btn_CompileDir);
            this.Controls.Add(this.btn_CompileScript);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CompileScript;
        private System.Windows.Forms.Button btn_CompileDir;
        private System.Windows.Forms.Button btn_CompileAll;
        private System.Windows.Forms.Button btn_SaveLog;
        private System.Windows.Forms.RichTextBox rtb_TextEcompile;
        private System.Windows.Forms.TextBox txt_ecompilePath;
        private System.Windows.Forms.Button btn_ChooseEcompiler;
        private System.ComponentModel.BackgroundWorker bw_Compiler;
        private System.Windows.Forms.Button btn_lastScript;
        private System.Windows.Forms.Button btn_lastFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tree_folders;
    }
}


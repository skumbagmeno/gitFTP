namespace gitFTP {
    partial class Form1 {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label label1;
            this.repositoryInput = new System.Windows.Forms.RichTextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.initButton = new System.Windows.Forms.Button();
            this.repoPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.commitToInput = new System.Windows.Forms.ComboBox();
            this.commitList = new System.Windows.Forms.ListView();
            this.dataC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shaC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDiffButton = new System.Windows.Forms.Button();
            this.commitButton = new System.Windows.Forms.Button();
            this.commitInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.branchLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.repoInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startPublish = new System.Windows.Forms.Button();
            this.startBackup = new System.Windows.Forms.Button();
            this.deletedList = new System.Windows.Forms.CheckedListBox();
            this.editedList = new System.Windows.Forms.CheckedListBox();
            this.createdList = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.repoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(13, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 17);
            label1.TabIndex = 1;
            label1.Text = "Repository";
            // 
            // repositoryInput
            // 
            this.repositoryInput.Location = new System.Drawing.Point(12, 36);
            this.repositoryInput.Name = "repositoryInput";
            this.repositoryInput.Size = new System.Drawing.Size(408, 22);
            this.repositoryInput.TabIndex = 0;
            this.repositoryInput.Text = "E:\\Lavori\\Moreno\\grid";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(426, 36);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Seleziona";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // initButton
            // 
            this.initButton.Location = new System.Drawing.Point(507, 36);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(75, 23);
            this.initButton.TabIndex = 3;
            this.initButton.Text = "Inizializza";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // repoPanel
            // 
            this.repoPanel.BackColor = System.Drawing.Color.White;
            this.repoPanel.Controls.Add(this.label3);
            this.repoPanel.Controls.Add(this.commitToInput);
            this.repoPanel.Controls.Add(this.commitList);
            this.repoPanel.Controls.Add(this.startDiffButton);
            this.repoPanel.Controls.Add(this.commitButton);
            this.repoPanel.Controls.Add(this.commitInput);
            this.repoPanel.Controls.Add(this.label2);
            this.repoPanel.Controls.Add(this.statusLabel);
            this.repoPanel.Controls.Add(this.branchLabel);
            this.repoPanel.Controls.Add(this.pathLabel);
            this.repoPanel.Controls.Add(this.repoInfo);
            this.repoPanel.Location = new System.Drawing.Point(16, 77);
            this.repoPanel.Name = "repoPanel";
            this.repoPanel.Size = new System.Drawing.Size(670, 561);
            this.repoPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Seleziona il commit di arrivo";
            // 
            // commitToInput
            // 
            this.commitToInput.FormattingEnabled = true;
            this.commitToInput.Items.AddRange(new object[] {
            "HEAD",
            "master",
            "origin/master",
            "testing",
            "origin/testing"});
            this.commitToInput.Location = new System.Drawing.Point(158, 529);
            this.commitToInput.Name = "commitToInput";
            this.commitToInput.Size = new System.Drawing.Size(274, 21);
            this.commitToInput.TabIndex = 15;
            // 
            // commitList
            // 
            this.commitList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dataC,
            this.shaC,
            this.authorC,
            this.messageC});
            this.commitList.HideSelection = false;
            this.commitList.Location = new System.Drawing.Point(17, 118);
            this.commitList.Name = "commitList";
            this.commitList.Size = new System.Drawing.Size(637, 403);
            this.commitList.TabIndex = 14;
            this.commitList.UseCompatibleStateImageBehavior = false;
            this.commitList.View = System.Windows.Forms.View.Details;
            this.commitList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.commitList_ItemSelectionChanged);
            // 
            // dataC
            // 
            this.dataC.Text = "Data";
            this.dataC.Width = 121;
            // 
            // shaC
            // 
            this.shaC.Text = "SHA";
            this.shaC.Width = 138;
            // 
            // authorC
            // 
            this.authorC.Text = "Autore";
            this.authorC.Width = 128;
            // 
            // messageC
            // 
            this.messageC.Text = "Messaggio";
            this.messageC.Width = 244;
            // 
            // startDiffButton
            // 
            this.startDiffButton.Location = new System.Drawing.Point(445, 529);
            this.startDiffButton.Name = "startDiffButton";
            this.startDiffButton.Size = new System.Drawing.Size(75, 23);
            this.startDiffButton.TabIndex = 13;
            this.startDiffButton.Text = "Avvia";
            this.startDiffButton.UseVisualStyleBackColor = true;
            this.startDiffButton.Click += new System.EventHandler(this.startDiffButton_Click);
            // 
            // commitButton
            // 
            this.commitButton.Location = new System.Drawing.Point(411, 91);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(75, 23);
            this.commitButton.TabIndex = 10;
            this.commitButton.Text = "Lista commit";
            this.commitButton.UseVisualStyleBackColor = true;
            this.commitButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // commitInput
            // 
            this.commitInput.Location = new System.Drawing.Point(17, 92);
            this.commitInput.Name = "commitInput";
            this.commitInput.Size = new System.Drawing.Size(387, 20);
            this.commitInput.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inserisci l\'hash del commit oppure fai click su Lista commit per selezionare il c" +
    "ommit da cui far partire il diff";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.statusLabel.Location = new System.Drawing.Point(548, 14);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(33, 20);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "OK";
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLabel.Location = new System.Drawing.Point(94, 27);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(58, 13);
            this.branchLabel.TabIndex = 1;
            this.branchLabel.Text = "MASTER";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(84, 40);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(92, 13);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "WORKING PATH";
            // 
            // repoInfo
            // 
            this.repoInfo.AutoSize = true;
            this.repoInfo.Location = new System.Drawing.Point(14, 14);
            this.repoInfo.Name = "repoInfo";
            this.repoInfo.Size = new System.Drawing.Size(221, 39);
            this.repoInfo.TabIndex = 2;
            this.repoInfo.Text = "Il repository è stato correttamente inizializzato.\r\nCurrent branch:\r\nWorkingPath:" +
    "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.createdList);
            this.panel1.Controls.Add(this.editedList);
            this.panel1.Controls.Add(this.deletedList);
            this.panel1.Controls.Add(this.startPublish);
            this.panel1.Controls.Add(this.startBackup);
            this.panel1.Location = new System.Drawing.Point(692, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 650);
            this.panel1.TabIndex = 5;
            // 
            // startPublish
            // 
            this.startPublish.Location = new System.Drawing.Point(184, 615);
            this.startPublish.Name = "startPublish";
            this.startPublish.Size = new System.Drawing.Size(110, 23);
            this.startPublish.TabIndex = 8;
            this.startPublish.Text = "Pubblica";
            this.startPublish.UseVisualStyleBackColor = true;
            // 
            // startBackup
            // 
            this.startBackup.Location = new System.Drawing.Point(68, 615);
            this.startBackup.Name = "startBackup";
            this.startBackup.Size = new System.Drawing.Size(110, 23);
            this.startBackup.TabIndex = 7;
            this.startBackup.Text = "Esegui Backup";
            this.startBackup.UseVisualStyleBackColor = true;
            this.startBackup.Click += new System.EventHandler(this.startBackup_Click);
            // 
            // deletedList
            // 
            this.deletedList.FormattingEnabled = true;
            this.deletedList.Location = new System.Drawing.Point(13, 370);
            this.deletedList.Name = "deletedList";
            this.deletedList.Size = new System.Drawing.Size(321, 139);
            this.deletedList.TabIndex = 9;
            // 
            // editedList
            // 
            this.editedList.FormattingEnabled = true;
            this.editedList.Location = new System.Drawing.Point(13, 203);
            this.editedList.Name = "editedList";
            this.editedList.Size = new System.Drawing.Size(321, 139);
            this.editedList.TabIndex = 10;
            // 
            // createdList
            // 
            this.createdList.FormattingEnabled = true;
            this.createdList.Location = new System.Drawing.Point(13, 35);
            this.createdList.Name = "createdList";
            this.createdList.Size = new System.Drawing.Size(321, 139);
            this.createdList.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "File creati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "File modificati";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "File eliminati";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 539);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 574);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 574);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Host";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.repoPanel);
            this.Controls.Add(this.initButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(label1);
            this.Controls.Add(this.repositoryInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.repoPanel.ResumeLayout(false);
            this.repoPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox repositoryInput;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Panel repoPanel;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Label repoInfo;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.TextBox commitInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startDiffButton;
        private System.Windows.Forms.ListView commitList;
        private System.Windows.Forms.ColumnHeader dataC;
        private System.Windows.Forms.ColumnHeader shaC;
        private System.Windows.Forms.ColumnHeader authorC;
        private System.Windows.Forms.ColumnHeader messageC;
        private System.Windows.Forms.ComboBox commitToInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startPublish;
        private System.Windows.Forms.Button startBackup;
        private System.Windows.Forms.CheckedListBox deletedList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox createdList;
        private System.Windows.Forms.CheckedListBox editedList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


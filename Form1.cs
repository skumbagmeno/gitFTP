using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using LibGit2Sharp;

namespace gitFTP {
    public partial class Form1 : Form {
        private GitHandler gh;
        private bool backup = false;

        public Form1() {
            InitializeComponent();
            repoPanel.Visible = false;
            this.gh = new GitHandler();
        }

        private void initializePanel () {
            repoPanel.Visible = true;
            branchLabel.Text = this.gh.getCurrentBranch();
            pathLabel.Text = this.gh.getRepositoryWorkingPath();
            if (!this.gh.retrieveStatus()) {
                statusLabel.Text = "DIRTY";
                statusLabel.ForeColor = Color.DarkRed;
            } else {
                statusLabel.Text = "OK";
                statusLabel.ForeColor = Color.DarkGreen;
            }
            List<RepoFile> createdFiles = this.gh.getFiles(GitHandler.TYPE_CREATE);
            List<RepoFile> editedFiles = this.gh.getFiles(GitHandler.TYPE_EDIT);
            List<RepoFile> deletedFiles = this.gh.getFiles(GitHandler.TYPE_DELETE);
        }

        private void button1_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Seleziona la cartella che contiene il repository";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                repositoryInput.Text = fbd.SelectedPath;
                initButton.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            repoPanel.Visible = false;
            if (this.gh.initializeRepository(repositoryInput.Text)) {
                this.initializePanel();
            } else {
                MessageBox.Show(this.gh.getLastError());
            }
        }

        private void commitButton_Click(object sender, EventArgs e) {
            List<Commit> list = this.gh.getCommitList();
            commitList.Items.Clear();
            foreach (Commit c in list) {
                string[] a = { c.Author.When.ToString("yyyy/MM/dd HH:mm:ss"), c.Sha, c.Author.Name, c.Message };
                ListViewItem lvi = new ListViewItem(a);
                commitList.Items.Add(lvi);
            }
        }

        private void startDiffButton_Click(object sender, EventArgs e) {
            createdList.Items.Clear();
            editedList.Items.Clear();
            deletedList.Items.Clear();
            this.backup = false;
            if (!string.IsNullOrEmpty(commitInput.Text) && !string.IsNullOrEmpty(commitToInput.Text)) {
                TreeChanges tc = this.gh.getDiff<TreeChanges>(commitInput.Text, commitToInput.Text);
                if (tc != null) {
                    foreach (TreeEntryChanges tec in tc.Added) {
                        createdList.Items.Add(tec.Path);
                    }
                    this.selectAll(createdList);
                    foreach (TreeEntryChanges tec in tc.Modified) {
                        editedList.Items.Add(tec.Path);
                    }
                    this.selectAll(editedList);
                    foreach (TreeEntryChanges tec in tc.Deleted) {
                        deletedList.Items.Add(tec.Path);
                    }
                    this.selectAll(deletedList);
                }
            }
        }

        private void selectAll (CheckedListBox chk) {
            for (int i = 0; i < chk.Items.Count; i++) {
                chk.SetItemChecked(i, true);
            }
        }

        private void unselectAll (CheckedListBox chk) {
            for (int i = 0; i < chk.Items.Count; i++) {
                chk.SetItemChecked(i, true);
            }
        }

        private void commitList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (commitList.SelectedItems.Count > 0) {
                ListViewItem sel = commitList.SelectedItems[0];
                commitInput.Text = sel.SubItems[1].Text;
            }
        }

        private void startBackup_Click(object sender, EventArgs e) {
            List<string> filesToBackup = new List<string>();
            if (editedList.Items.Count > 0 || deletedList.Items.Count > 0) {
                foreach (ListViewItem l in editedList.Items) {
                    filesToBackup.Add(l.Text);
                }
                foreach (ListViewItem l in deletedList.Items) {
                    filesToBackup.Add(l.Text);
                }

            }
            this.backup = true;
        }
    }
}

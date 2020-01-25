using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using LibGit2Sharp;

namespace gitFTP {
    class GitHandler {
        private Repository repository;
        private bool isConnected;
        private string lastError = "";
        private RepositoryStatus status;

        public const string TYPE_CREATE = "created";
        public const string TYPE_EDIT = "edited";
        public const string TYPE_DELETE = "deleted";

        public bool initializeRepository (string r) {
            this.lastError = "Repository non valido";
            this.isConnected = false;
            if (!string.IsNullOrWhiteSpace(r)) {
                try {
                    this.repository = new Repository(@r);
                    this.isConnected = true;
                    this.lastError = "";
                    return true;                    
                } catch (Exception  e) {
                    this.lastError = "La cartella selezionata non contiene un repository di Git!";
                }
            }
            return false;
        }

        public dynamic getDiff<T> (string from, string to) {
            Commit commitFrom = this.repository.Lookup<Commit>(from);
            Commit commitTo = null;
            if (string.Equals(to, "HEAD")) {
                commitTo = this.repository.Head.Tip;
            } else {
                if (this.repository.Branches[to] != null) {
                    commitTo = this.repository.Branches[to].Tip;
                } else {
                    commitTo = this.repository.Lookup<Commit>(to);
                }
            }
            if (commitTo == null) {
                MessageBox.Show("Commit target non valido!");
                return null;
            }
            return this.repository.Diff.Compare<TreeChanges>(commitFrom.Tree, commitTo.Tree);
        }

        public List<RepoFile> getFiles (string type = null) {
            List<RepoFile> list = new List<RepoFile>();
            switch (type) {
                case GitHandler.TYPE_CREATE:
                    
                    break;
                case GitHandler.TYPE_EDIT:
                    break;
                case GitHandler.TYPE_DELETE:
                    break;
                default:
                    break;
            }
            return list;
        }

        public bool retrieveStatus() {
            this.status = this.repository.RetrieveStatus();
            return (status.IsDirty) ? false : true;
        }

        public string getRepositoryWorkingPath () {
            string ret = "";
            if (this.isConnected) {
                ret = this.repository.Info.Path;
            }
            return ret;
        }

        public string getCurrentBranch () {
            string ret = "";
            if (this.isConnected) {
                ret = this.repository.Head.FriendlyName;
            }
            return ret;
        }

        public List<string> getBranches () {
            List<string> branches = new List<string>();
            if (this.isConnected) {
                foreach (Branch branch in this.repository.Branches) {
                    branches.Add(branch.FriendlyName);
                }
            }
            return branches;
        }

        public List<Commit> getCommitList () {
            List<Commit> list = new List<Commit>();
            if (this.isConnected) {
                CommitFilter cf = new CommitFilter { FirstParentOnly = true, SortBy = CommitSortStrategies.Time };
                foreach (Commit c in this.repository.Commits.QueryBy(cf)) {
                    list.Add(c);
                }
            }
            return list;
        }

        public string getLastError () {
            return this.lastError;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitFTP {
    class RepoFile {
        string fileName;
        string type;

        public RepoFile (string fileName, string type) {
            this.fileName = fileName;
            this.type = type;
        }
    }
}

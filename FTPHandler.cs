using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace gitFTP {
    class FTPHandler {
        private FtpWebRequest request;

        public FTPHandler (string target, string username, string password) {
            this.request = (FtpWebRequest)WebRequest.Create(target);
            this.request.Credentials = new NetworkCredential(username, password);
        }
        public void downloadFile () {

        }
    }
}

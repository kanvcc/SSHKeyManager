using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSHKeyManager
{
    public static class Extension
    {
        public static string GetFileContext(this string path)
        {
            string _strReturn = string.Empty;
            if (File.Exists(path))
            {
                _strReturn = File.ReadAllText(path, Encoding.Default);
            }
            return _strReturn;
        }
    }
}

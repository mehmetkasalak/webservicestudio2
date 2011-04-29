using System.IO;
using System.Windows.Forms;

namespace WebServiceStudio.Utils
{
    class File
    {
        static public bool SaveFile(IWin32Window parentWindow, string fileName, string contents)
        {
            if (System.IO.File.Exists(fileName))
            {
                if (MessageBox.Show(parentWindow, "File " + fileName + " already exists. Overwrite?", "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return false;
            }
            FileStream stream = System.IO.File.OpenWrite(fileName);
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(contents);
            writer.Flush();
            stream.SetLength(stream.Position);
            stream.Close();
            return true;
        }
    }
}

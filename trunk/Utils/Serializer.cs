using System.Text;
using System.Windows.Forms;

namespace WebServiceStudio.Utils
{
    class Serializer
    {
        static public string SerializeToString(TreeNodeCollection treeNodeCollection)
        {
            StringBuilder sb = new StringBuilder();
            serializeToString(treeNodeCollection, string.Empty, sb);
            return sb.ToString();
        }

        static private void serializeToString(TreeNodeCollection tnc, string tab, StringBuilder sb)
        {
            foreach(TreeNode tn in tnc)
            {
                sb.Append(tab);
                sb.AppendLine(tn.Text);
                serializeToString(tn.Nodes, tab + " ", sb);
            }
        }
    }
}

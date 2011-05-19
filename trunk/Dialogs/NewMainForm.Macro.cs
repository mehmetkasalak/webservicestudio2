using System;
using WebServiceStudio.Utils;
using System.Windows.Forms;
using System.Reflection;

namespace WebServiceStudio.Dialogs
{
    partial class NewMainForm
    {
        private void buttonMacroPlay_Click(object sender, EventArgs e)
        {
            if (((Control.ModifierKeys & Keys.Shift) == Keys.Shift) || string.IsNullOrEmpty(macroFile))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;
                dialog.Multiselect = false;
                dialog.Filter = "Text files (*.txt)|*.txt|Macro files (*.macro)|*.macro|All files (*.*)|*.*";
                dialog.Title = "Select a macro file to play";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    macroFile = dialog.FileName;
                else
                    return;
            }
            if (!string.IsNullOrEmpty(macroFile))
            {
                MacroPlayer macroPlayer = new MacroPlayer(this, macroFile);
                macroPlayer.Play();
            }
        }

        public void macroPlayGetWsdl(string uri, MacroPlayer.MacroCallbackType macroCallbackType)
        {
            macroCallback = macroCallbackType;
            comboEndPointUri.Text = uri;
            buttonGet.PerformClick();
        }

        internal void macroPlayInvoke(string method, MacroPlayer.MacroCallbackType macroCallbackType)
        {
            macroCallback = macroCallbackType;
            if (macroPlaySelectNode(method, treeMethods.Nodes, treeMethods) != null)
                buttonInvoke.PerformClick();
        }

        private TreeNode macroPlaySelectNode(string method, TreeNodeCollection trc, TreeView view)
        {
            int c = method.IndexOf('\'');
            if (c > 0)
            {
                string m = method.Substring(c + 1);
                method = method.Substring(0, c);
                c = Int32.Parse(m);
            }
            else
            {
                c = 1;
            }

            TreeNode[] tns = trc.Find(method, true);
            if (tns.Length > 0)
            {
                view.SelectedNode = tns[c - 1];
                return view.SelectedNode;
            }
            return null;
        }

        internal void macroResetCallback()
        {
            macroCallback = null;
        }

        internal void macroPlaySetInput(string method, string field, string value, MacroPlayer.MacroCallbackType macroCallbackType)
        {
            macroCallback = macroCallbackType;
            if (macroPlaySelectNode(method, treeMethods.Nodes, treeMethods) != null)
            {
                TreeNode body = treeInput.Nodes.Find("Body", true)[0];

                foreach (TreeNode tn in body.Nodes)
                {
                    TreeNodeProperty tnp = (tn.Tag as TreeNodeProperty);
                    if (tnp != null)
                    {
                        if (string.Compare(field, tnp.Name, StringComparison.InvariantCultureIgnoreCase) == 0)
                        {
                            treeInput.SelectedNode = tn;
                            object ovalue = value;
                            if (!tnp.Type.Equals(typeof(String)))
                            {
                                if (tnp.Type.Equals(typeof(DateTime)) && value.Equals("TODAY"))
                                {
                                    value = DateTime.Now.ToString("yyyy-MM-dd");
                                }

                                MethodInfo[] mi = tnp.Type.GetMethods();
                                foreach (MethodInfo m in mi)
                                {
                                    if ("Parse".Equals(m.Name))
                                    {
                                        ParameterInfo[] pi = m.GetParameters();
                                        if ((pi.Length == 1) && (pi[0].ParameterType.Equals(typeof(String))))
                                        {
                                            ovalue = m.Invoke(m, new object[] { value });
                                            break;
                                        }
                                    }
                                }
                            }
                            TreeNodeProperty property2 = TreeNodeProperty.CreateTreeNodeProperty(tnp, ovalue);
                            property2.TreeNode = tnp.TreeNode;
                            property2.RecreateSubtree(null);
                            this.treeInput.SelectedNode = property2.TreeNode;
                            macroCallback.Invoke();
                        }
                    }
                }
            }
        }

        internal void macroPlayCopy(string output, string fieldOut, string method, string fieldIn, MacroPlayer.MacroCallbackType macroCallbackType)
        {
            macroCallback = macroCallbackType;
            string v = macroPlayGetValue(output, fieldOut, treeOutput.Nodes);
            macroPlaySetInput(method, fieldIn, v, macroCallbackType);
        }

        internal string macroPlayGetValue(string output, string field, TreeNodeCollection trc)
        {
            int counter = field.IndexOf('\'');
            if (counter > 0)
            {
                string m = field.Substring(counter + 1);
                field = field.Substring(0, counter);
                counter = Int32.Parse(m);
            }
            return macroPlayGetValue(output, field, trc, ref counter);
        }

        internal string macroPlayGetValue(string output, string field, TreeNodeCollection trc, ref int counter)
        {
            string s = string.Empty;

            foreach (TreeNode tn in trc)
            {
                TreeNodeProperty tnp = (tn.Tag as TreeNodeProperty);
                if (tnp != null)
                {
                    if (string.Compare(field, tnp.Name, StringComparison.InvariantCultureIgnoreCase) == 0)
                    {
                        if (counter > 1)
                        {
                            counter--;
                            continue;
                        }
                        treeOutput.SelectedNode = tn;

                        ClassProperty cp = tn.Tag as ClassProperty;
                        if (cp != null)
                            return cp.InternalValue.ToString();

                        PrimitiveProperty pp = tn.Tag as PrimitiveProperty;
                        if (pp != null)
                            return pp.Value.ToString();

                        throw new ApplicationException("Unsupported type in macroPlayGetValue");
                    }
                }
                s = macroPlayGetValue(output, field, tn.Nodes, ref counter);

                if (!string.IsNullOrEmpty(s))
                    break;
            }
            return s;
        }

        public string macroPlayLogO(string output, string field)
        {
            return macroPlayGetValue(output, field, treeOutput.Nodes);
        }

        public bool macroPlayTest(string output, string field, string value)
        {
            string v = macroPlayGetValue(output, field, treeOutput.Nodes);
            return (string.Compare(v, value, StringComparison.InvariantCultureIgnoreCase) == 0);
        }

        public string macroPlayLogT(MacroPlayer.Trees t)
        {
            string s = string.Empty;
            switch (t)
            {
                case MacroPlayer.Trees.METHODS:
                    if (treeMethods.Nodes.Count > 0)
                        s = Serializer.SerializeToString(treeMethods.Nodes);
                    break;
                case MacroPlayer.Trees.INPUT:
                    if (treeInput.SelectedNode != null)
                        s = Serializer.SerializeToString(treeInput.Nodes);
                    break;
                case MacroPlayer.Trees.OUTPUT:
                    if (treeOutput.Nodes.Count > 0)
                        s = Serializer.SerializeToString(treeOutput.Nodes);
                    break;
            }
            return s;
        }

    }
}

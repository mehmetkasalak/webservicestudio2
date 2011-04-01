using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Web.Services.Protocols;
using System.Net;
using WebServiceStudio.Dialogs;
using System.Xml.Serialization;

namespace WebServiceStudio.Dialogs
{
    public partial class NewMainForm : Form
    {
        private static NewMainForm newMainForm;
        private Wsdl wsdl = null;
        private string stringToFind = string.Empty;

        public NewMainForm()
        {
            InitializeComponent();
            Text = string.Format("{0} version {1}", AboutBox.AssemblyTitle, AboutBox.AssemblyVersion);
            wsdl = new Wsdl();
            Control.CheckForIllegalCrossThreadCalls = false;
            richWsdl.Font = Configuration.MasterConfig.UiSettings.WsdlFont;
            comboEndPointUri.Items.AddRange(Configuration.MasterConfig.InvokeSettings.RecentlyUsedUris);
            if (comboEndPointUri.Items.Count > 0)
                comboEndPointUri.SelectedIndex = 0;
            richMessage.Font = Configuration.MasterConfig.UiSettings.MessageFont;
            richRequest.Font = Configuration.MasterConfig.UiSettings.ReqRespFont;
            richResponse.Font = Configuration.MasterConfig.UiSettings.ReqRespFont;
        }

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Version version = typeof(string).Assembly.GetName().Version;
            newMainForm = new NewMainForm();
            WSSWebRequestCreate.RegisterPrefixes();
            Application.Run(newMainForm);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            if ((this.saveAllDialog.ShowDialog() == DialogResult.OK) && ((((this.wsdl.Wsdls != null) && (this.wsdl.Wsdls.Count != 0)) || ((this.wsdl.Xsds != null) && (this.wsdl.Xsds.Count != 0))) || (this.wsdl.ProxyCode != null)))
            {
                int length = this.saveAllDialog.FileName.LastIndexOf('.');
                string str = (length >= 0) ? this.saveAllDialog.FileName.Substring(0, length) : this.saveAllDialog.FileName;
                if (this.wsdl.Wsdls.Count == 1)
                {
                    Utils.File.SaveFile(this, str + ".wsdl", this.wsdl.Wsdls[0]);
                }
                else
                {
                    for (int i = 0; i < this.wsdl.Wsdls.Count; i++)
                    {
                        Utils.File.SaveFile(this, str + i.ToString() + ".wsdl", this.wsdl.Wsdls[i]);
                    }
                }
                if (this.wsdl.Xsds.Count == 1)
                {
                    Utils.File.SaveFile(this, str + ".xsd", this.wsdl.Xsds[0]);
                }
                else
                {
                    for (int j = 0; j < this.wsdl.Xsds.Count; j++)
                    {
                        Utils.File.SaveFile(this, str + j.ToString() + ".xsd", wsdl.Xsds[j]);
                    }
                }
                Utils.File.SaveFile(this, str + "." + wsdl.ProxyFileExtension, wsdl.ProxyCode);
                Utils.File.SaveFile(this, str + "Client." + wsdl.ProxyFileExtension, 
                    Script.GetUsingCode(wsdl.WsdlProperties.Language) + "\n" + GenerateClientCode() + "\n" + 
                    Script.GetDumpCode(wsdl.WsdlProperties.Language));
            }
        }
        
        private string GenerateClientCode()
        {
            Script script = new Script(wsdl.ProxyNamespace, "MainClass");
            foreach (TreeNode node in treeMethods.Nodes)
            {
                script.Proxy = GetProxyPropertyFromNode(node).GetProxy();
                foreach (TreeNode node2 in node.Nodes)
                {
                    TreeNode tag = node2.Tag as TreeNode;
                    if (tag != null)
                    {
                        MethodProperty property = tag.Tag as MethodProperty;
                        if (property != null)
                        {
                            MethodInfo method = property.GetMethod();
                            object[] parameters = property.ReadChildren() as object[];
                            script.AddMethod(method, parameters);
                        }
                    }
                }
            }
            return script.Generate(this.wsdl.GetCodeGenerator);
        }

        private ProxyProperty GetProxyPropertyFromNode(TreeNode treeNode)
        {
            while (treeNode.Parent != null)
            {
                treeNode = treeNode.Parent;
            }
            TreeNode tag = treeNode.Tag as TreeNode;
            if (tag != null)
            {
                return (tag.Tag as ProxyProperty);
            }
            return null;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFind.Text))
            {
                string text = textBoxFind.Text.Trim();

                if (!stringToFind.Equals(text))
                    richWsdl.SelectionStart = 0;

                stringToFind = text;
                Find();
            }
            else
            {
                textBoxFind.Focus();
            }
        }

        private void Find()
        {
            if (!string.IsNullOrEmpty(stringToFind))
            {
                tabMain.SelectedTab = tabPageWsdl;
                richWsdl.Find(stringToFind, richWsdl.SelectionStart + richWsdl.SelectionLength, RichTextBoxFinds.None);
            }
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            new OptionDialog().ShowDialog(this);
        }

        private void comboEndPointUri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '\r') || (e.KeyChar == '\n'))
            {
                buttonGet_Click(sender, null);
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                comboEndPointUri.SelectedText = e.KeyChar.ToString();
                e.Handled = true;
                string text = this.comboEndPointUri.Text;
                if ((text != null) && (text.Length != 0))
                {
                    for (int i = 0; i < this.comboEndPointUri.Items.Count; i++)
                    {
                        if (((string)this.comboEndPointUri.Items[i]).StartsWith(text))
                        {
                            this.comboEndPointUri.SelectedIndex = i;
                            this.comboEndPointUri.Select(text.Length, this.comboEndPointUri.Text.Length);
                            break;
                        }
                    }
                }
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            if (this.buttonGet.Text == "Get")
            {
                string text = this.comboEndPointUri.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    ClearAllTabs();
                    TabPage selectedTab = this.tabMain.SelectedTab;
                    tabMain.SelectedTab = this.tabPageMessage;
                    wsdl.Reset();
                    wsdl.Paths.Add(text);
                    new Thread(new ThreadStart(this.wsdl.Generate)).Start();
                    buttonGet.Text = "Cancel";
                }
            }
            else
            {
                buttonGet.Text = "Get";
                ShowMessageInternal(this, MessageType.Failure, "Cancelled");
                wsdl.Reset();
                wsdl = new Wsdl();
            }

        }
        private void ClearAllTabs()
        {
            buttonSaveAll.Enabled = false;
            buttonFind.Enabled = false;
            buttonCopy.Enabled = false;
            buttonPaste.Enabled = false;
            buttonOutputCopy.Enabled = false;
            richWsdl.Clear();
            richWsdl.Font = Configuration.MasterConfig.UiSettings.WsdlFont;
            treeWsdl.Nodes.Clear();
            richMessage.Clear();
            richMessage.Font = Configuration.MasterConfig.UiSettings.MessageFont;
            richRequest.Clear();
            richRequest.Font = Configuration.MasterConfig.UiSettings.ReqRespFont;
            richResponse.Clear();
            richResponse.Font = Configuration.MasterConfig.UiSettings.ReqRespFont;
            treeMethods.Nodes.Clear();
            TreeNodeProperty.ClearIncludedTypes();
            treeInput.Nodes.Clear();
            treeOutput.Nodes.Clear();
            propInput.SelectedObject = null;
            propOutput.SelectedObject = null;
        }

        private void ShowMessageInternal(object sender, MessageType status, string message)
        {
            if (message == null)
            {
                message = status.ToString();
            }
            switch (status)
            {
                case MessageType.Begin:
                    this.richMessage.SelectionColor = Color.Blue;
                    this.richMessage.AppendText(message + "\n");
                    this.richMessage.Update();
                    break;

                case MessageType.Success:
                    this.richMessage.SelectionColor = Color.Green;
                    this.richMessage.AppendText(message + "\n");
                    this.richMessage.Update();
                    if (sender == this.wsdl)
                    {
                        base.BeginInvoke(new WsdlGenerationDoneCallback(WsdlGenerationDone), new object[] { true });
                    }
                    break;

                case MessageType.Failure:
                    this.richMessage.SelectionColor = Color.Red;
                    this.richMessage.AppendText(message + "\n");
                    this.richMessage.Update();
                    if (sender == this.wsdl)
                    {
                        base.BeginInvoke(new WsdlGenerationDoneCallback(WsdlGenerationDone), new object[] { false });
                    }
                    break;

                case MessageType.Warning:
                    this.richMessage.SelectionColor = Color.DarkRed;
                    this.richMessage.AppendText(message + "\n");
                    this.richMessage.Update();
                    break;

                case MessageType.Error:
                    this.richMessage.SelectionColor = Color.Red;
                    this.richMessage.AppendText(message + "\n");
                    this.richMessage.Update();
                    break;
            }
        }

        private void FillWsdlTab()
        {
            if ((wsdl.Wsdls != null) && (wsdl.Wsdls.Count != 0))
            {
                int num3;
                richWsdl.Text = wsdl.Wsdls[0];
                treeWsdl.Nodes.Clear();
                TreeNode node = treeWsdl.Nodes.Add("WSDLs");
                XmlTreeWriter writer = new XmlTreeWriter();
                for (int i = 0; i < wsdl.Wsdls.Count; i++)
                {
                    num3 = i + 1;
                    TreeNode root = node.Nodes.Add("WSDL#" + num3.ToString());
                    root.Tag = wsdl.Wsdls[i];
                    writer.FillTree(wsdl.Wsdls[i], root);
                }
                TreeNode node3 = treeWsdl.Nodes.Add("Schemas");
                for (int j = 0; j < wsdl.Xsds.Count; j++)
                {
                    num3 = j + 1;
                    TreeNode node4 = node3.Nodes.Add("Schema#" + num3.ToString());
                    node4.Tag = wsdl.Xsds[j];
                    writer.FillTree(wsdl.Xsds[j], node4);
                }
                treeWsdl.Nodes.Add("Proxy").Tag = wsdl.ProxyCode;
                treeWsdl.Nodes.Add("ClientCode").Tag = "Shows client code for all methods accessed in the invoke tab";
                node.Expand();
                buttonFind.Enabled = true;
                buttonSaveAll.Enabled = true;
            }
        }

        private void FillInvokeTab()
        {
            Assembly proxyAssembly = wsdl.ProxyAssembly;
            if (proxyAssembly != null)
            {
                treeMethods.Nodes.Clear();
                foreach (System.Type type in proxyAssembly.GetTypes())
                {
                    if (TreeNodeProperty.IsWebService(type))
                    {
                        TreeNode node = treeMethods.Nodes.Add(type.Name);
                        HttpWebClientProtocol proxy = (HttpWebClientProtocol)Activator.CreateInstance(type);
                        ProxyProperty property = new ProxyProperty(proxy);
                        property.RecreateSubtree(null);
                        node.Tag = property.TreeNode;
                        proxy.Credentials = CredentialCache.DefaultCredentials;
                        SoapHttpClientProtocol protocol2 = proxy as SoapHttpClientProtocol;
                        if (protocol2 != null)
                        {
                            protocol2.CookieContainer = new CookieContainer();
                            protocol2.AllowAutoRedirect = true;
                        }
                        foreach (MethodInfo info in type.GetMethods())
                        {
                            if (TreeNodeProperty.IsWebMethod(info))
                            {
                                node.Nodes.Add(info.Name).Tag = info;
                            }
                        }
                    }
                }
                this.treeMethods.ExpandAll();
            }
        }

        private void WsdlGenerationDone(bool genDone)
        {
            buttonGet.Text = "Get";
            FillWsdlTab();
            if (genDone)
            {
                ShowMessageInternal(this, MessageType.Begin, "Reflecting Proxy Assembly");
                FillInvokeTab();
                tabMain.SelectedTab = this.tabPageInvoke;
                ShowMessageInternal(this, MessageType.Success, "Ready To Invoke");
                Configuration.MasterConfig.InvokeSettings.AddUri(this.comboEndPointUri.Text);
                comboEndPointUri.Items.Clear();
                comboEndPointUri.Items.AddRange(Configuration.MasterConfig.InvokeSettings.RecentlyUsedUris);
            }
        }
        private delegate void WsdlGenerationDoneCallback(bool genDone);

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (this.openWsdlDialog.ShowDialog(this) == DialogResult.OK)
            {
                comboEndPointUri.Text = openWsdlDialog.FileName;
            }
        }

        public static void ShowMessage(object sender, MessageType status, string message)
        {
            if (newMainForm != null)
            {
                newMainForm.ShowMessageInternal(sender, status, message);
            }
        }

        private void buttonInvoke_Click(object sender, EventArgs e)
        {
            Cursor cursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                propOutput.SelectedObject = null;
                treeOutput.Nodes.Clear();
                InvokeWebMethod();
            }
            finally
            {
                this.Cursor = cursor;
            }
        }

        private void InvokeWebMethod()
        {
            MethodProperty currentMethodProperty = GetCurrentMethodProperty();
            if (currentMethodProperty != null)
            {
                HttpWebClientProtocol proxy = currentMethodProperty.GetProxyProperty().GetProxy();
                RequestProperties properties = new RequestProperties(proxy);
                try
                {
                    MethodInfo method = currentMethodProperty.GetMethod();
                    System.Type declaringType = method.DeclaringType;
                    WSSWebRequest.RequestTrace = properties;
                    object[] parameters = currentMethodProperty.ReadChildren() as object[];
                    object result = method.Invoke(proxy, BindingFlags.Public, null, parameters, null);
                    treeOutput.Nodes.Clear();
                    MethodProperty property2 = new MethodProperty(currentMethodProperty.GetProxyProperty(), method, result, parameters);
                    property2.RecreateSubtree(null);
                    treeOutput.Nodes.Add(property2.TreeNode);
                    treeOutput.ExpandAll();
                }
                finally
                {
                    WSSWebRequest.RequestTrace = null;
                    propRequest.SelectedObject = properties;
                    richRequest.Text = properties.requestPayLoad;
                    richResponse.Text = properties.responsePayLoad;
                }
            }
        }

        private MethodProperty GetCurrentMethodProperty()
        {
            if ((this.treeInput.Nodes == null) || (treeInput.Nodes.Count == 0))
            {
                MessageBox.Show(this, "Select a web method to execute");
                return null;
            }
            TreeNode node = treeInput.Nodes[0];
            MethodProperty tag = node.Tag as MethodProperty;
            if (tag == null)
            {
                MessageBox.Show(this, "Select a method to execute");
                return null;
            }
            return tag;
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab == this.tabPageRaw)
            {
                if (this.propRequest.SelectedObject == null)
                {
                    this.propRequest.SelectedObject = new RequestProperties(null);
                }
            }
            else if (((this.tabMain.SelectedTab == this.tabPageWsdl) && (this.treeWsdl.Nodes != null)) && (this.treeWsdl.Nodes.Count != 0))
            {
                TreeNode node = this.treeWsdl.Nodes[3];
                node.Tag = this.GenerateClientCode();
                if (this.treeWsdl.SelectedNode == node)
                {
                    this.richWsdl.Text = node.Tag.ToString();
                }
            }
        }

        private void SetupAssemblyResolver()
        {
            ResolveEventHandler handler = new ResolveEventHandler(this.OnAssemblyResolve);
            AppDomain.CurrentDomain.AssemblyResolve += handler;
        }

        public Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
        {
            Assembly proxyAssembly = this.wsdl.ProxyAssembly;
            if ((proxyAssembly != null) && (proxyAssembly.GetName().ToString() == args.Name))
            {
                return proxyAssembly;
            }
            return null;
        }

        private void CopyToClipboard(TreeNodeProperty tnp)
        {
            if (!IsValidCopyNode(tnp))
            {
                throw new Exception("Cannot copy from here");
            }
            object o = tnp.ReadChildren();
            if (o != null)
            {
                StringWriter writer = new StringWriter();
                System.Type[] extraTypes = new System.Type[] { o.GetType() };
                System.Type type = (o is DataSet) ? typeof(DataSet) : typeof(object);
                new XmlSerializer(type, extraTypes).Serialize((TextWriter)writer, o);
                Clipboard.SetDataObject(writer.ToString());
            }
        }

        private bool IsValidCopyNode(TreeNodeProperty tnp)
        {
            return (((tnp != null) && (tnp.TreeNode.Parent != null)) && (tnp.GetType() != typeof(TreeNodeProperty)));
        }

        private bool IsValidPasteNode(TreeNodeProperty tnp)
        {
            IDataObject dataObject = Clipboard.GetDataObject();
            if ((dataObject == null) || (dataObject.GetData(DataFormats.Text) == null))
            {
                return false;
            }
            return this.IsValidCopyNode(tnp);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            this.SendWebRequest();
        }

        private void DumpResponse(HttpWebResponse response)
        {
            this.richResponse.Text = WSSWebResponse.DumpResponse(response);
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            this.openWsdlDialog.ShowDialog();
            string fileName = this.openWsdlDialog.FileName;
            Cursor cursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.wsdl.Reset();
                this.wsdl.Paths.Add(fileName);
                this.wsdl.Generate();
                this.FillWsdlTab();
                this.FillInvokeTab();
            }
            finally
            {
                this.Cursor = cursor;
            }
        }

        private void SendWebRequest()
        {
            Encoding encoding = new UTF8Encoding(true);
            RequestProperties selectedObject = this.propRequest.SelectedObject as RequestProperties;
            HttpWebRequest request = (HttpWebRequest)WebRequest.CreateDefault(new Uri(selectedObject.Url));
            if ((selectedObject.HttpProxy != null) && (selectedObject.HttpProxy.Length != 0))
            {
                request.Proxy = new WebProxy(selectedObject.HttpProxy);
            }
            request.Method = selectedObject.Method.ToString();
            request.ContentType = selectedObject.ContentType;
            request.Headers["SOAPAction"] = selectedObject.SOAPAction;
            request.SendChunked = selectedObject.SendChunked;
            request.AllowAutoRedirect = selectedObject.AllowAutoRedirect;
            request.AllowWriteStreamBuffering = selectedObject.AllowWriteStreamBuffering;
            request.KeepAlive = selectedObject.KeepAlive;
            request.Pipelined = selectedObject.Pipelined;
            request.PreAuthenticate = selectedObject.PreAuthenticate;
            request.Timeout = selectedObject.Timeout;
            HttpWebClientProtocol proxy = this.GetCurrentMethodProperty().GetProxyProperty().GetProxy();
            if (selectedObject.UseCookieContainer)
            {
                if (proxy.CookieContainer != null)
                {
                    request.CookieContainer = proxy.CookieContainer;
                }
                else
                {
                    request.CookieContainer = new CookieContainer();
                }
            }
            CredentialCache cache = new CredentialCache();
            bool flag = false;
            if ((selectedObject.BasicAuthUserName != null) && (selectedObject.BasicAuthUserName.Length != 0))
            {
                cache.Add(new Uri(selectedObject.Url), "Basic", new NetworkCredential(selectedObject.BasicAuthUserName, selectedObject.BasicAuthPassword));
                flag = true;
            }
            if (selectedObject.UseDefaultCredential)
            {
                cache.Add(new Uri(selectedObject.Url), "NTLM", (NetworkCredential)CredentialCache.DefaultCredentials);
                flag = true;
            }
            if (flag)
            {
                request.Credentials = cache;
            }
            if (selectedObject.Method == RequestProperties.HttpMethod.POST)
            {
                request.ContentLength = this.richRequest.Text.Length + encoding.GetPreamble().Length;
                StreamWriter writer = new StreamWriter(request.GetRequestStream(), encoding);
                writer.Write(this.richRequest.Text);
                writer.Close();
            }
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                this.DumpResponse(response);
                response.Close();
            }
            catch (WebException exception)
            {
                if (exception.Response != null)
                {
                    this.DumpResponse((HttpWebResponse)exception.Response);
                }
                else
                {
                    this.richResponse.Text = exception.ToString();
                }
            }
            catch (Exception exception2)
            {
                this.richResponse.Text = exception2.ToString();
            }
        }

        private void treeMethods_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is MethodInfo)
            {
                MethodInfo tag = e.Node.Tag as MethodInfo;
                treeInput.Nodes.Clear();
                MethodProperty property = new MethodProperty(GetProxyPropertyFromNode(e.Node), tag);
                property.RecreateSubtree(null);
                treeInput.Nodes.Add(property.TreeNode);
                e.Node.Tag = property.TreeNode;
            }
            else if (e.Node.Tag is TreeNode)
            {
                treeInput.Nodes.Clear();
                treeInput.Nodes.Add((TreeNode)e.Node.Tag);
            }
            treeInput.ExpandAll();
            treeInput.SelectedNode = treeInput.Nodes[0];
        }

        private void treeInput_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propInput.SelectedObject = e.Node.Tag;
            buttonCopy.Enabled = this.IsValidCopyNode(e.Node.Tag as TreeNodeProperty);
            buttonPaste.Enabled = this.IsValidPasteNode(e.Node.Tag as TreeNodeProperty);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard(this.treeInput.SelectedNode.Tag as TreeNodeProperty);
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            TreeNodeProperty tag = this.treeInput.SelectedNode.Tag as TreeNodeProperty;
            if (tag is MethodProperty)
            {
                throw new Exception("Paste not valid on method");
            }
            System.Type[] typeList = tag.GetTypeList();
            System.Type type = typeof(DataSet).IsAssignableFrom(typeList[0]) ? typeof(DataSet) : typeof(object);
            XmlSerializer serializer = new XmlSerializer(type, typeList);
            StringReader textReader = new StringReader((string)Clipboard.GetDataObject().GetData(DataFormats.Text));
            object val = serializer.Deserialize(textReader);
            if ((val == null) || !typeList[0].IsAssignableFrom(val.GetType()))
            {
                throw new Exception("Invalid Type pasted");
            }
            TreeNodeProperty property2 = TreeNodeProperty.CreateTreeNodeProperty(tag, val);
            property2.TreeNode = tag.TreeNode;
            property2.RecreateSubtree(null);
            this.treeInput.SelectedNode = property2.TreeNode;
        }

        private void treeOutput_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propOutput.SelectedObject = e.Node.Tag;
            buttonOutputCopy.Enabled = IsValidCopyNode(e.Node.Tag as TreeNodeProperty);
        }

        private void buttonOutputCopy_Click(object sender, EventArgs e)
        {
            if (treeOutput.SelectedNode != null)
                CopyToClipboard(this.treeOutput.SelectedNode.Tag as TreeNodeProperty);
        }

        private void treeWsdl_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((e.Node.Tag != null) && (this.richWsdl.Tag != e.Node.Tag))
            {
                this.richWsdl.Text = e.Node.Tag.ToString();
                this.richWsdl.Tag = e.Node.Tag;
            }
            XmlTreeNode node = e.Node as XmlTreeNode;
            if (node != null)
            {
                this.richWsdl.Select(node.StartPosition, node.EndPosition - node.StartPosition);
            }

        }

        private void propInput_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            TreeNodeProperty selectedObject = this.propInput.SelectedObject as TreeNodeProperty;
            if ((selectedObject != null) && ((e.ChangedItem.Label == "Type") && (e.OldValue != selectedObject.Type)))
            {
                TreeNodeProperty property2 = TreeNodeProperty.CreateTreeNodeProperty(selectedObject);
                property2.TreeNode = selectedObject.TreeNode;
                property2.RecreateSubtree(null);
                this.treeInput.SelectedNode = property2.TreeNode;
            }

        }

        private void textBoxFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '\r') || (e.KeyChar == '\n'))
            {
                buttonFind_Click(sender, null);
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (buttonFind.Enabled)
            {
                if (keyData == (Keys.Control | Keys.F | Keys.Shift))
                {
                    buttonFind_Click(this, null);
                    return true;
                }
                else if (keyData == (Keys.Control | Keys.F))
                {
                    textBoxFind.Focus();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

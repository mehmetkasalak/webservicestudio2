namespace WebServiceStudio.Dialogs
{
    partial class NewMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMainForm));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.buttonSaveAll = new System.Windows.Forms.ToolStripButton();
            this.buttonOptions = new System.Windows.Forms.ToolStripButton();
            this.buttonAbout = new System.Windows.Forms.ToolStripButton();
            this.buttonCopy = new System.Windows.Forms.ToolStripButton();
            this.buttonPaste = new System.Windows.Forms.ToolStripButton();
            this.buttonOutputCopy = new System.Windows.Forms.ToolStripButton();
            this.buttonFind = new System.Windows.Forms.ToolStripButton();
            this.textBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.buttonMacroRecord = new System.Windows.Forms.ToolStripButton();
            this.buttonMacroPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripWsdl = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comboEndPointUri = new System.Windows.Forms.ToolStripComboBox();
            this.buttonGet = new System.Windows.Forms.ToolStripButton();
            this.buttonBrowse = new System.Windows.Forms.ToolStripButton();
            this.saveAllDialog = new System.Windows.Forms.SaveFileDialog();
            this.openWsdlDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageInvoke = new System.Windows.Forms.TabPage();
            this.splitContainerInvoke = new System.Windows.Forms.SplitContainer();
            this.splitContainerInvokeUp = new System.Windows.Forms.SplitContainer();
            this.treeInput = new System.Windows.Forms.TreeView();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelInputValue = new System.Windows.Forms.Label();
            this.propInput = new System.Windows.Forms.PropertyGrid();
            this.splitContainerInvokeDown = new System.Windows.Forms.SplitContainer();
            this.labelOutput = new System.Windows.Forms.Label();
            this.treeOutput = new System.Windows.Forms.TreeView();
            this.buttonInvoke = new System.Windows.Forms.Button();
            this.labelOutputValue = new System.Windows.Forms.Label();
            this.propOutput = new System.Windows.Forms.PropertyGrid();
            this.splitterInvoke = new System.Windows.Forms.Splitter();
            this.panelLeftInvoke = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSort = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.textBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.treeMethods = new System.Windows.Forms.TreeView();
            this.tabPageRaw = new System.Windows.Forms.TabPage();
            this.splitterRaw = new System.Windows.Forms.Splitter();
            this.panelRightRaw = new System.Windows.Forms.Panel();
            this.splitContainerReqRes = new System.Windows.Forms.SplitContainer();
            this.labelRequest = new System.Windows.Forms.Label();
            this.richRequest = new System.Windows.Forms.RichTextBox();
            this.labelResponse = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.richResponse = new System.Windows.Forms.RichTextBox();
            this.panelLeftRaw = new System.Windows.Forms.Panel();
            this.propRequest = new System.Windows.Forms.PropertyGrid();
            this.tabPageWsdl = new System.Windows.Forms.TabPage();
            this.splitterWsdl = new System.Windows.Forms.Splitter();
            this.panelRightWsdl = new System.Windows.Forms.Panel();
            this.richWsdl = new System.Windows.Forms.RichTextBox();
            this.panelLeftWsdl = new System.Windows.Forms.Panel();
            this.treeWsdl = new System.Windows.Forms.TreeView();
            this.tabPageMessage = new System.Windows.Forms.TabPage();
            this.richMessage = new System.Windows.Forms.RichTextBox();
            this.toolStripMenu.SuspendLayout();
            this.toolStripWsdl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPageInvoke.SuspendLayout();
            this.splitContainerInvoke.Panel1.SuspendLayout();
            this.splitContainerInvoke.Panel2.SuspendLayout();
            this.splitContainerInvoke.SuspendLayout();
            this.splitContainerInvokeUp.Panel1.SuspendLayout();
            this.splitContainerInvokeUp.Panel2.SuspendLayout();
            this.splitContainerInvokeUp.SuspendLayout();
            this.splitContainerInvokeDown.Panel1.SuspendLayout();
            this.splitContainerInvokeDown.Panel2.SuspendLayout();
            this.splitContainerInvokeDown.SuspendLayout();
            this.panelLeftInvoke.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPageRaw.SuspendLayout();
            this.panelRightRaw.SuspendLayout();
            this.splitContainerReqRes.Panel1.SuspendLayout();
            this.splitContainerReqRes.Panel2.SuspendLayout();
            this.splitContainerReqRes.SuspendLayout();
            this.panelLeftRaw.SuspendLayout();
            this.tabPageWsdl.SuspendLayout();
            this.panelRightWsdl.SuspendLayout();
            this.panelLeftWsdl.SuspendLayout();
            this.tabPageMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSaveAll,
            this.buttonOptions,
            this.buttonAbout,
            this.buttonCopy,
            this.buttonPaste,
            this.buttonOutputCopy,
            this.buttonFind,
            this.textBoxFind,
            this.buttonMacroRecord,
            this.buttonMacroPlay});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(912, 25);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Enabled = false;
            this.buttonSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveAll.Image")));
            this.buttonSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSaveAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(65, 21);
            this.buttonSaveAll.Text = "Save All";
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOptions.Image")));
            this.buttonOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(64, 21);
            this.buttonOptions.Text = "Options";
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(56, 21);
            this.buttonAbout.Text = "About";
            this.buttonAbout.ToolTipText = "About";
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Enabled = false;
            this.buttonCopy.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopy.Image")));
            this.buttonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(52, 21);
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Enabled = false;
            this.buttonPaste.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaste.Image")));
            this.buttonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPaste.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(54, 21);
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonOutputCopy
            // 
            this.buttonOutputCopy.Enabled = false;
            this.buttonOutputCopy.Image = ((System.Drawing.Image)(resources.GetObject("buttonOutputCopy.Image")));
            this.buttonOutputCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOutputCopy.Name = "buttonOutputCopy";
            this.buttonOutputCopy.Size = new System.Drawing.Size(89, 22);
            this.buttonOutputCopy.Text = "Copy Output";
            this.buttonOutputCopy.Click += new System.EventHandler(this.buttonOutputCopy_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Enabled = false;
            this.buttonFind.Image = ((System.Drawing.Image)(resources.GetObject("buttonFind.Image")));
            this.buttonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonFind.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonFind.Size = new System.Drawing.Size(53, 21);
            this.buttonFind.Text = "Find";
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.CausesValidation = false;
            this.textBoxFind.Enabled = false;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(250, 25);
            this.textBoxFind.DoubleClick += new System.EventHandler(this.textBoxFind_DoubleClick);
            this.textBoxFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFind_KeyPress);
            // 
            // buttonMacroRecord
            // 
            this.buttonMacroRecord.Name = "buttonMacroRecord";
            this.buttonMacroRecord.Size = new System.Drawing.Size(23, 22);
            // 
            // buttonMacroPlay
            // 
            this.buttonMacroPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonMacroPlay.Image")));
            this.buttonMacroPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonMacroPlay.Name = "buttonMacroPlay";
            this.buttonMacroPlay.Size = new System.Drawing.Size(79, 22);
            this.buttonMacroPlay.Text = "Play Macro";
            this.buttonMacroPlay.Click += new System.EventHandler(this.buttonMacroPlay_Click);
            // 
            // toolStripWsdl
            // 
            this.toolStripWsdl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.comboEndPointUri,
            this.buttonGet,
            this.buttonBrowse});
            this.toolStripWsdl.Location = new System.Drawing.Point(0, 25);
            this.toolStripWsdl.Name = "toolStripWsdl";
            this.toolStripWsdl.Size = new System.Drawing.Size(912, 25);
            this.toolStripWsdl.TabIndex = 1;
            this.toolStripWsdl.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "WSDL EndPoint";
            // 
            // comboEndPointUri
            // 
            this.comboEndPointUri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEndPointUri.Name = "comboEndPointUri";
            this.comboEndPointUri.Size = new System.Drawing.Size(500, 25);
            this.comboEndPointUri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEndPointUri_KeyPress);
            // 
            // buttonGet
            // 
            this.buttonGet.AutoSize = false;
            this.buttonGet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonGet.Image = ((System.Drawing.Image)(resources.GetObject("buttonGet.Image")));
            this.buttonGet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(80, 22);
            this.buttonGet.Text = "Get";
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Image = ((System.Drawing.Image)(resources.GetObject("buttonBrowse.Image")));
            this.buttonBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(74, 21);
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabPageInvoke);
            this.tabMain.Controls.Add(this.tabPageRaw);
            this.tabMain.Controls.Add(this.tabPageWsdl);
            this.tabMain.Controls.Add(this.tabPageMessage);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.ItemSize = new System.Drawing.Size(42, 18);
            this.tabMain.Location = new System.Drawing.Point(0, 50);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(912, 636);
            this.tabMain.TabIndex = 2;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabPageInvoke
            // 
            this.tabPageInvoke.Controls.Add(this.splitContainerInvoke);
            this.tabPageInvoke.Controls.Add(this.splitterInvoke);
            this.tabPageInvoke.Controls.Add(this.panelLeftInvoke);
            this.tabPageInvoke.Location = new System.Drawing.Point(4, 22);
            this.tabPageInvoke.Name = "tabPageInvoke";
            this.tabPageInvoke.Size = new System.Drawing.Size(904, 610);
            this.tabPageInvoke.TabIndex = 0;
            this.tabPageInvoke.Tag = "";
            this.tabPageInvoke.Text = "Invoke";
            // 
            // splitContainerInvoke
            // 
            this.splitContainerInvoke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerInvoke.Location = new System.Drawing.Point(214, 0);
            this.splitContainerInvoke.Name = "splitContainerInvoke";
            this.splitContainerInvoke.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerInvoke.Panel1
            // 
            this.splitContainerInvoke.Panel1.Controls.Add(this.splitContainerInvokeUp);
            // 
            // splitContainerInvoke.Panel2
            // 
            this.splitContainerInvoke.Panel2.Controls.Add(this.splitContainerInvokeDown);
            this.splitContainerInvoke.Size = new System.Drawing.Size(690, 610);
            this.splitContainerInvoke.SplitterDistance = 306;
            this.splitContainerInvoke.TabIndex = 5;
            // 
            // splitContainerInvokeUp
            // 
            this.splitContainerInvokeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerInvokeUp.Location = new System.Drawing.Point(3, 3);
            this.splitContainerInvokeUp.Name = "splitContainerInvokeUp";
            // 
            // splitContainerInvokeUp.Panel1
            // 
            this.splitContainerInvokeUp.Panel1.Controls.Add(this.treeInput);
            this.splitContainerInvokeUp.Panel1.Controls.Add(this.labelInput);
            // 
            // splitContainerInvokeUp.Panel2
            // 
            this.splitContainerInvokeUp.Panel2.Controls.Add(this.labelInputValue);
            this.splitContainerInvokeUp.Panel2.Controls.Add(this.propInput);
            this.splitContainerInvokeUp.Size = new System.Drawing.Size(677, 303);
            this.splitContainerInvokeUp.SplitterDistance = 338;
            this.splitContainerInvokeUp.TabIndex = 12;
            // 
            // treeInput
            // 
            this.treeInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeInput.HideSelection = false;
            this.treeInput.Location = new System.Drawing.Point(0, 22);
            this.treeInput.Name = "treeInput";
            this.treeInput.Size = new System.Drawing.Size(338, 278);
            this.treeInput.TabIndex = 11;
            this.treeInput.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeInput_AfterSelect);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(3, 3);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(31, 13);
            this.labelInput.TabIndex = 10;
            this.labelInput.Text = "Input";
            // 
            // labelInputValue
            // 
            this.labelInputValue.AutoSize = true;
            this.labelInputValue.Location = new System.Drawing.Point(3, 3);
            this.labelInputValue.Name = "labelInputValue";
            this.labelInputValue.Size = new System.Drawing.Size(34, 13);
            this.labelInputValue.TabIndex = 14;
            this.labelInputValue.Text = "Value";
            // 
            // propInput
            // 
            this.propInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propInput.HelpVisible = false;
            this.propInput.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propInput.Location = new System.Drawing.Point(0, 22);
            this.propInput.Name = "propInput";
            this.propInput.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.propInput.Size = new System.Drawing.Size(335, 278);
            this.propInput.TabIndex = 13;
            this.propInput.ToolbarVisible = false;
            // 
            // splitContainerInvokeDown
            // 
            this.splitContainerInvokeDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerInvokeDown.Location = new System.Drawing.Point(3, 2);
            this.splitContainerInvokeDown.Name = "splitContainerInvokeDown";
            // 
            // splitContainerInvokeDown.Panel1
            // 
            this.splitContainerInvokeDown.Panel1.Controls.Add(this.labelOutput);
            this.splitContainerInvokeDown.Panel1.Controls.Add(this.treeOutput);
            // 
            // splitContainerInvokeDown.Panel2
            // 
            this.splitContainerInvokeDown.Panel2.Controls.Add(this.buttonInvoke);
            this.splitContainerInvokeDown.Panel2.Controls.Add(this.labelOutputValue);
            this.splitContainerInvokeDown.Panel2.Controls.Add(this.propOutput);
            this.splitContainerInvokeDown.Size = new System.Drawing.Size(687, 298);
            this.splitContainerInvokeDown.SplitterDistance = 339;
            this.splitContainerInvokeDown.TabIndex = 11;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(3, 9);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 13);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.Text = "Output";
            // 
            // treeOutput
            // 
            this.treeOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeOutput.Location = new System.Drawing.Point(0, 25);
            this.treeOutput.Name = "treeOutput";
            this.treeOutput.Size = new System.Drawing.Size(339, 273);
            this.treeOutput.TabIndex = 6;
            this.treeOutput.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeOutput_AfterSelect);
            // 
            // buttonInvoke
            // 
            this.buttonInvoke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInvoke.AutoSize = true;
            this.buttonInvoke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInvoke.Location = new System.Drawing.Point(244, 0);
            this.buttonInvoke.Name = "buttonInvoke";
            this.buttonInvoke.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.buttonInvoke.Size = new System.Drawing.Size(90, 23);
            this.buttonInvoke.TabIndex = 11;
            this.buttonInvoke.Text = "Invoke";
            this.buttonInvoke.Click += new System.EventHandler(this.buttonInvoke_Click);
            // 
            // labelOutputValue
            // 
            this.labelOutputValue.AutoSize = true;
            this.labelOutputValue.Location = new System.Drawing.Point(3, 9);
            this.labelOutputValue.Name = "labelOutputValue";
            this.labelOutputValue.Size = new System.Drawing.Size(34, 13);
            this.labelOutputValue.TabIndex = 0;
            this.labelOutputValue.Text = "Value";
            // 
            // propOutput
            // 
            this.propOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propOutput.HelpVisible = false;
            this.propOutput.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propOutput.Location = new System.Drawing.Point(0, 25);
            this.propOutput.Name = "propOutput";
            this.propOutput.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.propOutput.Size = new System.Drawing.Size(334, 273);
            this.propOutput.TabIndex = 6;
            this.propOutput.ToolbarVisible = false;
            // 
            // splitterInvoke
            // 
            this.splitterInvoke.Enabled = false;
            this.splitterInvoke.Location = new System.Drawing.Point(220, 0);
            this.splitterInvoke.Name = "splitterInvoke";
            this.splitterInvoke.Size = new System.Drawing.Size(3, 610);
            this.splitterInvoke.TabIndex = 0;
            this.splitterInvoke.TabStop = false;
            // 
            // panelLeftInvoke
            // 
            this.panelLeftInvoke.Controls.Add(this.toolStrip1);
            this.panelLeftInvoke.Controls.Add(this.treeMethods);
            this.panelLeftInvoke.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftInvoke.Location = new System.Drawing.Point(0, 0);
            this.panelLeftInvoke.Name = "panelLeftInvoke";
            this.panelLeftInvoke.Size = new System.Drawing.Size(220, 610);
            this.panelLeftInvoke.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSort,
            this.toolStripButtonSearch,
            this.textBoxSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(220, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSort
            // 
            this.toolStripButtonSort.Enabled = false;
            this.toolStripButtonSort.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSort.Image")));
            this.toolStripButtonSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSort.Name = "toolStripButtonSort";
            this.toolStripButtonSort.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonSort.Text = "Sort";
            this.toolStripButtonSort.Click += new System.EventHandler(this.toolStripButtonSort_Click);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.Enabled = false;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonSearch.Text = "Search";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.CausesValidation = false;
            this.textBoxSearch.Enabled = false;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(90, 21);
            this.textBoxSearch.DoubleClick += new System.EventHandler(this.toolStripTextBox1_DoubleClick);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // treeMethods
            // 
            this.treeMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeMethods.HideSelection = false;
            this.treeMethods.Location = new System.Drawing.Point(0, 25);
            this.treeMethods.Name = "treeMethods";
            this.treeMethods.Size = new System.Drawing.Size(220, 585);
            this.treeMethods.TabIndex = 1;
            this.treeMethods.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMethods_AfterSelect);
            // 
            // tabPageRaw
            // 
            this.tabPageRaw.Controls.Add(this.splitterRaw);
            this.tabPageRaw.Controls.Add(this.panelRightRaw);
            this.tabPageRaw.Controls.Add(this.panelLeftRaw);
            this.tabPageRaw.Location = new System.Drawing.Point(4, 22);
            this.tabPageRaw.Name = "tabPageRaw";
            this.tabPageRaw.Size = new System.Drawing.Size(904, 610);
            this.tabPageRaw.TabIndex = 1;
            this.tabPageRaw.Text = "Request/Response";
            // 
            // splitterRaw
            // 
            this.splitterRaw.Location = new System.Drawing.Point(220, 0);
            this.splitterRaw.Name = "splitterRaw";
            this.splitterRaw.Size = new System.Drawing.Size(3, 610);
            this.splitterRaw.TabIndex = 0;
            this.splitterRaw.TabStop = false;
            // 
            // panelRightRaw
            // 
            this.panelRightRaw.Controls.Add(this.splitContainerReqRes);
            this.panelRightRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightRaw.Location = new System.Drawing.Point(220, 0);
            this.panelRightRaw.Name = "panelRightRaw";
            this.panelRightRaw.Size = new System.Drawing.Size(684, 610);
            this.panelRightRaw.TabIndex = 1;
            // 
            // splitContainerReqRes
            // 
            this.splitContainerReqRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerReqRes.Location = new System.Drawing.Point(3, 0);
            this.splitContainerReqRes.Name = "splitContainerReqRes";
            this.splitContainerReqRes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerReqRes.Panel1
            // 
            this.splitContainerReqRes.Panel1.Controls.Add(this.labelRequest);
            this.splitContainerReqRes.Panel1.Controls.Add(this.richRequest);
            // 
            // splitContainerReqRes.Panel2
            // 
            this.splitContainerReqRes.Panel2.Controls.Add(this.labelResponse);
            this.splitContainerReqRes.Panel2.Controls.Add(this.buttonSend);
            this.splitContainerReqRes.Panel2.Controls.Add(this.richResponse);
            this.splitContainerReqRes.Size = new System.Drawing.Size(681, 610);
            this.splitContainerReqRes.SplitterDistance = 305;
            this.splitContainerReqRes.TabIndex = 5;
            // 
            // labelRequest
            // 
            this.labelRequest.Location = new System.Drawing.Point(3, 3);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(144, 16);
            this.labelRequest.TabIndex = 3;
            this.labelRequest.Text = "Request";
            // 
            // richRequest
            // 
            this.richRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richRequest.Location = new System.Drawing.Point(0, 22);
            this.richRequest.Name = "richRequest";
            this.richRequest.Size = new System.Drawing.Size(681, 280);
            this.richRequest.TabIndex = 1;
            this.richRequest.Text = "";
            this.richRequest.WordWrap = false;
            // 
            // labelResponse
            // 
            this.labelResponse.Location = new System.Drawing.Point(3, 15);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(112, 16);
            this.labelResponse.TabIndex = 4;
            this.labelResponse.Text = "Response";
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSend.Location = new System.Drawing.Point(587, 3);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(94, 24);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // richResponse
            // 
            this.richResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richResponse.Location = new System.Drawing.Point(0, 33);
            this.richResponse.Name = "richResponse";
            this.richResponse.ReadOnly = true;
            this.richResponse.Size = new System.Drawing.Size(681, 268);
            this.richResponse.TabIndex = 2;
            this.richResponse.Text = "";
            this.richResponse.WordWrap = false;
            // 
            // panelLeftRaw
            // 
            this.panelLeftRaw.Controls.Add(this.propRequest);
            this.panelLeftRaw.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftRaw.Location = new System.Drawing.Point(0, 0);
            this.panelLeftRaw.Name = "panelLeftRaw";
            this.panelLeftRaw.Size = new System.Drawing.Size(220, 610);
            this.panelLeftRaw.TabIndex = 2;
            // 
            // propRequest
            // 
            this.propRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propRequest.HelpVisible = false;
            this.propRequest.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propRequest.Location = new System.Drawing.Point(0, 0);
            this.propRequest.Name = "propRequest";
            this.propRequest.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propRequest.Size = new System.Drawing.Size(220, 610);
            this.propRequest.TabIndex = 0;
            this.propRequest.ToolbarVisible = false;
            // 
            // tabPageWsdl
            // 
            this.tabPageWsdl.Controls.Add(this.splitterWsdl);
            this.tabPageWsdl.Controls.Add(this.panelRightWsdl);
            this.tabPageWsdl.Controls.Add(this.panelLeftWsdl);
            this.tabPageWsdl.Location = new System.Drawing.Point(4, 22);
            this.tabPageWsdl.Name = "tabPageWsdl";
            this.tabPageWsdl.Size = new System.Drawing.Size(904, 610);
            this.tabPageWsdl.TabIndex = 2;
            this.tabPageWsdl.Tag = "";
            this.tabPageWsdl.Text = "WSDLs & Proxy";
            // 
            // splitterWsdl
            // 
            this.splitterWsdl.Location = new System.Drawing.Point(220, 0);
            this.splitterWsdl.Name = "splitterWsdl";
            this.splitterWsdl.Size = new System.Drawing.Size(3, 610);
            this.splitterWsdl.TabIndex = 0;
            this.splitterWsdl.TabStop = false;
            // 
            // panelRightWsdl
            // 
            this.panelRightWsdl.Controls.Add(this.richWsdl);
            this.panelRightWsdl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightWsdl.Location = new System.Drawing.Point(220, 0);
            this.panelRightWsdl.Name = "panelRightWsdl";
            this.panelRightWsdl.Size = new System.Drawing.Size(684, 610);
            this.panelRightWsdl.TabIndex = 1;
            // 
            // richWsdl
            // 
            this.richWsdl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richWsdl.HideSelection = false;
            this.richWsdl.Location = new System.Drawing.Point(0, 0);
            this.richWsdl.Name = "richWsdl";
            this.richWsdl.ReadOnly = true;
            this.richWsdl.Size = new System.Drawing.Size(684, 610);
            this.richWsdl.TabIndex = 0;
            this.richWsdl.Text = "";
            this.richWsdl.WordWrap = false;
            // 
            // panelLeftWsdl
            // 
            this.panelLeftWsdl.Controls.Add(this.treeWsdl);
            this.panelLeftWsdl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftWsdl.Location = new System.Drawing.Point(0, 0);
            this.panelLeftWsdl.Name = "panelLeftWsdl";
            this.panelLeftWsdl.Size = new System.Drawing.Size(220, 610);
            this.panelLeftWsdl.TabIndex = 2;
            // 
            // treeWsdl
            // 
            this.treeWsdl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeWsdl.Location = new System.Drawing.Point(0, 0);
            this.treeWsdl.Name = "treeWsdl";
            this.treeWsdl.Size = new System.Drawing.Size(220, 610);
            this.treeWsdl.TabIndex = 0;
            this.treeWsdl.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeWsdl_AfterSelect);
            // 
            // tabPageMessage
            // 
            this.tabPageMessage.Controls.Add(this.richMessage);
            this.tabPageMessage.Location = new System.Drawing.Point(4, 22);
            this.tabPageMessage.Name = "tabPageMessage";
            this.tabPageMessage.Size = new System.Drawing.Size(904, 610);
            this.tabPageMessage.TabIndex = 3;
            this.tabPageMessage.Tag = "";
            this.tabPageMessage.Text = "Messages";
            // 
            // richMessage
            // 
            this.richMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richMessage.Location = new System.Drawing.Point(0, 0);
            this.richMessage.Name = "richMessage";
            this.richMessage.ReadOnly = true;
            this.richMessage.Size = new System.Drawing.Size(904, 610);
            this.richMessage.TabIndex = 0;
            this.richMessage.Text = "";
            // 
            // NewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 686);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolStripWsdl);
            this.Controls.Add(this.toolStripMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMainForm";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.toolStripWsdl.ResumeLayout(false);
            this.toolStripWsdl.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabPageInvoke.ResumeLayout(false);
            this.splitContainerInvoke.Panel1.ResumeLayout(false);
            this.splitContainerInvoke.Panel2.ResumeLayout(false);
            this.splitContainerInvoke.ResumeLayout(false);
            this.splitContainerInvokeUp.Panel1.ResumeLayout(false);
            this.splitContainerInvokeUp.Panel1.PerformLayout();
            this.splitContainerInvokeUp.Panel2.ResumeLayout(false);
            this.splitContainerInvokeUp.Panel2.PerformLayout();
            this.splitContainerInvokeUp.ResumeLayout(false);
            this.splitContainerInvokeDown.Panel1.ResumeLayout(false);
            this.splitContainerInvokeDown.Panel1.PerformLayout();
            this.splitContainerInvokeDown.Panel2.ResumeLayout(false);
            this.splitContainerInvokeDown.Panel2.PerformLayout();
            this.splitContainerInvokeDown.ResumeLayout(false);
            this.panelLeftInvoke.ResumeLayout(false);
            this.panelLeftInvoke.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPageRaw.ResumeLayout(false);
            this.panelRightRaw.ResumeLayout(false);
            this.splitContainerReqRes.Panel1.ResumeLayout(false);
            this.splitContainerReqRes.Panel2.ResumeLayout(false);
            this.splitContainerReqRes.ResumeLayout(false);
            this.panelLeftRaw.ResumeLayout(false);
            this.tabPageWsdl.ResumeLayout(false);
            this.panelRightWsdl.ResumeLayout(false);
            this.panelLeftWsdl.ResumeLayout(false);
            this.tabPageMessage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton buttonFind;
        private System.Windows.Forms.ToolStripButton buttonSaveAll;
        private System.Windows.Forms.ToolStripButton buttonOptions;
        private System.Windows.Forms.ToolStripButton buttonAbout;
        private System.Windows.Forms.ToolStrip toolStripWsdl;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox comboEndPointUri;
        private System.Windows.Forms.ToolStripButton buttonGet;
        private System.Windows.Forms.ToolStripButton buttonBrowse;
        private System.Windows.Forms.SaveFileDialog saveAllDialog;
        private System.Windows.Forms.OpenFileDialog openWsdlDialog;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageInvoke;
        private System.Windows.Forms.Splitter splitterInvoke;
        private System.Windows.Forms.Panel panelLeftInvoke;
        private System.Windows.Forms.TabPage tabPageRaw;
        private System.Windows.Forms.Splitter splitterRaw;
        private System.Windows.Forms.Panel panelRightRaw;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RichTextBox richRequest;
        private System.Windows.Forms.RichTextBox richResponse;
        private System.Windows.Forms.Label labelRequest;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.Panel panelLeftRaw;
        private System.Windows.Forms.PropertyGrid propRequest;
        private System.Windows.Forms.TabPage tabPageWsdl;
        private System.Windows.Forms.Splitter splitterWsdl;
        private System.Windows.Forms.Panel panelRightWsdl;
        private System.Windows.Forms.RichTextBox richWsdl;
        private System.Windows.Forms.Panel panelLeftWsdl;
        private System.Windows.Forms.TreeView treeWsdl;
        private System.Windows.Forms.TabPage tabPageMessage;
        private System.Windows.Forms.RichTextBox richMessage;
        private System.Windows.Forms.TreeView treeMethods;
        private System.Windows.Forms.ToolStripButton buttonCopy;
        private System.Windows.Forms.ToolStripButton buttonPaste;
        private System.Windows.Forms.ToolStripButton buttonOutputCopy;
        private System.Windows.Forms.PropertyGrid propInput;
        private System.Windows.Forms.TreeView treeInput;
        private System.Windows.Forms.SplitContainer splitContainerInvoke;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.SplitContainer splitContainerInvokeUp;
        private System.Windows.Forms.Label labelInputValue;
        private System.Windows.Forms.SplitContainer splitContainerInvokeDown;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TreeView treeOutput;
        private System.Windows.Forms.Button buttonInvoke;
        private System.Windows.Forms.Label labelOutputValue;
        private System.Windows.Forms.PropertyGrid propOutput;
        private System.Windows.Forms.SplitContainer splitContainerReqRes;
        private System.Windows.Forms.ToolStripTextBox textBoxFind;
        private System.Windows.Forms.ToolStripButton buttonMacroRecord;
        private System.Windows.Forms.ToolStripButton buttonMacroPlay;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSort;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripTextBox textBoxSearch;
    }
}
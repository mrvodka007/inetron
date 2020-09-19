namespace iNetron.GUI
{
    partial class mainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.i_statusLbl = new System.Windows.Forms.Label();
            this.pnlLogBrd = new System.Windows.Forms.Panel();
            this.pnlBkLog = new System.Windows.Forms.Panel();
            this.rtbLogger = new System.Windows.Forms.RichTextBox();
            this.rMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearURBufferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.btnMin = new iNetron.GUI.Controls.iButton();
            this.btnExit = new iNetron.GUI.Controls.iButton();
            this.lblHeaderConfig = new System.Windows.Forms.Label();
            this.lblipaddr = new System.Windows.Forms.Label();
            this.objectBorder1 = new System.Windows.Forms.Panel();
            this.objectBack1 = new System.Windows.Forms.Panel();
            this.txtIP_ADDR = new System.Windows.Forms.TextBox();
            this.lbldosm = new System.Windows.Forms.Label();
            this.lnllblAppname = new System.Windows.Forms.LinkLabel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.rMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unblockINetronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_option_selector = new iNetron.GUI.Controls.iDropdown();
            this.btnStopAtk = new iNetron.GUI.Controls.iButton();
            this.btnStartAtk = new iNetron.GUI.Controls.iButton();
            this.btnNewInst = new iNetron.GUI.Controls.iButton();
            this.objBrd2 = new System.Windows.Forms.Panel();
            this.objBk2 = new System.Windows.Forms.Panel();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblprt = new System.Windows.Forms.Label();
            this.chkSec = new System.Windows.Forms.CheckBox();
            this.chki6 = new System.Windows.Forms.CheckBox();
            this.objBrd3 = new System.Windows.Forms.Panel();
            this.objBk3 = new System.Windows.Forms.Panel();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lbldmain = new System.Windows.Forms.Label();
            this.objBrd9 = new System.Windows.Forms.Panel();
            this.objBk7 = new System.Windows.Forms.Panel();
            this.txtUA = new System.Windows.Forms.TextBox();
            this.lblaustr = new System.Windows.Forms.Label();
            this.objBrd4 = new System.Windows.Forms.Panel();
            this.objBk4 = new System.Windows.Forms.Panel();
            this.txtDNSIP = new System.Windows.Forms.TextBox();
            this.lbldip = new System.Windows.Forms.Label();
            this.objBrd5 = new System.Windows.Forms.Panel();
            this.objBk5 = new System.Windows.Forms.Panel();
            this.txtSz = new System.Windows.Forms.TextBox();
            this.lblsz = new System.Windows.Forms.Label();
            this.objBrd6 = new System.Windows.Forms.Panel();
            this.objk10 = new System.Windows.Forms.Panel();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.lblthreads = new System.Windows.Forms.Label();
            this.objBrd8 = new System.Windows.Forms.Panel();
            this.objBk9 = new System.Windows.Forms.Panel();
            this.txtSock = new System.Windows.Forms.TextBox();
            this.lblsocks = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.pnlLogBrd.SuspendLayout();
            this.pnlBkLog.SuspendLayout();
            this.rMenu2.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.objectBorder1.SuspendLayout();
            this.objectBack1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.rMenu.SuspendLayout();
            this.objBrd2.SuspendLayout();
            this.objBk2.SuspendLayout();
            this.objBrd3.SuspendLayout();
            this.objBk3.SuspendLayout();
            this.objBrd9.SuspendLayout();
            this.objBk7.SuspendLayout();
            this.objBrd4.SuspendLayout();
            this.objBk4.SuspendLayout();
            this.objBrd5.SuspendLayout();
            this.objBk5.SuspendLayout();
            this.objBrd6.SuspendLayout();
            this.objk10.SuspendLayout();
            this.objBrd8.SuspendLayout();
            this.objBk9.SuspendLayout();
            this.SuspendLayout();
            // 
            // i_statusLbl
            // 
            this.i_statusLbl.AutoEllipsis = true;
            this.i_statusLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.i_statusLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.i_statusLbl.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_statusLbl.Location = new System.Drawing.Point(0, 426);
            this.i_statusLbl.Name = "i_statusLbl";
            this.i_statusLbl.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.i_statusLbl.Size = new System.Drawing.Size(800, 23);
            this.i_statusLbl.TabIndex = 1;
            this.i_statusLbl.Text = "Ready.";
            this.i_statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLogBrd
            // 
            this.pnlLogBrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogBrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.pnlLogBrd.Controls.Add(this.pnlBkLog);
            this.pnlLogBrd.Location = new System.Drawing.Point(20, 212);
            this.pnlLogBrd.Name = "pnlLogBrd";
            this.pnlLogBrd.Padding = new System.Windows.Forms.Padding(1);
            this.pnlLogBrd.Size = new System.Drawing.Size(650, 198);
            this.pnlLogBrd.TabIndex = 2;
            // 
            // pnlBkLog
            // 
            this.pnlBkLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.pnlBkLog.Controls.Add(this.rtbLogger);
            this.pnlBkLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBkLog.Location = new System.Drawing.Point(1, 1);
            this.pnlBkLog.Name = "pnlBkLog";
            this.pnlBkLog.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlBkLog.Size = new System.Drawing.Size(648, 196);
            this.pnlBkLog.TabIndex = 3;
            // 
            // rtbLogger
            // 
            this.rtbLogger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.rtbLogger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogger.ContextMenuStrip = this.rMenu2;
            this.rtbLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLogger.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLogger.ForeColor = System.Drawing.Color.White;
            this.rtbLogger.HideSelection = false;
            this.rtbLogger.Location = new System.Drawing.Point(7, 6);
            this.rtbLogger.Name = "rtbLogger";
            this.rtbLogger.ReadOnly = true;
            this.rtbLogger.Size = new System.Drawing.Size(634, 184);
            this.rtbLogger.TabIndex = 0;
            this.rtbLogger.Text = "1:50 > Test Message";
            // 
            // rMenu2
            // 
            this.rMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogsToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.rMenu2.Name = "rMenu2";
            this.rMenu2.Size = new System.Drawing.Size(130, 48);
            // 
            // clearLogsToolStripMenuItem
            // 
            this.clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            this.clearLogsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clearLogsToolStripMenuItem.Text = "Clear Logs";
            this.clearLogsToolStripMenuItem.Click += new System.EventHandler(this.clearLogsToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.clearURBufferToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // clearURBufferToolStripMenuItem
            // 
            this.clearURBufferToolStripMenuItem.Name = "clearURBufferToolStripMenuItem";
            this.clearURBufferToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clearURBufferToolStripMenuItem.Text = "Clear U/R Buffer";
            this.clearURBufferToolStripMenuItem.Click += new System.EventHandler(this.clearURBufferToolStripMenuItem_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.pbxIcon);
            this.pnlTitleBar.Controls.Add(this.btnMin);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlTitleBar.Size = new System.Drawing.Size(800, 28);
            this.pnlTitleBar.TabIndex = 3;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitlebar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblTitle.Size = new System.Drawing.Size(48, 28);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "iNetron";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxIcon.Image = global::iNetron.GUI.Properties.Resources.eye_16;
            this.pbxIcon.Location = new System.Drawing.Point(5, 0);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(25, 28);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxIcon.TabIndex = 6;
            this.pbxIcon.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::iNetron.GUI.Properties.Resources.minimise_transparent;
            this.btnMin.Location = new System.Drawing.Point(710, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(45, 28);
            this.btnMin.TabIndex = 5;
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::iNetron.GUI.Properties.Resources.close_transparent;
            this.btnExit.Location = new System.Drawing.Point(755, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHeaderConfig
            // 
            this.lblHeaderConfig.AutoSize = true;
            this.lblHeaderConfig.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderConfig.Location = new System.Drawing.Point(14, 47);
            this.lblHeaderConfig.Name = "lblHeaderConfig";
            this.lblHeaderConfig.Size = new System.Drawing.Size(97, 32);
            this.lblHeaderConfig.TabIndex = 7;
            this.lblHeaderConfig.Text = "Settings";
            // 
            // lblipaddr
            // 
            this.lblipaddr.AutoSize = true;
            this.lblipaddr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblipaddr.Location = new System.Drawing.Point(18, 96);
            this.lblipaddr.Name = "lblipaddr";
            this.lblipaddr.Size = new System.Drawing.Size(62, 17);
            this.lblipaddr.TabIndex = 8;
            this.lblipaddr.Text = "Target IP:";
            // 
            // objectBorder1
            // 
            this.objectBorder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectBorder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.objectBorder1.Controls.Add(this.objectBack1);
            this.objectBorder1.Location = new System.Drawing.Point(88, 94);
            this.objectBorder1.Name = "objectBorder1";
            this.objectBorder1.Padding = new System.Windows.Forms.Padding(1);
            this.objectBorder1.Size = new System.Drawing.Size(197, 25);
            this.objectBorder1.TabIndex = 9;
            // 
            // objectBack1
            // 
            this.objectBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.objectBack1.Controls.Add(this.txtIP_ADDR);
            this.objectBack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectBack1.Location = new System.Drawing.Point(1, 1);
            this.objectBack1.Name = "objectBack1";
            this.objectBack1.Padding = new System.Windows.Forms.Padding(2);
            this.objectBack1.Size = new System.Drawing.Size(195, 23);
            this.objectBack1.TabIndex = 3;
            // 
            // txtIP_ADDR
            // 
            this.txtIP_ADDR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txtIP_ADDR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP_ADDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIP_ADDR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP_ADDR.ForeColor = System.Drawing.Color.White;
            this.txtIP_ADDR.Location = new System.Drawing.Point(2, 2);
            this.txtIP_ADDR.Name = "txtIP_ADDR";
            this.txtIP_ADDR.Size = new System.Drawing.Size(191, 18);
            this.txtIP_ADDR.TabIndex = 0;
            this.txtIP_ADDR.Text = "127.0.0.1";
            this.txtIP_ADDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP_ADDR.TextChanged += new System.EventHandler(this.txtIP_ADDR_TextChanged);
            // 
            // lbldosm
            // 
            this.lbldosm.AutoSize = true;
            this.lbldosm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldosm.Location = new System.Drawing.Point(447, 96);
            this.lbldosm.Name = "lbldosm";
            this.lbldosm.Size = new System.Drawing.Size(74, 17);
            this.lbldosm.TabIndex = 11;
            this.lbldosm.Text = "DoS Mode:";
            // 
            // lnllblAppname
            // 
            this.lnllblAppname.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lnllblAppname.AutoEllipsis = true;
            this.lnllblAppname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lnllblAppname.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lnllblAppname.Location = new System.Drawing.Point(680, 372);
            this.lnllblAppname.Name = "lnllblAppname";
            this.lnllblAppname.Size = new System.Drawing.Size(106, 16);
            this.lnllblAppname.TabIndex = 12;
            this.lnllblAppname.TabStop = true;
            this.lnllblAppname.Text = "iNetron v1.1";
            this.lnllblAppname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Image = global::iNetron.GUI.Properties.Resources.eye_64;
            this.pbxLogo.Location = new System.Drawing.Point(680, 336);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(106, 34);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 13;
            this.pbxLogo.TabStop = false;
            // 
            // rMenu
            // 
            this.rMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unblockINetronToolStripMenuItem});
            this.rMenu.Name = "rMenu";
            this.rMenu.Size = new System.Drawing.Size(150, 26);
            // 
            // unblockINetronToolStripMenuItem
            // 
            this.unblockINetronToolStripMenuItem.Name = "unblockINetronToolStripMenuItem";
            this.unblockINetronToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.unblockINetronToolStripMenuItem.Text = "Authorize DoS";
            this.unblockINetronToolStripMenuItem.Click += new System.EventHandler(this.unblockINetronToolStripMenuItem_Click);
            // 
            // i_option_selector
            // 
            this.i_option_selector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.i_option_selector.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.i_option_selector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i_option_selector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.i_option_selector.ForeColor = System.Drawing.Color.White;
            this.i_option_selector.FormattingEnabled = true;
            this.i_option_selector.Items.AddRange(new object[] {
            "— Amplification —",
            "DNS (ANY)",
            "— Application —",
            "Slow Loris",
            "Simple \"RUDY\"",
            "— Volume —",
            "HTTP Flood",
            "ICMP (Ping) Flood",
            "TCP Flood",
            "UDP Flood"});
            this.i_option_selector.Location = new System.Drawing.Point(526, 94);
            this.i_option_selector.Name = "i_option_selector";
            this.i_option_selector.Size = new System.Drawing.Size(260, 25);
            this.i_option_selector.TabIndex = 10;
            this.i_option_selector.Text = "None Selected";
            this.i_option_selector.SelectedIndexChanged += new System.EventHandler(this.i_option_selector_SelectedIndexChanged);
            // 
            // btnStopAtk
            // 
            this.btnStopAtk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.btnStopAtk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.btnStopAtk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopAtk.Location = new System.Drawing.Point(680, 290);
            this.btnStopAtk.Name = "btnStopAtk";
            this.btnStopAtk.Size = new System.Drawing.Size(106, 25);
            this.btnStopAtk.TabIndex = 6;
            this.btnStopAtk.Text = "Stop";
            this.btnStopAtk.UseVisualStyleBackColor = false;
            this.btnStopAtk.Click += new System.EventHandler(this.btnStopAtk_Click);
            // 
            // btnStartAtk
            // 
            this.btnStartAtk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.btnStartAtk.ContextMenuStrip = this.rMenu;
            this.btnStartAtk.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnStartAtk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAtk.Location = new System.Drawing.Point(680, 259);
            this.btnStartAtk.Name = "btnStartAtk";
            this.btnStartAtk.Size = new System.Drawing.Size(106, 25);
            this.btnStartAtk.TabIndex = 5;
            this.btnStartAtk.Text = "Start";
            this.btnStartAtk.UseVisualStyleBackColor = false;
            this.btnStartAtk.Click += new System.EventHandler(this.btnStartAtk_Click);
            // 
            // btnNewInst
            // 
            this.btnNewInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.btnNewInst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.btnNewInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInst.Location = new System.Drawing.Point(680, 212);
            this.btnNewInst.Name = "btnNewInst";
            this.btnNewInst.Size = new System.Drawing.Size(106, 41);
            this.btnNewInst.TabIndex = 4;
            this.btnNewInst.Text = "Start New Instance";
            this.btnNewInst.UseVisualStyleBackColor = false;
            this.btnNewInst.Click += new System.EventHandler(this.btnNewInst_Click);
            // 
            // objBrd2
            // 
            this.objBrd2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objBrd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.objBrd2.Controls.Add(this.objBk2);
            this.objBrd2.Location = new System.Drawing.Point(358, 94);
            this.objBrd2.Name = "objBrd2";
            this.objBrd2.Padding = new System.Windows.Forms.Padding(1);
            this.objBrd2.Size = new System.Drawing.Size(63, 25);
            this.objBrd2.TabIndex = 18;
            // 
            // objBk2
            // 
            this.objBk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.objBk2.Controls.Add(this.txtPort);
            this.objBk2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objBk2.Location = new System.Drawing.Point(1, 1);
            this.objBk2.Name = "objBk2";
            this.objBk2.Padding = new System.Windows.Forms.Padding(2);
            this.objBk2.Size = new System.Drawing.Size(61, 23);
            this.objBk2.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.White;
            this.txtPort.Location = new System.Drawing.Point(2, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(57, 18);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "6975";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // lblprt
            // 
            this.lblprt.AutoSize = true;
            this.lblprt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprt.Location = new System.Drawing.Point(310, 96);
            this.lblprt.Name = "lblprt";
            this.lblprt.Size = new System.Drawing.Size(40, 17);
            this.lblprt.TabIndex = 17;
            this.lblprt.Text = "*Port:";
            // 
            // chkSec
            // 
            this.chkSec.AutoSize = true;
            this.chkSec.Location = new System.Drawing.Point(723, 62);
            this.chkSec.Name = "chkSec";
            this.chkSec.Size = new System.Drawing.Size(63, 17);
            this.chkSec.TabIndex = 19;
            this.chkSec.Text = "HTTPS*";
            this.chkSec.UseVisualStyleBackColor = true;
            this.chkSec.CheckedChanged += new System.EventHandler(this.chkSec_CheckedChanged);
            // 
            // chki6
            // 
            this.chki6.AutoSize = true;
            this.chki6.Location = new System.Drawing.Point(666, 62);
            this.chki6.Name = "chki6";
            this.chki6.Size = new System.Drawing.Size(51, 17);
            this.chki6.TabIndex = 20;
            this.chki6.Text = "IPv6*";
            this.chki6.UseVisualStyleBackColor = true;
            this.chki6.CheckedChanged += new System.EventHandler(this.chki6_CheckedChanged);
            // 
            // objBrd3
            // 
            this.objBrd3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objBrd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.objBrd3.Controls.Add(this.objBk3);
            this.objBrd3.Location = new System.Drawing.Point(89, 125);
            this.objBrd3.Name = "objBrd3";
            this.objBrd3.Padding = new System.Windows.Forms.Padding(1);
            this.objBrd3.Size = new System.Drawing.Size(197, 25);
            this.objBrd3.TabIndex = 22;
            // 
            // objBk3
            // 
            this.objBk3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.objBk3.Controls.Add(this.txtDomain);
            this.objBk3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objBk3.Location = new System.Drawing.Point(1, 1);
            this.objBk3.Name = "objBk3";
            this.objBk3.Padding = new System.Windows.Forms.Padding(2);
            this.objBk3.Size = new System.Drawing.Size(195, 23);
            this.objBk3.TabIndex = 3;
            // 
            // txtDomain
            // 
            this.txtDomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txtDomain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDomain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomain.ForeColor = System.Drawing.Color.White;
            this.txtDomain.Location = new System.Drawing.Point(2, 2);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(191, 18);
            this.txtDomain.TabIndex = 0;
            this.txtDomain.Text = "sni.cloudflaressl.com";
            this.txtDomain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDomain.TextChanged += new System.EventHandler(this.txtDomain_TextChanged);
            // 
            // lbldmain
            // 
            this.lbldmain.AutoSize = true;
            this.lbldmain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmain.Location = new System.Drawing.Point(19, 127);
            this.lbldmain.Name = "lbldmain";
            this.lbldmain.Size = new System.Drawing.Size(61, 17);
            this.lbldmain.TabIndex = 21;
            this.lbldmain.Text = "*Domain:";
            // 
            // objBrd9
            // 
            this.objBrd9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objBrd9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.objBrd9.Controls.Add(this.objBk7);
            this.objBrd9.Location = new System.Drawing.Point(387, 125);
            this.objBrd9.Name = "objBrd9";
            this.objBrd9.Padding = new System.Windows.Forms.Padding(1);
            this.objBrd9.Size = new System.Drawing.Size(399, 25);
            this.objBrd9.TabIndex = 24;
            // 
            // objBk7
            // 
            this.objBk7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.objBk7.Controls.Add(this.txtUA);
            this.objBk7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objBk7.Location = new System.Drawing.Point(1, 1);
            this.objBk7.Name = "objBk7";
            this.objBk7.Padding = new System.Windows.Forms.Padding(2);
            this.objBk7.Size = new System.Drawing.Size(397, 23);
            this.objBk7.TabIndex = 3;
            // 
            // txtUA
            // 
            this.txtUA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txtUA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUA.ForeColor = System.Drawing.Color.White;
            this.txtUA.Location = new System.Drawing.Point(2, 2);
            this.txtUA.Name = "txtUA";
            this.txtUA.Size = new System.Drawing.Size(393, 18);
            this.txtUA.TabIndex = 0;
            this.txtUA.Text = "device.unknown";
            this.txtUA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUA.TextChanged += new System.EventHandler(this.txtUA_TextChanged);
            // 
            // lblaustr
            // 
            this.lblaustr.AutoSize = true;
            this.lblaustr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaustr.Location = new System.Drawing.Point(310, 128);
            this.lblaustr.Name = "lblaustr";
            this.lblaustr.Size = new System.Drawing.Size(71, 17);
            this.lblaustr.TabIndex = 23;
            this.lblaustr.Text = "*UA String:";
            // 
            // objBrd4
            // 
            this.objBrd4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objBrd4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.objBrd4.Controls.Add(this.objBk4);
            this.objBrd4.Location = new System.Drawing.Point(89, 156);
            this.objBrd4.Name = "objBrd4";
            this.objBrd4.Padding = new System.Windows.Forms.Padding(1);
            this.objBrd4.Size = new System.Drawing.Size(197, 25);
            this.objBrd4.TabIndex = 26;
            // 
            // objBk4
            // 
            this.objBk4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.objBk4.Controls.Add(this.txtDNSIP);
            this.objBk4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objBk4.Location = new System.Drawing.Point(1, 1);
            this.objBk4.Name = "objBk4";
            this.objBk4.Padding = new System.Windows.Forms.Padding(2);
            this.objBk4.Size = new System.Drawing.Size(195, 23);
            this.objBk4.TabIndex = 3;
            // 
            // txtDNSIP
            // 
            this.txtDNSIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txtDNSIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNSIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDNSIP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNSIP.ForeColor = System.Drawing.Color.White;
            this.txtDNSIP.Location = new System.Drawing.Point(2, 2);
            this.txtDNSIP.Name = "txtDNSIP";
            this.txtDNSIP.Size = new System.Drawing.Size(191, 18);
            this.txtDNSIP.TabIndex = 0;
            this.txtDNSIP.Text = "77.88.8.8";
            this.txtDNSIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDNSIP.TextChanged += new System.EventHandler(this.txtDNSIP_TextChanged);
            // 
            // lbldip
            // 
            this.lbldip.AutoSize = true;
            this.lbldip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldip.Location = new System.Drawing.Point(19, 158);
            this.lbldip.Name = "lbldip";
            this.lbldip.Size = new System.Drawing.Size(56, 17);
            this.lbldip.TabIndex = 25;
            this.lbldip.Text = "*DNS IP:";
            // 
            // objBrd5
            // 
            this.objBrd5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objBrd5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.objBrd5.Controls.Add(this.objBk5);
            this.objBrd5.Location = new System.Drawing.Point(357, 156);
            this.objBrd5.Name = "objBrd5";
            this.objBrd5.Padding = new System.Windows.Forms.Padding(1);
            this.objBrd5.Size = new System.Drawing.Size(74, 25);
            this.objBrd5.TabIndex = 28;
            // 
            // objBk5
            // 
            this.objBk5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.objBk5.Controls.Add(this.txtSz);
            this.objBk5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objBk5.Location = new System.Drawing.Point(1, 1);
            this.objBk5.Name = "objBk5";
            this.objBk5.Padding = new System.Windows.Forms.Padding(2);
            this.objBk5.Size = new System.Drawing.Size(72, 23);
            this.objBk5.TabIndex = 3;
            // 
            // txtSz
            // 
            this.txtSz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txtSz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSz.ForeColor = System.Drawing.Color.White;
            this.txtSz.Location = new System.Drawing.Point(2, 2);
            this.txtSz.Name = "txtSz";
            this.txtSz.Size = new System.Drawing.Size(68, 18);
            this.txtSz.TabIndex = 0;
            this.txtSz.Text = "6550";
            this.txtSz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSz.TextChanged += new System.EventHandler(this.txtSz_TextChanged);
            // 
            // lblsz
            // 
            this.lblsz.AutoSize = true;
            this.lblsz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsz.Location = new System.Drawing.Point(309, 158);
            this.lblsz.Name = "lblsz";
            this.lblsz.Size = new System.Drawing.Size(39, 17);
            this.lblsz.TabIndex = 27;
            this.lblsz.Text = "*Size:";
            // 
            // objBrd6
            // 
            this.objBrd6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objBrd6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.objBrd6.Controls.Add(this.objk10);
            this.objBrd6.Location = new System.Drawing.Point(513, 156);
            this.objBrd6.Name = "objBrd6";
            this.objBrd6.Padding = new System.Windows.Forms.Padding(1);
            this.objBrd6.Size = new System.Drawing.Size(77, 25);
            this.objBrd6.TabIndex = 30;
            // 
            // objk10
            // 
            this.objk10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.objk10.Controls.Add(this.txtThreads);
            this.objk10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objk10.Location = new System.Drawing.Point(1, 1);
            this.objk10.Name = "objk10";
            this.objk10.Padding = new System.Windows.Forms.Padding(2);
            this.objk10.Size = new System.Drawing.Size(75, 23);
            this.objk10.TabIndex = 3;
            // 
            // txtThreads
            // 
            this.txtThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txtThreads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThreads.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThreads.ForeColor = System.Drawing.Color.White;
            this.txtThreads.Location = new System.Drawing.Point(2, 2);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(71, 18);
            this.txtThreads.TabIndex = 0;
            this.txtThreads.Text = "8";
            this.txtThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThreads.TextChanged += new System.EventHandler(this.txtThreads_TextChanged);
            // 
            // lblthreads
            // 
            this.lblthreads.AutoSize = true;
            this.lblthreads.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthreads.Location = new System.Drawing.Point(447, 158);
            this.lblthreads.Name = "lblthreads";
            this.lblthreads.Size = new System.Drawing.Size(63, 17);
            this.lblthreads.TabIndex = 29;
            this.lblthreads.Text = "*Threads:";
            // 
            // objBrd8
            // 
            this.objBrd8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objBrd8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.objBrd8.Controls.Add(this.objBk9);
            this.objBrd8.Location = new System.Drawing.Point(676, 156);
            this.objBrd8.Name = "objBrd8";
            this.objBrd8.Padding = new System.Windows.Forms.Padding(1);
            this.objBrd8.Size = new System.Drawing.Size(110, 25);
            this.objBrd8.TabIndex = 32;
            // 
            // objBk9
            // 
            this.objBk9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.objBk9.Controls.Add(this.txtSock);
            this.objBk9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objBk9.Location = new System.Drawing.Point(1, 1);
            this.objBk9.Name = "objBk9";
            this.objBk9.Padding = new System.Windows.Forms.Padding(2);
            this.objBk9.Size = new System.Drawing.Size(108, 23);
            this.objBk9.TabIndex = 3;
            // 
            // txtSock
            // 
            this.txtSock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txtSock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSock.ForeColor = System.Drawing.Color.White;
            this.txtSock.Location = new System.Drawing.Point(2, 2);
            this.txtSock.Name = "txtSock";
            this.txtSock.Size = new System.Drawing.Size(104, 18);
            this.txtSock.TabIndex = 0;
            this.txtSock.Text = "200";
            this.txtSock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSock.TextChanged += new System.EventHandler(this.txtSock_TextChanged);
            // 
            // lblsocks
            // 
            this.lblsocks.AutoSize = true;
            this.lblsocks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsocks.Location = new System.Drawing.Point(610, 158);
            this.lblsocks.Name = "lblsocks";
            this.lblsocks.Size = new System.Drawing.Size(57, 17);
            this.lblsocks.TabIndex = 31;
            this.lblsocks.Text = "*Sockets";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblHint.Location = new System.Drawing.Point(466, 187);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(325, 13);
            this.lblHint.TabIndex = 33;
            this.lblHint.Text = "*is specific to a DoS mode, see manual for more info.";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.objBrd8);
            this.Controls.Add(this.lblsocks);
            this.Controls.Add(this.objBrd6);
            this.Controls.Add(this.lblthreads);
            this.Controls.Add(this.objBrd5);
            this.Controls.Add(this.lblsz);
            this.Controls.Add(this.objBrd4);
            this.Controls.Add(this.lbldip);
            this.Controls.Add(this.objBrd9);
            this.Controls.Add(this.lblaustr);
            this.Controls.Add(this.objBrd3);
            this.Controls.Add(this.lbldmain);
            this.Controls.Add(this.chki6);
            this.Controls.Add(this.chkSec);
            this.Controls.Add(this.objBrd2);
            this.Controls.Add(this.lblprt);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lnllblAppname);
            this.Controls.Add(this.lbldosm);
            this.Controls.Add(this.i_option_selector);
            this.Controls.Add(this.objectBorder1);
            this.Controls.Add(this.lblipaddr);
            this.Controls.Add(this.lblHeaderConfig);
            this.Controls.Add(this.btnStopAtk);
            this.Controls.Add(this.btnStartAtk);
            this.Controls.Add(this.btnNewInst);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlLogBrd);
            this.Controls.Add(this.i_statusLbl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iNetron";
            this.Activated += new System.EventHandler(this.mainWindow_Activated);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.pnlLogBrd.ResumeLayout(false);
            this.pnlBkLog.ResumeLayout(false);
            this.rMenu2.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.objectBorder1.ResumeLayout(false);
            this.objectBack1.ResumeLayout(false);
            this.objectBack1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.rMenu.ResumeLayout(false);
            this.objBrd2.ResumeLayout(false);
            this.objBk2.ResumeLayout(false);
            this.objBk2.PerformLayout();
            this.objBrd3.ResumeLayout(false);
            this.objBk3.ResumeLayout(false);
            this.objBk3.PerformLayout();
            this.objBrd9.ResumeLayout(false);
            this.objBk7.ResumeLayout(false);
            this.objBk7.PerformLayout();
            this.objBrd4.ResumeLayout(false);
            this.objBk4.ResumeLayout(false);
            this.objBk4.PerformLayout();
            this.objBrd5.ResumeLayout(false);
            this.objBk5.ResumeLayout(false);
            this.objBk5.PerformLayout();
            this.objBrd6.ResumeLayout(false);
            this.objk10.ResumeLayout(false);
            this.objk10.PerformLayout();
            this.objBrd8.ResumeLayout(false);
            this.objBk9.ResumeLayout(false);
            this.objBk9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label i_statusLbl;
        private System.Windows.Forms.Panel pnlLogBrd;
        private System.Windows.Forms.Panel pnlBkLog;
        private System.Windows.Forms.RichTextBox rtbLogger;
        private System.Windows.Forms.Panel pnlTitleBar;
        private Controls.iButton btnExit;
        private Controls.iButton btnMin;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Label lblTitle;
        private Controls.iButton btnNewInst;
        private Controls.iButton btnStartAtk;
        private Controls.iButton btnStopAtk;
        private System.Windows.Forms.Label lblHeaderConfig;
        private System.Windows.Forms.Label lblipaddr;
        private System.Windows.Forms.Panel objectBorder1;
        private System.Windows.Forms.Panel objectBack1;
        private System.Windows.Forms.TextBox txtIP_ADDR;
        private Controls.iDropdown i_option_selector;
        private System.Windows.Forms.Label lbldosm;
        private System.Windows.Forms.LinkLabel lnllblAppname;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ContextMenuStrip rMenu;
        private System.Windows.Forms.ToolStripMenuItem unblockINetronToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip rMenu2;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearURBufferToolStripMenuItem;
        private System.Windows.Forms.Panel objBrd2;
        private System.Windows.Forms.Panel objBk2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblprt;
        private System.Windows.Forms.CheckBox chkSec;
        private System.Windows.Forms.CheckBox chki6;
        private System.Windows.Forms.Panel objBrd3;
        private System.Windows.Forms.Panel objBk3;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label lbldmain;
        private System.Windows.Forms.Panel objBrd9;
        private System.Windows.Forms.Panel objBk7;
        private System.Windows.Forms.TextBox txtUA;
        private System.Windows.Forms.Label lblaustr;
        private System.Windows.Forms.Panel objBrd4;
        private System.Windows.Forms.Panel objBk4;
        private System.Windows.Forms.TextBox txtDNSIP;
        private System.Windows.Forms.Label lbldip;
        private System.Windows.Forms.Panel objBrd5;
        private System.Windows.Forms.Panel objBk5;
        private System.Windows.Forms.TextBox txtSz;
        private System.Windows.Forms.Label lblsz;
        private System.Windows.Forms.Panel objBrd6;
        private System.Windows.Forms.Panel objk10;
        private System.Windows.Forms.TextBox txtThreads;
        private System.Windows.Forms.Label lblthreads;
        private System.Windows.Forms.Panel objBrd8;
        private System.Windows.Forms.Panel objBk9;
        private System.Windows.Forms.TextBox txtSock;
        private System.Windows.Forms.Label lblsocks;
        private System.Windows.Forms.Label lblHint;
    }
}


namespace WinWLAN.UX
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Title = new System.Windows.Forms.Label();
            this.mainContentsContainer = new System.Windows.Forms.SplitContainer();
            this.wifiListContainer = new System.Windows.Forms.Panel();
            this.wlanList = new WinWLAN.UX.ListControl();
            this.actionsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshWifiListBtn = new System.Windows.Forms.Button();
            this.connectToSelectedBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ManagedNativeWifilnk = new System.Windows.Forms.LinkLabel();
            this.simpleWifilnk = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.APTypetxt = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.PHYTypetxt = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.accessPointFlagstxt = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.noConnectReasontxt = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Connectabletxt = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.SignalStrengthtxt = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.Ciphertxt = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.APRatetxt = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.Label();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.BSSIDtxt = new System.Windows.Forms.TextBox();
            this.BSSIDTypetxt = new System.Windows.Forms.Label();
            this.LAAUAALearnLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainContentsContainer)).BeginInit();
            this.mainContentsContainer.Panel1.SuspendLayout();
            this.mainContentsContainer.Panel2.SuspendLayout();
            this.mainContentsContainer.SuspendLayout();
            this.wifiListContainer.SuspendLayout();
            this.actionsContainer.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Location = new System.Drawing.Point(15, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(89, 19);
            this.Title.TabIndex = 0;
            this.Title.Text = "WinWLAN";
            // 
            // mainContentsContainer
            // 
            this.mainContentsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentsContainer.Location = new System.Drawing.Point(15, 34);
            this.mainContentsContainer.Name = "mainContentsContainer";
            // 
            // mainContentsContainer.Panel1
            // 
            this.mainContentsContainer.Panel1.Controls.Add(this.wifiListContainer);
            this.mainContentsContainer.Panel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            // 
            // mainContentsContainer.Panel2
            // 
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel11);
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel8);
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel7);
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel6);
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel5);
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel4);
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel3);
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel9);
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.mainContentsContainer.Panel2.Controls.Add(this.flowLayoutPanel10);
            this.mainContentsContainer.Panel2.Padding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            this.mainContentsContainer.Size = new System.Drawing.Size(770, 401);
            this.mainContentsContainer.SplitterDistance = 438;
            this.mainContentsContainer.TabIndex = 1;
            // 
            // wifiListContainer
            // 
            this.wifiListContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wifiListContainer.Controls.Add(this.wlanList);
            this.wifiListContainer.Controls.Add(this.actionsContainer);
            this.wifiListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wifiListContainer.Location = new System.Drawing.Point(0, 25);
            this.wifiListContainer.Name = "wifiListContainer";
            this.wifiListContainer.Size = new System.Drawing.Size(438, 376);
            this.wifiListContainer.TabIndex = 0;
            // 
            // wlanList
            // 
            this.wlanList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.wlanList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wlanList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wlanList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.wlanList.ForeColor = System.Drawing.Color.White;
            this.wlanList.FormattingEnabled = true;
            this.wlanList.IntegralHeight = false;
            this.wlanList.ItemHeight = 35;
            this.wlanList.ItemImage = null;
            this.wlanList.Location = new System.Drawing.Point(0, 0);
            this.wlanList.Name = "wlanList";
            this.wlanList.ScrollAlwaysVisible = true;
            this.wlanList.ShowScrollbar = true;
            this.wlanList.Size = new System.Drawing.Size(436, 334);
            this.wlanList.TabIndex = 0;
            this.wlanList.SelectedIndexChanged += new System.EventHandler(this.wlanList_SelectedIndexChanged);
            // 
            // actionsContainer
            // 
            this.actionsContainer.AutoSize = true;
            this.actionsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actionsContainer.Controls.Add(this.refreshWifiListBtn);
            this.actionsContainer.Controls.Add(this.connectToSelectedBtn);
            this.actionsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsContainer.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.actionsContainer.Location = new System.Drawing.Point(0, 334);
            this.actionsContainer.Name = "actionsContainer";
            this.actionsContainer.Size = new System.Drawing.Size(436, 40);
            this.actionsContainer.TabIndex = 1;
            // 
            // refreshWifiListBtn
            // 
            this.refreshWifiListBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.refreshWifiListBtn.AutoSize = true;
            this.refreshWifiListBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshWifiListBtn.Image = global::WinWLAN.Properties.Resources.loop_right_line__1_;
            this.refreshWifiListBtn.Location = new System.Drawing.Point(399, 3);
            this.refreshWifiListBtn.Name = "refreshWifiListBtn";
            this.refreshWifiListBtn.Padding = new System.Windows.Forms.Padding(5);
            this.refreshWifiListBtn.Size = new System.Drawing.Size(34, 34);
            this.refreshWifiListBtn.TabIndex = 0;
            this.refreshWifiListBtn.UseVisualStyleBackColor = true;
            this.refreshWifiListBtn.Click += new System.EventHandler(this.refreshWifiListBtn_Click);
            // 
            // connectToSelectedBtn
            // 
            this.connectToSelectedBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.connectToSelectedBtn.AutoSize = true;
            this.connectToSelectedBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectToSelectedBtn.Image = global::WinWLAN.Properties.Resources.links_line;
            this.connectToSelectedBtn.Location = new System.Drawing.Point(359, 3);
            this.connectToSelectedBtn.Name = "connectToSelectedBtn";
            this.connectToSelectedBtn.Padding = new System.Windows.Forms.Padding(5);
            this.connectToSelectedBtn.Size = new System.Drawing.Size(34, 34);
            this.connectToSelectedBtn.TabIndex = 1;
            this.connectToSelectedBtn.UseVisualStyleBackColor = true;
            this.connectToSelectedBtn.Click += new System.EventHandler(this.connectToSelectedBtn_Click);
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.AutoSize = true;
            this.flowLayoutPanel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel11.Controls.Add(this.label1);
            this.flowLayoutPanel11.Controls.Add(this.ManagedNativeWifilnk);
            this.flowLayoutPanel11.Controls.Add(this.simpleWifilnk);
            this.flowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(10, 317);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel11.Size = new System.Drawing.Size(308, 62);
            this.flowLayoutPanel11.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "WinWLAN uses both ManagedNativeWifi and SimpleWiFi.";
            // 
            // ManagedNativeWifilnk
            // 
            this.ManagedNativeWifilnk.AutoSize = true;
            this.ManagedNativeWifilnk.Location = new System.Drawing.Point(3, 38);
            this.ManagedNativeWifilnk.Name = "ManagedNativeWifilnk";
            this.ManagedNativeWifilnk.Size = new System.Drawing.Size(146, 19);
            this.ManagedNativeWifilnk.TabIndex = 6;
            this.ManagedNativeWifilnk.TabStop = true;
            this.ManagedNativeWifilnk.Text = "ManagedNativeWiFi";
            this.ManagedNativeWifilnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManagedNativeWifilnk_LinkClicked);
            // 
            // simpleWifilnk
            // 
            this.simpleWifilnk.AutoSize = true;
            this.simpleWifilnk.Location = new System.Drawing.Point(155, 38);
            this.simpleWifilnk.Name = "simpleWifilnk";
            this.simpleWifilnk.Size = new System.Drawing.Size(87, 19);
            this.simpleWifilnk.TabIndex = 7;
            this.simpleWifilnk.TabStop = true;
            this.simpleWifilnk.Text = "SimpleWiFi";
            this.simpleWifilnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.simpleWifilnk_LinkClicked);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel8.Controls.Add(this.label9);
            this.flowLayoutPanel8.Controls.Add(this.APTypetxt);
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(10, 293);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel8.Size = new System.Drawing.Size(308, 24);
            this.flowLayoutPanel8.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "AP Type:";
            // 
            // APTypetxt
            // 
            this.APTypetxt.AutoSize = true;
            this.APTypetxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.APTypetxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APTypetxt.ForeColor = System.Drawing.Color.Black;
            this.APTypetxt.Location = new System.Drawing.Point(81, 0);
            this.APTypetxt.Name = "APTypetxt";
            this.APTypetxt.Size = new System.Drawing.Size(59, 19);
            this.APTypetxt.TabIndex = 2;
            this.APTypetxt.Text = "Unsure";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel7.Controls.Add(this.label7);
            this.flowLayoutPanel7.Controls.Add(this.PHYTypetxt);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(10, 269);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel7.Size = new System.Drawing.Size(308, 24);
            this.flowLayoutPanel7.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "PHY Type(s):";
            // 
            // PHYTypetxt
            // 
            this.PHYTypetxt.AutoSize = true;
            this.PHYTypetxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.PHYTypetxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PHYTypetxt.ForeColor = System.Drawing.Color.Black;
            this.PHYTypetxt.Location = new System.Drawing.Point(110, 0);
            this.PHYTypetxt.Name = "PHYTypetxt";
            this.PHYTypetxt.Size = new System.Drawing.Size(59, 19);
            this.PHYTypetxt.TabIndex = 2;
            this.PHYTypetxt.Text = "Unsure";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.label8);
            this.flowLayoutPanel6.Controls.Add(this.accessPointFlagstxt);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(10, 245);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(308, 24);
            this.flowLayoutPanel6.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Flags:";
            // 
            // accessPointFlagstxt
            // 
            this.accessPointFlagstxt.AutoSize = true;
            this.accessPointFlagstxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.accessPointFlagstxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accessPointFlagstxt.ForeColor = System.Drawing.Color.Black;
            this.accessPointFlagstxt.Location = new System.Drawing.Point(57, 0);
            this.accessPointFlagstxt.Name = "accessPointFlagstxt";
            this.accessPointFlagstxt.Size = new System.Drawing.Size(59, 19);
            this.accessPointFlagstxt.TabIndex = 2;
            this.accessPointFlagstxt.Text = "Unsure";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.noConnectReasontxt);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(10, 221);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(308, 24);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Reason:";
            // 
            // noConnectReasontxt
            // 
            this.noConnectReasontxt.AutoSize = true;
            this.noConnectReasontxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.noConnectReasontxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noConnectReasontxt.ForeColor = System.Drawing.Color.Black;
            this.noConnectReasontxt.Location = new System.Drawing.Point(72, 0);
            this.noConnectReasontxt.Name = "noConnectReasontxt";
            this.noConnectReasontxt.Size = new System.Drawing.Size(109, 19);
            this.noConnectReasontxt.TabIndex = 2;
            this.noConnectReasontxt.Text = "Not applicable";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.Connectabletxt);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(10, 197);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(308, 24);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Connectable:";
            // 
            // Connectabletxt
            // 
            this.Connectabletxt.AutoSize = true;
            this.Connectabletxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Connectabletxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Connectabletxt.ForeColor = System.Drawing.Color.Black;
            this.Connectabletxt.Location = new System.Drawing.Point(107, 0);
            this.Connectabletxt.Name = "Connectabletxt";
            this.Connectabletxt.Size = new System.Drawing.Size(59, 19);
            this.Connectabletxt.TabIndex = 2;
            this.Connectabletxt.Text = "Unsure";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.SignalStrengthtxt);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(10, 173);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(308, 24);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Signal strength:";
            // 
            // SignalStrengthtxt
            // 
            this.SignalStrengthtxt.AutoSize = true;
            this.SignalStrengthtxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.SignalStrengthtxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignalStrengthtxt.ForeColor = System.Drawing.Color.Black;
            this.SignalStrengthtxt.Location = new System.Drawing.Point(127, 0);
            this.SignalStrengthtxt.Name = "SignalStrengthtxt";
            this.SignalStrengthtxt.Size = new System.Drawing.Size(59, 19);
            this.SignalStrengthtxt.TabIndex = 2;
            this.SignalStrengthtxt.Text = "Unsure";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.Ciphertxt);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 149);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(308, 24);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cipher:";
            // 
            // Ciphertxt
            // 
            this.Ciphertxt.AutoSize = true;
            this.Ciphertxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ciphertxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ciphertxt.ForeColor = System.Drawing.Color.Black;
            this.Ciphertxt.Location = new System.Drawing.Point(67, 0);
            this.Ciphertxt.Name = "Ciphertxt";
            this.Ciphertxt.Size = new System.Drawing.Size(59, 19);
            this.Ciphertxt.TabIndex = 2;
            this.Ciphertxt.Text = "Unsure";
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel9.Controls.Add(this.label10);
            this.flowLayoutPanel9.Controls.Add(this.APRatetxt);
            this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(10, 125);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel9.Size = new System.Drawing.Size(308, 24);
            this.flowLayoutPanel9.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Speeds:";
            // 
            // APRatetxt
            // 
            this.APRatetxt.AutoSize = true;
            this.APRatetxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.APRatetxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APRatetxt.ForeColor = System.Drawing.Color.Black;
            this.APRatetxt.Location = new System.Drawing.Point(71, 0);
            this.APRatetxt.Name = "APRatetxt";
            this.APRatetxt.Size = new System.Drawing.Size(59, 19);
            this.APRatetxt.TabIndex = 2;
            this.APRatetxt.Text = "Unsure";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.Nametxt);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 24);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "SSID:";
            // 
            // Nametxt
            // 
            this.Nametxt.AutoSize = true;
            this.Nametxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nametxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nametxt.ForeColor = System.Drawing.Color.Black;
            this.Nametxt.Location = new System.Drawing.Point(56, 0);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(59, 19);
            this.Nametxt.TabIndex = 2;
            this.Nametxt.Text = "Unsure";
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.AutoSize = true;
            this.flowLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel10.Controls.Add(this.label11);
            this.flowLayoutPanel10.Controls.Add(this.BSSIDtxt);
            this.flowLayoutPanel10.Controls.Add(this.BSSIDTypetxt);
            this.flowLayoutPanel10.Controls.Add(this.LAAUAALearnLink);
            this.flowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(10, 25);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel10.Size = new System.Drawing.Size(308, 76);
            this.flowLayoutPanel10.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "BSSID:";
            // 
            // BSSIDtxt
            // 
            this.BSSIDtxt.Location = new System.Drawing.Point(3, 22);
            this.BSSIDtxt.Name = "BSSIDtxt";
            this.BSSIDtxt.ReadOnly = true;
            this.BSSIDtxt.Size = new System.Drawing.Size(298, 27);
            this.BSSIDtxt.TabIndex = 3;
            // 
            // BSSIDTypetxt
            // 
            this.BSSIDTypetxt.AutoSize = true;
            this.BSSIDTypetxt.Location = new System.Drawing.Point(3, 52);
            this.BSSIDTypetxt.Name = "BSSIDTypetxt";
            this.BSSIDTypetxt.Size = new System.Drawing.Size(139, 19);
            this.BSSIDTypetxt.TabIndex = 4;
            this.BSSIDTypetxt.Text = "LAA/UAA: Unsure";
            // 
            // LAAUAALearnLink
            // 
            this.LAAUAALearnLink.AutoSize = true;
            this.LAAUAALearnLink.Location = new System.Drawing.Point(148, 52);
            this.LAAUAALearnLink.Name = "LAAUAALearnLink";
            this.LAAUAALearnLink.Size = new System.Drawing.Size(93, 19);
            this.LAAUAALearnLink.TabIndex = 5;
            this.LAAUAALearnLink.TabStop = true;
            this.LAAUAALearnLink.Text = "What\'s this?";
            this.LAAUAALearnLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LAAUAALearnLink_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContentsContainer);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinWLAN";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.mainContentsContainer.Panel1.ResumeLayout(false);
            this.mainContentsContainer.Panel2.ResumeLayout(false);
            this.mainContentsContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContentsContainer)).EndInit();
            this.mainContentsContainer.ResumeLayout(false);
            this.wifiListContainer.ResumeLayout(false);
            this.wifiListContainer.PerformLayout();
            this.actionsContainer.ResumeLayout(false);
            this.actionsContainer.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private SplitContainer mainContentsContainer;
        private Panel wifiListContainer;
        private ListControl wlanList;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label6;
        private Label SignalStrengthtxt;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private Label Ciphertxt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label Nametxt;
        private FlowLayoutPanel actionsContainer;
        private Button refreshWifiListBtn;
        private Button connectToSelectedBtn;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private Label Connectabletxt;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label5;
        private Label noConnectReasontxt;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label8;
        private Label accessPointFlagstxt;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label7;
        private Label PHYTypetxt;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label9;
        private Label APTypetxt;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label label10;
        private Label APRatetxt;
        private FlowLayoutPanel flowLayoutPanel10;
        private Label label11;
        private TextBox BSSIDtxt;
        private Label BSSIDTypetxt;
        private LinkLabel LAAUAALearnLink;
        private FlowLayoutPanel flowLayoutPanel11;
        private Label label1;
        private LinkLabel ManagedNativeWifilnk;
        private LinkLabel simpleWifilnk;
    }
}
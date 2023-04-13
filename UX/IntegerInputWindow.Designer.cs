namespace WinWLAN.UX
{
    partial class IntegerInputWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntegerInputWindow));
            this.Requesttxt = new System.Windows.Forms.Label();
            this.actionsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.submitBtn = new System.Windows.Forms.Button();
            this.valueAdjustment = new System.Windows.Forms.TrackBar();
            this.currentValueTxt = new System.Windows.Forms.Label();
            this.actionsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueAdjustment)).BeginInit();
            this.SuspendLayout();
            // 
            // Requesttxt
            // 
            this.Requesttxt.AutoSize = true;
            this.Requesttxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Requesttxt.Location = new System.Drawing.Point(15, 15);
            this.Requesttxt.Name = "Requesttxt";
            this.Requesttxt.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Requesttxt.Size = new System.Drawing.Size(93, 28);
            this.Requesttxt.TabIndex = 5;
            this.Requesttxt.Text = "Request title:";
            // 
            // actionsContainer
            // 
            this.actionsContainer.AutoSize = true;
            this.actionsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actionsContainer.Controls.Add(this.submitBtn);
            this.actionsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsContainer.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.actionsContainer.Location = new System.Drawing.Point(15, 129);
            this.actionsContainer.Name = "actionsContainer";
            this.actionsContainer.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.actionsContainer.Size = new System.Drawing.Size(431, 58);
            this.actionsContainer.TabIndex = 7;
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.submitBtn.AutoSize = true;
            this.submitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(357, 18);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Padding = new System.Windows.Forms.Padding(5);
            this.submitBtn.Size = new System.Drawing.Size(71, 37);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // valueAdjustment
            // 
            this.valueAdjustment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueAdjustment.Location = new System.Drawing.Point(15, 43);
            this.valueAdjustment.Name = "valueAdjustment";
            this.valueAdjustment.Size = new System.Drawing.Size(431, 58);
            this.valueAdjustment.TabIndex = 8;
            this.valueAdjustment.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valueAdjustment.ValueChanged += new System.EventHandler(this.valueAdjustment_ValueChanged);
            // 
            // currentValueTxt
            // 
            this.currentValueTxt.AutoSize = true;
            this.currentValueTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.currentValueTxt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentValueTxt.Location = new System.Drawing.Point(15, 101);
            this.currentValueTxt.Name = "currentValueTxt";
            this.currentValueTxt.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.currentValueTxt.Size = new System.Drawing.Size(18, 28);
            this.currentValueTxt.TabIndex = 9;
            this.currentValueTxt.Text = "0";
            // 
            // IntegerInputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(461, 202);
            this.Controls.Add(this.valueAdjustment);
            this.Controls.Add(this.currentValueTxt);
            this.Controls.Add(this.Requesttxt);
            this.Controls.Add(this.actionsContainer);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntegerInputWindow";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinWLAN - Integer input";
            this.actionsContainer.ResumeLayout(false);
            this.actionsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueAdjustment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Requesttxt;
        private FlowLayoutPanel actionsContainer;
        private Button submitBtn;
        private TrackBar valueAdjustment;
        private Label currentValueTxt;
    }
}
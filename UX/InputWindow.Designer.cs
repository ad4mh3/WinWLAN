namespace WinWLAN.UX
{
    partial class InputWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputWindow));
            this.Requesttxt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.actionsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.submitBtn = new System.Windows.Forms.Button();
            this.actionsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Requesttxt
            // 
            this.Requesttxt.AutoSize = true;
            this.Requesttxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Requesttxt.Location = new System.Drawing.Point(15, 15);
            this.Requesttxt.Name = "Requesttxt";
            this.Requesttxt.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Requesttxt.Size = new System.Drawing.Size(102, 29);
            this.Requesttxt.TabIndex = 2;
            this.Requesttxt.Text = "Request title:";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(172)))), ((int)(((byte)(110)))));
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.ForeColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(15, 44);
            this.txtInput.MaxLength = 9999;
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(431, 85);
            this.txtInput.TabIndex = 3;
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
            this.actionsContainer.TabIndex = 4;
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
            // InputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(461, 202);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.Requesttxt);
            this.Controls.Add(this.actionsContainer);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputWindow";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinWLAN - Input";
            this.actionsContainer.ResumeLayout(false);
            this.actionsContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Requesttxt;
        private TextBox txtInput;
        private FlowLayoutPanel actionsContainer;
        private Button submitBtn;
    }
}
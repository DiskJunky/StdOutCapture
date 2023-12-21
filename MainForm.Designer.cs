namespace StdOutCapture
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCommand = new Label();
            txtCommand = new TextBox();
            btnStart = new Button();
            ssStatus = new StatusStrip();
            tssDResultCode = new ToolStripStatusLabel();
            tssResultCode = new ToolStripStatusLabel();
            txtOutput = new TextBox();
            ssStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lblCommand
            // 
            lblCommand.AutoSize = true;
            lblCommand.Location = new Point(12, 15);
            lblCommand.Name = "lblCommand";
            lblCommand.Size = new Size(100, 25);
            lblCommand.TabIndex = 0;
            lblCommand.Text = "Command:";
            // 
            // txtCommand
            // 
            txtCommand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCommand.Location = new Point(118, 12);
            txtCommand.Name = "txtCommand";
            txtCommand.Size = new Size(509, 31);
            txtCommand.TabIndex = 1;
            txtCommand.Text = "dotnet build ..\\..\\..\\";
            txtCommand.KeyDown += txtCommand_KeyDown;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStart.Location = new Point(633, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 2;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // ssStatus
            // 
            ssStatus.ImageScalingSize = new Size(24, 24);
            ssStatus.Items.AddRange(new ToolStripItem[] { tssDResultCode, tssResultCode });
            ssStatus.Location = new Point(0, 446);
            ssStatus.Name = "ssStatus";
            ssStatus.Size = new Size(757, 32);
            ssStatus.TabIndex = 3;
            ssStatus.Text = "statusStrip1";
            // 
            // tssDResultCode
            // 
            tssDResultCode.Name = "tssDResultCode";
            tssDResultCode.Size = new Size(110, 25);
            tssDResultCode.Text = "Result Code:";
            // 
            // tssResultCode
            // 
            tssResultCode.Name = "tssResultCode";
            tssResultCode.Size = new Size(22, 25);
            tssResultCode.Text = "0";
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.BackColor = Color.Black;
            txtOutput.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOutput.ForeColor = Color.Silver;
            txtOutput.Location = new Point(12, 49);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(733, 394);
            txtOutput.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 478);
            Controls.Add(txtOutput);
            Controls.Add(ssStatus);
            Controls.Add(btnStart);
            Controls.Add(txtCommand);
            Controls.Add(lblCommand);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Capture Output";
            ssStatus.ResumeLayout(false);
            ssStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCommand;
        private TextBox txtCommand;
        private Button btnStart;
        private StatusStrip ssStatus;
        private ToolStripStatusLabel tssDResultCode;
        private ToolStripStatusLabel tssResultCode;
        private TextBox txtOutput;
    }
}

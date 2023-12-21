using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace StdOutCapture
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                btnStart.Enabled = false;

                // get the command and arguments
                var segments = txtCommand.Text.Trim().Split(" ");
                txtOutput.Text = string.Empty;

                var startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.FileName = segments[0];
                startInfo.Arguments = string.Join(" ", segments.Skip(1));
                startInfo.CreateNoWindow = true;

                using (var process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.EnableRaisingEvents = true;
                    process.OutputDataReceived += Process_OutputDataReceived;

                    process.Start();
                    
                    process.BeginOutputReadLine();
                    await process.WaitForExitAsync();
                    process.CancelOutputRead();
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.ToString();
            }
            finally
            {
                btnStart.Enabled = true;
            }
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            txtOutput.Invoke(() =>
            {
                txtOutput.AppendText(Environment.NewLine + e.Data);
                txtOutput.SelectionStart = txtOutput.Text.Length;
                txtOutput.SelectionLength = 0;
            });
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnStart_Click(sender, null);
            }
        }
    }
}

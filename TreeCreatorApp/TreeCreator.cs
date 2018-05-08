using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TreeCreatorApp
{
    public enum Simulation { No, Yes };
    
    public partial class TreeCreator : Form
    {
        private const string SIMULATION = "*** Simulation *** ";
        public Simulation Simulation { get; set; }
        
        public TreeCreator()
        {
            InitializeComponent();
        }
        private void TreeCreator_Load(object sender, EventArgs e)
        {
            console.ReadOnly = true;
            Simulation = Simulation.Yes;
            AppendToConsole(Validator.Usage(true),true);
#if DEBUG
            txtPackageDir.Text = "C:/Temp";
            txtWorkingDir.Text = "C:/TempProd";
            txtDestinationDir.Text = "C:/TempRollback";
#endif
        }
        public void AppendToConsole(string text,bool IsFirstTime = false)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(console.Text);
            sb.AppendLine(Simulation.Equals(Simulation.Yes) && !IsFirstTime ? SIMULATION + text : text);
            console.Clear();
            console.Text = sb.ToString();
            console.Font = new Font("Maiandra GD", 13);
            console.ForeColor = this.Simulation.Equals(Simulation.Yes) ? Color.LawnGreen : Color.Red;
        }
        private void lblPackage_Click(object sender, EventArgs e)
        {

        }

        private void lblProductionPackage_Click(object sender, EventArgs e)
        {

        }

        private void txtWorkingDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Simulation = Simulation.No;
            string errMsg = string.Empty;
            string[] args = new string[3] { txtPackageDir.Text, txtWorkingDir.Text, txtDestinationDir.Text };
            if (Validator.IsValid(args,out errMsg))
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Processor p = new Processor();
                bool success = p.StartProcessing(args, this);
                sw.Stop();
                if (success)
                    AppendToConsole(string.Format("Finished successfully! total time wasted: {0}", GetTimeSpanFormat(sw.Elapsed)));
                else
                    AppendToConsole(string.Format("Stopped due to the errors above"));
            }
            else
            {
                AppendToConsole(errMsg);
                AppendToConsole(Validator.Usage(false));
            }
        }

        private void console_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            console.SelectionStart = console.Text.Length;            
            // scroll it automatically
            console.ScrollToCaret();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void txtPackageDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDestDirectory_Click(object sender, EventArgs e)
        {

        }

        private void txtDestinationDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            console.Clear();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            this.Simulation = Simulation.Yes;
            string errMsg = string.Empty;
            string[] args = new string[3] { txtPackageDir.Text, txtWorkingDir.Text, txtDestinationDir.Text };
            if (Validator.IsValid(args, out errMsg,this.Simulation))
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Processor p = new Processor();
                bool success = p.StartProcessing(args, this);
                sw.Stop();
                if (success)
                    AppendToConsole(string.Format("Simulator has finished successfully! total time wasted: {0}", GetTimeSpanFormat(sw.Elapsed)));
                else
                    AppendToConsole(string.Format("Simulator was stopped due to the errors above"));
            }
            else
            {
                AppendToConsole(errMsg);
                AppendToConsole(Validator.Usage(false));
            }
        }
        private string GetTimeSpanFormat(TimeSpan ts)
        {
            return string.Format("{0}:{1}", Math.Floor(ts.TotalMinutes), ts.ToString("ss\\.ff"));
        }
    }
}

namespace LearnAndTest.Events
{
    partial class frmSimpleEvent
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
            this.ctrlCalculator1 = new LearnAndTest.ctrlCalculator();
            this.SuspendLayout();
            // 
            // ctrlCalculator1
            // 
            this.ctrlCalculator1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlCalculator1.Location = new System.Drawing.Point(12, 12);
            this.ctrlCalculator1.Name = "ctrlCalculator1";
            this.ctrlCalculator1.Size = new System.Drawing.Size(366, 150);
            this.ctrlCalculator1.TabIndex = 0;
            this.ctrlCalculator1.OnCalculationComplete += new System.EventHandler<LearnAndTest.ctrlCalculator.CalculationEventArgs>(this.ctrlCalculator1_OnCalculationComplete_1);
            // 
            // frmSimpleEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlCalculator1);
            this.Name = "frmSimpleEvent";
            this.Text = "frmSimpleEvent";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCalculator ctrlCalculator1;
    }
}
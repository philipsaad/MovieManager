namespace MovieManager.WF
{
    partial class WaitingForm
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
      this.waitingLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // waitingLabel
      // 
      this.waitingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.waitingLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.waitingLabel.Location = new System.Drawing.Point(0, 0);
      this.waitingLabel.Name = "waitingLabel";
      this.waitingLabel.Size = new System.Drawing.Size(300, 84);
      this.waitingLabel.TabIndex = 0;
      this.waitingLabel.Text = "Loading...";
      this.waitingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.waitingLabel.UseWaitCursor = true;
      // 
      // WaitingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(300, 84);
      this.Controls.Add(this.waitingLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "WaitingForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.TopMost = true;
      this.UseWaitCursor = true;
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label waitingLabel;
    }
}
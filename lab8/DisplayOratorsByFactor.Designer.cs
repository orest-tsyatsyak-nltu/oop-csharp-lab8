namespace lab8
{
    partial class DisplayOratorsByFactor
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
            this.orators = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // orators
            // 
            this.orators.FormattingEnabled = true;
            this.orators.Location = new System.Drawing.Point(12, 12);
            this.orators.Name = "orators";
            this.orators.Size = new System.Drawing.Size(628, 368);
            this.orators.TabIndex = 2;
            this.orators.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.orators_Format);
            // 
            // DisplayOratorsByFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 392);
            this.Controls.Add(this.orators);
            this.Name = "DisplayOratorsByFactor";
            this.Text = "DisplayOratorsByFactor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox orators;
    }
}
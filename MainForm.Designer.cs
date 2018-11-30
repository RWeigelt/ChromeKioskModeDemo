namespace ChromeKioskModeDemo
{
	partial class MainForm
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
			this._tableLayout = new System.Windows.Forms.TableLayoutPanel();
			this._openChromeButton = new System.Windows.Forms.Button();
			this._closeChromeButton = new System.Windows.Forms.Button();
			this._tableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tableLayout
			// 
			this._tableLayout.ColumnCount = 1;
			this._tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableLayout.Controls.Add(this._openChromeButton, 0, 0);
			this._tableLayout.Controls.Add(this._closeChromeButton, 0, 1);
			this._tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableLayout.Location = new System.Drawing.Point(0, 0);
			this._tableLayout.Name = "_tableLayout";
			this._tableLayout.RowCount = 2;
			this._tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableLayout.Size = new System.Drawing.Size(275, 192);
			this._tableLayout.TabIndex = 0;
			// 
			// _openChromeButton
			// 
			this._openChromeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._openChromeButton.Location = new System.Drawing.Point(87, 23);
			this._openChromeButton.Name = "_openChromeButton";
			this._openChromeButton.Size = new System.Drawing.Size(100, 50);
			this._openChromeButton.TabIndex = 0;
			this._openChromeButton.Text = "Open Chrome";
			this._openChromeButton.UseVisualStyleBackColor = true;
			this._openChromeButton.Click += new System.EventHandler(this.HandleOpenChromeButton_Click);
			// 
			// _closeChromeButton
			// 
			this._closeChromeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._closeChromeButton.Location = new System.Drawing.Point(87, 119);
			this._closeChromeButton.Name = "_closeChromeButton";
			this._closeChromeButton.Size = new System.Drawing.Size(100, 50);
			this._closeChromeButton.TabIndex = 1;
			this._closeChromeButton.Text = "Close Chrome";
			this._closeChromeButton.UseVisualStyleBackColor = true;
			this._closeChromeButton.Click += new System.EventHandler(this.HandleCloseChromeButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(275, 192);
			this.Controls.Add(this._tableLayout);
			this.Name = "MainForm";
			this.Text = "ChromeKioskMode";
			this._tableLayout.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _tableLayout;
		private System.Windows.Forms.Button _openChromeButton;
		private System.Windows.Forms.Button _closeChromeButton;
	}
}


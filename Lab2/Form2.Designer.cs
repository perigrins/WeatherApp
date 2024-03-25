namespace Lab2
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			label1 = new Label();
			plotView1 = new OxyPlot.WindowsForms.PlotView();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(24, 30);
			label1.Name = "label1";
			label1.Size = new Size(673, 100);
			label1.TabIndex = 0;
			label1.Text = "Comparison between temperature and\nperceptible temperature in Wrocław";
			// 
			// plotView1
			// 
			plotView1.Location = new Point(105, 218);
			plotView1.Name = "plotView1";
			plotView1.PanCursor = Cursors.Hand;
			plotView1.Size = new Size(1231, 689);
			plotView1.TabIndex = 1;
			plotView1.Text = "plotView1";
			plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
			plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
			plotView1.ZoomVerticalCursor = Cursors.SizeNS;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.RosyBrown;
			ClientSize = new Size(1424, 994);
			Controls.Add(plotView1);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form2";
			Text = "Statictics";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private OxyPlot.WindowsForms.PlotView plotView1;
	}
}
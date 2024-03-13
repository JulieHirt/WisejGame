namespace WisejHybridLocalApplication1
{
	partial class Page1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new Wisej.Web.Button();
			this.GameCanvas = new Wisej.Web.PictureBox();
			this.Ticker = new Wisej.Web.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(375, 127);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(192, 63);
			this.button1.TabIndex = 0;
			this.button1.Text = "Click Me!";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// GameCanvas
			// 
			this.GameCanvas.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.GameCanvas.Location = new System.Drawing.Point(65, 217);
			this.GameCanvas.Name = "GameCanvas";
			this.GameCanvas.Size = new System.Drawing.Size(640, 480);
			this.GameCanvas.Paint += new Wisej.Web.PaintEventHandler(this.GameCanvas_Paint);
			// 
			// Ticker
			// 
			this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.GameCanvas);
			this.Controls.Add(this.button1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1229, 559);
			this.Text = "Page1";
			((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button button1;
		private Wisej.Web.PictureBox GameCanvas;
		private Wisej.Web.Timer Ticker;
	}
}


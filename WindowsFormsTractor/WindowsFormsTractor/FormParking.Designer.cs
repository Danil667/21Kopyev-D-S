namespace WindowsFormsTractor
{
	partial class FormParking
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
			this.pictureBoxParking = new System.Windows.Forms.PictureBox();
			this.buttonSetTractor = new System.Windows.Forms.Button();
			this.buttonSetDop = new System.Windows.Forms.Button();
			this.groupBoxTake = new System.Windows.Forms.GroupBox();
			this.buttonTakeTractor = new System.Windows.Forms.Button();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.labelPlace = new System.Windows.Forms.Label();
			this.pictureBoxTakeTractor = new System.Windows.Forms.PictureBox();
			this.listBoxLevel = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
			this.groupBoxTake.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTractor)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxParking
			// 
			this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxParking.Name = "pictureBoxParking";
			this.pictureBoxParking.Size = new System.Drawing.Size(665, 452);
			this.pictureBoxParking.TabIndex = 0;
			this.pictureBoxParking.TabStop = false;
			// 
			// buttonSetTractor
			// 
			this.buttonSetTractor.Location = new System.Drawing.Point(671, 123);
			this.buttonSetTractor.Name = "buttonSetTractor";
			this.buttonSetTractor.Size = new System.Drawing.Size(93, 39);
			this.buttonSetTractor.TabIndex = 1;
			this.buttonSetTractor.Text = "припарковать трактор";
			this.buttonSetTractor.UseVisualStyleBackColor = true;
			this.buttonSetTractor.Click += new System.EventHandler(this.buttonSetTractor_Click);
			// 
			// buttonSetDop
			// 
			this.buttonSetDop.Location = new System.Drawing.Point(671, 168);
			this.buttonSetDop.Name = "buttonSetDop";
			this.buttonSetDop.Size = new System.Drawing.Size(93, 42);
			this.buttonSetDop.TabIndex = 2;
			this.buttonSetDop.Text = "припарковать экскаватор";
			this.buttonSetDop.UseVisualStyleBackColor = true;
			this.buttonSetDop.Click += new System.EventHandler(this.buttonSetDop_Click);
			// 
			// groupBoxTake
			// 
			this.groupBoxTake.Controls.Add(this.buttonTakeTractor);
			this.groupBoxTake.Controls.Add(this.maskedTextBox);
			this.groupBoxTake.Controls.Add(this.labelPlace);
			this.groupBoxTake.Location = new System.Drawing.Point(671, 216);
			this.groupBoxTake.Name = "groupBoxTake";
			this.groupBoxTake.Size = new System.Drawing.Size(117, 87);
			this.groupBoxTake.TabIndex = 3;
			this.groupBoxTake.TabStop = false;
			this.groupBoxTake.Text = "забрать ";
			// 
			// buttonTakeTractor
			// 
			this.buttonTakeTractor.Location = new System.Drawing.Point(18, 57);
			this.buttonTakeTractor.Name = "buttonTakeTractor";
			this.buttonTakeTractor.Size = new System.Drawing.Size(75, 23);
			this.buttonTakeTractor.TabIndex = 2;
			this.buttonTakeTractor.Text = "забрать";
			this.buttonTakeTractor.UseVisualStyleBackColor = true;
			this.buttonTakeTractor.Click += new System.EventHandler(this.buttonTakeTractor_Click);
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(58, 25);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(35, 20);
			this.maskedTextBox.TabIndex = 1;
			// 
			// labelPlace
			// 
			this.labelPlace.AutoSize = true;
			this.labelPlace.Location = new System.Drawing.Point(6, 25);
			this.labelPlace.Name = "labelPlace";
			this.labelPlace.Size = new System.Drawing.Size(38, 13);
			this.labelPlace.TabIndex = 0;
			this.labelPlace.Text = "место";
			// 
			// pictureBoxTakeTractor
			// 
			this.pictureBoxTakeTractor.Location = new System.Drawing.Point(671, 309);
			this.pictureBoxTakeTractor.Name = "pictureBoxTakeTractor";
			this.pictureBoxTakeTractor.Size = new System.Drawing.Size(126, 141);
			this.pictureBoxTakeTractor.TabIndex = 4;
			this.pictureBoxTakeTractor.TabStop = false;
			// 
			// listBoxLevel
			// 
			this.listBoxLevel.FormattingEnabled = true;
			this.listBoxLevel.Location = new System.Drawing.Point(671, 12);
			this.listBoxLevel.Name = "listBoxLevel";
			this.listBoxLevel.Size = new System.Drawing.Size(126, 108);
			this.listBoxLevel.TabIndex = 5;
			this.listBoxLevel.SelectedIndexChanged += new System.EventHandler(this.listBoxLevel_SelectedIndexChanged);
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 452);
			this.Controls.Add(this.listBoxLevel);
			this.Controls.Add(this.pictureBoxTakeTractor);
			this.Controls.Add(this.groupBoxTake);
			this.Controls.Add(this.buttonSetDop);
			this.Controls.Add(this.buttonSetTractor);
			this.Controls.Add(this.pictureBoxParking);
			this.Name = "FormParking";
			this.Text = "Parking";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
			this.groupBoxTake.ResumeLayout(false);
			this.groupBoxTake.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTractor)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.Button buttonSetTractor;
		private System.Windows.Forms.Button buttonSetDop;
		private System.Windows.Forms.GroupBox groupBoxTake;
		private System.Windows.Forms.Button buttonTakeTractor;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
		private System.Windows.Forms.Label labelPlace;
		private System.Windows.Forms.PictureBox pictureBoxTakeTractor;
		private System.Windows.Forms.ListBox listBoxLevel;
	}
}
namespace WindowsFormsTractor
{
	partial class FormTractorConfig
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
			this.pictureBoxTractor = new System.Windows.Forms.PictureBox();
			this.groupBoxBodyType = new System.Windows.Forms.GroupBox();
			this.labelTractorLoader = new System.Windows.Forms.Label();
			this.labelTractor = new System.Windows.Forms.Label();
			this.panelTractor = new System.Windows.Forms.Panel();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.labelBaseColor = new System.Windows.Forms.Label();
			this.groupBoxColor = new System.Windows.Forms.GroupBox();
			this.panelColor = new System.Windows.Forms.Panel();
			this.panelGold = new System.Windows.Forms.Panel();
			this.panelBlack = new System.Windows.Forms.Panel();
			this.panelGray = new System.Windows.Forms.Panel();
			this.panelWhite = new System.Windows.Forms.Panel();
			this.panelGreen = new System.Windows.Forms.Panel();
			this.panelRed = new System.Windows.Forms.Panel();
			this.panelBlue = new System.Windows.Forms.Panel();
			this.panelYellow = new System.Windows.Forms.Panel();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractor)).BeginInit();
			this.groupBoxBodyType.SuspendLayout();
			this.panelTractor.SuspendLayout();
			this.groupBoxColor.SuspendLayout();
			this.panelColor.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxTractor
			// 
			this.pictureBoxTractor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxTractor.Location = new System.Drawing.Point(12, 11);
			this.pictureBoxTractor.Name = "pictureBoxTractor";
			this.pictureBoxTractor.Size = new System.Drawing.Size(130, 139);
			this.pictureBoxTractor.TabIndex = 0;
			this.pictureBoxTractor.TabStop = false;
			// 
			// groupBoxBodyType
			// 
			this.groupBoxBodyType.Controls.Add(this.labelTractorLoader);
			this.groupBoxBodyType.Controls.Add(this.labelTractor);
			this.groupBoxBodyType.Location = new System.Drawing.Point(30, 72);
			this.groupBoxBodyType.Name = "groupBoxBodyType";
			this.groupBoxBodyType.Size = new System.Drawing.Size(142, 100);
			this.groupBoxBodyType.TabIndex = 1;
			this.groupBoxBodyType.TabStop = false;
			this.groupBoxBodyType.Text = "Тип кузова";
			// 
			// labelTractorLoader
			// 
			this.labelTractorLoader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelTractorLoader.Location = new System.Drawing.Point(7, 55);
			this.labelTractorLoader.Name = "labelTractorLoader";
			this.labelTractorLoader.Size = new System.Drawing.Size(115, 30);
			this.labelTractorLoader.TabIndex = 1;
			this.labelTractorLoader.Text = "Трактор-экскаватор";
			this.labelTractorLoader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTractorLoader_MouseDown);
			// 
			// labelTractor
			// 
			this.labelTractor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelTractor.Location = new System.Drawing.Point(7, 16);
			this.labelTractor.Name = "labelTractor";
			this.labelTractor.Size = new System.Drawing.Size(115, 30);
			this.labelTractor.TabIndex = 0;
			this.labelTractor.Text = "Обычный трактор";
			this.labelTractor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTractor_MouseDown);
			// 
			// panelTractor
			// 
			this.panelTractor.AllowDrop = true;
			this.panelTractor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTractor.Controls.Add(this.labelDopColor);
			this.panelTractor.Controls.Add(this.labelBaseColor);
			this.panelTractor.Controls.Add(this.pictureBoxTractor);
			this.panelTractor.Location = new System.Drawing.Point(228, 21);
			this.panelTractor.Name = "panelTractor";
			this.panelTractor.Size = new System.Drawing.Size(159, 217);
			this.panelTractor.TabIndex = 2;
			this.panelTractor.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTractor_DragDrop);
			this.panelTractor.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTractor_DragEnter);
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(32, 183);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(100, 23);
			this.labelDopColor.TabIndex = 4;
			this.labelDopColor.Text = "Дополнительный";
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// labelBaseColor
			// 
			this.labelBaseColor.AllowDrop = true;
			this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBaseColor.Location = new System.Drawing.Point(32, 155);
			this.labelBaseColor.Name = "labelBaseColor";
			this.labelBaseColor.Size = new System.Drawing.Size(100, 23);
			this.labelBaseColor.TabIndex = 3;
			this.labelBaseColor.Text = "Основной";
			this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// groupBoxColor
			// 
			this.groupBoxColor.Controls.Add(this.panelColor);
			this.groupBoxColor.Location = new System.Drawing.Point(475, 72);
			this.groupBoxColor.Name = "groupBoxColor";
			this.groupBoxColor.Size = new System.Drawing.Size(138, 225);
			this.groupBoxColor.TabIndex = 5;
			this.groupBoxColor.TabStop = false;
			this.groupBoxColor.Text = "Цвет";
			// 
			// panelColor
			// 
			this.panelColor.AllowDrop = true;
			this.panelColor.Controls.Add(this.panelGold);
			this.panelColor.Controls.Add(this.panelBlack);
			this.panelColor.Controls.Add(this.panelGray);
			this.panelColor.Controls.Add(this.panelWhite);
			this.panelColor.Controls.Add(this.panelGreen);
			this.panelColor.Controls.Add(this.panelRed);
			this.panelColor.Controls.Add(this.panelBlue);
			this.panelColor.Controls.Add(this.panelYellow);
			this.panelColor.Location = new System.Drawing.Point(6, 16);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new System.Drawing.Size(126, 203);
			this.panelColor.TabIndex = 6;
			// 
			// panelGold
			// 
			this.panelGold.BackColor = System.Drawing.Color.Gold;
			this.panelGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelGold.Location = new System.Drawing.Point(76, 164);
			this.panelGold.Name = "panelGold";
			this.panelGold.Size = new System.Drawing.Size(30, 30);
			this.panelGold.TabIndex = 1;
			this.panelGold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelBlack
			// 
			this.panelBlack.BackColor = System.Drawing.Color.Black;
			this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBlack.Location = new System.Drawing.Point(24, 12);
			this.panelBlack.Name = "panelBlack";
			this.panelBlack.Size = new System.Drawing.Size(30, 30);
			this.panelBlack.TabIndex = 0;
			this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGray
			// 
			this.panelGray.BackColor = System.Drawing.Color.Gray;
			this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelGray.Location = new System.Drawing.Point(24, 164);
			this.panelGray.Name = "panelGray";
			this.panelGray.Size = new System.Drawing.Size(30, 30);
			this.panelGray.TabIndex = 5;
			this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelWhite
			// 
			this.panelWhite.BackColor = System.Drawing.Color.White;
			this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelWhite.Location = new System.Drawing.Point(76, 12);
			this.panelWhite.Name = "panelWhite";
			this.panelWhite.Size = new System.Drawing.Size(30, 30);
			this.panelWhite.TabIndex = 1;
			this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGreen
			// 
			this.panelGreen.BackColor = System.Drawing.Color.Green;
			this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelGreen.Location = new System.Drawing.Point(24, 62);
			this.panelGreen.Name = "panelGreen";
			this.panelGreen.Size = new System.Drawing.Size(30, 30);
			this.panelGreen.TabIndex = 2;
			this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelRed
			// 
			this.panelRed.BackColor = System.Drawing.Color.Red;
			this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelRed.Location = new System.Drawing.Point(24, 117);
			this.panelRed.Name = "panelRed";
			this.panelRed.Size = new System.Drawing.Size(30, 30);
			this.panelRed.TabIndex = 4;
			this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelBlue
			// 
			this.panelBlue.BackColor = System.Drawing.Color.Blue;
			this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBlue.Location = new System.Drawing.Point(76, 62);
			this.panelBlue.Name = "panelBlue";
			this.panelBlue.Size = new System.Drawing.Size(30, 30);
			this.panelBlue.TabIndex = 3;
			this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelYellow
			// 
			this.panelYellow.BackColor = System.Drawing.Color.Yellow;
			this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelYellow.Location = new System.Drawing.Point(76, 117);
			this.panelYellow.Name = "panelYellow";
			this.panelYellow.Size = new System.Drawing.Size(30, 30);
			this.panelYellow.TabIndex = 1;
			this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(37, 173);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 6;
			this.buttonOk.Text = "Добавить";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(37, 215);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormTractorConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.groupBoxColor);
			this.Controls.Add(this.panelTractor);
			this.Controls.Add(this.groupBoxBodyType);
			this.Name = "FormTractorConfig";
			this.Text = "FormTractorConfig";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractor)).EndInit();
			this.groupBoxBodyType.ResumeLayout(false);
			this.panelTractor.ResumeLayout(false);
			this.groupBoxColor.ResumeLayout(false);
			this.panelColor.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxTractor;
		private System.Windows.Forms.GroupBox groupBoxBodyType;
		private System.Windows.Forms.Label labelTractorLoader;
		private System.Windows.Forms.Label labelTractor;
		private System.Windows.Forms.Panel panelTractor;
		private System.Windows.Forms.Label labelBaseColor;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.GroupBox groupBoxColor;
		private System.Windows.Forms.Panel panelColor;
		private System.Windows.Forms.Panel panelGold;
		private System.Windows.Forms.Panel panelBlack;
		private System.Windows.Forms.Panel panelGray;
		private System.Windows.Forms.Panel panelWhite;
		private System.Windows.Forms.Panel panelGreen;
		private System.Windows.Forms.Panel panelRed;
		private System.Windows.Forms.Panel panelBlue;
		private System.Windows.Forms.Panel panelYellow;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
	}
}
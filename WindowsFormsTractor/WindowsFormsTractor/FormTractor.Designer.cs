namespace WindowsFormsTractor
{
	partial class FormTractor
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.pictureBoxTractor = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractor)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = global::WindowsFormsTractor.Properties.Resources.Снимок2;
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(644, 418);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(30, 30);
			this.buttonRight.TabIndex = 11;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = global::WindowsFormsTractor.Properties.Resources.Снимок4;
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(608, 418);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(30, 30);
			this.buttonDown.TabIndex = 10;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = global::WindowsFormsTractor.Properties.Resources.Снимок3;
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(572, 418);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(30, 30);
			this.buttonLeft.TabIndex = 9;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = global::WindowsFormsTractor.Properties.Resources.Снимок;
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonUp.Location = new System.Drawing.Point(608, 382);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(30, 30);
			this.buttonUp.TabIndex = 8;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(0, 0);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(75, 23);
			this.buttonCreate.TabIndex = 7;
			this.buttonCreate.Text = "создать";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// pictureBoxTractor
			// 
			this.pictureBoxTractor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxTractor.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxTractor.Name = "pictureBoxTractor";
			this.pictureBoxTractor.Size = new System.Drawing.Size(800, 450);
			this.pictureBoxTractor.TabIndex = 6;
			this.pictureBoxTractor.TabStop = false;
			// 
			// FormTractor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.pictureBoxTractor);
			this.Name = "FormTractor";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractor)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.PictureBox pictureBoxTractor;
	}
}


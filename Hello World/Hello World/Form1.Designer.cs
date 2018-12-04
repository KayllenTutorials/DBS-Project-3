namespace Hello_World
{
	partial class m_frmHelloWorld
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
			this.m_lblGreeting = new System.Windows.Forms.Label();
			this.m_tbGreeting = new System.Windows.Forms.TextBox();
			this.m_btnSayHelloWorld = new System.Windows.Forms.Button();
			this.m_tbWhoToTarget = new System.Windows.Forms.TextBox();
			this.m_lblWhoToGreet = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_lblGreeting
			// 
			this.m_lblGreeting.AutoSize = true;
			this.m_lblGreeting.Location = new System.Drawing.Point(37, 50);
			this.m_lblGreeting.Name = "m_lblGreeting";
			this.m_lblGreeting.Size = new System.Drawing.Size(47, 13);
			this.m_lblGreeting.TabIndex = 0;
			this.m_lblGreeting.Text = "Greeting";
			// 
			// m_tbGreeting
			// 
			this.m_tbGreeting.Location = new System.Drawing.Point(90, 47);
			this.m_tbGreeting.Name = "m_tbGreeting";
			this.m_tbGreeting.ReadOnly = true;
			this.m_tbGreeting.Size = new System.Drawing.Size(160, 20);
			this.m_tbGreeting.TabIndex = 1;
			// 
			// m_btnSayHelloWorld
			// 
			this.m_btnSayHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_btnSayHelloWorld.Location = new System.Drawing.Point(51, 97);
			this.m_btnSayHelloWorld.Name = "m_btnSayHelloWorld";
			this.m_btnSayHelloWorld.Size = new System.Drawing.Size(199, 40);
			this.m_btnSayHelloWorld.TabIndex = 2;
			this.m_btnSayHelloWorld.Text = "Say \"Hello, World!\"";
			this.m_btnSayHelloWorld.UseVisualStyleBackColor = true;
			this.m_btnSayHelloWorld.Click += new System.EventHandler(this.m_btnSayHelloWorld_Click);
			// 
			// m_tbWhoToTarget
			// 
			this.m_tbWhoToTarget.Location = new System.Drawing.Point(118, 183);
			this.m_tbWhoToTarget.Name = "m_tbWhoToTarget";
			this.m_tbWhoToTarget.Size = new System.Drawing.Size(132, 20);
			this.m_tbWhoToTarget.TabIndex = 3;
			this.m_tbWhoToTarget.TextChanged += new System.EventHandler(this.m_tbWhoToTarget_TextChanged);
			// 
			// m_lblWhoToGreet
			// 
			this.m_lblWhoToGreet.AutoSize = true;
			this.m_lblWhoToGreet.Location = new System.Drawing.Point(37, 186);
			this.m_lblWhoToGreet.Name = "m_lblWhoToGreet";
			this.m_lblWhoToGreet.Size = new System.Drawing.Size(75, 13);
			this.m_lblWhoToGreet.TabIndex = 4;
			this.m_lblWhoToGreet.Text = "Who To Greet";
			this.m_lblWhoToGreet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_frmHelloWorld
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.m_lblWhoToGreet);
			this.Controls.Add(this.m_tbWhoToTarget);
			this.Controls.Add(this.m_btnSayHelloWorld);
			this.Controls.Add(this.m_tbGreeting);
			this.Controls.Add(this.m_lblGreeting);
			this.Name = "m_frmHelloWorld";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hello, World!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label m_lblGreeting;
		private System.Windows.Forms.TextBox m_tbGreeting;
		private System.Windows.Forms.Button m_btnSayHelloWorld;
		private System.Windows.Forms.TextBox m_tbWhoToTarget;
		private System.Windows.Forms.Label m_lblWhoToGreet;
	}
}


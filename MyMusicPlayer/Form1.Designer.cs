namespace MyMusicPlayer
{
     partial class Form1
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.Player = new AxWMPLib.AxWindowsMediaPlayer();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.button1 = new System.Windows.Forms.Button();
               this.Exit = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
               ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
               this.SuspendLayout();
               // 
               // Player
               // 
               this.Player.Enabled = true;
               this.Player.Location = new System.Drawing.Point(1, 1);
               this.Player.Name = "Player";
               this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
               this.Player.Size = new System.Drawing.Size(1197, 495);
               this.Player.TabIndex = 0;
               this.Player.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(1, 465);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(110, 31);
               this.textBox1.TabIndex = 1;
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.BlueViolet;
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.Color.White;
               this.button1.Location = new System.Drawing.Point(12, 518);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(173, 42);
               this.button1.TabIndex = 2;
               this.button1.Text = "Browse";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // Exit
               // 
               this.Exit.BackColor = System.Drawing.Color.DarkBlue;
               this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Exit.ForeColor = System.Drawing.Color.White;
               this.Exit.Location = new System.Drawing.Point(922, 518);
               this.Exit.Name = "Exit";
               this.Exit.Size = new System.Drawing.Size(173, 42);
               this.Exit.TabIndex = 3;
               this.Exit.Text = "Exit";
               this.Exit.UseVisualStyleBackColor = false;
               this.Exit.Click += new System.EventHandler(this.Exit_Click);
               // 
               // button3
               // 
               this.button3.BackColor = System.Drawing.Color.Goldenrod;
               this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.ForeColor = System.Drawing.Color.White;
               this.button3.Location = new System.Drawing.Point(706, 518);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(173, 42);
               this.button3.TabIndex = 4;
               this.button3.Text = "Stop";
               this.button3.UseVisualStyleBackColor = false;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // button4
               // 
               this.button4.BackColor = System.Drawing.Color.Crimson;
               this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button4.ForeColor = System.Drawing.Color.White;
               this.button4.Location = new System.Drawing.Point(474, 518);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(173, 42);
               this.button4.TabIndex = 5;
               this.button4.Text = "Pause";
               this.button4.UseVisualStyleBackColor = false;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // button5
               // 
               this.button5.BackColor = System.Drawing.Color.DodgerBlue;
               this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button5.ForeColor = System.Drawing.Color.White;
               this.button5.Location = new System.Drawing.Point(241, 518);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(173, 42);
               this.button5.TabIndex = 6;
               this.button5.Text = "Play";
               this.button5.UseVisualStyleBackColor = false;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // openFileDialog1
               // 
               this.openFileDialog1.FileName = "openFileDialog1";
               this.openFileDialog1.Multiselect = true;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LimeGreen;
               this.ClientSize = new System.Drawing.Size(1201, 594);
               this.Controls.Add(this.button5);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.Exit);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.Player);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.MaximizeBox = false;
               this.Name = "Form1";
               this.ShowInTaskbar = false;
               this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "My Music Player";
               ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private AxWMPLib.AxWindowsMediaPlayer Player;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button Exit;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button button5;
          private System.Windows.Forms.OpenFileDialog openFileDialog1;
     }
}


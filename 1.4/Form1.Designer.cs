
namespace Lab1._4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrush = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnMagenta = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnCyan = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Speed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Songs = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Open = new System.Windows.Forms.Button();
            this.ShapeView = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShapeView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrush);
            this.groupBox1.Controls.Add(this.btnPen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing Tool";
            // 
            // btnBrush
            // 
            this.btnBrush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBrush.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrush.Location = new System.Drawing.Point(7, 70);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(106, 23);
            this.btnBrush.TabIndex = 1;
            this.btnBrush.Text = "Brush";
            this.btnBrush.UseVisualStyleBackColor = false;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPen.Location = new System.Drawing.Point(7, 31);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(106, 23);
            this.btnPen.TabIndex = 0;
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLine);
            this.groupBox2.Controls.Add(this.btnSquare);
            this.groupBox2.Controls.Add(this.btnCircle);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Shape";
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLine.Location = new System.Drawing.Point(7, 20);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(101, 23);
            this.btnLine.TabIndex = 3;
            this.btnLine.Text = "&Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSquare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSquare.Location = new System.Drawing.Point(7, 114);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(101, 23);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.Text = "&Square";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCircle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCircle.Location = new System.Drawing.Point(7, 65);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(101, 23);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "&Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWhite);
            this.groupBox3.Controls.Add(this.btnYellow);
            this.groupBox3.Controls.Add(this.btnMagenta);
            this.groupBox3.Controls.Add(this.btnRed);
            this.groupBox3.Controls.Add(this.btnCyan);
            this.groupBox3.Controls.Add(this.btnGreen);
            this.groupBox3.Controls.Add(this.btnBlue);
            this.groupBox3.Controls.Add(this.btnBlack);
            this.groupBox3.Location = new System.Drawing.Point(190, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 343);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnWhite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWhite.Location = new System.Drawing.Point(0, 304);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(106, 23);
            this.btnWhite.TabIndex = 8;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnYellow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYellow.Location = new System.Drawing.Point(0, 266);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(106, 23);
            this.btnYellow.TabIndex = 7;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnMagenta
            // 
            this.btnMagenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMagenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMagenta.Location = new System.Drawing.Point(0, 227);
            this.btnMagenta.Name = "btnMagenta";
            this.btnMagenta.Size = new System.Drawing.Size(106, 23);
            this.btnMagenta.TabIndex = 6;
            this.btnMagenta.Text = "Magenta";
            this.btnMagenta.UseVisualStyleBackColor = false;
            this.btnMagenta.Click += new System.EventHandler(this.btnMagenta_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRed.Location = new System.Drawing.Point(0, 182);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(106, 23);
            this.btnRed.TabIndex = 5;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnCyan
            // 
            this.btnCyan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCyan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCyan.Location = new System.Drawing.Point(0, 144);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(106, 23);
            this.btnCyan.TabIndex = 4;
            this.btnCyan.Text = "Cyan";
            this.btnCyan.UseVisualStyleBackColor = false;
            this.btnCyan.Click += new System.EventHandler(this.btnCyan_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGreen.Location = new System.Drawing.Point(0, 102);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(106, 23);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBlue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlue.Location = new System.Drawing.Point(0, 59);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(106, 23);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBlack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlack.Location = new System.Drawing.Point(0, 20);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(106, 23);
            this.btnBlack.TabIndex = 1;
            this.btnBlack.Text = "Black";
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Red;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.Location = new System.Drawing.Point(685, 23);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(26, 20);
            this.btnClean.TabIndex = 5;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(705, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(-7, 569);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(788, 37);
            this.player.TabIndex = 16;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(428, 26);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(149, 45);
            this.Speed.TabIndex = 10;
            this.Speed.Scroll += new System.EventHandler(this.Speed_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(27, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Voice";
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(107, 26);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(153, 45);
            this.Volume.TabIndex = 8;
            this.Volume.Scroll += new System.EventHandler(this.Volume_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(353, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Speed";
            // 
            // Songs
            // 
            this.Songs.FormattingEnabled = true;
            this.Songs.Location = new System.Drawing.Point(107, 78);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(195, 69);
            this.Songs.TabIndex = 17;
            this.Songs.SelectedIndexChanged += new System.EventHandler(this.Songs_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Pause);
            this.groupBox4.Controls.Add(this.Open);
            this.groupBox4.Controls.Add(this.Songs);
            this.groupBox4.Controls.Add(this.Play);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Volume);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.Speed);
            this.groupBox4.Location = new System.Drawing.Point(19, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(610, 170);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sound Options";
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.SystemColors.Desktop;
            this.Open.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Open.Location = new System.Drawing.Point(318, 115);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(55, 32);
            this.Open.TabIndex = 18;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // ShapeView
            // 
            this.ShapeView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShapeView.Location = new System.Drawing.Point(375, 43);
            this.ShapeView.Name = "ShapeView";
            this.ShapeView.Size = new System.Drawing.Size(336, 307);
            this.ShapeView.TabIndex = 4;
            this.ShapeView.TabStop = false;
            this.ShapeView.Paint += new System.Windows.Forms.PaintEventHandler(this.ShapeView_Paint);
            this.ShapeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShapeView_MouseDown);
            this.ShapeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShapeView_MouseMove);
            this.ShapeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShapeView_MouseUp);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.Desktop;
            this.Play.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Play.Location = new System.Drawing.Point(388, 115);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(62, 32);
            this.Play.TabIndex = 16;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.SystemColors.Desktop;
            this.Pause.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pause.Location = new System.Drawing.Point(456, 115);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(62, 32);
            this.Pause.TabIndex = 19;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(772, 605);
            this.Controls.Add(this.player);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.ShapeView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Audio/Sound";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShapeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnMagenta;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnCyan;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnBlack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.PictureBox ShapeView;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar Speed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.ListBox Songs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Pause;
    }
}


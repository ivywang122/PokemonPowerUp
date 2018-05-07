namespace PoketmonPowerUp
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.HPProgressBar = new System.Windows.Forms.ProgressBar();
            this.HPLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CurrentHPLabel = new System.Windows.Forms.Label();
            this.TotalHPLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.StarCheckBox = new System.Windows.Forms.CheckBox();
            this.DustLabel = new System.Windows.Forms.Label();
            this.CandyLabel = new System.Windows.Forms.Label();
            this.PowerUpButton = new System.Windows.Forms.Button();
            this.EvolveButton = new System.Windows.Forms.Button();
            this.PowerUpDustLabel = new System.Windows.Forms.Label();
            this.PowerUpCandyLabel = new System.Windows.Forms.Label();
            this.EvolveCandyLabel = new System.Windows.Forms.Label();
            this.CPLabel = new System.Windows.Forms.Label();
            this.PokemonPictureBox = new System.Windows.Forms.PictureBox();
            this.TitlesPictureBox = new System.Windows.Forms.PictureBox();
            this.DustPic01 = new System.Windows.Forms.PictureBox();
            this.CandyPic01 = new System.Windows.Forms.PictureBox();
            this.DustPic02 = new System.Windows.Forms.PictureBox();
            this.CandyPic02 = new System.Windows.Forms.PictureBox();
            this.CandyPic03 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DustPic01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandyPic01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DustPic02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandyPic02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandyPic03)).BeginInit();
            this.SuspendLayout();
            // 
            // HPProgressBar
            // 
            this.HPProgressBar.Location = new System.Drawing.Point(57, 271);
            this.HPProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.HPProgressBar.Name = "HPProgressBar";
            this.HPProgressBar.Size = new System.Drawing.Size(250, 20);
            this.HPProgressBar.TabIndex = 1;
            this.HPProgressBar.Value = 100;
            // 
            // HPLabel
            // 
            this.HPLabel.AutoSize = true;
            this.HPLabel.Location = new System.Drawing.Point(132, 303);
            this.HPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(26, 17);
            this.HPLabel.TabIndex = 2;
            this.HPLabel.Text = "HP";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(111, 219);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(144, 25);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.Text = "Pikachu";
            this.NameTextBox.Click += new System.EventHandler(this.NameTextBox_Click);
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyDown);
            // 
            // CurrentHPLabel
            // 
            this.CurrentHPLabel.AutoSize = true;
            this.CurrentHPLabel.Location = new System.Drawing.Point(166, 303);
            this.CurrentHPLabel.Name = "CurrentHPLabel";
            this.CurrentHPLabel.Size = new System.Drawing.Size(24, 17);
            this.CurrentHPLabel.TabIndex = 4;
            this.CurrentHPLabel.Text = "25";
            // 
            // TotalHPLabel
            // 
            this.TotalHPLabel.AutoSize = true;
            this.TotalHPLabel.Location = new System.Drawing.Point(196, 303);
            this.TotalHPLabel.Name = "TotalHPLabel";
            this.TotalHPLabel.Size = new System.Drawing.Size(24, 17);
            this.TotalHPLabel.TabIndex = 5;
            this.TotalHPLabel.Text = "25";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TypeLabel.Location = new System.Drawing.Point(48, 360);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(63, 20);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Electric";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WeightLabel.Location = new System.Drawing.Point(156, 360);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(40, 20);
            this.WeightLabel.TabIndex = 7;
            this.WeightLabel.Text = "5.00";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeightLabel.Location = new System.Drawing.Point(260, 360);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(40, 20);
            this.HeightLabel.TabIndex = 8;
            this.HeightLabel.Text = "0.37";
            // 
            // StarCheckBox
            // 
            this.StarCheckBox.AutoSize = true;
            this.StarCheckBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StarCheckBox.Location = new System.Drawing.Point(295, 12);
            this.StarCheckBox.Name = "StarCheckBox";
            this.StarCheckBox.Size = new System.Drawing.Size(52, 34);
            this.StarCheckBox.TabIndex = 9;
            this.StarCheckBox.Text = "☆";
            this.StarCheckBox.UseVisualStyleBackColor = true;
            this.StarCheckBox.CheckedChanged += new System.EventHandler(this.StarCheckBox_CheckedChanged);
            // 
            // DustLabel
            // 
            this.DustLabel.AutoSize = true;
            this.DustLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DustLabel.Location = new System.Drawing.Point(78, 432);
            this.DustLabel.Name = "DustLabel";
            this.DustLabel.Size = new System.Drawing.Size(95, 34);
            this.DustLabel.TabIndex = 10;
            this.DustLabel.Text = "10638";
            // 
            // CandyLabel
            // 
            this.CandyLabel.AutoSize = true;
            this.CandyLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CandyLabel.Location = new System.Drawing.Point(231, 432);
            this.CandyLabel.Name = "CandyLabel";
            this.CandyLabel.Size = new System.Drawing.Size(63, 34);
            this.CandyLabel.TabIndex = 11;
            this.CandyLabel.Text = "108";
            // 
            // PowerUpButton
            // 
            this.PowerUpButton.Location = new System.Drawing.Point(47, 489);
            this.PowerUpButton.Name = "PowerUpButton";
            this.PowerUpButton.Size = new System.Drawing.Size(111, 40);
            this.PowerUpButton.TabIndex = 12;
            this.PowerUpButton.Text = "POWER UP";
            this.PowerUpButton.UseVisualStyleBackColor = true;
            this.PowerUpButton.Click += new System.EventHandler(this.PowerUpButton_Click);
            // 
            // EvolveButton
            // 
            this.EvolveButton.Location = new System.Drawing.Point(47, 550);
            this.EvolveButton.Name = "EvolveButton";
            this.EvolveButton.Size = new System.Drawing.Size(111, 38);
            this.EvolveButton.TabIndex = 13;
            this.EvolveButton.Text = "EVOLVE";
            this.EvolveButton.UseVisualStyleBackColor = true;
            this.EvolveButton.Click += new System.EventHandler(this.EvolveButton_Click);
            // 
            // PowerUpDustLabel
            // 
            this.PowerUpDustLabel.AutoSize = true;
            this.PowerUpDustLabel.Location = new System.Drawing.Point(199, 499);
            this.PowerUpDustLabel.Name = "PowerUpDustLabel";
            this.PowerUpDustLabel.Size = new System.Drawing.Size(32, 17);
            this.PowerUpDustLabel.TabIndex = 14;
            this.PowerUpDustLabel.Text = "600";
            // 
            // PowerUpCandyLabel
            // 
            this.PowerUpCandyLabel.AutoSize = true;
            this.PowerUpCandyLabel.Location = new System.Drawing.Point(266, 499);
            this.PowerUpCandyLabel.Name = "PowerUpCandyLabel";
            this.PowerUpCandyLabel.Size = new System.Drawing.Size(16, 17);
            this.PowerUpCandyLabel.TabIndex = 15;
            this.PowerUpCandyLabel.Text = "1";
            // 
            // EvolveCandyLabel
            // 
            this.EvolveCandyLabel.AutoSize = true;
            this.EvolveCandyLabel.Location = new System.Drawing.Point(266, 561);
            this.EvolveCandyLabel.Name = "EvolveCandyLabel";
            this.EvolveCandyLabel.Size = new System.Drawing.Size(24, 17);
            this.EvolveCandyLabel.TabIndex = 16;
            this.EvolveCandyLabel.Text = "50";
            // 
            // CPLabel
            // 
            this.CPLabel.AutoSize = true;
            this.CPLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPLabel.Location = new System.Drawing.Point(146, 26);
            this.CPLabel.Name = "CPLabel";
            this.CPLabel.Size = new System.Drawing.Size(74, 40);
            this.CPLabel.TabIndex = 17;
            this.CPLabel.Text = "103";
            // 
            // PokemonPictureBox
            // 
            this.PokemonPictureBox.ImageLocation = "";
            this.PokemonPictureBox.Location = new System.Drawing.Point(132, 84);
            this.PokemonPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.PokemonPictureBox.Name = "PokemonPictureBox";
            this.PokemonPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PokemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PokemonPictureBox.TabIndex = 0;
            this.PokemonPictureBox.TabStop = false;
            // 
            // TitlesPictureBox
            // 
            this.TitlesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TitlesPictureBox.Image")));
            this.TitlesPictureBox.Location = new System.Drawing.Point(40, 383);
            this.TitlesPictureBox.Name = "TitlesPictureBox";
            this.TitlesPictureBox.Size = new System.Drawing.Size(279, 25);
            this.TitlesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitlesPictureBox.TabIndex = 18;
            this.TitlesPictureBox.TabStop = false;
            // 
            // DustPic01
            // 
            this.DustPic01.Image = ((System.Drawing.Image)(resources.GetObject("DustPic01.Image")));
            this.DustPic01.Location = new System.Drawing.Point(52, 432);
            this.DustPic01.Name = "DustPic01";
            this.DustPic01.Size = new System.Drawing.Size(18, 38);
            this.DustPic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DustPic01.TabIndex = 19;
            this.DustPic01.TabStop = false;
            // 
            // CandyPic01
            // 
            this.CandyPic01.Image = ((System.Drawing.Image)(resources.GetObject("CandyPic01.Image")));
            this.CandyPic01.Location = new System.Drawing.Point(203, 436);
            this.CandyPic01.Name = "CandyPic01";
            this.CandyPic01.Size = new System.Drawing.Size(29, 28);
            this.CandyPic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CandyPic01.TabIndex = 20;
            this.CandyPic01.TabStop = false;
            // 
            // DustPic02
            // 
            this.DustPic02.Image = ((System.Drawing.Image)(resources.GetObject("DustPic02.Image")));
            this.DustPic02.Location = new System.Drawing.Point(179, 488);
            this.DustPic02.Name = "DustPic02";
            this.DustPic02.Size = new System.Drawing.Size(16, 35);
            this.DustPic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DustPic02.TabIndex = 21;
            this.DustPic02.TabStop = false;
            // 
            // CandyPic02
            // 
            this.CandyPic02.Image = ((System.Drawing.Image)(resources.GetObject("CandyPic02.Image")));
            this.CandyPic02.Location = new System.Drawing.Point(246, 497);
            this.CandyPic02.Name = "CandyPic02";
            this.CandyPic02.Size = new System.Drawing.Size(19, 22);
            this.CandyPic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CandyPic02.TabIndex = 22;
            this.CandyPic02.TabStop = false;
            // 
            // CandyPic03
            // 
            this.CandyPic03.Image = ((System.Drawing.Image)(resources.GetObject("CandyPic03.Image")));
            this.CandyPic03.Location = new System.Drawing.Point(246, 556);
            this.CandyPic03.Name = "CandyPic03";
            this.CandyPic03.Size = new System.Drawing.Size(19, 22);
            this.CandyPic03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CandyPic03.TabIndex = 23;
            this.CandyPic03.TabStop = false;
            // 
            // PokemonPowerUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 628);
            this.Controls.Add(this.CandyPic03);
            this.Controls.Add(this.CandyPic02);
            this.Controls.Add(this.DustPic02);
            this.Controls.Add(this.CandyPic01);
            this.Controls.Add(this.DustPic01);
            this.Controls.Add(this.TitlesPictureBox);
            this.Controls.Add(this.CPLabel);
            this.Controls.Add(this.EvolveCandyLabel);
            this.Controls.Add(this.PowerUpCandyLabel);
            this.Controls.Add(this.PowerUpDustLabel);
            this.Controls.Add(this.EvolveButton);
            this.Controls.Add(this.PowerUpButton);
            this.Controls.Add(this.CandyLabel);
            this.Controls.Add(this.DustLabel);
            this.Controls.Add(this.StarCheckBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TotalHPLabel);
            this.Controls.Add(this.CurrentHPLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.HPLabel);
            this.Controls.Add(this.HPProgressBar);
            this.Controls.Add(this.PokemonPictureBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PokemonPowerUp";
            this.Text = "PokemonPowerUp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DustPic01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandyPic01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DustPic02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandyPic02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandyPic03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PokemonPictureBox;
        private System.Windows.Forms.ProgressBar HPProgressBar;
        private System.Windows.Forms.Label HPLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label CurrentHPLabel;
        private System.Windows.Forms.Label TotalHPLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.CheckBox StarCheckBox;
        private System.Windows.Forms.Label DustLabel;
        private System.Windows.Forms.Label CandyLabel;
        private System.Windows.Forms.Button PowerUpButton;
        private System.Windows.Forms.Button EvolveButton;
        private System.Windows.Forms.Label PowerUpDustLabel;
        private System.Windows.Forms.Label PowerUpCandyLabel;
        private System.Windows.Forms.Label EvolveCandyLabel;
        private System.Windows.Forms.Label CPLabel;
        private System.Windows.Forms.PictureBox TitlesPictureBox;
        private System.Windows.Forms.PictureBox DustPic01;
        private System.Windows.Forms.PictureBox CandyPic01;
        private System.Windows.Forms.PictureBox DustPic02;
        private System.Windows.Forms.PictureBox CandyPic02;
        private System.Windows.Forms.PictureBox CandyPic03;
    }
}


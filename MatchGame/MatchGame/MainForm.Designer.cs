
namespace MatchGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.playBtn = new System.Windows.Forms.Button();
            this.player1Score = new System.Windows.Forms.TextBox();
            this.player2Score = new System.Windows.Forms.TextBox();
            this.playerSelect = new System.Windows.Forms.ComboBox();
            this.slot1 = new System.Windows.Forms.Button();
            this.slot2 = new System.Windows.Forms.Button();
            this.slot3 = new System.Windows.Forms.Button();
            this.slot4 = new System.Windows.Forms.Button();
            this.slot5 = new System.Windows.Forms.Button();
            this.slot6 = new System.Windows.Forms.Button();
            this.slot7 = new System.Windows.Forms.Button();
            this.slot8 = new System.Windows.Forms.Button();
            this.slot9 = new System.Windows.Forms.Button();
            this.slot10 = new System.Windows.Forms.Button();
            this.slot11 = new System.Windows.Forms.Button();
            this.slot12 = new System.Windows.Forms.Button();
            this.slot13 = new System.Windows.Forms.Button();
            this.slot14 = new System.Windows.Forms.Button();
            this.slot15 = new System.Windows.Forms.Button();
            this.slot16 = new System.Windows.Forms.Button();
            this.slot17 = new System.Windows.Forms.Button();
            this.slot18 = new System.Windows.Forms.Button();
            this.slot19 = new System.Windows.Forms.Button();
            this.slot20 = new System.Windows.Forms.Button();
            this.gameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.gameText = new System.Windows.Forms.Label();
            this.gameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(266, 10);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(149, 40);
            this.playBtn.TabIndex = 2;
            this.playBtn.Text = "Play Game";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // player1Score
            // 
            this.player1Score.Location = new System.Drawing.Point(770, 10);
            this.player1Score.Name = "player1Score";
            this.player1Score.ReadOnly = true;
            this.player1Score.Size = new System.Drawing.Size(24, 20);
            this.player1Score.TabIndex = 6;
            this.player1Score.Text = "0";
            this.player1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player2Score
            // 
            this.player2Score.Location = new System.Drawing.Point(770, 36);
            this.player2Score.Name = "player2Score";
            this.player2Score.ReadOnly = true;
            this.player2Score.Size = new System.Drawing.Size(24, 20);
            this.player2Score.TabIndex = 7;
            this.player2Score.Text = "0";
            this.player2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerSelect
            // 
            this.playerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSelect.FormattingEnabled = true;
            this.playerSelect.Items.AddRange(new object[] {
            "1",
            "2"});
            this.playerSelect.Location = new System.Drawing.Point(12, 13);
            this.playerSelect.Name = "playerSelect";
            this.playerSelect.Size = new System.Drawing.Size(248, 37);
            this.playerSelect.TabIndex = 8;
            this.playerSelect.Text = "How Many Players?";
            // 
            // slot1
            // 
            this.slot1.AutoSize = true;
            this.slot1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.slot1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot1.BackgroundImage")));
            this.slot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot1.FlatAppearance.BorderSize = 0;
            this.slot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slot1.ForeColor = System.Drawing.Color.Black;
            this.slot1.Location = new System.Drawing.Point(16, 16);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(123, 213);
            this.slot1.TabIndex = 0;
            this.slot1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.slot1.UseVisualStyleBackColor = true;
            this.slot1.Click += new System.EventHandler(this.card_selected);
            // 
            // slot2
            // 
            this.slot2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot2.BackgroundImage")));
            this.slot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot2.Location = new System.Drawing.Point(148, 16);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(123, 213);
            this.slot2.TabIndex = 1;
            this.slot2.UseVisualStyleBackColor = true;
            this.slot2.Click += new System.EventHandler(this.card_selected);
            // 
            // slot3
            // 
            this.slot3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot3.BackgroundImage")));
            this.slot3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot3.Location = new System.Drawing.Point(280, 16);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(123, 213);
            this.slot3.TabIndex = 2;
            this.slot3.UseVisualStyleBackColor = true;
            this.slot3.Click += new System.EventHandler(this.card_selected);
            // 
            // slot4
            // 
            this.slot4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot4.BackgroundImage")));
            this.slot4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot4.Location = new System.Drawing.Point(412, 16);
            this.slot4.Name = "slot4";
            this.slot4.Size = new System.Drawing.Size(123, 213);
            this.slot4.TabIndex = 3;
            this.slot4.UseVisualStyleBackColor = true;
            this.slot4.Click += new System.EventHandler(this.card_selected);
            // 
            // slot5
            // 
            this.slot5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot5.BackgroundImage")));
            this.slot5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot5.Location = new System.Drawing.Point(544, 16);
            this.slot5.Name = "slot5";
            this.slot5.Size = new System.Drawing.Size(123, 213);
            this.slot5.TabIndex = 4;
            this.slot5.UseVisualStyleBackColor = true;
            this.slot5.Click += new System.EventHandler(this.card_selected);
            // 
            // slot6
            // 
            this.slot6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot6.BackgroundImage")));
            this.slot6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot6.Location = new System.Drawing.Point(16, 238);
            this.slot6.Name = "slot6";
            this.slot6.Size = new System.Drawing.Size(123, 213);
            this.slot6.TabIndex = 5;
            this.slot6.UseVisualStyleBackColor = true;
            this.slot6.Click += new System.EventHandler(this.card_selected);
            // 
            // slot7
            // 
            this.slot7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot7.BackgroundImage")));
            this.slot7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot7.Location = new System.Drawing.Point(148, 238);
            this.slot7.Name = "slot7";
            this.slot7.Size = new System.Drawing.Size(123, 213);
            this.slot7.TabIndex = 6;
            this.slot7.UseVisualStyleBackColor = true;
            this.slot7.Click += new System.EventHandler(this.card_selected);
            // 
            // slot8
            // 
            this.slot8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot8.BackgroundImage")));
            this.slot8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot8.Location = new System.Drawing.Point(280, 238);
            this.slot8.Name = "slot8";
            this.slot8.Size = new System.Drawing.Size(123, 213);
            this.slot8.TabIndex = 7;
            this.slot8.UseVisualStyleBackColor = true;
            this.slot8.Click += new System.EventHandler(this.card_selected);
            // 
            // slot9
            // 
            this.slot9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot9.BackgroundImage")));
            this.slot9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot9.Location = new System.Drawing.Point(412, 238);
            this.slot9.Name = "slot9";
            this.slot9.Size = new System.Drawing.Size(123, 213);
            this.slot9.TabIndex = 8;
            this.slot9.UseVisualStyleBackColor = true;
            this.slot9.Click += new System.EventHandler(this.card_selected);
            // 
            // slot10
            // 
            this.slot10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot10.BackgroundImage")));
            this.slot10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot10.Location = new System.Drawing.Point(544, 238);
            this.slot10.Name = "slot10";
            this.slot10.Size = new System.Drawing.Size(123, 213);
            this.slot10.TabIndex = 9;
            this.slot10.UseVisualStyleBackColor = true;
            this.slot10.Click += new System.EventHandler(this.card_selected);
            // 
            // slot11
            // 
            this.slot11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot11.BackgroundImage")));
            this.slot11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot11.Location = new System.Drawing.Point(16, 460);
            this.slot11.Name = "slot11";
            this.slot11.Size = new System.Drawing.Size(123, 213);
            this.slot11.TabIndex = 10;
            this.slot11.UseVisualStyleBackColor = true;
            this.slot11.Click += new System.EventHandler(this.card_selected);
            // 
            // slot12
            // 
            this.slot12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot12.BackgroundImage")));
            this.slot12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot12.Location = new System.Drawing.Point(148, 460);
            this.slot12.Name = "slot12";
            this.slot12.Size = new System.Drawing.Size(123, 213);
            this.slot12.TabIndex = 11;
            this.slot12.UseVisualStyleBackColor = true;
            this.slot12.Click += new System.EventHandler(this.card_selected);
            // 
            // slot13
            // 
            this.slot13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot13.BackgroundImage")));
            this.slot13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot13.Location = new System.Drawing.Point(280, 460);
            this.slot13.Name = "slot13";
            this.slot13.Size = new System.Drawing.Size(123, 213);
            this.slot13.TabIndex = 12;
            this.slot13.UseVisualStyleBackColor = true;
            this.slot13.Click += new System.EventHandler(this.card_selected);
            // 
            // slot14
            // 
            this.slot14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot14.BackgroundImage")));
            this.slot14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot14.Location = new System.Drawing.Point(412, 460);
            this.slot14.Name = "slot14";
            this.slot14.Size = new System.Drawing.Size(123, 213);
            this.slot14.TabIndex = 13;
            this.slot14.UseVisualStyleBackColor = true;
            this.slot14.Click += new System.EventHandler(this.card_selected);
            // 
            // slot15
            // 
            this.slot15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot15.BackgroundImage")));
            this.slot15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot15.Location = new System.Drawing.Point(544, 460);
            this.slot15.Name = "slot15";
            this.slot15.Size = new System.Drawing.Size(123, 213);
            this.slot15.TabIndex = 14;
            this.slot15.UseVisualStyleBackColor = true;
            this.slot15.Click += new System.EventHandler(this.card_selected);
            // 
            // slot16
            // 
            this.slot16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot16.BackgroundImage")));
            this.slot16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot16.Location = new System.Drawing.Point(16, 682);
            this.slot16.Name = "slot16";
            this.slot16.Size = new System.Drawing.Size(123, 213);
            this.slot16.TabIndex = 15;
            this.slot16.UseVisualStyleBackColor = true;
            this.slot16.Click += new System.EventHandler(this.card_selected);
            // 
            // slot17
            // 
            this.slot17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot17.BackgroundImage")));
            this.slot17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot17.Location = new System.Drawing.Point(148, 682);
            this.slot17.Name = "slot17";
            this.slot17.Size = new System.Drawing.Size(123, 213);
            this.slot17.TabIndex = 16;
            this.slot17.UseVisualStyleBackColor = true;
            this.slot17.Click += new System.EventHandler(this.card_selected);
            // 
            // slot18
            // 
            this.slot18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot18.BackgroundImage")));
            this.slot18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot18.Location = new System.Drawing.Point(280, 682);
            this.slot18.Name = "slot18";
            this.slot18.Size = new System.Drawing.Size(123, 213);
            this.slot18.TabIndex = 17;
            this.slot18.UseVisualStyleBackColor = true;
            this.slot18.Click += new System.EventHandler(this.card_selected);
            // 
            // slot19
            // 
            this.slot19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot19.BackgroundImage")));
            this.slot19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot19.Location = new System.Drawing.Point(412, 682);
            this.slot19.Name = "slot19";
            this.slot19.Size = new System.Drawing.Size(123, 213);
            this.slot19.TabIndex = 18;
            this.slot19.UseVisualStyleBackColor = true;
            this.slot19.Click += new System.EventHandler(this.card_selected);
            // 
            // slot20
            // 
            this.slot20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slot20.BackgroundImage")));
            this.slot20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot20.Location = new System.Drawing.Point(544, 682);
            this.slot20.Name = "slot20";
            this.slot20.Size = new System.Drawing.Size(123, 213);
            this.slot20.TabIndex = 19;
            this.slot20.UseVisualStyleBackColor = true;
            this.slot20.Click += new System.EventHandler(this.card_selected);
            // 
            // gameBoard
            // 
            this.gameBoard.AutoSize = true;
            this.gameBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameBoard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gameBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.gameBoard.ColumnCount = 5;
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gameBoard.Controls.Add(this.slot20, 4, 3);
            this.gameBoard.Controls.Add(this.slot19, 3, 3);
            this.gameBoard.Controls.Add(this.slot18, 2, 3);
            this.gameBoard.Controls.Add(this.slot17, 1, 3);
            this.gameBoard.Controls.Add(this.slot16, 0, 3);
            this.gameBoard.Controls.Add(this.slot15, 4, 2);
            this.gameBoard.Controls.Add(this.slot14, 3, 2);
            this.gameBoard.Controls.Add(this.slot13, 2, 2);
            this.gameBoard.Controls.Add(this.slot12, 1, 2);
            this.gameBoard.Controls.Add(this.slot11, 0, 2);
            this.gameBoard.Controls.Add(this.slot10, 4, 1);
            this.gameBoard.Controls.Add(this.slot9, 3, 1);
            this.gameBoard.Controls.Add(this.slot8, 2, 1);
            this.gameBoard.Controls.Add(this.slot7, 1, 1);
            this.gameBoard.Controls.Add(this.slot6, 0, 1);
            this.gameBoard.Controls.Add(this.slot5, 4, 0);
            this.gameBoard.Controls.Add(this.slot4, 3, 0);
            this.gameBoard.Controls.Add(this.slot3, 2, 0);
            this.gameBoard.Controls.Add(this.slot2, 1, 0);
            this.gameBoard.Controls.Add(this.slot1, 0, 0);
            this.gameBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBoard.Location = new System.Drawing.Point(74, 75);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Padding = new System.Windows.Forms.Padding(10);
            this.gameBoard.RowCount = 4;
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.Size = new System.Drawing.Size(683, 911);
            this.gameBoard.TabIndex = 0;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pauseTimer
            // 
            this.pauseTimer.Interval = 1000;
            this.pauseTimer.Tick += new System.EventHandler(this.pauseTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Player 1 Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Player 2 Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(855, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = ":";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(835, 25);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(27, 29);
            this.minutesLabel.TabIndex = 15;
            this.minutesLabel.Text = "0";
            this.minutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(868, 25);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(41, 29);
            this.secondsLabel.TabIndex = 16;
            this.secondsLabel.Text = "00";
            this.secondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gameText
            // 
            this.gameText.AutoSize = true;
            this.gameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameText.Location = new System.Drawing.Point(421, 14);
            this.gameText.Name = "gameText";
            this.gameText.Size = new System.Drawing.Size(0, 33);
            this.gameText.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(956, 1041);
            this.Controls.Add(this.gameText);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerSelect);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.gameBoard);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(972, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(972, 1038);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match Game";
            this.gameBoard.ResumeLayout(false);
            this.gameBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.TextBox player1Score;
        private System.Windows.Forms.TextBox player2Score;
        private System.Windows.Forms.ComboBox playerSelect;
        private System.Windows.Forms.Button slot1;
        private System.Windows.Forms.Button slot2;
        private System.Windows.Forms.Button slot3;
        private System.Windows.Forms.Button slot4;
        private System.Windows.Forms.Button slot5;
        private System.Windows.Forms.Button slot6;
        private System.Windows.Forms.Button slot7;
        private System.Windows.Forms.Button slot8;
        private System.Windows.Forms.Button slot9;
        private System.Windows.Forms.Button slot10;
        private System.Windows.Forms.Button slot11;
        private System.Windows.Forms.Button slot12;
        private System.Windows.Forms.Button slot13;
        private System.Windows.Forms.Button slot14;
        private System.Windows.Forms.Button slot15;
        private System.Windows.Forms.Button slot16;
        private System.Windows.Forms.Button slot17;
        private System.Windows.Forms.Button slot18;
        private System.Windows.Forms.Button slot19;
        private System.Windows.Forms.Button slot20;
        public System.Windows.Forms.TableLayoutPanel gameBoard;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer pauseTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label gameText;
    }
}


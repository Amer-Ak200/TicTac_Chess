namespace TicTac_Chess
{
    partial class TicTacChess
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
            this.gbxBord = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxBord13 = new System.Windows.Forms.PictureBox();
            this.pbxBord12 = new System.Windows.Forms.PictureBox();
            this.pbxBord11 = new System.Windows.Forms.PictureBox();
            this.pbxBord23 = new System.Windows.Forms.PictureBox();
            this.pbxBord22 = new System.Windows.Forms.PictureBox();
            this.pbxBord21 = new System.Windows.Forms.PictureBox();
            this.pbxBord33 = new System.Windows.Forms.PictureBox();
            this.pbxBord32 = new System.Windows.Forms.PictureBox();
            this.pbxBord31 = new System.Windows.Forms.PictureBox();
            this.gbxPieces = new System.Windows.Forms.GroupBox();
            this.pbxQueen = new System.Windows.Forms.PictureBox();
            this.pbxKnight = new System.Windows.Forms.PictureBox();
            this.pbxRook = new System.Windows.Forms.PictureBox();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbnWhite = new System.Windows.Forms.RadioButton();
            this.rbnBlack = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbxBord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord31)).BeginInit();
            this.gbxPieces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRook)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBord
            // 
            this.gbxBord.Controls.Add(this.panel4);
            this.gbxBord.Controls.Add(this.panel3);
            this.gbxBord.Controls.Add(this.panel2);
            this.gbxBord.Controls.Add(this.panel1);
            this.gbxBord.Controls.Add(this.pbxBord13);
            this.gbxBord.Controls.Add(this.pbxBord12);
            this.gbxBord.Controls.Add(this.pbxBord11);
            this.gbxBord.Controls.Add(this.pbxBord23);
            this.gbxBord.Controls.Add(this.pbxBord22);
            this.gbxBord.Controls.Add(this.pbxBord21);
            this.gbxBord.Controls.Add(this.pbxBord33);
            this.gbxBord.Controls.Add(this.pbxBord32);
            this.gbxBord.Controls.Add(this.pbxBord31);
            this.gbxBord.Location = new System.Drawing.Point(12, 79);
            this.gbxBord.Name = "gbxBord";
            this.gbxBord.Size = new System.Drawing.Size(479, 469);
            this.gbxBord.TabIndex = 1;
            this.gbxBord.TabStop = false;
            this.gbxBord.Text = "Bord";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(139, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 451);
            this.panel1.TabIndex = 12;
            // 
            // pbxBord13
            // 
            this.pbxBord13.Location = new System.Drawing.Point(12, 344);
            this.pbxBord13.Name = "pbxBord13";
            this.pbxBord13.Size = new System.Drawing.Size(129, 119);
            this.pbxBord13.TabIndex = 11;
            this.pbxBord13.TabStop = false;
            this.pbxBord13.Tag = "13";
            this.pbxBord13.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragDrop);
            this.pbxBord13.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragEnter);
            // 
            // pbxBord12
            // 
            this.pbxBord12.Location = new System.Drawing.Point(6, 196);
            this.pbxBord12.Name = "pbxBord12";
            this.pbxBord12.Size = new System.Drawing.Size(129, 119);
            this.pbxBord12.TabIndex = 10;
            this.pbxBord12.TabStop = false;
            this.pbxBord12.Tag = "12";
            this.pbxBord12.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragDrop);
            this.pbxBord12.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragEnter);
            // 
            // pbxBord11
            // 
            this.pbxBord11.Location = new System.Drawing.Point(6, 41);
            this.pbxBord11.Name = "pbxBord11";
            this.pbxBord11.Size = new System.Drawing.Size(129, 119);
            this.pbxBord11.TabIndex = 9;
            this.pbxBord11.TabStop = false;
            this.pbxBord11.Tag = "11";
            this.pbxBord11.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragDrop);
            this.pbxBord11.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragEnter);
            // 
            // pbxBord23
            // 
            this.pbxBord23.Location = new System.Drawing.Point(171, 344);
            this.pbxBord23.Name = "pbxBord23";
            this.pbxBord23.Size = new System.Drawing.Size(129, 119);
            this.pbxBord23.TabIndex = 8;
            this.pbxBord23.TabStop = false;
            this.pbxBord23.Tag = "23";
            this.pbxBord23.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragDrop);
            this.pbxBord23.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragEnter);
            // 
            // pbxBord22
            // 
            this.pbxBord22.Location = new System.Drawing.Point(168, 195);
            this.pbxBord22.Name = "pbxBord22";
            this.pbxBord22.Size = new System.Drawing.Size(129, 119);
            this.pbxBord22.TabIndex = 7;
            this.pbxBord22.TabStop = false;
            this.pbxBord22.Tag = "22";
            this.pbxBord22.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragDrop);
            this.pbxBord22.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragEnter);
            // 
            // pbxBord21
            // 
            this.pbxBord21.Location = new System.Drawing.Point(166, 41);
            this.pbxBord21.Name = "pbxBord21";
            this.pbxBord21.Size = new System.Drawing.Size(129, 119);
            this.pbxBord21.TabIndex = 6;
            this.pbxBord21.TabStop = false;
            this.pbxBord21.Tag = "21";
            this.pbxBord21.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragDrop);
            this.pbxBord21.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragEnter);
            // 
            // pbxBord33
            // 
            this.pbxBord33.Location = new System.Drawing.Point(333, 344);
            this.pbxBord33.Name = "pbxBord33";
            this.pbxBord33.Size = new System.Drawing.Size(129, 119);
            this.pbxBord33.TabIndex = 5;
            this.pbxBord33.TabStop = false;
            this.pbxBord33.Tag = "33";
            this.pbxBord33.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragDrop);
            this.pbxBord33.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragEnter);
            // 
            // pbxBord32
            // 
            this.pbxBord32.Location = new System.Drawing.Point(332, 196);
            this.pbxBord32.Name = "pbxBord32";
            this.pbxBord32.Size = new System.Drawing.Size(129, 119);
            this.pbxBord32.TabIndex = 4;
            this.pbxBord32.TabStop = false;
            this.pbxBord32.Tag = "32";
            this.pbxBord32.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragDrop);
            this.pbxBord32.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragEnter);
            // 
            // pbxBord31
            // 
            this.pbxBord31.Location = new System.Drawing.Point(333, 41);
            this.pbxBord31.Name = "pbxBord31";
            this.pbxBord31.Size = new System.Drawing.Size(129, 119);
            this.pbxBord31.TabIndex = 3;
            this.pbxBord31.TabStop = false;
            this.pbxBord31.Tag = "31";
            this.pbxBord31.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragDrop);
            this.pbxBord31.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxBoard_DragEnter);
            // 
            // gbxPieces
            // 
            this.gbxPieces.Controls.Add(this.pbxQueen);
            this.gbxPieces.Controls.Add(this.pbxKnight);
            this.gbxPieces.Controls.Add(this.pbxRook);
            this.gbxPieces.Location = new System.Drawing.Point(497, 79);
            this.gbxPieces.Name = "gbxPieces";
            this.gbxPieces.Size = new System.Drawing.Size(177, 469);
            this.gbxPieces.TabIndex = 2;
            this.gbxPieces.TabStop = false;
            this.gbxPieces.Text = "Pieces";
            // 
            // pbxQueen
            // 
            this.pbxQueen.Location = new System.Drawing.Point(26, 319);
            this.pbxQueen.Name = "pbxQueen";
            this.pbxQueen.Size = new System.Drawing.Size(129, 119);
            this.pbxQueen.TabIndex = 2;
            this.pbxQueen.TabStop = false;
            this.pbxQueen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxPiece_MouseDown);
            // 
            // pbxKnight
            // 
            this.pbxKnight.Location = new System.Drawing.Point(26, 178);
            this.pbxKnight.Name = "pbxKnight";
            this.pbxKnight.Size = new System.Drawing.Size(129, 119);
            this.pbxKnight.TabIndex = 1;
            this.pbxKnight.TabStop = false;
            this.pbxKnight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxPiece_MouseDown);
            // 
            // pbxRook
            // 
            this.pbxRook.Location = new System.Drawing.Point(26, 41);
            this.pbxRook.Name = "pbxRook";
            this.pbxRook.Size = new System.Drawing.Size(129, 119);
            this.pbxRook.TabIndex = 0;
            this.pbxRook.TabStop = false;
            this.pbxRook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxPiece_MouseDown);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Location = new System.Drawing.Point(24, 27);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(172, 46);
            this.btnRestartGame.TabIndex = 3;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start game, setup pieces";
            // 
            // rbnWhite
            // 
            this.rbnWhite.AutoSize = true;
            this.rbnWhite.Location = new System.Drawing.Point(511, 12);
            this.rbnWhite.Name = "rbnWhite";
            this.rbnWhite.Size = new System.Drawing.Size(62, 20);
            this.rbnWhite.TabIndex = 5;
            this.rbnWhite.TabStop = true;
            this.rbnWhite.Text = "White";
            this.rbnWhite.UseVisualStyleBackColor = true;
            // 
            // rbnBlack
            // 
            this.rbnBlack.AutoSize = true;
            this.rbnBlack.Location = new System.Drawing.Point(511, 53);
            this.rbnBlack.Name = "rbnBlack";
            this.rbnBlack.Size = new System.Drawing.Size(62, 20);
            this.rbnBlack.TabIndex = 6;
            this.rbnBlack.TabStop = true;
            this.rbnBlack.Text = "Black";
            this.rbnBlack.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(306, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 451);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(16, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 20);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(17, 318);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 20);
            this.panel4.TabIndex = 15;
            // 
            // TicTacChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 560);
            this.Controls.Add(this.rbnBlack);
            this.Controls.Add(this.rbnWhite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.gbxPieces);
            this.Controls.Add(this.gbxBord);
            this.Name = "TicTacChess";
            this.Text = "Tic Tac Chess";
            this.Load += new System.EventHandler(this.TicTacChess_Load);
            this.gbxBord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBord31)).EndInit();
            this.gbxPieces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBord;
        private System.Windows.Forms.PictureBox pbxBord13;
        private System.Windows.Forms.PictureBox pbxBord12;
        private System.Windows.Forms.PictureBox pbxBord11;
        private System.Windows.Forms.PictureBox pbxBord23;
        private System.Windows.Forms.PictureBox pbxBord22;
        private System.Windows.Forms.PictureBox pbxBord21;
        private System.Windows.Forms.PictureBox pbxBord33;
        private System.Windows.Forms.PictureBox pbxBord32;
        private System.Windows.Forms.PictureBox pbxBord31;
        private System.Windows.Forms.GroupBox gbxPieces;
        private System.Windows.Forms.PictureBox pbxQueen;
        private System.Windows.Forms.PictureBox pbxKnight;
        private System.Windows.Forms.PictureBox pbxRook;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbnWhite;
        private System.Windows.Forms.RadioButton rbnBlack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}


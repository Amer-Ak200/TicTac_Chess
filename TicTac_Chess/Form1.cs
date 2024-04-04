using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac_Chess
{
    public partial class TicTacChess : Form
    {
        private Board gameBoard;
        private Dictionary<string, Piece> gamePieces;
        private Piece selectedPiece; // You'll need to set this when a piece is selected
        private void ClearPreviousPositionImage(Point previousPosition)
        {
            // Finds the PictureBox by its tag and clears the image
            string tagToFind = $"{previousPosition.X}{previousPosition.Y}";
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox pbx && pbx.Tag?.ToString() == tagToFind)
                {
                    pbx.Image = null;
                    break; // Exit the loop since we found the PictureBox and cleared the image
                }
            }
        }
        public TicTacChess()
        {
            InitializeComponent();
            SetPictureBoxEventsAndTags();
        }

        private void SetPictureBoxEventsAndTags()
        {
            // Assuming your PictureBoxes are named systematically like pbxBord11, pbxBord12, etc.
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox pbx && pbx.Name.StartsWith("pbxBord"))
                {
                    pbx.MouseDown += pbxPiece_MouseDown;
                    pbx.DragEnter += pbxBoard_DragEnter;
                    pbx.DragDrop += pbxBoard_DragDrop;

                    // Setting the Tag based on the Name, assuming the last two characters define the position
                    pbx.Tag = pbx.Name.Substring(pbx.Name.Length - 2);
                }
            }
        
        
            // List of PictureBox names and their corresponding tags based on your board structure
            var pictureBoxesAndTags = new Dictionary<string, string>
            {
                { "pbxBord11", "11" },
                { "pbxBord21", "21" },
                { "pbxBord31", "31" },
                { "pbxBord12", "12" },
                { "pbxBord22", "22" },
                { "pbxBord32", "32" },
                { "pbxBord13", "13" },
                { "pbxBord23", "23" },
                { "pbxBord33", "33" },
             };

            foreach (var pair in pictureBoxesAndTags)
            {
                if (this.Controls.Find(pair.Key, true).FirstOrDefault() is PictureBox pbx)
                {
                    pbx.MouseDown += pbxPiece_MouseDown;
                    pbx.DragEnter += pbxBoard_DragEnter;
                    pbx.DragDrop += pbxBoard_DragDrop;
                    pbx.Tag = pair.Value;
                }
            }
        }
        private void InitializeGame()
        {
            // Initialize the game board and pieces dictionary
            gameBoard = new Board();
            gamePieces = new Dictionary<string, Piece>();

            try
            {
                // Load images for white pieces
                Image whiteRookImage = Image.FromFile(@"C:\Users\redfo\Desktop\C# ChatApp\TicTac_Chess\TicTac_Chess\img\RookWhite.png");
                Image whiteKnightImage = Image.FromFile(@"C:\Users\redfo\Desktop\C# ChatApp\TicTac_Chess\TicTac_Chess\img\KnightWhite.png");
                Image whiteQueenImage = Image.FromFile(@"C:\Users\redfo\Desktop\C# ChatApp\TicTac_Chess\TicTac_Chess\img\QueenWhite.png");

                // Load images for black pieces
                Image blackRookImage = Image.FromFile(@"C:\Users\redfo\Desktop\C# ChatApp\TicTac_Chess\TicTac_Chess\img\RookBlack.png");
                Image blackKnightImage = Image.FromFile(@"C:\Users\redfo\Desktop\C# ChatApp\TicTac_Chess\TicTac_Chess\img\KnightBlack.png");
                Image blackQueenImage = Image.FromFile(@"C:\Users\redfo\Desktop\C# ChatApp\TicTac_Chess\TicTac_Chess\img\QueenBlack.png");

                // Create pieces and add them to the dictionary
                gamePieces.Add("WhiteRook", new Piece(Piece.PieceType.Rook, whiteRookImage));
                gamePieces.Add("WhiteKnight", new Piece(Piece.PieceType.Knight, whiteKnightImage));
                gamePieces.Add("WhiteQueen", new Piece(Piece.PieceType.Queen, whiteQueenImage));

                gamePieces.Add("BlackRook", new Piece(Piece.PieceType.Rook, blackRookImage));
                gamePieces.Add("BlackKnight", new Piece(Piece.PieceType.Knight, blackKnightImage));
                gamePieces.Add("BlackQueen", new Piece(Piece.PieceType.Queen, blackQueenImage));

                // You can now set the initial positions of the pieces on the board
                // This is a simple example and may need to be adjusted based on your actual PictureBox names and positions
                gameBoard.AddPiece(gamePieces["WhiteRook"], 0, 0); // Assuming top-left corner is 0,0
                gameBoard.AddPiece(gamePieces["WhiteKnight"], 1, 0);
                gameBoard.AddPiece(gamePieces["WhiteQueen"], 2, 0);

                // Repeat for black pieces
                gameBoard.AddPiece(gamePieces["BlackRook"], 7, 0); // Assuming bottom-left corner is 7,0
                gameBoard.AddPiece(gamePieces["BlackKnight"], 6, 0);
                gameBoard.AddPiece(gamePieces["BlackQueen"], 5, 0);

                // Determine who starts first and any other setup needed
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading images: " + ex.Message);
                // You may want to add additional error handling here
            }
        }
        private void TicTacChess_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }
        private void rbnWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnWhite.Checked)
            {
                pbxRook.Image = gamePieces["WhiteRook"].Image;
                pbxKnight.Image = gamePieces["WhiteKnight"].Image;
                pbxQueen.Image = gamePieces["WhiteQueen"].Image;
            }
        }
        private void rbnBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnBlack.Checked)
            {
                pbxRook.Image = gamePieces["BlackRook"].Image;
                pbxKnight.Image = gamePieces["BlackKnight"].Image;
                pbxQueen.Image = gamePieces["BlackQueen"].Image;
            }
        }

        private void pbxPiece_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pbx = sender as PictureBox;
            if (pbx != null && pbx.Image != null)
            {
                // Assuming the Name of the PictureBox corresponds to the key in gamePieces
                selectedPiece = gamePieces[pbx.Name]; // This requires that you name your PictureBoxes appropriately.
                pbx.DoDragDrop(pbx.Image, DragDropEffects.Move);
            }
        }

        private void pbxBoard_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void pbxBoard_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox target = sender as PictureBox;
            if (target != null)
            {
                // Assuming the PictureBox has a tag that helps identify its board position
                string tag = target.Tag.ToString();
                // Parse the tag to get the x and y board coordinates
                int x = int.Parse(tag.Substring(0, 1));
                int y = int.Parse(tag.Substring(1, 1));

                // Check if a piece was selected to move
                if (selectedPiece != null)
                {
                    // Perform move if valid
                    if (gameBoard.MovePiece(selectedPiece.CurrentPosition.X, selectedPiece.CurrentPosition.Y, x, y))
                    {
                        // Update the UI to reflect the new position of the piece
                        target.Image = selectedPiece.Image;
                        // Clear the previous position image
                        ClearPreviousPositionImage(selectedPiece.CurrentPosition);
                        // Reset selectedPiece
                        selectedPiece = null;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac_Chess
{
    public class Board
    {
        private Piece[,] squares = new Piece[3, 3];

        public void AddPiece(Piece piece, int x, int y)
        {
            if (IsPositionValid(x, y) && squares[x, y] == null)
            {
                squares[x, y] = piece;
                piece.CurrentPosition = new Point(x, y);
            }
        }

        public bool MovePiece(int startX, int startY, int endX, int endY)
        {
            if (IsPositionValid(startX, startY) && IsPositionValid(endX, endY))
            {
                Piece piece = squares[startX, startY];
                // Validate move based on the piece's movement rules
                if (piece != null && piece.IsValidMove(startX, startY, endX, endY))
                {
                    squares[endX, endY] = piece;
                    squares[startX, startY] = null;
                    piece.CurrentPosition = new Point(endX, endY);
                    return true;
                }
            }
            return false;
        }

        public bool IsPositionValid(int x, int y)
        {
            // Check if the position is within the bounds of the board
            return x >= 0 && x < 3 && y >= 0 && y < 3;
        }

        // You'll need to implement this method to check if the game is won.
        public bool CheckForWin()
        {
            // Add logic to check rows, columns, and diagonals for a win.
            return false;
        }

        // You can add a method to get the piece at a certain position if needed.
        public Piece GetPieceAt(int x, int y)
        {
            if (IsPositionValid(x, y))
            {
                return squares[x, y];
            }
            return null;
        }
    }
}

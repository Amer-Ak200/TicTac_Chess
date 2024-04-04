using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac_Chess
{
    public class Piece
    {
        public enum PieceType { Rook, Knight, Queen }

        public PieceType Type { get; private set; }
        public Image Image { get; private set; }
        public Point CurrentPosition { get; set; }

        public Piece(PieceType type, Image image)
        {
            Type = type;
            Image = image;
            CurrentPosition = new Point(-1, -1); // -1 indicates that it's not on the board.
        }

        // This method should be implemented to check if a move is valid for the piece
        public bool IsValidMove(int startX, int startY, int endX, int endY)
        {
            // Implement the logic for each piece type
            // For example, a rook can move horizontally or vertically without limit
            // A knight moves in an L shape: two squares in one direction and then one square perpendicular
            // The queen can move any number of squares along a row, column, or diagonal
            switch (Type)
            {
                case PieceType.Rook:
                    // Rook moves straight lines horizontally or vertically
                    return (startX == endX || startY == endY) && (startX != endX || startY != endY);
                case PieceType.Knight:
                    // Knight moves in L shapes: two squares in one direction, then one square perpendicular
                    int deltaX = Math.Abs(startX - endX);
                    int deltaY = Math.Abs(startY - endY);
                    return (deltaX == 2 && deltaY == 1) || (deltaX == 1 && deltaY == 2);
                case PieceType.Queen:
                    // Queen moves in straight lines in any direction or diagonally
                    bool straightLineMove = (startX == endX || startY == endY);
                    bool diagonalMove = Math.Abs(startX - endX) == Math.Abs(startY - endY);
                    return straightLineMove || diagonalMove;
                default:
                    return false;
            }
        }
    }
}

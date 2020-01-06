using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWang_Sokoban_GameboardDesignAndPlay
{
    #region Enum PictureType
    public enum PictureType
    {
        None,
        Hero,
        Wall,
        Box,
        Destination
    }
    #endregion

    class Tile : PictureBox
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public PictureType PictureType { get; set; }

        public static Tile[,] Tiles { get; set; }

        const int TILE_SIZE = 40;
        const int OFFSET = 40;

        #region Constructors
        public Tile(int row, int col)
        {
            Row = row;
            Col = col;
            PictureType = PictureType.None;
            this.Image = null;

            this.Size = new Size(TILE_SIZE, TILE_SIZE);
            this.Location = new Point(OFFSET + col * TILE_SIZE, OFFSET + row * TILE_SIZE);
            this.BorderStyle = BorderStyle.Fixed3D;
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public Tile()
        {

        } 
        #endregion

        /// <summary>
        /// to return a string of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Row},{Col},{(int)PictureType}";
        }

        /// <summary>
        /// to get the tile from the Tiles array
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public static Tile GetTile(int row, int col)
        {
            return Tiles[row, col];
        }
    }
}

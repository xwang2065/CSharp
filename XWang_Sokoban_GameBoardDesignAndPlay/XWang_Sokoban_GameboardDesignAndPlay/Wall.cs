using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWang_Sokoban_GameboardDesignAndPlay
{
    class Wall : Tile
    {
        public Wall()
        {
        }

        /// <summary>
        /// initialize the wall picturetype and image beside the base class construction
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public Wall(int row, int col) : base(row, col)
        {
            this.PictureType = PictureType.Wall;
            this.Image = Properties.Resources.wall;
        }
    }
}

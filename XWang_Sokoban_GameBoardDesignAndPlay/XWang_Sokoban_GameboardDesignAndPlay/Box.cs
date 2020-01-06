using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWang_Sokoban_GameboardDesignAndPlay
{
    class Box : Tile
    {
        public Box()
        {
        }

        /// <summary>
        /// initialize the box picturetype and image beside the base class construction
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public Box(int row, int col) : base(row, col)
        {
            this.PictureType = PictureType.Box;
            this.Image = Properties.Resources.box;
        }
    }
}

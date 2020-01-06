using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWang_Sokoban_GameboardDesignAndPlay
{
    class Destination : Tile
    {
        public Destination()
        {
        }

        /// <summary>
        /// initialize the destination picturetype and image beside the base class construction
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public Destination(int row, int col) : base(row, col)
        {
            this.PictureType = PictureType.Destination;
            this.Image = Properties.Resources.destination;
        }
    }
}

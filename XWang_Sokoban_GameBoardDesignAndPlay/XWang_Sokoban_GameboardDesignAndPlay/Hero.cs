using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWang_Sokoban_GameboardDesignAndPlay
{
    class Hero : Tile
    {
        public Hero()
        {
        }

        /// <summary>
        /// initialize the hero picturetype and image beside the base class construction
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public Hero(int row, int col) : base(row, col)
        {
            this.PictureType = PictureType.Hero;
            this.Image = Properties.Resources.hero;
        }
    }
}

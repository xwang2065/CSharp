using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWang_Sokoban_GameboardDesignAndPlay
{
    public partial class PlayForm : Form
    {
        Tile heroTile = new Tile();
        int numberOfMoves = 0;
        int numberOfPushes = 0;

        /// <summary>
        /// to initianlize conmponent and initialize the textboxes for showing scores 
        /// </summary>
        public PlayForm()
        {
            InitializeComponent();

            //initialize the textboxes for showing scores
            SetScoresTextBoxes();
        }

        /// <summary>
        /// set the value of score textboxes
        /// </summary>
        private void SetScoresTextBoxes()
        {
            txtNumberOfMoves.Text = numberOfMoves.ToString();
            txtNumberOfPushes.Text = numberOfPushes.ToString();
        }

        /// <summary>
        /// the eventhandler when menu item Load clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGameBoard();

            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "SKBN(*.skbn)|*.skbn";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileLines = File.ReadAllLines(openFileDialog.FileName);

                //the start index of lines for store tile info
                int tileLineIndex = 2;

                Tile.Tiles = new Tile[int.Parse(fileLines[0]), int.Parse(fileLines[1])];

                for (int row = 0; row < Tile.Tiles.GetLength(0); row++)
                {
                    for (int col = 0; col < Tile.Tiles.GetLength(1); col++)
                    {
                        string[] elements = fileLines[tileLineIndex++].Split(',');

                        Tile tile;
                        switch (int.Parse(elements[2]))
                        {
                            case (int)PictureType.Hero:
                                tile = new Hero(row, col);
                                Tile.Tiles[row, col] = tile;
                                break;
                            case (int)PictureType.Wall:
                                tile = new Wall(row, col);
                                Tile.Tiles[row, col] = tile;
                                break;
                            case (int)PictureType.Box:
                                tile = new Box(row, col);
                                Tile.Tiles[row, col] = tile;
                                break;
                            case (int)PictureType.Destination:
                                tile = new Destination(row, col);
                                Tile.Tiles[row, col] = tile;
                                break;
                            default:
                                tile = new Tile(row, col);
                                Tile.Tiles[row, col] = tile;
                                break;
                        }

                        tile.BorderStyle = BorderStyle.None;
                        pnlPlayBoard.Controls.Add(tile);
                    }
                }
            }
        }

        /// <summary>
        /// the event handler when menu item Exit clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// the event handler when the control buttons(direction buttons) clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDirection_Click(object sender, EventArgs e)
        {
            Button btnDirection = (Button)sender;

            Tile nextTile;
            Tile besideBoxTile;

            try
            {
                FindHeroTile();
                nextTile = GetNextTile(btnDirection, heroTile);

                //if the tile beside hero is empty or destination image, hero can move
                if (nextTile.PictureType == PictureType.None || nextTile.PictureType == PictureType.Destination)
                {
                    ChangeHeroTileAndNextTileImage(nextTile, btnDirection);
                    numberOfMoves += 1;
                    SetScoresTextBoxes();
                }
                else if (nextTile.PictureType == PictureType.Box)
                {
                    besideBoxTile = GetNextTile(btnDirection, nextTile);

                    //if the tile image beside the nextTile is empty or destination, the hero can push the box move
                    if (besideBoxTile.PictureType == PictureType.None || besideBoxTile.PictureType == PictureType.Destination)
                    {
                        ChangeHeroTileAndNextTileImage(nextTile, btnDirection);

                        //if box get into destination, change the box to another box image
                        if (besideBoxTile.PictureType == PictureType.Destination)
                        {
                            besideBoxTile.Image = Properties.Resources.boxGetDestination;
                        }
                        else
                        {
                            besideBoxTile.Image = Properties.Resources.box;
                        }
                        besideBoxTile.PictureType = PictureType.Box;
                        numberOfMoves += 1;
                        numberOfPushes += 1;
                        SetScoresTextBoxes();

                        //if all boxes get into destination, massagebox show the scores
                        if (CheckIfAllBoxesInDestination())
                        {
                            DialogResult result = MessageBox.Show($"Game end! \r\n Total Moves: {txtNumberOfMoves.Text} \r\n Total Pushes: {txtNumberOfPushes.Text}",
                                            "Sokoban", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (result == DialogResult.OK)
                            {
                                ResetGameBoard();
                            }
                        }
                    }
                    else
                    {
                        heroTile.Image = GetHeroImage(btnDirection);
                    }
                }
                else
                {
                    heroTile.Image = GetHeroImage(btnDirection);
                }
            }catch(IndexOutOfRangeException)
            {
                //if the design is not surrounded by walls and closed, the hero or box could be push out of the tiles borad,
                //then the IndexOutOfRangeException should be catched
                MessageBox.Show("The maze design error: the maze must be surrounded by walls and closed." +
                                "\r\n Please load another level");
                ResetGameBoard();
            }
            
        }

        /// <summary>
        /// to change the heroTile and the nextTile image
        /// </summary>
        /// <param name="nextTile"></param>
        /// <param name="btnDirection"></param>
        private void ChangeHeroTileAndNextTileImage(Tile nextTile, Button btnDirection)
        {
            //if hero moves to the destination, the tile image should be destination instead of empty when hero move out
            if (heroTile is Destination)
            {
                heroTile.Image = Properties.Resources.destination;
                heroTile.PictureType = PictureType.Destination;
            }
            else
            {
                heroTile.Image = null;
                heroTile.PictureType = PictureType.None;
            }

            nextTile.Image = GetHeroImage(btnDirection); ;
            nextTile.PictureType = PictureType.Hero;
        }

        /// <summary>
        /// return a hero image from resources according to the direction button clicked
        /// </summary>
        /// <param name="btnDirection"></param>
        /// <returns>image from the resources</returns>
        private Image GetHeroImage(Button btnDirection)
        {
            if (btnDirection == btnUp)
            {
                return Properties.Resources.heroUp;
            }
            else if (btnDirection == btnLeft)
            {
                return Properties.Resources.heroLeft;
            }
            else if (btnDirection == btnRight)
            {
                return Properties.Resources.heroRight;
            }
            else
            {
                return Properties.Resources.hero;
            }
        }

        /// <summary>
        /// to clear the game borad and reset the score textboxes
        /// </summary>
        private void ResetGameBoard()
        {
            pnlPlayBoard.Controls.Clear();
            Tile.Tiles = null;

            numberOfMoves = 0;
            numberOfPushes = 0;

            SetScoresTextBoxes();

            txtNumberOfMoves.Focus();
        }

        /// <summary>
        /// to check and return if all the boxes in destination
        /// </summary>
        /// <returns>are all boxes in destination</returns>
        private bool CheckIfAllBoxesInDestination()
        {
            int destinationCount = 0;
            int boxGetDestinationCount = 0;
            foreach(Tile tile in pnlPlayBoard.Controls)
            {
                if (tile is Destination)
                {
                    destinationCount += 1;
                    if (tile.PictureType != PictureType.Box)
                    {
                        return false;
                    }
                    else if (tile.PictureType == PictureType.Box)
                    {
                        boxGetDestinationCount += 1;
                    }
                }
            }

            if (boxGetDestinationCount == destinationCount)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// to find the tile which image is hero
        /// </summary>
        private void FindHeroTile()
        {
            foreach (Tile tile in pnlPlayBoard.Controls)
            {
                if (tile.PictureType == PictureType.Hero)
                {
                    heroTile = tile;
                    break;
                }
            }
        }

        /// <summary>
        /// to get the tile beside the hero's one side which is determined by the direction button clicked.
        /// ex: if btnLeft clicked, find the tile on the left side of the hero
        /// </summary>
        /// <param name="btnControl"></param>
        /// <param name="presentTile"></param>
        /// <returns>the tile next to the presentTile</returns>
        private Tile GetNextTile(Button btnControl, Tile presentTile)
        {
            if (btnControl == btnUp)
            {
                return Tile.GetTile(presentTile.Row - 1, presentTile.Col);
            }
            else if (btnControl == btnDown)
            {
                return Tile.GetTile(presentTile.Row + 1, presentTile.Col);
            }
            else if (btnControl == btnLeft)
            {
                return Tile.GetTile(presentTile.Row, presentTile.Col - 1);
            }
            else
            {
                return Tile.GetTile(presentTile.Row, presentTile.Col + 1);
            }
        }
    }
}

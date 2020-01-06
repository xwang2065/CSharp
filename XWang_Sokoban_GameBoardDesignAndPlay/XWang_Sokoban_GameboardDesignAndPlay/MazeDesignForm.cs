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
    public partial class MazeDesignForm : Form
    {
        int rowCount;
        int colCount;
        PictureType activePictureType = PictureType.None;

        private int ROW_LIMIT = 20;
        private int COL_LIMIT = 20;

        public MazeDesignForm()
        {
            InitializeComponent();

            //Store the pictureType to each radioButton's tag
            rdbNone.Tag = PictureType.None;
            rdbHero.Tag = PictureType.Hero;
            rdbWall.Tag = PictureType.Wall;
            rdbBox.Tag = PictureType.Box;
            rdbDestination.Tag = PictureType.Destination;
        }

        /// <summary>
        /// This is a even handler when Generate button get clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRow.Text, out rowCount) && int.TryParse(txtColumn.Text, out colCount))
            {
                //Limit the rowCount&colCount under 20
                if (rowCount > ROW_LIMIT || colCount > COL_LIMIT)
                {
                    MessageBox.Show("The maximum counts of row and column are 20.",
                                    "Sokoban", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int row = 0; row < rowCount; row++)
                    {
                        for (int col = 0; col < colCount; col++)
                        {
                            Tile tile = new Tile(row, col);
                            tile.Tag = tile;
                            tile.Click += Tile_Click;

                            pnlTiles.Controls.Add(tile);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide valid data for rows and columns (Both must be integers)",
                                "Sokoban", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This is a event handler for all the radio buttons when they get checked
        /// To assign the pictureType using their tag info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdbTool_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radTool = (RadioButton)sender;
            activePictureType = (PictureType)radTool.Tag;
        }

        /// <summary>
        /// this is a event handler when the generated tile get clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tile_Click(object sender, EventArgs e)
        {
            Tile tile = (Tile)sender;
            if (activePictureType == PictureType.Hero)
            {
                Hero hero = new Hero(tile.Row, tile.Col);
                tile.Tag = hero;
                tile.Image = hero.Image;
            }
            else if (activePictureType == PictureType.Wall)
            {
                Wall wall = new Wall(tile.Row, tile.Col);
                tile.Tag = wall;
                tile.Image = wall.Image;
            }
            else if (activePictureType == PictureType.Box)
            {
                Box box = new Box(tile.Row, tile.Col);
                tile.Tag = box;
                tile.Image = box.Image;
            }
            else if (activePictureType == PictureType.Destination)
            {
                Destination destination = new Destination(tile.Row, tile.Col);
                tile.Tag = destination;
                tile.Image = destination.Image;
            }
            else
            {
                tile.Tag = tile;
                tile.Image = null;
            }

            tile.PictureType = activePictureType;
        } 

        /// <summary>
        /// This is a event handler when the menu item "Save" get clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidateDesign();
        }

        #region Validate and SaveDesign
        /// <summary>
        /// This is a method to validate the design when user click the save button
        /// </summary>
        private void ValidateDesign()
        {
            int heroCount = 0;
            int boxCount = 0;
            int destinationCount = 0;

            foreach (Tile tile in pnlTiles.Controls)
            {
                if (tile.PictureType == PictureType.Hero)
                {
                    heroCount += 1;
                }
                if (tile.PictureType == PictureType.Box)
                {
                    boxCount += 1;
                }
                if (tile.PictureType == PictureType.Destination)
                {
                    destinationCount += 1;
                }
            }

            if (heroCount > 1 || boxCount != destinationCount)
            {
                MessageBox.Show("Please change some tools (There is only one hero, and the number of boxes should be equal to the number of destinations)",
                                "Sokoban", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveDesign();
            }

        }

        /// <summary>
        /// This is a method for saving the validated design to file
        /// </summary>
        private void SaveDesign()
        {
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.Filter = "SKBN(*.skbn)|*.skbn";
            saveFileDialog1.FileName = "XWangAssignment1Level";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(rowCount);
                    writer.WriteLine(colCount);

                    foreach (Tile tile in pnlTiles.Controls)
                    {
                        Tile savingTile = (Tile)tile.Tag;
                        writer.WriteLine(savingTile.ToString());
                    }
                }

                MessageBox.Show("File saved successfully.", "Sokoban",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        /// <summary>
        /// This is the event handler when the menu item "Exit" get clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

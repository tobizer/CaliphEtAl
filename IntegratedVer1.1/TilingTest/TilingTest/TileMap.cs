using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace FluxOfSouls
{

    class MapRow
    { 
        public List<MapCell> Columns = new List<MapCell>();
    }

    class TileMap
    {
        int squaresAcross = 10;
        int squaresDown = 20;
        int baseOffsetX = 250;
        int baseOffsetY = 50;
        Vector2 Location = Vector2.Zero;
        public List<MapRow> Rows = new List<MapRow>();
        public int MapWidth = 62;
        public int MapHeight = 20;

        public TileMap()
        {
            for (int y = 0; y < MapHeight; y++)
            {
                MapRow thisRow = new MapRow();
                for (int x = 0; x < MapWidth; x++)
                {
                    thisRow.Columns.Add(new MapCell(0));
                }
                Rows.Add(thisRow);
            }
            Rows[3].Columns[3].TileID = 3;
            Rows[4].Columns[3].TileID = 3;
            Rows[3].Columns[4].TileID = 3;
            Rows[4].Columns[4].TileID = 3;
            Rows[9].Columns[9].TileID = 3;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 firstSquare = new Vector2(Location.X % Tile.TileStepX, Location.Y / Tile.TileStepY);
            int firstX = (int)firstSquare.X;
            int firstY = (int)firstSquare.Y;

            Vector2 squareOffset = new Vector2(Location.X % Tile.TileStepX, Location.Y / Tile.TileStepY);
            int offsetX = (int)squareOffset.X;
            int offsetY = (int)squareOffset.Y;

            for (int y = 0; y < squaresDown; y++)
            {
                int rowOffset = 0;
                if ((firstY + y) % 2 == 1)
                    rowOffset = Tile.OddRowXOffset;

                for (int x = 0; x < squaresAcross; x++)
                {
                    foreach (int tileID in Rows[y + firstY].Columns[x + firstX].BaseTiles)
                    {
                        spriteBatch.Draw(Tile.TileSetTexture, new Rectangle((x * Tile.TileStepX) - offsetX + rowOffset + baseOffsetX, (y * Tile.TileStepY) - offsetY + baseOffsetY, Tile.TileWidth, Tile.TileHeight), Tile.GetSourceRectangle(tileID), Color.White);
                    }
                }
            }
        }
    }
}

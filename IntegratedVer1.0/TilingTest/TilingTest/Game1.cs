using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


/*Edited Version of Tutorial http://www.xnaresources.com/default.asp?page=Tutorial:TileEngineSeries:3 */

namespace FluxOfSouls
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        TileMap myMap = new TileMap();
        static public Vector2 Location = Vector2.Zero;
        SplashScreenGameComponent splashScreen;
        EndOfTurnGui endOfTurnGui;
        ZoneGui zoneGui;
        SoulGui soulGui;

        //Game Manager Class
        GameManager gameManager;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
            splashScreen = new SplashScreenGameComponent(this);
            endOfTurnGui = new EndOfTurnGui(this);
            zoneGui = new ZoneGui(this);
            soulGui = new SoulGui(this);

            gameManager = new GameManager(this, splashScreen);



            //Components.Add(splashScreen);

            //endOfTurnGui.Visible = false;
            //endOfTurnGui.Enabled = false;
            //Components.Add(endOfTurnGui);

            Components.Add(zoneGui);
            //Components.Add(soulGui);
        }
        protected override void Initialize()
        {
            this.IsMouseVisible = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Tile.TileSetTexture = Content.Load<Texture2D>(@"images\TileSets\part3_tileset");
            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {  
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            myMap.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

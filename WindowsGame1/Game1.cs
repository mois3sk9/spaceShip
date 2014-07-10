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
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace WindowsGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D[] camino = new Texture2D[2];
        Vector2[] posCamino = new Vector2[2];
        int velocidadCamino = 3;
        Texture2D auto;
        Vector2 posAuto = new Vector2(410, 400);

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            camino[0] = Content.Load<Texture2D>("fondospace");
            camino[1] = Content.Load<Texture2D>("fondospace");
            auto = Content.Load<Texture2D>("camaro");
            posCamino[0] = new Vector2(0, 0);
            posCamino[1] = new Vector2(0, -600);
           

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            posCamino[0].Y+=velocidadCamino;
            posCamino[1].Y += velocidadCamino;
            // TODO: Add your update logic here
            if (posCamino[0].Y == 600)
                posCamino[0].Y = -600;
            if (posCamino[1].Y == 600)
                posCamino[1].Y = -600;
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                if(posAuto.X == 410)
                    posAuto.X -= 100;
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                if (posAuto.X == 310)
                    posAuto.X += 100;
            velocidadCamino += gameTime.ElapsedGameTime.Seconds;
            base.Update(gameTime);
        }

        /// <summary>
        
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(camino[0], posCamino[0], Color.White);
            spriteBatch.Draw(camino[1], posCamino[1], Color.White);
            spriteBatch.Draw(auto, posAuto, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

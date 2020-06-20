﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MatchThreeGameForest.Gui.Screens
{
    class EndGameScreen : MenuScreen
    {
        private Texture2D gameOverScreen;

        Viewport viewport = Game1.instance.GraphicsDevice.Viewport;

        public EndGameScreen()
        {
            var content = Game1.instance.Content;
            var menuButtonTexture = content.Load<Texture2D>("Sprites/MenuButton");
            var menuButton = new Button(menuButtonTexture, new Point((viewport.Width - menuButtonTexture.Width) / 2, 300));
            menuButton.Clicked += OkButtonClicked;
            MenuButtons.Add(menuButton);
            gameOverScreen = content.Load<Texture2D>("Sprites/Gameover");
        }

        void OkButtonClicked(object sender, PlayerIndexEventArgs e)
        {
            LoadingScreen.Load(ScreenManager, new MainMenuScreen());
        }

        public override void Draw(GameTime gameTime)
        {
            var spriteBatch = Game1.instance.spriteBatch;
            spriteBatch.Begin();
            spriteBatch.Draw(gameOverScreen, new Vector2((viewport.Width - gameOverScreen.Width) / 2, (viewport.Height - gameOverScreen.Height) / 2), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
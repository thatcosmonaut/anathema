using Encompass;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Anathema
{
    class AnathemaGame : Game
    {
        GraphicsDeviceManager graphics;

        WorldBuilder WorldBuilder { get; } = new WorldBuilder();
        World World { get; set; }

        public AnathemaGame()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferMultiSampling = true;
            Content.RootDirectory = "Content";

            Window.AllowUserResizing = true;
            IsMouseVisible = true;
        }

        protected override void LoadContent()
        {
            World = WorldBuilder.Build();
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            World.Update(gameTime.ElapsedGameTime.TotalSeconds);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            World.Draw();

            base.Draw(gameTime);
        }
    }
}

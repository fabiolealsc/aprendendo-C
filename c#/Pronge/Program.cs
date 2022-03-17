using OpenTK.Graphics.OpenGL;
using OpenTK;
using OpenTK.Input;
using System;

namespace Pronge
{
    internal class Program :GameWindow
    {
        int xDaBola = 0;
        int yDaBola = 0;
        int tamanhoDaBola = 20;
        int velBolaX = 6;
        int velBolaY = 6;

        int yDoJog1 = 0;
        int yDoJog2 = 0;

        int xDoJog1()
        {
            return -ClientSize.Width / 2 + largDosJogs() / 2;
        }
        int xDoJog2()
        {
            return ClientSize.Width / 2 - largDosJogs() / 2;
        }
        int largDosJogs()
        {
            return tamanhoDaBola;
        }
        int altDosJogs()
        {
            return tamanhoDaBola * 5;
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            xDaBola += velBolaX;
            yDaBola += velBolaY;

            if (xDaBola + tamanhoDaBola/2 > ClientSize.Width / 2)
            {
                velBolaX = -velBolaX;
            }
            if (xDaBola - tamanhoDaBola / 2 < -ClientSize.Width / 2)
            {
                velBolaX = -velBolaX;
            }
            if (yDaBola + tamanhoDaBola / 2 > ClientSize.Height / 2)
            {
                velBolaY = -velBolaY;
            }
            if (yDaBola - tamanhoDaBola / 2 < -ClientSize.Height / 2)
            {
                velBolaY = -velBolaY;
            }
            if (Keyboard.GetState().IsKeyDown(Key.W))
            {
                yDoJog1 = yDoJog1 + 5;
                Console.WriteLine("Apertando W" + yDoJog1);
            }
            if (Keyboard.GetState().IsKeyDown(Key.S))
            {
                yDoJog1 = yDoJog1 - 5;
            }
            if (Keyboard.GetState().IsKeyDown(Key.Up))
            {
                yDoJog2 = yDoJog2 + 5;
            }
            if (Keyboard.GetState().IsKeyDown(Key.Down))
            {
                yDoJog2 = yDoJog2 - 5;
            }
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Viewport(0,0, ClientSize.Width, ClientSize.Height);

            Matrix4 projection = Matrix4.CreateOrthographic(ClientSize.Width, ClientSize.Height, 0.0f, 1.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            DesenharRetang(xDaBola, yDaBola, tamanhoDaBola, tamanhoDaBola);
            DesenharRetang(xDoJog1(), yDoJog1, altDosJogs(), largDosJogs());
            DesenharRetang(xDoJog2(), yDoJog2, altDosJogs(), largDosJogs());

            SwapBuffers();
        }
        void DesenharRetang(int x, int y, int alt, int larg)
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex2(-0.5f * larg + x, -0.5f * alt + y);
            GL.Vertex2(0.5f * larg + x, -0.5f * alt + y);
            GL.Vertex2(0.5f * larg + x, 0.5f * alt + y);
            GL.Vertex2(-0.5f * larg + x, 0.5f * alt + y);

            GL.End();
        }
        static void Main(string[] args)
        {
            new Program().Run();
        }
    }
}

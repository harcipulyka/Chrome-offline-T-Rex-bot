using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace DinoBot
{
    public partial class Form1 : Form
    {
        #region publics

        public static Rectangle rectangle = new Rectangle(675, 195, 550, 125);

        InputSimulator inputSimulator = new InputSimulator();

        public Color backgroundColor;
        public Color obstacleColor;
        Thread T;

        public int delay = 0;
        public int loopCounter = 0;
        public bool isActive = true;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //T = new Thread(Loop);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //T.Start();
            Loop();
        }

        public void ColorUpdate(Bitmap bitmap)
        {
            obstacleColor = bitmap.GetPixel(20, 40);
            /*
            akadalySample.BackColor = akadaly;
            akadalySample.Refresh();
            */

            backgroundColor = bitmap.GetPixel(6, 110);
            /*
            hatterSample.BackColor = hatter;
            hatterSample.Refresh();
            */
        }

        public void Loop()
        {
            while (true)
            {
                Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height, PixelFormat.Format32bppArgb);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(rectangle.Left, rectangle.Top, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);

                ColorUpdate(bitmap);

                WhatToDo(bitmap);

                Updater(bitmap);
            }
        }

        private void WhatToDo(Bitmap bitmap)
        {
            CheckJumpHeight(bitmap);
            CheckDuckHeight(bitmap);
            DelayUpdater();
        }

        private void CheckJumpHeight(Bitmap bitmap)
        {
            for (int i = 60 + Delay(true); i > 0; i--)
            {
                if (bitmap.GetPixel(60 + i, 60) != backgroundColor)
                {
                    VirtualKeyCode space = VirtualKeyCode.SPACE;
                    inputSimulator.Keyboard.KeyDown(space);
                    Thread.Sleep(Delay(false));
                    inputSimulator.Keyboard.KeyUp(space);

                    break;
                }
            }
        }

        private void CheckDuckHeight(Bitmap bitmap)
        {
            int duckDelay = 5;
            if (delay > 130)
            {
                duckDelay = 15;
            }

            for (int i = 40 + duckDelay; i > 0; i--)
            {
                if (bitmap.GetPixel(50 + i, 26) != backgroundColor)
                {
                    if (bitmap.GetPixel(50 + i + 30, 38) != backgroundColor) //akkor madar, ez a farka vege
                    {
                        VirtualKeyCode duck = VirtualKeyCode.DOWN;
                        inputSimulator.Keyboard.KeyDown(duck);
                        Thread.Sleep(250);
                        inputSimulator.Keyboard.KeyUp(duck);

                        break;
                    }
                }
            }
        }
        
        private void DelayUpdater()
        {
            loopCounter++;
            if (loopCounter % 90 == 0) delay++;
        }
        
        private int Delay(bool Jump)
        {
            if (Jump)
            {
                if (delay <= 100)
                {
                    return delay;
                }
                else return 100;
            }

            if (!Jump)
            {
                if (delay <= 70)
                {
                    return 140-delay;
                }
                else if (delay > 70 && delay <= 450)
                {
                    return 70;
                } 
                else if (delay > 450)
                {
                    return 90;
                }
            }

            return 0;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            //T.Suspend();
        }

        private void Updater(Bitmap bitmap)
        {
            ss.Image = bitmap;
            ss.Refresh();

            DelayScreen.Text = delay.ToString();
            DelayScreen.Refresh();
        }
    }
}

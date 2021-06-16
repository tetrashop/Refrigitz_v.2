using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace LearningMachine
{
    class ThinkingAtamata
    {
        //Initiate Global Variables.
        public QuantumLearningKrinskyAtamata[,] Tinking = null;
        PictureBox pictureBoxPointer = null;
        //Constructor.
        public ThinkingAtamata(PictureBox pictureBoxPointer0, Color AC)
        {
            //Initiate Global Variable By Local Parameters. 
            Tinking = new QuantumLearningKrinskyAtamata[pictureBoxPointer0.Image.Size.Width, pictureBoxPointer0.Image.Size.Height];
            pictureBoxPointer = pictureBoxPointer0;
            if (pictureBoxPointer0.Image.Size.Height > pictureBoxPointer0.Image.Size.Width)
            {
                //Initiate Quantum Learning Objects.
                for (int i = 0; i < pictureBoxPointer0.Image.Size.Width; i++)
                    for (int j = 0; j < pictureBoxPointer0.Image.Size.Height; j++)
                        Tinking[i, j] = new QuantumLearningKrinskyAtamata(pictureBoxPointer0.Size.Height, pictureBoxPointer0.Image.Size.Height, pictureBoxPointer0.Image.Size.Height, 0.1);
            }
            else
            {
                //Initiate Quantum Learning Objects.
                for (int i = 0; i < pictureBoxPointer0.Image.Size.Width; i++)
                    for (int j = 0; j < pictureBoxPointer0.Image.Size.Height; j++)
                        Tinking[i, j] = new QuantumLearningKrinskyAtamata(pictureBoxPointer0.Size.Height, pictureBoxPointer0.Image.Size.Width, pictureBoxPointer0.Image.Size.Width, 0.1);
            }
            //Draw Bitmap.
            Bitmap A = new Bitmap(pictureBoxPointer.Image, pictureBoxPointer.Image.Size);
            for (int i = 0; i < pictureBoxPointer0.Image.Size.Width; i++)
                for (int j = 0; j < pictureBoxPointer0.Image.Size.Height; j++)
                {
                    Color AColor = A.GetPixel(i, j);

                    if (AColor.ToArgb() == AC.ToArgb())
                    {


                        Tinking[i, j].LearningAlgorithmRegard();
                    }
                    else
                    {

                        Tinking[i, j].LearningAlgorithmPenalty();
                    }

                }
            A.Dispose();

        }

    }
}

//End Documents.
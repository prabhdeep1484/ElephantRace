using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElephantRace
{
    public class Elephant
    {
        private static int StartingPosition;
        private static int RacetrackLength;
        public PictureBox ElephantPictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get => StartingPosition; set => StartingPosition = value; }
        public static int RacetrackLength1 { get => RacetrackLength; set => RacetrackLength = value; }

        // generation across all Elephant objects

        public static bool Run(Elephant obj)
        {
            int distance = MyRandom.Next(2, 6);
            if (obj.ElephantPictureBox != null)
                obj.MoveElephantPictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1))
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            MoveElephantPictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveElephantPictureBox(int distance)
        {
            Point p = ElephantPictureBox.Location;
            p.X += distance;
            ElephantPictureBox.Location = p; //move Elephant in x-axis
        }
    }
}

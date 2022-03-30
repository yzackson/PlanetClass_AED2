using System;

namespace Planet
{
    
    public class CelestBody
    {
        private float posX { get; set; }
        private float posY { get; set; }
        private float mass { get; set; }

        public CelestBody(string posX, string posY, string mass)
        {
            this.posX = float.Parse(posX);
            Console.WriteLine(this.posX);
            this.posY = float.Parse(posY);
            this.mass = float.Parse(mass);
        }
    }

}



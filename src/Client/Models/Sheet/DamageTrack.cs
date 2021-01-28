using System;

namespace Models.Sheet
{
    public class DamageTrack
    {
        public string Type { get; set; }
        public int Boxes { get; set; }
        public int Overflow { get; set; }

        public DamageTrack(string type, int attributeTotal)
        {
            Type = type;

            if (attributeTotal % 2 > 0)
            {
                Boxes = (attributeTotal + 1) / 2 + 8;
            }
            else
            {
                Boxes = attributeTotal / 2 + 8;
            }

            Overflow = attributeTotal;
        }

        public DamageTrack()
        {
            Type = string.Empty;
            Boxes = 0;
            Overflow = 0;
        }
    }
}
using System;

namespace JsonModels.Sheet
{
    public class DamageTrack
    {
        public enum TrackType
        {
            PHYSICAL,
            STUN
        }

        public TrackType Type { get; set; }
        public int Boxes { get; set; }
        public int Overflow { get; set; }
        public int Current { get; set; }

        // Calculated
        public int WoundModifer
        {
            get => -(Math.Min(Current, Boxes) / 3);
        }
        
        public int Total
        {
            get
            {
                if (Type == TrackType.PHYSICAL)
                {
                    return Boxes + Overflow + 1;
                }
                
                return Boxes;
            }
        }

        public DamageTrack(TrackType type, int attributeTotal) : base()
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

            if (Type == TrackType.PHYSICAL)
            {
                Overflow = attributeTotal;
            }
        }

        public DamageTrack()
        {
            Type = TrackType.PHYSICAL;
            Boxes = 0;
            Overflow = 0;
            Current = 0;
        }

        public override string ToString()
        {
            return $"Damage Track => Type: {Type}; Boxes: {Boxes}; Overflow: {Overflow}; Current: {Current}; Total: {Total}";
        }
    }
}
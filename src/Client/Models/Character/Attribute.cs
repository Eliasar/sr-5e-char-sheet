using System;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Attribute
    {
        [JsonPropertyName("name_english")]
        public string NameEnglish { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("base")]
        public string BaseString { get; set; }

        [JsonIgnore]
        public int Base
        {
            get => Convert.ToInt32(BaseString);
        }

        [JsonPropertyName("total")]
        public string TotalString { get; set; }

        private int _total;
        [JsonIgnore]
        public int Total
        {
            get
            {
                if (_total == 0)
                {
                    _total = Convert.ToInt32(TotalString);
                }

                int _return = _total <= Aug ? _total : Aug;

                return _return;
            }

            set
            {
                _total = value;
                TotalString = _total.ToString();
            }
        }

        [JsonPropertyName("min")]
        public string MinString { get; set; }

        private int _min;
        [JsonIgnore]
        public int Min
        {
            get
            {
                if (_min == 0)
                {
                    _min = Convert.ToInt32(MinString);
                }

                return _min;
            }

            set
            {
                _min = value;
                MinString = _min.ToString();
            }
        }

        [JsonPropertyName("max")]
        public string MaxString { get; set; }

        private int _max;
        [JsonIgnore]
        public int Max
        {
            get
            {
                if (_max == 0)
                {
                    _max = Convert.ToInt32(MaxString);
                }

                return _max;
            }

            set
            {
                _max = value;
                MaxString = _max.ToString();
            }
        }

        [JsonPropertyName("aug")]
        public string AugString { get; set; }

        private int _aug;
        [JsonIgnore]
        public int Aug
        {
            get
            {
                if (_aug == 0)
                {
                    _aug = Convert.ToInt32(AugString);
                }

                return _aug;
            }

            set
            {
                _aug = value;
                AugString = _aug.ToString();
            }
        }

        [JsonPropertyName("bp")]
        public string BpString { get; set; }

        private int _bp;
        [JsonIgnore]
        public int Bp
        {
            get
            {
                if (_bp == 0)
                {
                    _bp = Convert.ToInt32(BpString);
                }

                return _bp;
            }

            set
            {
                _bp = value;
                BpString = _bp.ToString();
            }
        }

        [JsonPropertyName("metatypecategory")]
        public string Metatypecategory { get; set; }
    }
}
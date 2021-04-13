using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace JsonModels.Character
{
    public class Attribute : INotifyPropertyChanged
    {
        [JsonPropertyName("name_english")]
        public string NameEnglish { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("base")]
        public string BaseString { get; set; }

        [JsonPropertyName("total")]
        public string TotalString { get; set; }

        [JsonPropertyName("min")]
        public string MinString { get; set; }

        [JsonPropertyName("max")]
        public string MaxString { get; set; }

        [JsonPropertyName("aug")]
        public string AugString { get; set; }

        [JsonPropertyName("bp")]
        public string BpString { get; set; }

        [JsonPropertyName("metatypecategory")]
        public string Metatypecategory { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
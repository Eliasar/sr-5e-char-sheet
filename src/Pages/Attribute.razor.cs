using System;
using JsonModels.Character;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using src.Client;

namespace src.Pages
{
    public partial class Attribute : ComponentBase
    {
        public string Name { get; set; }
        public int Base { get; set; }

        /// <summary>
        /// Current value of attribute
        /// </summary>
        /// <value></value>
        public int Total
        {
            get { return Math.Clamp(total, Min, Aug); }
            set { total = value; }
        }
        private int total;

        /// <summary>
        /// Metatype minimum
        /// </summary>
        /// <value></value>
        public int Min { get; set; }

        /// <summary>
        /// Metatype maximum
        /// </summary>
        /// <value></value>
        public int Max { get; set; }

        /// <summary>
        /// Augmented maximum
        /// </summary>
        /// <value></value>
        public int Aug { get; set; }

        public int Bp { get; set; }
        public string MetaTypeCategory { get; set; }

        private static int INDEX = 0;
        private int Index { get; set; }

        private JsonModels.Character.Attribute _attribute;
        private bool areEventsRegistered = false;

        public JsonModels.Character.Attribute AttributeData
        {
            get => _attribute;
            set
            {
                _attribute = value;

                Name = value.Name;
                Base = Convert.ToInt32(value.BaseString);
                total = Convert.ToInt32(value.TotalString);
                Min = Convert.ToInt32(value.MinString);
                Max = Convert.ToInt32(value.MaxString);
                Aug = Convert.ToInt32(value.AugString);
                Bp = Convert.ToInt32(value.BpString);
                MetaTypeCategory = value.Metatypecategory;

                if (!areEventsRegistered)
                {
                    EffectManager.EffectActivated += HandleEffectActivated;
                    EffectManager.EffectDeactivated += HandleEffectDeactivated;
                    areEventsRegistered = true;
                }

                Index = INDEX++;

                Refresh();
            }
        }

        [Inject]
        private IJSRuntime JS { get; set; }

        public void HandleEffectActivated(object sender, EffectEventArgs e)
        {
            if (e.Effect.Type == Effect.EffectType.ATTRIBUTE &&
                e.Effect.ValueToAffect == Name &&
                e.Effect.IsActive)
            {
                total += e.Effect.Rating;
                Refresh();
            }
        }

        public void HandleEffectDeactivated(object sender, EffectEventArgs e)
        {
            if (e.Effect.Type == Effect.EffectType.ATTRIBUTE &&
                e.Effect.ValueToAffect == Name)
            {
                total -= e.Effect.Rating;
                Refresh();
            }
        }

        private void Refresh()
        {
            var row = new
            {
                name = Name,
                @base = Base,
                total = $"<strong>{Total}</strong>",
                metatype = $"{Min} / {Max} ({Aug})"
            };

            JS.InvokeVoidAsync("bootstrapTableFunctions.updateAttributeRow", Index, row);
            StateHasChanged();
        }
    }
}
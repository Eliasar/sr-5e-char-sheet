using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.JSInterop;
using JsonModels.Character;
using System.Text.Json;

namespace src.Client
{
    public class EffectManager
    {
        public static List<Effect> Effects = new List<Effect>();
        
        // Checkbox events
        public static event EventHandler<EffectEventArgs> EffectActivated;
        public static event EventHandler<EffectEventArgs> EffectDeactivated;

        // Member change events
        public static event EventHandler<EffectEventArgs> EffectAdded;
        public static event EventHandler<EffectEventArgs> EffectRemoved;

        public static void AddEffect(Effect effect)
        {
            effect.IsActive = true;
            Effects.Add(effect);
            EffectAdded?.Invoke(null, new EffectEventArgs(effect));

            if (effect.IsActive)
            {
                EffectActivated?.Invoke(null, new EffectEventArgs(effect));
            }
            else
            {
                EffectDeactivated?.Invoke(null, new EffectEventArgs(effect));
            }
        }

        public static void RemoveEffect(Effect effect)
        {
            effect.IsActive = false;
            Effects.Remove(effect);

            EffectDeactivated?.Invoke(null, new EffectEventArgs(effect));
            EffectRemoved?.Invoke(null, new EffectEventArgs(effect));
        }

        [JSInvokable]
        public static void RemoveEffectFromJs(string data)
        {
            RemoveEffect(Effects.First(e => e.Name == data));
        }

        [JSInvokable]
        public static void AddEffectFromJs(string data)
        {
            Effect effect = JsonSerializer.Deserialize<Effect>(data);
            AddEffect(effect);
        }

        public static string ToJson()
        {
            List<object> effectStrings = new List<object>();

            foreach (var effect in EffectManager.Effects)
            {
                effectStrings.Add(effect.ToObject());
            }

            return JsonSerializer.Serialize(effectStrings);
        }
    }

    public class EffectEventArgs : EventArgs
    {
        public Effect Effect { get; set; }

        public EffectEventArgs(Effect effect)
        {
            Effect = effect;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Character;
using Models.Sheet;
using Attribute = Models.Character.Attribute;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;

namespace src.Pages
{
    public partial class CharSheet : ComponentBase
    {
        private List<Attribute> Attributes = new List<Attribute>();
        private string Initiative;
        private string Armor;
        private string DefenseTest;
        private string FullDefenseTest;
        private DamageTrack DamageTrackPhysical = new DamageTrack();
        private DamageTrack DamageTrackStun = new DamageTrack();
        private List<Effect> CurrentEffects = new List<Effect>();

        [Inject]
        private HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Root root = await Http.GetFromJsonAsync<Root>("sample-data/wall.json");
            Character character = root.Characters.Character;

            Attribute Body = character.Attributes.Attribute[0];
            Body.Total += GetEffectTotal("BOD", character.Effects);

            Attribute Agility = character.Attributes.Attribute[1];
            Agility.Total += GetEffectTotal("AGI", character.Effects);

            Attribute Reaction = character.Attributes.Attribute[2];
            Reaction.Total += GetEffectTotal("REA", character.Effects);

            Attribute Strength = character.Attributes.Attribute[3];
            Strength.Total += GetEffectTotal("STR", character.Effects);

            Attribute Charisma = character.Attributes.Attribute[4];
            Charisma.Total += GetEffectTotal("CHA", character.Effects);

            Attribute Intuition = character.Attributes.Attribute[5];
            Intuition.Total += GetEffectTotal("INT", character.Effects);

            Attribute Logic = character.Attributes.Attribute[6];
            Logic.Total += GetEffectTotal("LOG", character.Effects);

            Attribute Willpower = character.Attributes.Attribute[7];
            Willpower.Total += GetEffectTotal("WIL", character.Effects);

            Attribute Edge = character.Attributes.Attribute[8];
            Attribute Magic = character.Attributes.Attribute[9];

            Attributes.Add(Body);
            Attributes.Add(Agility);
            Attributes.Add(Reaction);
            Attributes.Add(Strength);
            Attributes.Add(Charisma);
            Attributes.Add(Intuition);
            Attributes.Add(Logic);
            Attributes.Add(Willpower);
            Attributes.Add(Edge);
            Attributes.Add(Magic);

            // Important

            // Initiative
            //  Bonus - REA + INT
            //  Dice - Any power or cyberware of Improved Reflexes or Wired Reflexes
            int improvedReflexesRating = Convert.ToInt32(character.Powers.Power.First(p => p.Name == "Improved Reflexes").Rating);
            int wiredReflexesRating = Convert.ToInt32(character.Cyberwares?.Cyberware.First(p => p.Name == "Wired Reflexes").Rating);

            int initiativeDice = improvedReflexesRating + wiredReflexesRating + 1;

            Initiative = $"{(Reaction.Total + Intuition.Total)} + {initiativeDice}d6";

            // Armor
            Armor = character.Armor;

            // Defense Test
            DefenseTest = (Reaction.Total + Intuition.Total).ToString();

            // Full Defense Track
            // TODO: check for Agile Defender, Too Pretty to Hit where Willpower isn't used as the additional stat
            FullDefenseTest = (Reaction.Total + Intuition.Total + Willpower.Total).ToString();

            // Physical Damage Track (BOD / 2) [round up] + 8
            DamageTrackPhysical = new DamageTrack("Physical", Body.Total);

            // Stun Damage Track (WIL / 2) [round up] + 8
            DamageTrackStun = new DamageTrack("Stun", Willpower.Total);

            // Current Effects - Name, type affected, and Rating
            CurrentEffects = character.Effects;
        }

        int GetEffectTotal(string valueToAffect, List<Effect> effects)
        {
            if (effects.Count == 0)
            {
                return 0;
            }

            return effects
                .Where(e => e.Type == Effect.EffectType.ATTRIBUTE
                    && e.ValueToAffect == valueToAffect
                    && e.IsActive)
                .Sum(e => e.Rating);
        }
    }
}


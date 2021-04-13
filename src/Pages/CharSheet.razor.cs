using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonModels.Character;
using JsonModels.Sheet;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.JSInterop;
using src.Client;

namespace src.Pages
{
    public partial class CharSheet : ComponentBase
    {
        private string Name;
        private string Alias;
        private string Notes;

        private Attribute Body;
        private Attribute Agility;
        private Attribute Reaction;
        private Attribute Strength;
        private Attribute Charisma;
        private Attribute Intuition;
        private Attribute Logic;
        private Attribute Willpower;
        private Attribute Edge;
        private Attribute Magic;

        private List<Important> Importants = new List<Important>();
        private List<Important> Limits = new List<Important>();

        // private string Initiative;
        // private string Armor;
        // private string DefenseTest;
        // private string FullDefenseTest;
        
        private DamageTrack DamageTrackPhysical = new DamageTrack();
        private DamageTrack DamageTrackStun = new DamageTrack();

        private List<Skill> Skills = new List<Skill>();
        private List<Weapon> Weapons = new List<Weapon>();
        private List<Armor> Armors = new List<Armor>();
        private List<Gear> Gears = new List<Gear>();
        private List<Vehicle> Vehicles = new List<Vehicle>();
        private List<Cyberware> Cyberwares = new List<Cyberware>();
        private List<Spell> Spells = new List<Spell>();
        private List<Power> Powers = new List<Power>();
        private List<Martialart> MartialArts = new List<Martialart>();

        [Inject]
        private HttpClient Http { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        public CharSheet()
        {
            // Subscribe to EffectManager events
            EffectManager.EffectAdded += RefreshEffectTable;
            EffectManager.EffectRemoved += RefreshEffectTable;
        }

        ~CharSheet()
        {
            EffectManager.EffectAdded -= RefreshEffectTable;
            EffectManager.EffectRemoved -= RefreshEffectTable;
        }

        private string characterJsonFile = "sample-data/wall.json";

        protected override async Task OnInitializedAsync()
        {
            Root root = await Http.GetFromJsonAsync<Root>(characterJsonFile);
            Character character = root.Characters.Character;

            Name = !string.IsNullOrWhiteSpace(character.Name) ? character.Name : string.Empty;
            Alias = !string.IsNullOrWhiteSpace(character.Alias) ? character.Alias : string.Empty;
            Notes = !string.IsNullOrWhiteSpace(character.Notes) ? character.Notes : string.Empty;

            Body.AttributeData = character.Attributes[0].Attribute[0];
            Agility.AttributeData = character.Attributes[0].Attribute[1];
            Reaction.AttributeData = character.Attributes[0].Attribute[2];
            Strength.AttributeData = character.Attributes[0].Attribute[3];
            Charisma.AttributeData = character.Attributes[0].Attribute[4];
            Intuition.AttributeData = character.Attributes[0].Attribute[5];
            Logic.AttributeData = character.Attributes[0].Attribute[6];
            Willpower.AttributeData = character.Attributes[0].Attribute[7];
            Edge.AttributeData = character.Attributes[0].Attribute[8];
            Magic.AttributeData = character.Attributes[0].Attribute[9];

            // Important

            // Initiative
            //  Bonus - REA + INT
            //  Dice - Any power or cyberware of Improved Reflexes or Wired Reflexes
            int initiativeBonus = Reaction.Total + Intuition.Total;
            int initiativeDice = 1;

            if (character.Powers?.Power.Any(p => p.Name == "Improved Reflexes") == true)
            {
                initiativeDice += Convert.ToInt32(character.Powers?.Power.First(p => p.Name == "Improved Reflexes").Rating);
            }

            if (character.Cyberwares?.Cyberware.Any(p => p.Name == "Wired Reflexes") == true)
            {
                initiativeDice += Convert.ToInt32(character.Cyberwares?.Cyberware.First(p => p.Name == "Wired Reflexes").Rating);
            }

            Importants.Add(new Important
            {
                Name = "Initiative",
                Value = $"{initiativeBonus} + {initiativeDice}d6"
            });

            // Armor
            Importants.Add(new Important{ Name = "Armor", Value = character.Armor });

            // Defense Test
            Importants.Add(new Important
            {
                Name = "Defense Test",
                Value = (Reaction.Total + Intuition.Total).ToString()
            });

            // Full Defense Track
            // TODO: check for Agile Defender, Too Pretty to Hit where Willpower isn't used as the additional stat
            Importants.Add(new Important
            {
                Name = "Full Defense Test",
                Value = (Reaction.Total + Intuition.Total + Willpower.Total).ToString()
            });

            // Limits
            Important PhysicalLimit = new Important { Name = "Physical", Value = character.Limitphysical };
            Important MentalLimit = new Important { Name = "Mental", Value = character.Limitmental };
            Important SocialLimit = new Important { Name = "Social", Value = character.Limitsocial };
            Important AstralLimit = new Important { Name = "Astral", Value = character.Limitastral };
            
            if (character.Limitmodifiersphys?.Limitmodifier.Count > 0)
            {
                PhysicalLimit.Detail.AddRange(character.Limitmodifiersphys.Limitmodifier.Select(s => s.Name));
            }

            if (character.Limitmodifiersment?.Limitmodifier.Count > 0)
            {
                MentalLimit.Detail.AddRange(character.Limitmodifiersment.Limitmodifier.Select(s => s.Name));
            }

            if (character.Limitmodifierssoc?.Limitmodifier.Count > 0)
            {
                SocialLimit.Detail.AddRange(character.Limitmodifierssoc.Limitmodifier.Select(s => s.Name));
            }

            Limits.Add(PhysicalLimit);
            Limits.Add(MentalLimit);
            Limits.Add(SocialLimit);
            Limits.Add(AstralLimit);

            // Physical Damage Track (BOD / 2) [round up] + 8
            DamageTrackPhysical = new DamageTrack(DamageTrack.TrackType.PHYSICAL, Body.Total);

            // Stun Damage Track (WIL / 2) [round up] + 8
            DamageTrackStun = new DamageTrack(DamageTrack.TrackType.STUN, Willpower.Total);

            // Current Effects - Name, type affected, and Rating
            if (character.Effects?.Count > 0)
            {
                foreach (var eff in character.Effects)
                {
                    EffectManager.AddEffect(eff);
                }
            }

            // Skills
            Skills = character.Skills?.Skill;

            foreach (var skill in Skills)
            {
                // Add specialization rating to Total for viewing them together
                if (!string.IsNullOrWhiteSpace(skill.Spec))
                {
                    skill.Total = $"{skill.Total} ({skill.Specializedrating})";
                }

                // Change native language value from int.max to "Native"
                if (skill.Isnativelanguage == "True")
                {
                    skill.Rating = "Native";
                    skill.Total = "Native";
                }
            }

            // Weapons
            Weapons = character.Weapons?.Weapon;

            // Armors
            Armors = character.Armors?.Armor;
            
            // Gear
            Gears = character.Gears?.Gear;

            // Vehicle
            Vehicles = character.Vehicles?.Vehicle;

            // Cyberware
            Cyberwares = character.Cyberwares?.Cyberware;

            // Spells
            Spells = character.Spells?.Spell;

            // Powers
            Powers = character.Powers?.Power;

            // Martial Arts
            MartialArts = character.Martialarts?.Martialart;
        }

        private bool isSecondRender = false;
        protected override async Task OnAfterRenderAsync(bool isFirstRender)
        {
            if (isSecondRender)
            {
                var tasks = new List<Task>();

                tasks.Add(CreateBootstrapTable("attribute-table"));
                tasks.Add(CreateBootstrapTable("important-table"));
                tasks.Add(CreateBootstrapTable("effect-table"));
                tasks.Add(CreateBootstrapTable("limit-table"));
                tasks.Add(CreateBootstrapTable("skill-table"));
                tasks.Add(CreateBootstrapTable("knowledge-skill-table"));
                tasks.Add(CreateBootstrapTable("melee-weapons-table"));
                tasks.Add(CreateBootstrapTable("ranged-weapons-table"));
                tasks.Add(CreateBootstrapTable("armor-table"));
                tasks.Add(CreateBootstrapTable("vehicle-table"));
                tasks.Add(CreateBootstrapTable("cyberware-table"));
                tasks.Add(CreateBootstrapTable("spell-table"));
                tasks.Add(CreateBootstrapTable("power-table"));
                tasks.Add(CreateBootstrapTable("martial-art-table"));

                await Task.WhenAll(tasks);

                isSecondRender = false;
            }

            if (isFirstRender)
            {
                isSecondRender = true;
            }
                
            await base.OnAfterRenderAsync(isFirstRender);
        }

        /// <summary>
        /// Create a Bootstrap Table through a JavaScript call
        /// </summary>
        /// <param name="tableId">The "id" attribute of a table. Send without "#" prefix</param>
        /// <remarks>https://bootstrap-table.com/</remarks>
        /// <returns></returns>
        private async Task CreateBootstrapTable(string tableId)
        {
            await JS.InvokeVoidAsync("bootstrapTableFunctions.createTable", $"#{tableId}");
        }

        private async Task CreateRecursiveBootstrapTable(string tableId)
        {
            await JS.InvokeVoidAsync("bootstrapTableFunctions.createRecursiveTables", $"{tableId}");
        }

        private void UpdateWoundModifiers(DamageTrack damageTrack)
        {
            string name = string.Empty;
            Effect.EffectType type = Effect.EffectType.WOUND_PHYSICAL;
            int rating = 0;
            
            // Physical setup
            if (damageTrack.Type == DamageTrack.TrackType.PHYSICAL)
            {
                DamageTrackPhysical.Current = damageTrack.Current;

                name = "Wound Modifier - Physical";
                type = Effect.EffectType.WOUND_PHYSICAL;
                rating = DamageTrackPhysical.WoundModifer;
            }

            // Stun setup
            if (damageTrack.Type == DamageTrack.TrackType.STUN)
            {
                DamageTrackStun.Current = damageTrack.Current;

                name = "Wound Modifier - Stun";
                type = Effect.EffectType.WOUND_STUN;
                rating = DamageTrackStun.WoundModifer;
            }

            // If a wound modifier of the same types exists, remove it
            if (rating <= 0 && EffectManager.Effects.Any(e => e.Type == type && e.Rating != rating))
            {
                EffectManager.RemoveEffect(EffectManager.Effects.First(e => e.Type == type));
            }
            
            // Add effect to effect table
            if (rating < 0 && !EffectManager.Effects.Any(e => e.Type == type))
            {
                EffectManager.AddEffect(new Effect
                {
                    Name = name,
                    Type = type,
                    Rating = rating
                });
            }
        }

        private void RefreshEffectTable(object? sender, EffectEventArgs e)
        {
            JS.InvokeVoidAsync("bootstrapTableFunctions.refreshEffectTable", "#effect-table", EffectManager.ToJson());
        }
    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Character
{
    public class Character
    {
        [JsonPropertyName("imageformat")]
        public string Imageformat { get; set; }

        [JsonPropertyName("metatype")]
        public string Metatype { get; set; }

        [JsonPropertyName("metatype_english")]
        public string MetatypeEnglish { get; set; }

        [JsonPropertyName("metatype_guid")]
        public string MetatypeGuid { get; set; }

        [JsonPropertyName("metavariant")]
        public string Metavariant { get; set; }

        [JsonPropertyName("metavariant_english")]
        public string MetavariantEnglish { get; set; }

        [JsonPropertyName("metavariant_guid")]
        public string MetavariantGuid { get; set; }

        [JsonPropertyName("movement")]
        public string Movement { get; set; }

        [JsonPropertyName("walk")]
        public string Walk { get; set; }

        [JsonPropertyName("run")]
        public string Run { get; set; }

        [JsonPropertyName("sprint")]
        public string Sprint { get; set; }

        [JsonPropertyName("movementwalk")]
        public string Movementwalk { get; set; }

        [JsonPropertyName("movementswim")]
        public string Movementswim { get; set; }

        [JsonPropertyName("movementfly")]
        public string Movementfly { get; set; }

        [JsonPropertyName("gameplayoption")]
        public string Gameplayoption { get; set; }

        [JsonPropertyName("maxkarma")]
        public string Maxkarma { get; set; }

        [JsonPropertyName("maxnuyen")]
        public string Maxnuyen { get; set; }

        [JsonPropertyName("contactmultiplier")]
        public string Contactmultiplier { get; set; }

        [JsonPropertyName("prioritymetatype")]
        public string Prioritymetatype { get; set; }

        [JsonPropertyName("priorityattributes")]
        public string Priorityattributes { get; set; }

        [JsonPropertyName("priorityspecial")]
        public string Priorityspecial { get; set; }

        [JsonPropertyName("priorityskills")]
        public List<string> Priorityskills { get; set; }

        [JsonPropertyName("priorityresources")]
        public string Priorityresources { get; set; }

        [JsonPropertyName("primaryarm")]
        public string Primaryarm { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("age")]
        public string Age { get; set; }

        [JsonPropertyName("eyes")]
        public string Eyes { get; set; }

        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("weight")]
        public string Weight { get; set; }

        [JsonPropertyName("skin")]
        public string Skin { get; set; }

        [JsonPropertyName("hair")]
        public string Hair { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("background")]
        public object Background { get; set; }

        [JsonPropertyName("concept")]
        public string Concept { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        [JsonPropertyName("playername")]
        public string Playername { get; set; }

        [JsonPropertyName("gamenotes")]
        public object Gamenotes { get; set; }

        [JsonPropertyName("limitphysical")]
        public string Limitphysical { get; set; }

        [JsonPropertyName("limitmental")]
        public string Limitmental { get; set; }

        [JsonPropertyName("limitsocial")]
        public string Limitsocial { get; set; }

        [JsonPropertyName("limitastral")]
        public string Limitastral { get; set; }

        [JsonPropertyName("contactpoints")]
        public string Contactpoints { get; set; }

        [JsonPropertyName("contactpointsused")]
        public string Contactpointsused { get; set; }

        [JsonPropertyName("cfplimit")]
        public string Cfplimit { get; set; }

        [JsonPropertyName("ainormalprogramlimit")]
        public string Ainormalprogramlimit { get; set; }

        [JsonPropertyName("aiadvancedprogramlimit")]
        public string Aiadvancedprogramlimit { get; set; }

        [JsonPropertyName("spelllimit")]
        public string Spelllimit { get; set; }

        [JsonPropertyName("karma")]
        public string Karma { get; set; }

        [JsonPropertyName("totalkarma")]
        public string Totalkarma { get; set; }

        [JsonPropertyName("special")]
        public string Special { get; set; }

        [JsonPropertyName("totalspecial")]
        public string Totalspecial { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("totalattributes")]
        public string Totalattributes { get; set; }

        [JsonPropertyName("streetcred")]
        public string Streetcred { get; set; }

        [JsonPropertyName("calculatedstreetcred")]
        public string Calculatedstreetcred { get; set; }

        [JsonPropertyName("totalstreetcred")]
        public string Totalstreetcred { get; set; }

        [JsonPropertyName("burntstreetcred")]
        public string Burntstreetcred { get; set; }

        [JsonPropertyName("notoriety")]
        public string Notoriety { get; set; }

        [JsonPropertyName("calculatednotoriety")]
        public string Calculatednotoriety { get; set; }

        [JsonPropertyName("totalnotoriety")]
        public string Totalnotoriety { get; set; }

        [JsonPropertyName("publicawareness")]
        public string Publicawareness { get; set; }

        [JsonPropertyName("calculatedpublicawareness")]
        public string Calculatedpublicawareness { get; set; }

        [JsonPropertyName("totalpublicawareness")]
        public string Totalpublicawareness { get; set; }

        [JsonPropertyName("astralreputation")]
        public string Astralreputation { get; set; }

        [JsonPropertyName("totalastralreputation")]
        public string Totalastralreputation { get; set; }

        [JsonPropertyName("wildreputation")]
        public string Wildreputation { get; set; }

        [JsonPropertyName("totalwildreputation")]
        public string Totalwildreputation { get; set; }

        [JsonPropertyName("created")]
        public string Created { get; set; }

        [JsonPropertyName("nuyen")]
        public string Nuyen { get; set; }

        [JsonPropertyName("adept")]
        public string Adept { get; set; }

        [JsonPropertyName("magician")]
        public string Magician { get; set; }

        [JsonPropertyName("technomancer")]
        public string Technomancer { get; set; }

        [JsonPropertyName("ai")]
        public string Ai { get; set; }

        [JsonPropertyName("cyberwaredisabled")]
        public string Cyberwaredisabled { get; set; }

        [JsonPropertyName("critter")]
        public string Critter { get; set; }

        [JsonPropertyName("totaless")]
        public string Totaless { get; set; }

        [JsonPropertyName("tradition")]
        public Tradition Tradition { get; set; }

        [JsonPropertyName("dodge")]
        public string Dodge { get; set; }

        [JsonPropertyName("armor")]
        public string Armor { get; set; }

        [JsonPropertyName("firearmor")]
        public string Firearmor { get; set; }

        [JsonPropertyName("coldarmor")]
        public string Coldarmor { get; set; }

        [JsonPropertyName("electricityarmor")]
        public string Electricityarmor { get; set; }

        [JsonPropertyName("acidarmor")]
        public string Acidarmor { get; set; }

        [JsonPropertyName("fallingarmor")]
        public string Fallingarmor { get; set; }

        [JsonPropertyName("armordicestun")]
        public string Armordicestun { get; set; }

        [JsonPropertyName("firearmordicestun")]
        public string Firearmordicestun { get; set; }

        [JsonPropertyName("coldarmordicestun")]
        public string Coldarmordicestun { get; set; }

        [JsonPropertyName("electricityarmordicestun")]
        public string Electricityarmordicestun { get; set; }

        [JsonPropertyName("acidarmordicestun")]
        public string Acidarmordicestun { get; set; }

        [JsonPropertyName("fallingarmordicestun")]
        public string Fallingarmordicestun { get; set; }

        [JsonPropertyName("armordicephysical")]
        public string Armordicephysical { get; set; }

        [JsonPropertyName("firearmordicephysical")]
        public string Firearmordicephysical { get; set; }

        [JsonPropertyName("coldarmordicephysical")]
        public string Coldarmordicephysical { get; set; }

        [JsonPropertyName("electricityarmordicephysical")]
        public string Electricityarmordicephysical { get; set; }

        [JsonPropertyName("acidarmordicephysical")]
        public string Acidarmordicephysical { get; set; }

        [JsonPropertyName("fallingarmordicephysical")]
        public string Fallingarmordicephysical { get; set; }

        [JsonPropertyName("physicalcm")]
        public string Physicalcm { get; set; }

        [JsonPropertyName("physicalcmiscorecm")]
        public string Physicalcmiscorecm { get; set; }

        [JsonPropertyName("stuncm")]
        public string Stuncm { get; set; }

        [JsonPropertyName("stuncmismatrixcm")]
        public string Stuncmismatrixcm { get; set; }

        [JsonPropertyName("physicalcmfilled")]
        public string Physicalcmfilled { get; set; }

        [JsonPropertyName("stuncmfilled")]
        public string Stuncmfilled { get; set; }

        [JsonPropertyName("cmthreshold")]
        public string Cmthreshold { get; set; }

        [JsonPropertyName("physicalcmthresholdoffset")]
        public string Physicalcmthresholdoffset { get; set; }

        [JsonPropertyName("stuncmthresholdoffset")]
        public string Stuncmthresholdoffset { get; set; }

        [JsonPropertyName("cmoverflow")]
        public string Cmoverflow { get; set; }

        [JsonPropertyName("init")]
        public string Init { get; set; }

        [JsonPropertyName("initdice")]
        public string Initdice { get; set; }

        [JsonPropertyName("initvalue")]
        public string Initvalue { get; set; }

        [JsonPropertyName("initbonus")]
        public string Initbonus { get; set; }

        [JsonPropertyName("astralinit")]
        public string Astralinit { get; set; }

        [JsonPropertyName("astralinitdice")]
        public string Astralinitdice { get; set; }

        [JsonPropertyName("astralinitvalue")]
        public string Astralinitvalue { get; set; }

        [JsonPropertyName("matrixarinit")]
        public string Matrixarinit { get; set; }

        [JsonPropertyName("matrixarinitdice")]
        public string Matrixarinitdice { get; set; }

        [JsonPropertyName("matrixarinitvalue")]
        public string Matrixarinitvalue { get; set; }

        [JsonPropertyName("matrixcoldinit")]
        public string Matrixcoldinit { get; set; }

        [JsonPropertyName("matrixcoldinitdice")]
        public string Matrixcoldinitdice { get; set; }

        [JsonPropertyName("matrixcoldinitvalue")]
        public string Matrixcoldinitvalue { get; set; }

        [JsonPropertyName("matrixhotinit")]
        public string Matrixhotinit { get; set; }

        [JsonPropertyName("matrixhotinitdice")]
        public string Matrixhotinitdice { get; set; }

        [JsonPropertyName("matrixhotinitvalue")]
        public string Matrixhotinitvalue { get; set; }

        [JsonPropertyName("riggerinit")]
        public string Riggerinit { get; set; }

        [JsonPropertyName("magenabled")]
        public string Magenabled { get; set; }

        [JsonPropertyName("initiategrade")]
        public string Initiategrade { get; set; }

        [JsonPropertyName("resenabled")]
        public string Resenabled { get; set; }

        [JsonPropertyName("submersiongrade")]
        public string Submersiongrade { get; set; }

        [JsonPropertyName("depenabled")]
        public string Depenabled { get; set; }

        [JsonPropertyName("groupmember")]
        public string Groupmember { get; set; }

        [JsonPropertyName("groupname")]
        public object Groupname { get; set; }

        [JsonPropertyName("groupnotes")]
        public object Groupnotes { get; set; }

        [JsonPropertyName("surprise")]
        public string Surprise { get; set; }

        [JsonPropertyName("composure")]
        public string Composure { get; set; }

        [JsonPropertyName("judgeintentions")]
        public string Judgeintentions { get; set; }

        [JsonPropertyName("judgeintentionsresist")]
        public string Judgeintentionsresist { get; set; }

        [JsonPropertyName("liftandcarry")]
        public string Liftandcarry { get; set; }

        [JsonPropertyName("memory")]
        public string Memory { get; set; }

        [JsonPropertyName("liftweight")]
        public string Liftweight { get; set; }

        [JsonPropertyName("carryweight")]
        public string Carryweight { get; set; }

        [JsonPropertyName("fatigueresist")]
        public string Fatigueresist { get; set; }

        [JsonPropertyName("radiationresist")]
        public string Radiationresist { get; set; }

        [JsonPropertyName("sonicresist")]
        public string Sonicresist { get; set; }

        [JsonPropertyName("toxincontactresist")]
        public string Toxincontactresist { get; set; }

        [JsonPropertyName("toxiningestionresist")]
        public string Toxiningestionresist { get; set; }

        [JsonPropertyName("toxininhalationresist")]
        public string Toxininhalationresist { get; set; }

        [JsonPropertyName("toxininjectionresist")]
        public string Toxininjectionresist { get; set; }

        [JsonPropertyName("pathogencontactresist")]
        public string Pathogencontactresist { get; set; }

        [JsonPropertyName("pathogeningestionresist")]
        public string Pathogeningestionresist { get; set; }

        [JsonPropertyName("pathogeninhalationresist")]
        public string Pathogeninhalationresist { get; set; }

        [JsonPropertyName("pathogeninjectionresist")]
        public string Pathogeninjectionresist { get; set; }

        [JsonPropertyName("physiologicaladdictionresistfirsttime")]
        public string Physiologicaladdictionresistfirsttime { get; set; }

        [JsonPropertyName("physiologicaladdictionresistalreadyaddicted")]
        public string Physiologicaladdictionresistalreadyaddicted { get; set; }

        [JsonPropertyName("psychologicaladdictionresistfirsttime")]
        public string Psychologicaladdictionresistfirsttime { get; set; }

        [JsonPropertyName("psychologicaladdictionresistalreadyaddicted")]
        public string Psychologicaladdictionresistalreadyaddicted { get; set; }

        [JsonPropertyName("physicalcmnaturalrecovery")]
        public string Physicalcmnaturalrecovery { get; set; }

        [JsonPropertyName("stuncmnaturalrecovery")]
        public string Stuncmnaturalrecovery { get; set; }

        [JsonPropertyName("indirectdefenseresist")]
        public string Indirectdefenseresist { get; set; }

        [JsonPropertyName("directmanaresist")]
        public string Directmanaresist { get; set; }

        [JsonPropertyName("directphysicalresist")]
        public string Directphysicalresist { get; set; }

        [JsonPropertyName("detectionspellresist")]
        public string Detectionspellresist { get; set; }

        [JsonPropertyName("decreasebodresist")]
        public string Decreasebodresist { get; set; }

        [JsonPropertyName("decreaseagiresist")]
        public string Decreaseagiresist { get; set; }

        [JsonPropertyName("decreaserearesist")]
        public string Decreaserearesist { get; set; }

        [JsonPropertyName("decreasestrresist")]
        public string Decreasestrresist { get; set; }

        [JsonPropertyName("decreasecharesist")]
        public string Decreasecharesist { get; set; }

        [JsonPropertyName("decreaseintresist")]
        public string Decreaseintresist { get; set; }

        [JsonPropertyName("decreaselogresist")]
        public string Decreaselogresist { get; set; }

        [JsonPropertyName("decreasewilresist")]
        public string Decreasewilresist { get; set; }

        [JsonPropertyName("illusionmanaresist")]
        public string Illusionmanaresist { get; set; }

        [JsonPropertyName("illusionphysicalresist")]
        public string Illusionphysicalresist { get; set; }

        [JsonPropertyName("manipulationmentalresist")]
        public string Manipulationmentalresist { get; set; }

        [JsonPropertyName("manipulationphysicalresist")]
        public string Manipulationphysicalresist { get; set; }

        [JsonPropertyName("skills")]
        public Skills Skills { get; set; }

        [JsonPropertyName("contacts")]
        public Contacts Contacts { get; set; }

        [JsonPropertyName("limitmodifiersphys")]
        public Limitmodifiersphys Limitmodifiersphys { get; set; }

        [JsonPropertyName("limitmodifiersment")]
        public object Limitmodifiersment { get; set; }

        [JsonPropertyName("limitmodifierssoc")]
        public object Limitmodifierssoc { get; set; }

        [JsonPropertyName("spells")]
        public object Spells { get; set; }

        [JsonPropertyName("powers")]
        public Powers Powers { get; set; }

        [JsonPropertyName("spirits")]
        public object Spirits { get; set; }

        [JsonPropertyName("complexforms")]
        public object Complexforms { get; set; }

        [JsonPropertyName("aiprograms")]
        public object Aiprograms { get; set; }

        [JsonPropertyName("martialarts")]
        public Martialarts Martialarts { get; set; }

        [JsonPropertyName("armors")]
        public Armors Armors { get; set; }

        [JsonPropertyName("weapons")]
        public Weapons Weapons { get; set; }

        [JsonPropertyName("cyberwares")]
        public Cyberwares? Cyberwares { get; set; }= null!;

        [JsonPropertyName("qualities")]
        public Qualities Qualities { get; set; }

        [JsonPropertyName("lifestyles")]
        public Lifestyles Lifestyles { get; set; }

        [JsonPropertyName("gears")]
        public Gears Gears { get; set; }

        [JsonPropertyName("drugs")]
        public object Drugs { get; set; }

        [JsonPropertyName("vehicles")]
        public object Vehicles { get; set; }

        [JsonPropertyName("initiationgrades")]
        public object Initiationgrades { get; set; }

        [JsonPropertyName("metamagics")]
        public object Metamagics { get; set; }

        [JsonPropertyName("arts")]
        public object Arts { get; set; }

        [JsonPropertyName("enhancements")]
        public object Enhancements { get; set; }

        [JsonPropertyName("critterpowers")]
        public object Critterpowers { get; set; }

        [JsonPropertyName("calendar")]
        public object Calendar { get; set; }

        [JsonPropertyName("effects")]
        public List<Effect> Effects { get; set; }
    }
}
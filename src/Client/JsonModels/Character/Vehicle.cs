using JsonModels.Character;
using Newtonsoft.Json;

public class Vehicle
{
    [JsonProperty("guid")]
    public string Guid { get; set; } 

    [JsonProperty("sourceid")]
    public string Sourceid { get; set; } 

    [JsonProperty("name")]
    public string Name { get; set; } 

    [JsonProperty("fullname")]
    public string Fullname { get; set; } 

    [JsonProperty("category")]
    public string Category { get; set; } 

    [JsonProperty("handling")]
    public string Handling { get; set; } 

    [JsonProperty("accel")]
    public string Accel { get; set; } 

    [JsonProperty("speed")]
    public string Speed { get; set; } 

    [JsonProperty("pilot")]
    public string Pilot { get; set; } 

    [JsonProperty("body")]
    public string Body { get; set; } 

    [JsonProperty("armor")]
    public string Armor { get; set; } 

    [JsonProperty("seats")]
    public string Seats { get; set; } 

    [JsonProperty("sensor")]
    public string Sensor { get; set; } 

    [JsonProperty("avail")]
    public string Avail { get; set; } 

    [JsonProperty("cost")]
    public string Cost { get; set; } 

    [JsonProperty("owncost")]
    public string Owncost { get; set; } 

    [JsonProperty("source")]
    public string Source { get; set; } 

    [JsonProperty("page")]
    public string Page { get; set; } 

    [JsonProperty("physicalcm")]
    public string Physicalcm { get; set; } 

    [JsonProperty("matrixcm")]
    public string Matrixcm { get; set; } 

    [JsonProperty("physicalcmfilled")]
    public string Physicalcmfilled { get; set; } 

    [JsonProperty("vehiclename")]
    public object Vehiclename { get; set; } 

    [JsonProperty("maneuver")]
    public string Maneuver { get; set; } 

    [JsonProperty("location")]
    public object Location { get; set; } 

    [JsonProperty("active")]
    public string Active { get; set; } 

    [JsonProperty("homenode")]
    public string Homenode { get; set; } 

    [JsonProperty("iscommlink")]
    public string Iscommlink { get; set; } 

    [JsonProperty("attack")]
    public string Attack { get; set; } 

    [JsonProperty("sleaze")]
    public string Sleaze { get; set; } 

    [JsonProperty("dataprocessing")]
    public string Dataprocessing { get; set; } 

    [JsonProperty("firewall")]
    public string Firewall { get; set; } 

    [JsonProperty("devicerating")]
    public string Devicerating { get; set; } 

    [JsonProperty("programlimit")]
    public string Programlimit { get; set; } 

    [JsonProperty("mods")]
    public Mods Mods { get; set; } 

    [JsonProperty("gears")]
    public Gears Gears { get; set; } 

    [JsonProperty("weapons")]
    public object Weapons { get; set; } 

    [JsonProperty("notes")]
    public object Notes { get; set; } 
}
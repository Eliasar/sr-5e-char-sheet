public class Stat
{
    public string Name { get; set; }
    public int Base { get; set; }
    public int Total { get; set; }
    public int MetatypeMinimum { get; set; }
    public int MetatypeMaximum { get; set; }
    public int AugmentMaximum { get; set; }

    public Stat(string name)
    {
        Name = name;
    }
}
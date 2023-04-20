
namespace _cs_inher_poly_music
{
    public class Instrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }

        public string Sound { get; set; }

        public Instrument()
        {
            Name= string.Empty;
            Description= string.Empty;
            Material= string.Empty;
            Sound= string.Empty;
        }
        public Instrument(string name, string description, string material, string sound)
        {
            Name = name;
            Description = description;
            Material = material;
            Sound = sound;
        }
        public Instrument(string name)
        {
            Name = name;
            Description= "none";
            Material= "none";
            Sound= "none";
        }

        public virtual void Using()
        {
            Console.Write($"Your {Name} do sound {Sound}");
        }
        public virtual void ToString()
        {
            Console.Write($"Name: {Name}\nDescription: {Description}\nMaterial: {Material}\nSound: {Sound}\n");
        }
    }
    public sealed class Piano : Instrument
    {
        public string Company { get; set; }
        public int NumberButtons { get; set; }

        public Piano(string name, string description, string material, string sound, string company, int numberButtons)
            : base(name, description, material, sound) 
        {
            Company= company;
            NumberButtons = numberButtons;
        }
        public override void Using()
        {
            base.Using();
            Console.Write($" on your piano");
        }
        public override void ToString()
        {
            base.ToString();
            Console.Write($"Company: {Company}\nNumber buttons: {NumberButtons}\n");
        }
    }
    public sealed class Guitar : Instrument
    {
        public int NumberWire { get; set; }
        public string Type{ get; set; }

        public Guitar(string name, string description, string material, string sound, int numberWire, string type)
            : base(name, description, material, sound)
        {
            NumberWire = numberWire;
            Type = type;
        }
        public override void Using()
        {
            base.Using();
            Console.Write($" on your guitar");
        }
        public override void ToString()
        {
            base.ToString();
            Console.Write($"Type: {Type}\nNumber wire: {NumberWire}\n");
        }
    }

    public sealed class Sopilka : Instrument
    {
        public string NumberHoles { get; set; }

        public Sopilka(string name, string description, string material, string sound, string numberHoles)
            : base(name, description, material, sound)
        {
            NumberHoles= numberHoles;
        }
        public override void Using()
        {
            base.Using();
            Console.Write($" on your sopilka");
        }
        public override void ToString()
        {
            base.ToString();
            Console.Write($"Number holes: {NumberHoles}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Instrument i = new Instrument();
            i.ToString();
        }
    }
}
using System;
namespace DesignPatterns.Prototype
{
    public class UsePrototypes
    {
        public void Run ()
        {
            Component prototype = new Type1Component();
            var printer = new ComponentInformationPrinter (prototype);
            printer.PrintInformation ();
        }
    }

    public class ComponentInformationPrinter
    {
        public ComponentInformationPrinter (Component prototype)
        {
            this.prototype = prototype;
        }

        private Component prototype { get; }

        public void PrintInformation ()
        {
            var component = this.prototype.Clone ();
            Console.WriteLine (component.Type ());
            Console.WriteLine (component.Category ());
        }
    }

    public abstract class Component
    {
        public abstract int Type ();
        public abstract string Category ();
        public abstract Component Clone ();
    }

    public class Type1Component : Component
    {
        public override int Type () => 1;
        public override string Category () => "Category 1";
        public override Component Clone () => new Type1Component ();
    }

    public class Type2Component : Component
    {
        public override int Type () => 2;
        public override string Category () => "Category 2";
        public override Component Clone () => new Type1Component ();
    }
}


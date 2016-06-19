using System;
namespace DesignPatterns.FactoryMethod
{
    public class UseFactoryMethod
    {
        public void Run ()
        {
            var printer = new ComponentInformationPrinter ();
            printer.PrintInformation ();
        }
    }

    public class ComponentInformationPrinter
    {
        public virtual Component CreateComponent () =>  null;
        public void PrintInformation ()
        {
            var component = CreateComponent ();
            Console.WriteLine (component.Type ());
            Console.WriteLine (component.Category ());
        }
    }

    public class Type1Printer : ComponentInformationPrinter
    {
        public override Component CreateComponent () => new Type1Component ();
    }

    public class Type2Printer : ComponentInformationPrinter
    {
        public override Component CreateComponent () => new Type2Component ();
    }

    public abstract class Component
    {
        public abstract int Type ();
        public abstract string Category ();
    }

    public class Type1Component : Component
    {
        public override int Type () => 1;
        public override string Category () => "Category 1";
    }

    public class Type2Component : Component
    {
        public override int Type () => 2;
        public override string Category () => "Category 2";
    }
}


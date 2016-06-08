using System;
namespace DesignPatterns
{
    public class UseAbstractFactoryPattern
    {
        public void Run ()
        {
            var printer = new ComponentInformationPrinter (new Type1Factory ());
            printer.PrintInformation ();
        }
    }

    public class ComponentInformationPrinter
    {
        public ComponentInformationPrinter (ComponentFactory componentFactory)
        {
            this.ComponentFactory = componentFactory;
        }

        private ComponentFactory ComponentFactory { get; }

        public void PrintInformation ()
        {
            var component = this.ComponentFactory.CreateComponent ();
            Console.WriteLine (component.Type ());
            Console.WriteLine (component.Category ());
        }
    }

    public abstract class ComponentFactory
    {
        public abstract Component CreateComponent ();
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

    public class Type1Factory : ComponentFactory
    {
        public override Component CreateComponent () => new Type1Component ();
    }

    public class Type2Component : Component
    {
        public override int Type () => 2;
        public override string Category () => "Category 2";
    }

    public class Type2Factory : ComponentFactory
    {
        public override Component CreateComponent () => new Type2Component ();
    }
}


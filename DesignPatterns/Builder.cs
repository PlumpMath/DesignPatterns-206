﻿using System;
namespace DesignPatterns
{
    public class UseBuilderPattern
    {
        public void Run ()
        {
            var director = new ItemDirector ();

            var builder = new YellowItemBuilder ();

            var builtItem = director.Construct (builder);

            builtItem.ShowParts ();
        }
    }

    public class ItemDirector
    {
        public Item Construct (ItemBuilder builder)
        {
            builder.BuildFirstPart ();
            builder.BuildSecondPart ();
            return builder.GetItem ();
        }
    }

    public abstract class ItemBuilder
    {
        public abstract void BuildFirstPart ();
        public abstract void BuildSecondPart ();
        public abstract Item GetItem ();
    }

    public class YellowItemBuilder : ItemBuilder
    {
        private readonly Item item = new Item ();

        public override void BuildFirstPart ()
        {
            item.FirstPartName = "YellowFirstPart";
        }

        public override void BuildSecondPart ()
        {
            item.SecondPartName = "YellowSecondPart";
        }

        public override Item GetItem () => item;
    }

    public class GreenItemBuilder : ItemBuilder
    {
        private readonly Item item = new Item ();

        public override void BuildFirstPart ()
        {
            item.FirstPartName = "GreenFirstPart";
        }

        public override void BuildSecondPart ()
        {
            item.SecondPartName = "GreenSecondPart";
        }

        public override Item GetItem () => item;
    }

    public class Item
    {
        public string FirstPartName;
        public string SecondPartName;

        public void ShowParts () => Console.WriteLine ($"{FirstPartName}, {SecondPartName}.");
    }
}


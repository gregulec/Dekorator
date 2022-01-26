using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dekorator
{
    abstract class Room
    {
        protected string room = "Pokój ekonomiczny";

        virtual public String description()
        {
            return room;
        }

        public abstract double price();
    }
    
    abstract class Decorator : Room
    {
        public abstract override String description();
    }

    class Sheraton : Room
    {

        public Sheraton()
        {
            room = "pokój w Sheratonie";
        }

        public override double price()
        {
            return 50;
        }
    }

    class Mercure : Room
    {

        public Mercure()
        {
            room = "pokój w Mercure";
        }

        public override double price()
        {
            return 20;
        }
    }

    class Phone : Decorator
    {
        Room phoneroom;

        public Phone(Room room)
        {
            phoneroom = room;
        }

        public override String description()
        {
            return phoneroom.description() + " z telefonem";
        }

        public override double price()
        {
            if (phoneroom is Sheraton)
            {
                return phoneroom.price() + 20;
            }
            else if (phoneroom is Mercure)
            {
                return phoneroom.price() + 10;
            }
            return 0;
        }
    }

    class Air : Decorator
    {
        Room airroom;

        public Air(Room room)
        {
            airroom = room;
        }

        public override String description()
        {
            return airroom.description() + " z wann¹";
        }

        public override double price()
        {
            return airroom.price() + 30;
        }
    }
}
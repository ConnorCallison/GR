using System;
namespace GR
{
    public class Item
    {
        public Item()
        {
            this.DailyDegredation = 1;
        }

        public string Name { get; set; }

        public int SellIn { get; set; }

        public string Type { get; set; }

        // Decided to add this property for extensibility of degredation for
        // future products
        public int DailyDegredation { get; set; }

        // private protected so Sulfuras class can have its quality of 80 without
        // adding extra cost to these getter / setters for the rest of the items
        private protected int _quality { get; set; }

        public int Quality
        {
            //Custom getter & setter to enforce quality never greater than
            // fifty and never less than zero.
            get
            {
                return this._quality;
            }
            set
            {
                if ((this._quality + value) >= 50)
                {
                    this._quality = 50;
                }
                else if (value >= 0)
                {
                    this._quality = value;
                }
                else
                {
                    this._quality = 0;
                    Console.WriteLine("Item quality has reached zero!");
                }
            }
        }


        public virtual void DailyUpdate()
        {
            //If we are past the SellBy date, degrade twice as fast.
            if (SellIn < 0)
            {
                this.Quality -= (this.DailyDegredation * 2);
            }
            else
            {
                this.Quality -= this.DailyDegredation;

            }

            this.SellIn -= 1;
        }
    }
}

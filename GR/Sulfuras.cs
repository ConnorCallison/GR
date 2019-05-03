using System;
namespace GR
{
    public class Sulfuras : Item
    {
        public Sulfuras()
        {
            this._quality = 80;
        }

        public override void DailyUpdate()
        {
            //Never needs to change so we dont do anything
            Console.WriteLine("No change for the mighty weapon of Ragnaros the Firelord.");
        }

    }
}

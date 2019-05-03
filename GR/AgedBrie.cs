using System;
namespace GR
{
    public class AgedBrie : Item
    {
        //This class could be removed if we simply set
        //the aged brie's DailyDegredation to -1.
        //But that felt hacky so I went with a class.

        public override void DailyUpdate()
        {
            //Note: Assuming this item increases in quality over time it also
            //never needs to be sold. So not decrementing SellIn.
            this.Quality += 1;
        }
    }
}

using System;
namespace GR
{
    public class BackstagePasses : Item
    {
        public override void DailyUpdate()
        {
            //Increment by 1 if concert in 11+ days
            if (this.SellIn >= 11)
            {
                this.Quality += 1;
            }
            //Increment by 2 between 10 and 5 days
            else if (this.SellIn <= 10 && this.SellIn > 5)
            {
                this.Quality += 2;
            }
            //Increment by 3 if within last 5 days
            else if (this.SellIn <= 5 && this.SellIn > 0)
            {
                this.Quality += 3;
            }
            //Set to zero after concert.
            else
            {
                this.Quality = 0;
            }

            this.SellIn -= 1;
        }

    }
}

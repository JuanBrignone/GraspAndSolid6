using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class TimerCli : TimerClient
    {
        private Recipe recipe;

        public TimerCli(Recipe recipe)
        {
            this.recipe = recipe;
        }

        public void TimeOut()
        {
            recipe.Cooked = true;
        }
    }







}
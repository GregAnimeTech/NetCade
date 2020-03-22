using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Web;

namespace NetCade.App_Code
{
    public class PlayerHealth //This sites global variable for the story game.  
    {
        private int health;  // Global variable storing stuff.
        public int Health  // Get or set the data.
        {
            get { return health; }
            set { health = 100; }
        }
    }
}

using Exiled.API.Features;
using PlayerRoles.Spectating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwoodTpsFix
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "Mariki";
        public override string Name => "TpsFix";

        public override void OnEnabled()
        {
            base.OnEnabled();
        }
    }
}

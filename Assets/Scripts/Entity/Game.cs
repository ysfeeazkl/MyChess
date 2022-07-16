using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Entity
{
    public class Game
    {
        public bool order { get; set; }
        public List<object> GameObjectList { get; set; }
        public List<object> ChessTableSquare { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Entity
{
    public class Piece
    {
        public List<object> DangerSquare { get; set; }
        public object MainSquare { get; set; }
        public string PieceType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Entity
{
    public class Piece : MonoBehaviour
    {
        public List<GameObject> DangerSquare { get; set; }
        public string MainSquareName { get; set; }
        public string PieceType { get; set; }
    }
}

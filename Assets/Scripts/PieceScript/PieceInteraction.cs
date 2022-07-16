using Assets.Scripts.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.PieceScript
{
    public class PieceInteraction : MonoBehaviour
    {

        private void OnMouseUp()
        {
            Debug.Log("Aybanabişileroluyo "+gameObject.name);
            Debug.Log("kare " + gameObject.GetComponentInParent<Square>().Name);

        }
    }
}

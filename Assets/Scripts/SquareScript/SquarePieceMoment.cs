using Assets.Scripts.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.SquareScript
{
    public class SquarePieceMoment : MonoBehaviour
    {
        private void OnMouseUp()
        {

            if (gameObject.GetComponent<SpriteRenderer>().color==Color.black)
            {
                var piecesList = GameObject.Find("CreateTable").GetComponent<CreateTable>().ChessPieces;

                var game = GameManager.Game;
                string pieceName = game.SelectPieceName;

                var pieces = piecesList.SingleOrDefault(a => a.name == pieceName);

                pieces.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y);
                pieces.transform.SetParent(gameObject.transform);

                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
    }
}

using Assets.Scripts.Entity;
using Assets.Scripts.Manager;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PawnMove : MonoBehaviour
{
    
    private void OnMouseUp()
    {
        var game = GameManager.Game;

        game.SelectPieceName = gameObject.name;
        //var squareList = CreateTable.SquareList;
        var squareList = GameObject.Find("CreateTable").GetComponent<CreateTable>().SquareList;


        var squareName = gameObject.GetComponentInParent<Square>().Name;
        var squareNameSplit = squareName.Split(',');

        int squareLine = int.Parse(squareNameSplit[1]);

        var nextSquare = squareList.SingleOrDefault(a => a.name == $"{squareNameSplit[0]},{squareLine+1}");
        nextSquare.GetComponent<SpriteRenderer>().color = Color.black;
    }
}

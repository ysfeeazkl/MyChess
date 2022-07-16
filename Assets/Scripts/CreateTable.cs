using Assets.Scripts.Entity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTable : MonoBehaviour
{
    public GameObject white, black;
    public Sprite[] chessPiece;
    public GameObject[] chessPieceObject;

    List<GameObject> chessPieces;




    public static Game Game;
    public static List<GameObject> SquareList;

    char[] letter = new char[] 
    {
        'A',
        'B',
        'C',
        'D',
        'E',
        'F',
        'G',
        'H',
    };


    bool control = false;
    void Start()
    {
        Game = new();
        SquareList = new List<GameObject>();
        chessPieces = new List<GameObject>();
        control = true;
    }

    
    void Update()
    {
        if (control)
        {
            create();
            
        }
    }


    void create()
    {
        foreach (var Piece in chessPieceObject)
        {
            GameObject newPiece;
            newPiece = Instantiate(Piece, new Vector3(0, 0, 0), Quaternion.identity);
            chessPieces.Add(newPiece);
        }


        for (int i = 1; i < 9; i++)
        {
            for (int j = 1; j < 9; j++)
            {
                if ((i+j) % 2 == 0)
                {
                    GameObject newSquare;
                    newSquare = Instantiate(black, new Vector3(j * 0.8f, i * 0.8f, 0), Quaternion.identity);
                    newSquare.name = $"{letter[j-1]}{i}";
                    newSquare.GetComponent<Square>().Name = newSquare.name;

                    //var sprite = newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;

                    if (i == 1)
                    {
                        //sprite = chessPiece[j - 1];
                        //newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[j - 1];
                        //chessPieces[j - 1].transform.SetParent(newSquare.transform, false);
                        chessPieces[j - 1].transform.Translate(new Vector3(newSquare.transform.position.x, newSquare.transform.position.y));
                        chessPieces[j -1].transform.SetParent(newSquare.transform);
                        //chessPieces[j - 1].GetComponent<Piece>().MainSquareName = newSquare.name;

                    }
                    else if(i == 2)
                    {
                        //newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[8];
                        //chessPieces[j + 7].transform.SetParent(newSquare.transform, false);

                        //sprite = chessPiece[8];
                        chessPieces[j + 7].transform.Translate(new Vector3(newSquare.transform.position.x, newSquare.transform.position.y));
                        chessPieces[j + 7].transform.SetParent(newSquare.transform);
                        //chessPieces[j + 7].GetComponent<Piece>().MainSquareName = newSquare.name;
                    }
                    else if (i == 8)
                    {
                        //newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[9];

                        //chessPieces[j + 15].transform.SetParent(newSquare.transform, false);

                        chessPieces[j + 15].transform.Translate(new Vector3(newSquare.transform.position.x, newSquare.transform.position.y));
                        chessPieces[j + 15].transform.SetParent(newSquare.transform);
                        //chessPieces[j + 15].GetComponent<Piece>().MainSquareName = newSquare.name;
                    }
                    else if (i == 7)
                    {
                        //newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[(j-1)+10];

                        chessPieces[j + 23].transform.Translate(new Vector3(newSquare.transform.position.x, newSquare.transform.position.y));
                        chessPieces[j + 23].transform.SetParent(newSquare.transform);

                        //chessPieces[j + 23].GetComponent<Piece>().MainSquareName = newSquare.name;
                    }
                    SquareList.Add(newSquare);
                }
                else
                {
                    GameObject newSquare;
                    newSquare = Instantiate(white, new Vector3(j * 0.8f, i * 0.8f, 0), Quaternion.identity);
                    newSquare.name = $"{letter[j-1]}{i}";
                    newSquare.GetComponent<Square>().Name = newSquare.name;

                    if (i == 1)
                    {
                        //sprite = chessPiece[j - 1];
                        //newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[j - 1];
                        //chessPieces[j - 1].transform.SetParent(newSquare.transform, false);
                        chessPieces[j - 1].transform.Translate(new Vector3(newSquare.transform.position.x, newSquare.transform.position.y));
                        chessPieces[j - 1].transform.SetParent(newSquare.transform);
                        //chessPieces[j - 1].GetComponent<Piece>().MainSquareName = newSquare.name;

                    }
                    else if (i == 2)
                    {
                        //newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[8];
                        //chessPieces[j + 7].transform.SetParent(newSquare.transform, false);

                        //sprite = chessPiece[8];
                        chessPieces[j + 7].transform.Translate(new Vector3(newSquare.transform.position.x, newSquare.transform.position.y));
                        chessPieces[j + 7].transform.SetParent(newSquare.transform);
                        //chessPieces[j + 7].GetComponent<Piece>().MainSquareName = newSquare.name;
                    }
                    else if (i == 8)
                    {
                        //newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[9];

                        //chessPieces[j + 15].transform.SetParent(newSquare.transform, false);

                        chessPieces[j + 15].transform.Translate(new Vector3(newSquare.transform.position.x, newSquare.transform.position.y));
                        chessPieces[j + 15].transform.SetParent(newSquare.transform);
                        //chessPieces[j + 15].GetComponent<Piece>().MainSquareName = newSquare.name;
                    }
                    else if (i == 7)
                    {
                        //newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[(j-1)+10];

                        chessPieces[j + 23].transform.Translate(new Vector3(newSquare.transform.position.x, newSquare.transform.position.y));
                        chessPieces[j + 23].transform.SetParent(newSquare.transform);

                        //chessPieces[j + 23].GetComponent<Piece>().MainSquareName = newSquare.name;
                    }

                    SquareList.Add(newSquare);
                }
                
            }
        }
        control = false;
        
    }

}





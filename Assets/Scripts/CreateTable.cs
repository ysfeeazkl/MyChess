using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTable : MonoBehaviour
{
    public GameObject white, black;

    public Sprite[] chessPiece;

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
        for (int i = 1; i < 9; i++)
        {
            for (int j = 1; j < 9; j++)
            {
                if ((i+j) % 2 == 0)
                {
                    GameObject newSquare;
                    newSquare = Instantiate(black, new Vector3(j * 0.8f, i * 0.8f, 0), Quaternion.identity);
                    newSquare.name = $"{letter[j-1]}{i}";

                    //var sprite = newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;

                    if (i == 1)
                    {
                        //sprite = chessPiece[j - 1];
                        newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[j - 1];
                    }
                    else if(i == 2)
                    {
                        newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[8];
                        //sprite = chessPiece[8];
                    }
                    else if (i == 7)
                    {
                        newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[9];

                    }
                    else if (i == 8)
                    {
                        newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[(j-1)+10];

                    }

                }
                else
                {
                    GameObject newSquare;
                    newSquare = Instantiate(white, new Vector3(j * 0.8f, i * 0.8f, 0), Quaternion.identity);
                    newSquare.name = $"{letter[j-1]}{i}";

                    if (i == 1)
                    {
                        //sprite = chessPiece[j - 1];
                        newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[j - 1];
                    }
                    else if (i == 2)
                    {
                        newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[8];
                        //sprite = chessPiece[8];
                    }
                    else if(i == 7)
                    {
                        newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[9];

                    }
                    else if(i==8)
                    {
                        newSquare.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = chessPiece[(j - 1) + 10];

                    }
                }
            }
        }
        control = false;
    }

}





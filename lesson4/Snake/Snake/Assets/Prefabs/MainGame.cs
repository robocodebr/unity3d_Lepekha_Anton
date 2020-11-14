using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MainGame : MonoBehaviour {
    GameObject SnakeObj;
    int gameMode = 0;
    int score = 0;
    public GameObject ApplePref;
    int time = 0;
    int time2 = 0;
    int maxTime = 150;
    public GameObject SnakeHead;
    List<GameObject> Apples = new List<GameObject>();
    void creatSnake()
    {
        SnakeObj = Instantiate(SnakeHead) as GameObject;
        SnakeObj.name = "Snake";
        gameMode = 1;

    }
    // Start is called before the first frame update
    void Start()
    {
        //   creatSnake();
    }

    // Update is called once per frame
    float xx = 0, yy = 0;
    void Update()
    {
        time++;
        time2++;

        if (gameMode ==1 && time >= maxTime)
        {
            GameObject apple = Instantiate(ApplePref) as GameObject;
            Apples.Add(apple);
            time = 0;
            //    Destroy(Apples[0]);
        }
        if (gameMode == 1 && time2 >= maxTime * 3) {
            GameObject apple = Apples[0];
            if(apple == null )
            {
                Apples.Remove(apple);
                apple = Apples[0];
            }
            Apples.Remove(apple); 
            Destroy(apple);
            time2 = 0;
        }



        if (SnakeObj != null)
        {
            xx = 0;
            yy = 0;
            if (Input.GetAxis("Horizontal") > 0)
            {
                xx = 1;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                xx = -1;
            }

            if (Input.GetAxis("Vertical") > 0)
            {
                yy = 1;
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                yy = -1;
            }

            if (xx != 0 || yy != 0)
            {
                Snekaife s = SnakeObj.GetComponent<Snekaife>();
                if (xx != 0) { s.direction = new Vector2(xx, 0); }
                if (yy != 0) { s.direction = new Vector2(0, yy); }
            }
        }
    }

    void OnGUI()
    {
        int posX = (Screen.width / 2);
        int posY = (Screen.height / 2) -50;
        switch (gameMode)
        {


            case 0:

                bool stateBtn1 = GUI.Button(new Rect(
                     new Vector2(posX - 100, posY),
                     new Vector2(200, 30)
                     ), "Cтарт игры");


                bool stateBtn2 = GUI.Button(new Rect(
                    new Vector2(posX - 100, posY + 50),
                    new Vector2(200, 30)
                    ), "выход");
                if (stateBtn1)
                {
                    creatSnake();
                }


                if (stateBtn2)
                {
                    Application.Quit();
                }
                break;

            case 1:

                Snekaife snakeL = SnakeHead.GetComponent<Snekaife>();
                if (snakeL != null)
                {
                    score = snakeL.snakeScore;
                    Rect rect = new Rect(
                        new Vector2(posX - 20, 0),
                        new Vector2(200, 30)
                        );
                    GUI.Label(rect, "Score:" + score);
                }
                break;


        }
    }
}

    

    
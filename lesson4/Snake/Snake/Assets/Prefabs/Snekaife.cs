
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Snekaife : MonoBehaviour
{
    int timebuff = 10;
    int time = 0;
    public GameObject SnakeBody;


    List<GameObject> SnakeTail = new List<GameObject>();

    public Vector2 direction = new Vector2(0, 0);

    public int snakeScore = 0;
    float speed = 3;


    public void addChank()
    {
        Vector3 position = transform.position;

        if (SnakeTail.Count > 0)
        {
            position = SnakeTail[SnakeTail.Count - 1].transform.position;
        }
        position.y += 0.5f;
        GameObject lastTailChank = Instantiate(SnakeBody, position, Quaternion.identity) as GameObject;
        SnakeTail.Add(lastTailChank);
    }

    void snakeStep()
    {
        if (direction.x != 0 || direction.y != 0)
        {
            Rigidbody componentRigid = GetComponent<Rigidbody>();
            componentRigid.velocity = new Vector3(direction.x * speed, direction.y * speed, 0);
            
            if (SnakeTail.Count > 0)
            {
                SnakeTail[0].transform.position = transform.position;


                for (int i = SnakeTail.Count - 1; i > 0; i--)
                {
                    SnakeTail[i].transform.position = SnakeTail[i - 1].transform.position;
               
                }
            }

        }
    }
    public void DestroySnake()
    {
        foreach (var tall in SnakeTail) ;
        {
            direction = new Vector2(0, 0);
            foreach(var tall in SnakeTail)
            {
                Destroy(tall);
            }
            Destroy(gameObject);
        }

    }
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            addChank();
        }
    }


    void Update()
    {
        timebuff++;
        if (timebuff >= time)
        {
            snakeStep();
            timebuff = 0;
        }

    }
}
                            


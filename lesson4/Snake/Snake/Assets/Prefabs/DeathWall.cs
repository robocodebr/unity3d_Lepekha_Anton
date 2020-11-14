using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Snekaife s = collision.gameObject.GetComponent<Snekaife>();
        if (s != null)
        {
            s.DestroySnake();
            // Destroy(Collision.gameObject
            //    )
            //        }
        }
    } 
}

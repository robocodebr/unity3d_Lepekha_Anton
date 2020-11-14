using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AppleLife : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-5, 5f);
        float y = Random.Range(-4.5f, 4.5f);
        transform.position = new Vector3(x, y, 0);
        // creatApple();   
    }

    //  public GameObject ApplePref;
    //GameObject AppleObj;
    // void creatApple()



    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter(Collision collision)
    {
        Snekaife s = collision.gameObject.GetComponent<Snekaife>();
        if (s != null)
        {
            s.addChank();
            s.snakeScore++;
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissTriggerScript : MonoBehaviour
{

    public GameObject heart1, heart2, heart3;
    public static int hearts;
    
    // Start is called before the first frame update
    void Start()
    {
        hearts = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Miss Detected");
        hearts -= 1;
        if(hearts == 2)
        {
            heart1.gameObject.SetActive(false);
        }
        if(hearts == 1)
        {
            heart2.gameObject.SetActive(false);
        }
        if(hearts == 0)
        {
            heart3.gameObject.SetActive(false);
        }
    }
}

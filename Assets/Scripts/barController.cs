using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class barController : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    //Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            touchPosition.y = -4.2f;
            transform.position = touchPosition;
        }



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit detected");
        Destroy(other.gameObject);
        AddScore();

    }

    void AddScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }



}

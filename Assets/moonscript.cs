using UnityEngine;
using System.Collections;

public class moonscript : MonoBehaviour
{
    public float CHspeed = 3f;
    public int score = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, CHspeed * Time.deltaTime, 0));
        }
        else
        { transform.Translate(new Vector3(0, -CHspeed * Time.deltaTime, 0)); }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "UpWall" || col.tag == "DownWall")
        Debug.Log("collision");

    }

    void OnTriggerExit2D(Collider2D col1)
    {
        if(col1.tag == "TwoWall")
            {
                score++;
                Debug.Log("Score : " + score);
            };
    }

}

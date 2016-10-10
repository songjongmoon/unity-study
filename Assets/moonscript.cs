using UnityEngine;
using System.Collections;

public class moonscript : MonoBehaviour {
    public float CHspeed = -3f;
    public int score2 = 0;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, CHspeed*Time.deltaTime, 0));
        }
        else
        { transform.Translate(new Vector3(0, -CHspeed * Time.deltaTime, 0)); }

	}

    void OnCollisionEnter(Collision col)
    {
        score2--;
        Debug.Log("Score2 : " + score2);
        if (col.gameObject.tag == "moon")
        {
            score2--;
            Debug.Log("Score2 : " + score2);
        }
       
    }

}

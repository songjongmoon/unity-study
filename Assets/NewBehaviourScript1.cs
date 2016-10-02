using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour
{


    float random = Random.Range(-3f, 3f);

    IEnumerator CoFunction()
    {


        yield return new WaitForSeconds(2);
        Instantiate(gameObject);
        transform.Translate(new Vector3(0, random, 0));



    }



    // Use this for initialization
    void Start()
    {
        StartCoroutine(this.CoFunction());
    }
   

    // Update is called once per frame
    void Update()
    {

        
    }
}

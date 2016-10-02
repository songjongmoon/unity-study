using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour
{

 

    IEnumerator CoFunction()
    {
        
        
        yield return new WaitForSeconds(2);
        Instantiate(gameObject);
        



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

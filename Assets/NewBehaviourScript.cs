using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    IEnumerator CoFunction()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(this.CoFunction());
	
	}
}

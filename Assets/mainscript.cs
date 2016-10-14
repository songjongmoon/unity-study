using UnityEngine;
using System.Collections;

public class mainscript : MonoBehaviour
{
    
    public GameObject WallPrefab;
     
    public float DestroyTime = 20f; 
    public float YIntervalRange = 2f;

   
 
    public Transform UpWall; 
    public Transform DownWall;

 

    void Start()
     { 
         float yinterval = Random.Range(YIntervalRange, 2 * YIntervalRange); 
         UpWall.localPosition = new Vector3(0, yinterval, 0); 
         DownWall.localPosition = new Vector3(0, -yinterval, 0);

        StartCoroutine(DestroyRoutine());
    } 
 	 
 	void Update()
     { 
         transform.Translate(Vector3.left* Time.deltaTime * prefab.Instance.Speed); 
 	 } 
 
 
     IEnumerator DestroyRoutine()
     { 
         yield return new WaitForSeconds(DestroyTime);
         Destroy(gameObject);
     }
}

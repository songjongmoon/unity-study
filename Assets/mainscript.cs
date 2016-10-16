using UnityEngine;
using System.Collections;

public class mainscript : MonoBehaviour
{
    
    public GameObject WallPrefab;
     
    public float DestroyTime = 20f; 
    public float YIntervalRange = 2f;
    public float speed = 1.5f;
   
 
    public Transform UpWall; 
    public Transform DownWall;

 

    void Start()
     { 
         float yinterval = Random.Range(YIntervalRange, 2 * YIntervalRange);
        transform.localPosition = new Vector3(7, YIntervalRange, 0);
      //  UpWall.localPosition = new Vector3(5, yinterval, 0); 
        // DownWall.localPosition = new Vector3(5, -yinterval, 0);
        
    } 
 	 
 	void Update()
     {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        int i = 0;
      
            if (transform.localPosition.x < -7.0f)
            {
                transform.localPosition = new Vector3(10, YIntervalRange, 0);
                speed += 1.5f;
                i++;
            if(speed>6)
            {
                Destroy(gameObject);
            }

            }
 	 } 
}

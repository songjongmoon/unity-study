using UnityEngine;
using System.Collections;

public class prefab : MonoBehaviour

{
    public static prefab Instance;
    public GameObject WallPrefab; 

    public float SpawnInterval = 5f; 
    public float YRange = 5f;
    public float Speed = 1f;


    void Awake()
    {
        Instance = this;
    }
    void Start()
     { 
         StartCoroutine(SpawnRoutine()); 
     } 
 
 
     IEnumerator SpawnRoutine()
     { 
         while (true) 
         { 
            var ypos = Random.Range(-YRange, YRange); 
            Instantiate(WallPrefab, new Vector3(10, ypos, 0), Quaternion.identity);
            yield return new WaitForSeconds(SpawnInterval);
            Speed += 0.3f;
         } 
     } 
 } 


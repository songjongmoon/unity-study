using UnityEngine;
using System.Collections;

public class prefab : MonoBehaviour

{ 
    public GameObject WallPrefab; 
    public float SpawnInterval = 5f; 
    public float YRange = 5f;
    public int score = 0; 
 
 
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
            score++;
            Debug.Log("Score : " + score);


        } 
     } 
 } 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilecontroller: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] tileprefabs;
    public float zspwan = 0 ;
    public float tilelength=30;
    public int numberoftiles;
    public Transform playertransform;
    private List<GameObject> activetiles = new List<GameObject>();
    void Start()
    {
        for (int i = 0; i < numberoftiles; i++) 
        {
            if (i == 0)
            {
                SpawnTile(0);
            }
            else
            {
                SpawnTile(Random.Range(0, tileprefabs.Length));
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (playertransform.position.z-35 > zspwan - numberoftiles * tilelength) 
        {
            SpawnTile(Random.Range(0, tileprefabs.Length));
            Deletetile();

        }
        
    }
    public void SpawnTile(int tileindex) 
    {
       GameObject go = Instantiate(tileprefabs[tileindex], transform.forward * zspwan , transform.rotation);
        activetiles.Add(go);
        zspwan += tilelength;
    }
    public void Deletetile() 
    {
        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);


    }
}

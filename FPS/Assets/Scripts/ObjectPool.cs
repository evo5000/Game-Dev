using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject objPrefab;
    public int createOnStart;
    private List<GameObject> pooledObjs = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x < createOnStart; x++)
        {
            CreateNewObject();
        }
    }
// creates new obj then deactivates it
    GameObject CreateNewObject()
    {
        GameObject obj = Instantiate(objPrefab);
        obj.SetActive(false);
        pooledObjs.Add(obj);

        return obj;
    }

    public GameObject GetObject()
    {
        // find highest in the hierarchy
        GameObject obj = pooledObjs.Find(x => x.activeInHierarchy == false);

        if(obj == null)
        {
            // creates a new object if theres not any objects
            obj = CreateNewObject();
        }

        obj.SetActive(true);

        return obj;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

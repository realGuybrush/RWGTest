using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadList : MonoBehaviour
{
    [SerializeField]
    List<GameObject> dontdestroy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < dontdestroy.Count; i++)
        {
            DontDestroyOnLoad(dontdestroy[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

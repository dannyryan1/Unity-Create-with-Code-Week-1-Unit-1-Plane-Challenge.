using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowNPC : MonoBehaviour
{
    public GameObject nonplayercharacter;
    private Vector3 offset = new Vector3(0, 5, 20); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = nonplayercharacter.transform.position + offset;
    }
}

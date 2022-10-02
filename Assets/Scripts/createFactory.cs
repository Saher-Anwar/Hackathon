using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createFactory : MonoBehaviour
{
    public GameObject LNGfactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createNewFactory(){
        Instantiate(LNGfactory, transform.position, transform.rotation);
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown("space"))
        {
            print("Constructing LNG factory");
            createNewFactory();
        }
    }
}


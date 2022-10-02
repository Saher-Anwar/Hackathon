using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public string CountryName;
    public GameObject factory;
    public List<GameObject> factories;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Click detected");
    }

    public void createNewFactory()
    {
        Instantiate(factory, Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.rotation);
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

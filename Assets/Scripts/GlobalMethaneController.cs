using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMethaneController : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public float MethaneLevel = 0;
    
    public void addEmissions(float emission)
    {
        MethaneLevel += emission;
    }

    public void reduceEmissions(float emission)
    {
        MethaneLevel -= emission;
    }

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = $"Global CH4: {MethaneLevel}%";   
    }


}

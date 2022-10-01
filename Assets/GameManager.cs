using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float targetYear = 2024;
    public float targetMethaneLevel = 50;
    public GlobalMethaneController globalMethanecontroller;
    public YearIncrementor YearIncrementor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(globalMethanecontroller.MethaneLevel >= targetMethaneLevel)
        {
            // you've won or something
        }

        if(targetYear >= YearIncrementor.Year)
        {
            // end game
        }
    }
}

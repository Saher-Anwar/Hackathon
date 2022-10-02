using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float targetYear = 2024;
    public float targetMethaneLevel = 50;
    public GlobalMethaneController globalMethanecontroller;
    public YearIncrementor YearIncrementor;
    public BudgetController BudgetController;
    public Ticker newsPanel;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
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

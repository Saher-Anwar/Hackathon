using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class YearIncrementor : MonoBehaviour
{
    public int Year = 2022;
    public int Quarter = 0;
    public TextMeshProUGUI tmp;
    public float timeLimitPerQuarterInSeconds = 3;

    private float timeElapsedInSeconds = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsedInSeconds += Time.deltaTime;

        if(timeElapsedInSeconds > timeLimitPerQuarterInSeconds)
        {
            Quarter++;

            if(Quarter > 4)
            {
                Quarter = 0;
                Year++;
            }

            timeElapsedInSeconds = 0;
        }

        tmp.text = $"Year {Year}\nQuarter {Quarter}";
        
    }
}

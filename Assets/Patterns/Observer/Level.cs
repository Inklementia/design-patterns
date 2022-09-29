using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] int expiriencePointsPerLevel = 200;
    [SerializeField] UnityEvent onLevelUp;

    int expiriencePoints = 0;

    private void Start()
    {
        StartCoroutine(StartLevel());
    }

   private IEnumerator StartLevel()
    {
        while (true)
        {
            yield return new WaitForSeconds(.2f);
            GainExpirience(10);
        }
    }

    private void GainExpirience(int points)
    {
        int level = GetLevel();

        expiriencePoints += points;

        if (GetLevel() > level)
        {
            onLevelUp.Invoke();
            //GetComponent<Health>().ResetMaxHealth();   // why Level comp should know about Health?
        }


    }

    public int GetExpirience()
    {
        return expiriencePoints;
    }

    public int GetLevel()
    {
        return expiriencePoints / expiriencePointsPerLevel;
    }
}

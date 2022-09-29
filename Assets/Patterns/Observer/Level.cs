using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] int experiencePointsPerLevel = 200;
    [SerializeField] UnityEvent onLevelUp;

    // public delegate void CallbackType();

    // public event CallbackType onLevelUpAction;

    public event Action onLevelUpAction;

    int experiencePoints = 0;

    private void Start()
    {
        StartCoroutine(StartLevel());

    }

    private IEnumerator StartLevel()
    {
        while (true)
        {
            yield return new WaitForSeconds(.2f);
            GainExperience(10);
        }
    }

    private void GainExperience(int points)
    {
        int level = GetLevel();

        experiencePoints += points;

        if (GetLevel() > level)
        {
            onLevelUp.Invoke();

            if (onLevelUpAction != null)
            {
                onLevelUpAction();
            }

            //GetComponent<Health>().ResetMaxHealth();   // why Level comp should know about Health?
        }


    }

    public int GetExpirience()
    {
        return experiencePoints;
    }

    public int GetLevel()
    {
        return experiencePoints / experiencePointsPerLevel;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    [SerializeField] private Level level;
    [SerializeField] private Health health;

    private void Start()
    {
        StartCoroutine(ShowStats());
    }

    private IEnumerator ShowStats()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Debug.Log($"Exp: {level.GetExpirience()}, Level: {level.GetLevel()}, Health: {health.GetHealth()}");
           
        }
       

    }
}

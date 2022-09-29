using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float maxHealth = 100f;
    [SerializeField] float drainPerSecond = 2f; // speed

    private float _currentHealth = 0f;
    // private int lastLevel = 0;

    private void Awake()
    {
        ResetMaxHealth();
        StartCoroutine(HealthDrain());
    }

    private void OnEnable()
    {
        GetComponent<Level>().onLevelUpAction += ResetMaxHealth;
    }

    // private void Start()
    // {
    //     //lastLevel = GetComponent<Level>().GetLevel();
    // }

    private void OnDisable()
    {
        GetComponent<Level>().onLevelUpAction -= ResetMaxHealth;
    }

    //private void Update()
    //{
    //    int currentLevel = GetComponent<Level>().GetLevel();
    //    if(lastLevel > currentLevel)
    //    {
    //        lastLevel = currentLevel;
    //        ResetMaxHealth();
    //    }

    //}
    // not efficient

    public float GetHealth()
    {
        return _currentHealth;
    }

    public void ResetMaxHealth()
    {
        _currentHealth = maxHealth;
    }

    private IEnumerator HealthDrain()
    {
        while (_currentHealth > 0)
        {
            _currentHealth -= drainPerSecond;
            yield return new WaitForSeconds(1);
        }
    }
}

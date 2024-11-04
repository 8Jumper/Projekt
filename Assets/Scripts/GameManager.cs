using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [NonSerialized]
    public int resourcesCollected = 0;
    private int totalResources = 4;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void CollectResource()
    {
        resourcesCollected++;
        if (resourcesCollected >= totalResources)
        {
            EndGame(true);
        }
    }

    public void EndGame(bool victory)
    {
        if (victory)
        {
            Debug.Log("Gratulacje! Zdoby³eœ wszystkie zasobniki!");
        }
        else
        {
            Debug.Log("Koniec gry! Spad³eœ z platformy.");
            Time.timeScale = 0;
        }
    }
}

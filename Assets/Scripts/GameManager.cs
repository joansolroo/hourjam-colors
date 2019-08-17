using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public Color[] colors;
    [SerializeField] public int[] layers;

    [SerializeField] GameObject level;
    [SerializeField] GameObject winScreen;
    GameObject levelClone;

    public static GameManager instance;
    void Awake()
    {
        instance = this;

        level.SetActive(false);
        Restart();
    }

    bool won = false;
    void Restart()
    {
        winScreen.SetActive(false);
        if (levelClone != null)
        {
            GameObject.Destroy(levelClone);
        }
        levelClone = Instantiate<GameObject>(level);
        levelClone.SetActive(true);
    }
    
    private void Update()
    {
        if ((won && Input.anyKeyDown) || Input.GetKeyDown(KeyCode.R))
        {
            won = false;
            Restart();
        }
    }

    public void OnWin()
    {
        won = true;
        winScreen.SetActive(true);
    }
}

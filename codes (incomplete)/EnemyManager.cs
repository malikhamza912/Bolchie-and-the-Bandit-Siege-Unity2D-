using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public int smallbanditTotal = 2;
    public int largebanditTotal = 1;

    public GameObject YouWinUI;

    public int smallbanditKilled;
    public int largebanditKilled;

    // Start is called before the first frame update
    void Start()
    {
        smallbanditKilled = 0;
        largebanditKilled = 0;
        YouWinUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        CheckMissionStatus();
    }

    public void CheckMissionStatus()
    {
        if(smallbanditKilled >= smallbanditTotal && largebanditKilled >= largebanditTotal)
        {
            MissionPassed();
        }
    }

    public void MissionPassed()
    {
        YouWinUI.SetActive(true);
    }
    public void SmallBanditCheck()
    {
        smallbanditKilled++;
        CheckMissionStatus();
    }

    public void LargeBanditCheck()
    {
        largebanditKilled++;
        CheckMissionStatus();
    }
}

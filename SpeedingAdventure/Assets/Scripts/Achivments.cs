using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Achivments : MonoBehaviour
{
    public GameObject forestTime;
    public GameObject forestScore;
    public GameObject forestRace;

    public GameObject cityTime;
    public GameObject cityScore;
    public GameObject cityRace;


    public int forestTimeValue;
    public int forestScoreValue;
    public int forestRaceValue;

    public int cityTimeValue;
    public int cityScoreValue;
    public int cityRaceValue;

    void Start()
    {
        GetValue();
        SetActiveInactive();
    }
    
    void Update()
    {
        GetValue();
        SetActiveInactive();
    }



    private void ResetAchivments()
    {
        SetFalseValue();
        SetActiveInactive();
    }

    private void GetValue()
    {
        forestTimeValue = PlayerPrefs.GetInt("forestTimeAchivment");
        forestScoreValue = PlayerPrefs.GetInt("forestScoreAchivment");
        forestRaceValue = PlayerPrefs.GetInt("forestRaceAchivment");

        cityTimeValue = PlayerPrefs.GetInt("cityTimeAchivment");
        cityScoreValue = PlayerPrefs.GetInt("cityScoreAchivment");
        cityRaceValue = PlayerPrefs.GetInt("cityRaceAchivment");
    }

    private void SetFalseValue()
    {
        PlayerPrefs.SetInt("forestTimeAchivment", 0);
        PlayerPrefs.SetInt("forestScoreAchivment", 0);
        PlayerPrefs.SetInt("forestRaceAchivment", 0);

        PlayerPrefs.SetInt("cityTimeAchivment", 0);
        PlayerPrefs.SetInt("cityScoreAchivment", 0);
        PlayerPrefs.SetInt("cityRaceAchivment", 0);
    }

    private void SetActiveInactive()
    {
        if (forestTimeValue == 1)
        {
            forestTime.SetActive(true);
        }
        else
        {
            forestTime.SetActive(false);
        }

        if (forestScoreValue == 1)
        {
            forestScore.SetActive(true);
        }
        else
        {
            forestScore.SetActive(false);
        }

        if (forestRaceValue == 1)
        {
            forestRace.SetActive(true);
        }
        else
        {
            forestRace.SetActive(false);
        }

        if (cityTimeValue == 1)
        {
            cityTime.SetActive(true);
        }
        else
        {
            cityTime.SetActive(false);
        }

        if (cityScoreValue == 1)
        {
            cityScore.SetActive(true);
        }
        else
        {
            cityScore.SetActive(false);
        }

        if (cityRaceValue == 1)
        {
            cityRace.SetActive(true);
        }
        else
        {
            cityRace.SetActive(false);
        }
    }

    private void Reload()
    {
        SceneManager.LoadScene(9);
    }






    public void SetOne()
    {
        PlayerPrefs.SetInt("forestTimeAchivment", 1);
        PlayerPrefs.SetInt("forestScoreAchivment", 0);
        PlayerPrefs.SetInt("forestRaceAchivment", 1);

        PlayerPrefs.SetInt("cityTimeAchivment", 0);
        PlayerPrefs.SetInt("cityScoreAchivment", 1);
        PlayerPrefs.SetInt("cityRaceAchivment", 0);
    }
}

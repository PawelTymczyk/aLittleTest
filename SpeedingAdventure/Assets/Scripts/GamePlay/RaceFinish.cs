using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class RaceFinish : MonoBehaviour
{
    public GameObject AICar;
    public GameObject LevelMusic;
    public GameObject CompleteTrigger;
    public AudioSource FinishMusic;
    public GameObject CoutingTime;

    public GameObject FinishScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FinishScreen.SetActive(false);
            SceneManager.LoadScene(1);
        }
    }

    void OnTriggerEnter()
    {
        CompleteTrigger.SetActive(false);
        LevelMusic.SetActive(false);
        FinishMusic.Play();
        FinishScreen.SetActive(true);

        if (ModeSelect.RaceType == 1)
        {
            CoutingTime.SetActive(false);
        }
    }
}

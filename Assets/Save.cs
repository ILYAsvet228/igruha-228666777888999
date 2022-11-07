using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    [SerializeField]
    GameObject Couner;

    private void Awake()
    {
        LoadGame();
    }

    private void OnApplicationQuit()
    {
        SaveGame();

    }

    void SaveGame()
    {
        PlayerPrefs.SetInt("SaverInteger", Couner.GetComponent Click.count);
        PlayerPrefs.Save();
        Debug.Log("Game data saved!");
    }

    void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedInteger"))
        {
            Couner.GetComponent <Click>().count = PlayerPrefs.GetInt("SavedInteger");
            Debug.Log("Game data loaded!");
        }
        else
            Debug.LogError("There is no save data!");
    }
}
    
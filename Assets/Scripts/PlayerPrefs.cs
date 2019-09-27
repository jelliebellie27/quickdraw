using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void SetLanguagePreference(string language)
    {
        PlayerPrefs.SetSTring("language", language);
    }

    // Update is called once per frame
    void SetDifficultyPreference(string difficulty)
    {
        PlayerPrefs.SetSTring("difficulty", difficulty);
    }
}

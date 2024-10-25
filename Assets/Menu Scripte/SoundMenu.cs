using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundMenu : MonoBehaviour
{

    public AudioSource audioSource; // Associe ton AudioSource ici
    public Slider volumeSlider; // Associe ton Slider ici
    public GameObject optionMenu;
    public GameObject mainMenu;

    private void Start()
    {
        // Charge le volume sauvegardé
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f); // 1f est la valeur par défaut
        audioSource.volume = volumeSlider.value;

        // Ajoute un listener pour le slider
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume); // Sauvegarde le volume
        PlayerPrefs.Save();
    }



    public void Retour()
    {
        optionMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}

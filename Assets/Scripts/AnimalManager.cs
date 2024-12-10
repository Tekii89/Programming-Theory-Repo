using UnityEngine;
using TMPro;

public class AnimalManager : MonoBehaviour
{
    public static AnimalManager Instance { get; private set; } // ENCAPSULATION

    public TextMeshProUGUI DisplayTextTMP; // R�f�rence au texte � afficher

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void DisplayAnimalSound(string sound) // ABSTRACTION
    {
        DisplayTextTMP.text = sound;
    }
}

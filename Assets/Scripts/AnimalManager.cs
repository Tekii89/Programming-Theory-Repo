using UnityEngine;
using TMPro;

public class AnimalManager : MonoBehaviour
{
    public static AnimalManager Instance { get; private set; } // ENCAPSULATION

    public TextMeshProUGUI DisplayTextTMP; // Référence au texte à afficher

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

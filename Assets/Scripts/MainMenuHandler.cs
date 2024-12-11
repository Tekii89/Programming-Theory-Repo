using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void StartGame()
    {
        // Charge la scène principale
        SceneManager.LoadScene("GameScene"); // Remplacez "GameScene" par le nom de votre scène de jeu
    }

    public void QuitGame()
    {
        // Quitte l'application
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode(); // Quitte le mode Play dans l'éditeur
#else
        Application.Quit(); // Ferme l'application dans une build
#endif
    }
}

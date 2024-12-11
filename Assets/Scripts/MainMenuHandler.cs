using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void StartGame()
    {
        // Charge la sc�ne principale
        SceneManager.LoadScene("GameScene"); // Remplacez "GameScene" par le nom de votre sc�ne de jeu
    }

    public void QuitGame()
    {
        // Quitte l'application
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode(); // Quitte le mode Play dans l'�diteur
#else
        Application.Quit(); // Ferme l'application dans une build
#endif
    }
}

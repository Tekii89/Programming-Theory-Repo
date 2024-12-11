using UnityEngine;

public class Cat : Animal
{
    public override void MakeSound() // POLYMORPHISME
    {
        AnimalManager.Instance.DisplayAnimalSound("Miaou!"); // Affiche "Miaou!"
    }

    private void OnMouseDown()
    {
        MakeSound(); // Joue le son lorsque l'objet est cliqué
        Destroy(gameObject); // Détruit l'objet après clic
    }

    private void Start()
    {
        Destroy(gameObject, 3f); // Détruit l'objet automatiquement après 5 secondes
    }
}

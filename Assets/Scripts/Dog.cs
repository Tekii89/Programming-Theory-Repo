using UnityEngine;

public class Dog : Animal
{
    public override void MakeSound() // POLYMORPHISME
    {
        AnimalManager.Instance.DisplayAnimalSound("Wouf!"); // Affiche "Wouf!"
    }

    private void OnMouseDown()
    {
        MakeSound(); // Joue le son lorsque l'objet est cliqu�
        Destroy(gameObject); // D�truit l'objet apr�s clic
    }

    private void Start()
    {
        Destroy(gameObject, 3f); // D�truit l'objet automatiquement apr�s 5 secondes
    }
}

using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject DogPrefab; // Préfabriqué du chien
    public GameObject CatPrefab; // Préfabriqué du chat
    public float SpawnInterval = 1f; // Intervalle entre les apparitions

    private float spawnRangeX = 49f; // Limites horizontales
    private float spawnRangeZ = 14f; // Limites verticales

    private void Start()
    {
        InvokeRepeating("SpawnAnimal", 0f, SpawnInterval);
    }

    private void SpawnAnimal()
    {
        // Choisit aléatoirement Dog ou Cat
        GameObject animalPrefab = Random.value > 0.5f ? DogPrefab : CatPrefab;

        // Position aléatoire sur le terrain
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX),
            0.5f,
            Random.Range(-spawnRangeZ, spawnRangeZ)
        );

        Instantiate(animalPrefab, spawnPosition, Quaternion.identity);
    }
}

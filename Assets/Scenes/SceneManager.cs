using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject terrainPrefab;   // Assign a terrain model in the Inspector
    public GameObject buildingPrefab;  // Assign a building model in the Inspector
    public GameObject propPrefab;      // Assign a prop model in the Inspector

    void Start()
    {
        // Instantiate and place terrain
        GameObject terrain = Instantiate(terrainPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        terrain.transform.localScale = new Vector3(10, 1, 10);

        // Instantiate and place building
        GameObject building = Instantiate(buildingPrefab, new Vector3(5, 0, 5), Quaternion.identity);
        building.transform.localScale = new Vector3(1, 1, 1);

        // Instantiate and place prop
        GameObject prop = Instantiate(propPrefab, new Vector3(2, 0, 3), Quaternion.identity);
        prop.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}

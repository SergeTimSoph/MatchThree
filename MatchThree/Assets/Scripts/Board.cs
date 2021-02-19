using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private GameObject tilePrefab;
    [SerializeField]
    private int width;
    [SerializeField]
    private int height;

    private Tile[,] allTiles;

    private void Awake()
    {
        allTiles = new Tile[width,height];
    }

    private void Start()
    {
        SetupTiles();
    }

    private void SetupTiles()
    {
        for (var i = 0; i < width; i++)
        {
            for (var j = 0; j < height; j++)
            {
                var tile = Instantiate(tilePrefab, new Vector3(i, j, 0), Quaternion.identity);
                tile.name = $"Tile {i}, {j}";

                allTiles[i, j] = tile.GetComponent<Tile>();
                tile.transform.parent = transform;
            }
        }
    }
}

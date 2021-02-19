using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private GameObject tilePrefab;
    [SerializeField]
    private int width;
    [SerializeField]
    private int height;
    [SerializeField]
    private int borderSize;

    [SerializeField]
    private Camera camera;

    private Tile[,] allTiles;

    private void Awake()
    {
        allTiles = new Tile[width,height];
    }

    private void Start()
    {
        SetupTiles();
        SetupCamera();
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

    private void SetupCamera()
    {
        camera.transform.position = new Vector3((float) (width - 1)/2f, (float) (height - 1)/2, -10f);

        var aspectRatio = (float) Screen.width / (float) Screen.height;
        var verticalSize = (float) height / 2f + (float) borderSize;
        var horizontalSize = ((float) width / 2f + (float) borderSize) / aspectRatio;
        camera.orthographicSize = (verticalSize > horizontalSize) ? verticalSize : horizontalSize;
    }
}

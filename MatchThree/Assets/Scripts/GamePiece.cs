using UnityEngine;

public class GamePiece : MonoBehaviour
{
    [SerializeField]
    private int xIndex;
    [SerializeField]
    private int yIndex;

    public void SetCoord(int xIndex, int yIndex)
    {
        this.xIndex = xIndex;
        this.yIndex = yIndex;
    }
}

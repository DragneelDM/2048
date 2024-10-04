using UnityEngine;

public class TileGrid : MonoBehaviour
{
    public TileRow[] Rows {  get; private set; }
    public TileCell[] Cells { get; private set; }

    public int Size => Cells.Length;
    public int Height => Rows.Length;
    public int Width => Size / Height;

    private void Awake()
    {
        Rows = GetComponentsInChildren<TileRow>();
        Cells = GetComponentsInChildren<TileCell>();
    }

    private void Start()
    {
        for (int row = 0; row < Rows.Length; row++)
        {
            for (int column = 0; column < Rows[row].Cells.Length; column++)
            {
                Rows[row].Cells[column].Coordinates = new Vector2Int(column, row);
            }
        }
    }
}

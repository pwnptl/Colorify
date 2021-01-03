using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BaseTilemap : MonoBehaviour
{
    // Start is called before the first frame update
    public Tilemap tilemap;

    void Awake() { 

    }
    void Start()
    {
        Debug.Log(
                "Start Class : " + this.GetType().Name + 
                "Start Method : " + System.Reflection.MethodBase.GetCurrentMethod().Name);
        Debug.Log("tilemap is empty ? : " + (tilemap == null) );
        // tilemap = ???;
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// Set the colour of a tile.
    /// </summary>
    /// <param name="colour">The desired colour.</param>
    /// <param name="position">The position of the tile.</param>
    /// <param name="tilemap">The tilemap the tile belongs to.</param>
    private void SetTileColour(Color colour, Vector3Int position, Tilemap tilemap)
    {
        // Flag the tile, inidicating that it can change colour.
        // By default it's set to "Lock Colour".
        tilemap.SetTileFlags(position, TileFlags.None);

        // Set the colour.
        tilemap.SetColor(position, colour);
    }
}

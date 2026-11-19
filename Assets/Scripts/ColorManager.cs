using UnityEngine;
using Unity.Netcode;

public enum TileColor
{
    RebeccaPurple, HotPink, NavajoWhite, Peru, Grey4
}

public class ColorManager : NetworkBehaviour
{
    //Variable sincronizada con el color seguro de cada ronda
    public NetworkVariable<TileColor> safecolor = new NetworkVariable<TileColor>();

    private void Start()
    {

    }

    private void Update()
    {
        //solo funciona si el jugador es el host / server
        if (IsServer == false) return;

        if (Input.GetKeyDown(KeyCode.C))
        {
            safecolor.Value = RandomColor();
        }
    }
      


   public TileColor RandomColor()
    {
        return (TileColor)Random.Range(0,5);
    }
}
 
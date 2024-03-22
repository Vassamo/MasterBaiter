using UnityEngine;

public class InventoryOpener : MonoBehaviour
{
    public GameObject inventoryUI; // Referencja do interfejsu u�ytkownika ekwipunku

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Sprawd�, czy klawisz "E" zosta� naci�ni�ty
        {
            ToggleInventory(); // Wywo�aj funkcj� do otwierania/ zamykania ekwipunku
        }
    }

    void ToggleInventory()
    {
        // Je�li ekwipunek jest aktywny, wy��cz go; w przeciwnym razie w��cz
        inventoryUI.SetActive(!inventoryUI.activeSelf);
    }
}

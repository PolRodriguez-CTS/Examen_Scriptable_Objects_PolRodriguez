using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public ScriptableArmas[] armasArray;
    public Text[] armasNombresArray;
    public Text[] armasPreciosArray;
    public Image[] armasSpritesArray;

    public void AddArma(ScriptableArmas arma)
    {
        for(int i = 0; i < armasArray.Length; i++)
        {
            if(armasArray[i] == null)
            {
                armasArray[i] = arma;
                armasNombresArray[i].text = arma.nombreArma;
                armasPreciosArray[i].text = arma.precioArma;

                armasSpritesArray[i].sprite = arma.spriteArma;

                return;
            }
        }
    }
}

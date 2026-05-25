using UnityEngine;

public class InteractableArma : MonoBehaviour
{
    public ScriptableArmas arma;
    public SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Start()
    {
        //Cuidao esto
        spriteRenderer.sprite = arma.spriteArma;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.Instance.AddArma(arma);

        Destroy(gameObject);
    }
}

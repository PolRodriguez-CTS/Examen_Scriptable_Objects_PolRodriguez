using UnityEngine;

public class InteractableArmadura : MonoBehaviour
{
    public ScriptableArmaduras armadura;
    public SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        spriteRenderer.sprite = armadura.spriteArmadura;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.Instance.AddArmadura(armadura);

        Destroy(gameObject);
    }
}

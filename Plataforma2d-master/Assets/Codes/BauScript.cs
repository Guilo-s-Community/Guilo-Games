using TreeEditor;
using UnityEngine;

public class BauScript : MonoBehaviour, IInteragivel
{
    public bool IsOpened {get; private set; }
    public string BauID {get;private set; }

    public GameObject itemPrefab;
    public Sprite openedSprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BauID ??= GlobalHelper.GerarIDUnico(gameObject);
    }
    
    public bool CanInteract()
    {
        return !IsOpened;
    }

    public void Interact()
    {
        if (!CanInteract()) return;
        OpenChest();

    }
    private void OpenChest()
    {
        SetOpened(true);
        if(itemPrefab)
        {
            GameObject droppedItem = Instantiate(itemPrefab, transform.position + Vector3.down, Quaternion.identity);
        }
    }

    public void SetOpened(bool opened)
    {
        IsOpened = opened;
        if(IsOpened)
        {
            GetComponent<SpriteRenderer>().sprite = openedSprite;
        }
    }
}

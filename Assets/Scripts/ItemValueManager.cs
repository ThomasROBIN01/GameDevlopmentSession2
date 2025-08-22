using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ItemValueManager : MonoBehaviour
{
    public static ItemValueManager Instance;

    public List<string> animations = new List<string>();

    public List<string> Models = new List<string>();

    // public Dictionary<string, Sprite> sprites = new Dictionary<string, Sprite>();

    public List<Sprite> sprites = new List<Sprite>();


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("There can only be one object with the ItemValueManager attached to it");
            gameObject.SetActive(false);
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

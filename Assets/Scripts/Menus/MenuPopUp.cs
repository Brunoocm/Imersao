using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MenuPopUp : MonoBehaviour
{

    [SerializeField] private GameObject menuPopUp;
    [SerializeField] private EventSystem eventSystem;
    [SerializeField] private Button firstSelected;


    InputAction menu;

    private void Awake()
    {
        StarterAssetsMaps sam = new StarterAssetsMaps();
        menu = sam.Player.Menu;
    }
    private void OnEnable()
    {
        menu.Enable();
    }
    private void OnDisable()
    {
        menu.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        menuPopUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (menu.WasPressedThisFrame())
        {
            if (!menuPopUp.activeInHierarchy)
            {
                firstSelected.Select();
                menuPopUp.SetActive(true);

                
            }
        }
    }
}

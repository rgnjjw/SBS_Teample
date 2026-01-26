using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// 여러 아이템을 담을 가장 기본적인 인벤토리
/// </summary>
public class InventoryMain : InventoryBase
{
    public InputActionAsset uiInputAction;
    private InputActionMap uiActionMap;

    public static bool IsInventoryActive = false;

    new void Awake()
    {
        base.Awake();

        uiActionMap = uiInputAction.FindActionMap("Option");
    }

    private void OnEnable()
    {
        uiActionMap.Enable();
        uiActionMap.FindAction("OpenInventory").performed += OnOpenInventory;
    }

    void Update()
    {

    }

    private void OnOpenInventory(InputAction.CallbackContext value)
    {
        //옵션이 켜저있는 경우 활성화 안 함 나중에 작성

        if (!IsInventoryActive)
        {
            OpenInventory();
        }
        else
        {
            CloseInventory();
        }
    }

    private void OpenInventory()
    {
        inventoryBase.SetActive(true);
        IsInventoryActive = true;

        Cursor.visible = true;
    }

    private void CloseInventory()
    {
        inventoryBase.SetActive(false);
        IsInventoryActive = false;

        //Cursor.visible = false;
    }
}

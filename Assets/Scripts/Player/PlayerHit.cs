using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerHit : PlayerState
{
    [Header("Text")]
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] TextMeshProUGUI actCountText;

    private void Update()
    {
        hpText.text = "hp : " + maxHp;
        actCountText.text = "actCount : " + actCount;

        if (maxHp <= 0)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
    private void OnTriggerEnter(Collider other)
    {

    }

    public void OnTestKey(InputAction.CallbackContext context)
    {
        maxHp = 0;
    }
}

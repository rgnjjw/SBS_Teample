using TMPro;
using UnityEngine;

public class EnemyTest : PlayerState
{
    private float enemyHp = 100;

    [SerializeField] TextMeshProUGUI enemyHpText;
    [SerializeField] GameObject item;
    [SerializeField] GameObject potal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemyHpText.text = "EnemyHp : " + enemyHp;

        if (enemyHp <= 0)
        {
            enemyHp = 0;
            item.SetActive(true);
            potal.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SwordBasicAttack" || other.tag == "StampBasicAttack" || other.tag == "ArrowBasicAttack")
        {
            enemyHp -= atk;
        }
    }
}

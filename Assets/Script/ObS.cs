using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObS : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CoinTxt;
    private int coin = 0;

    void Start()
    {
        coin = PlayerPrefs.GetInt("Coin", 0);
        CoinTxt.text = coin.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin5")
        {
            coin += 5;
            PlayerPrefs.SetInt("Coin", coin);
            CoinTxt.text = coin.ToString();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Coin25")
        {
            coin += 25;
            PlayerPrefs.SetInt("Coin", coin);
            CoinTxt.text = coin.ToString();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Coin100")
        {
            coin += 100;
            PlayerPrefs.SetInt("Coin", coin);
            CoinTxt.text = coin.ToString();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Coin500")
        {
            coin += 500;
            PlayerPrefs.SetInt("Coin", coin);
            CoinTxt.text = coin.ToString();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Fule")
        {
            //Debug.Log("Enterrrrrr");
            GameManager.instance.Fule.fillAmount = 1;
            Destroy(collision.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    bool isbreak, isgas, isrelease;
    [SerializeField] public Image Fule;
    [SerializeField]
    SurfaceEffector2D effector;
    [SerializeField]
    float speed;
    private float FuleSpeed = 0.05f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Fule.fillAmount > 0)
        {
            Fule.fillAmount -= Time.deltaTime * FuleSpeed;
        }
        else
        {
            Debug.Log("Fule Is Over");
        }
        if (isgas)
        {
            effector.speed += Time.deltaTime * speed;

        }
        else if (isbreak)
        {
            effector.speed -= Time.deltaTime * speed;

        }
        else
        {
            if (!isgas && !isbreak)
            {

                if (effector.speed > 0)
                {
                    effector.speed -= Time.deltaTime * speed;
                }
                else if (effector.speed < 0)
                {
                    effector.speed += Time.deltaTime * speed;
                }
            }
        }
    }
    public void gas()
    {
        isgas = true;
        isbreak = false;
    }
    public void breakk()
    {
        isbreak = true;
        isgas = false;
    }
    public void release()
    {
        isgas = false;
        isbreak = false;
    }
}

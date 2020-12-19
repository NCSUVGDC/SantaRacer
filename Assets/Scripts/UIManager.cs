using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICooldowns : MonoBehaviour
{
    [Header("Krampus Ability 1")]
    public Image krampusImage1;
    public float cooldownKrampus1;
    [Header("Krampus Ability 2")]
    public Image krampusImage2;
    public float cooldownKrampus2;
    [Header("Santa Ability 1")]
    public Image santaImage1;
    public float cooldownSanta1;
    [Header("Santa Ability 2")]
    public Image santaImage2;
    public float cooldownSanta2;
    [Header("Santa Ability 3")]
    public Image santaImage3;
    public float cooldownSanta3;
    bool isCooldown1;
    bool isCooldown2;
    bool isCooldown3;
    bool isCooldown4;
    bool isCooldown5;
    public Text Objective;
    public int giftsLeft;
    public ChimneyCount x;
    public int giftsCount;
    // Start is called before the first frame update
    void Start()
    {
        krampusImage1.fillAmount = 0;
        krampusImage2.fillAmount = 0;
        santaImage1.fillAmount = 0;
        santaImage2.fillAmount = 0;
        santaImage3.fillAmount = 0;
        giftsLeft = 10;
    }

    // Update is called once per frame
    void Update()
    {
        giftsCount = (int)x.GetComponent<ChimneyCount>().used;
        Objective.text = (giftsCount) + "/" + giftsLeft + "Gifts given";
        krampusAbility1();
        krampusAbility2();
        santaAbility1();
        santaAbility2();
        santaAbility3();
    }

    void santaAbility3()
    {
        if (!isCooldown5 && Input.GetButtonDown("West"))
        {
            isCooldown5 = true;
            santaImage3.fillAmount = 1;
        }
        if (isCooldown5)
        {
            santaImage3.fillAmount -= 1 / cooldownSanta3 * Time.deltaTime;

            if(santaImage3.fillAmount <= 0)
            {
                santaImage3.fillAmount = 0;
                isCooldown5 = false;
            }
        }
    }

    void santaAbility2()
    {
        if (!isCooldown4 && Input.GetButtonDown("North"))
        {
            isCooldown4 = true;
            santaImage2.fillAmount = 1;
        }
        if (isCooldown4)
        {
            santaImage2.fillAmount -= 1 / cooldownSanta2 * Time.deltaTime;

            if (santaImage2.fillAmount <= 0)
            {
                santaImage2.fillAmount = 0;
                isCooldown4 = false;
            }
        }
    }

    void santaAbility1()
    {
        if (!isCooldown3 && Input.GetButtonDown("East"))
        {
            isCooldown3 = true;
            santaImage1.fillAmount = 1;
        }
        if (isCooldown3)
        {
            santaImage1.fillAmount -= 1 / cooldownSanta1 * Time.deltaTime;

            if (santaImage1.fillAmount <= 0)
            {
                santaImage1.fillAmount = 0;
                isCooldown3 = false;
            }
        }
    }

    void krampusAbility2()
    {
        if (!isCooldown2 && Input.GetKeyDown("2"))
        {
            isCooldown2 = true;
            krampusImage2.fillAmount = 1;
        }
        if (isCooldown2)
        {
            krampusImage2.fillAmount -= 1 / cooldownKrampus2 * Time.deltaTime;

            if (krampusImage2.fillAmount <= 0)
            {
                krampusImage2.fillAmount = 0;
                isCooldown2 = false;
            }
        }
    }

    void krampusAbility1()
    {
        if (!isCooldown1 && Input.GetKeyDown("1"))
        {
            isCooldown1 = true;
            santaImage1.fillAmount = 1;
        }
        if (isCooldown1)
        {
            krampusImage1.fillAmount -= 1 / cooldownKrampus1 * Time.deltaTime;

            if (santaImage1.fillAmount <= 0)
            {
                santaImage1.fillAmount = 0;
                isCooldown1 = false;
            }
        }
    }
}

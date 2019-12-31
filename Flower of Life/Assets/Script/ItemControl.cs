using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{

    // Use this for initialization
    GameObject PaperFlower;
    GameObject FlowerofLife;
    GameObject ItemActiveEffect;
    GameObject ItemHintEffect;
    GameObject CharmVitality;
    GameObject CharmTenacity;

    void Start()
    {
        PaperFlower = ItemActiveEffect = ItemHintEffect = FlowerofLife = null;
        CharmVitality = CharmTenacity = null;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Show_Paper_Flower()
    {
        StartCoroutine(SHOWPAPERFLOWER());
    }

    public void Move_Paper_Flower()
    {
        StartCoroutine(MOVEPAPERFLOWER());
    }

    public void Take_Paper_Flower()
    {
        StartCoroutine(TAKEPAPERFLOWER());
    }
    public void Show_Flower_of_Life()
    {
        StartCoroutine(SHOWFLOWEROFLIFE());
    }
    public void Show_Flower_of_Life_temple()
    {
        StartCoroutine(SHOWFLOWEROFLIFETEMPLE());
    }
    public void Flower_of_Life_Active()
    {
        StartCoroutine(FLOWEROFLIFEACTIVE());
    }
    public void Fade_paper_flower()
    {
        StartCoroutine(FADEPAPERFLOWER());
    }
    public void Fade_flower_of_life()
    {
        StartCoroutine(FADEFLOWEROFLIFE());
    }
    public void show_charm_vitality()
    {
        StartCoroutine(SHOWCHARMVITALITY());
    }
    public void show_charm_tenacity()
    {
        StartCoroutine(SHOWCHARMTENACITY());
    }
    public void fade_charm_vitality()
    {
        StartCoroutine(FADECHARMVITALITY());
    }
    public void fade_charm_tenacity()
    {
        StartCoroutine(FADECHARMTENACITY());
    }
    public void The_End()
    {
        Instantiate(Resources.Load("Prefabs/The End"));
    }
    IEnumerator MOVEPAPERFLOWER()
    {
        float time = 0;
        while (time < 0.5f)
        {
            PaperFlower.transform.position += new Vector3(-1.3f, 1, 0) * Time.deltaTime * 2;
            PaperFlower.transform.localScale += new Vector3(-0.4f, -0.4f, -0.4f) * Time.deltaTime * 2;
            time += Time.deltaTime;
            yield return null;
        }
        ItemActiveEffect = (GameObject)Instantiate(Resources.Load("Prefabs/Item Active Effect"), new Vector3(-1.3f, 3, -1), new Quaternion(0, 0, 0, 0));
        ItemActiveEffect.transform.Find("Effect").localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }
    IEnumerator FADEPAPERFLOWER()
    {
        if (PaperFlower != null)
        {
            float time = 0;
            float alpha = 1;
            while (time < 0.5f)
            {
                alpha -= Time.deltaTime * 2;
                PaperFlower.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
                time += Time.deltaTime;
                yield return null;
            }
            Destroy(PaperFlower.gameObject);
        }
        
    }
    IEnumerator FADEFLOWEROFLIFE()
    {
        float time = 0;
        float alpha = 1;
        while (time < 0.5f)
        {
            alpha -= Time.deltaTime * 2;
            FlowerofLife.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            time += Time.deltaTime;
            yield return null;
        }
        Destroy(FlowerofLife.gameObject);

    }
    IEnumerator TAKEPAPERFLOWER()
    {
        float time = 0;
        while (time < 1)
        {
            PaperFlower.transform.position += (new Vector3(4.7f, 0.8f, -1) - new Vector3(-1.3f, 3, -1)) * Time.deltaTime;
            time += Time.deltaTime;
            yield return null;
        }
        ItemActiveEffect = (GameObject)Instantiate(Resources.Load("Prefabs/Item Active Effect"), new Vector3(4.7f, 0.8f, -1), new Quaternion(0, 0, 0, 0));
        ItemActiveEffect.transform.Find("Effect").localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }
    IEnumerator SHOWPAPERFLOWER()
    {
        PaperFlower = (GameObject)Instantiate(Resources.Load("Prefabs/Paper Flower"), new Vector3(0, 2, -1), new Quaternion(0, 0, 0, 0));
        PaperFlower.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        PaperFlower.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        float alpha = 0;
        while (PaperFlower.GetComponent<SpriteRenderer>().color.a < 1)
        {
            alpha += Time.deltaTime * 2;
            PaperFlower.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            yield return null;
        }

    }
    IEnumerator SHOWFLOWEROFLIFE()
    {
        FlowerofLife = (GameObject)Instantiate(Resources.Load("Prefabs/Flower of Life"));
        FlowerofLife.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        float alpha = 0;
        while (FlowerofLife.GetComponent<SpriteRenderer>().color.a < 1)
        {
            alpha += Time.deltaTime * 2;
            FlowerofLife.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            yield return null;
        }

    }
    IEnumerator SHOWFLOWEROFLIFETEMPLE()
    {
        FlowerofLife = (GameObject)Instantiate(Resources.Load("Prefabs/Flower of Life"), new Vector3(0, 32, -1), new Quaternion(0, 0, 0, 0));
        FlowerofLife.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        FlowerofLife.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        float alpha = 0;
        while (FlowerofLife.GetComponent<SpriteRenderer>().color.a < 1)
        {
            alpha += Time.deltaTime * 2;
            FlowerofLife.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            yield return null;
        }

    }

    IEnumerator FLOWEROFLIFEACTIVE()
    {
       
        float alpha = 1;
        ItemHintEffect = (GameObject)Instantiate(Resources.Load("Prefabs/Item Hint Effect"), FlowerofLife.transform.position - new Vector3(0, 0, 0.5f), new Quaternion(0, 0, 0, 0));
        ItemHintEffect.transform.parent = FlowerofLife.transform;
        ItemHintEffect.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        while (alpha > 0)
        {
            alpha -= Time.deltaTime / 10;
            FlowerofLife.transform.position += new Vector3(0, -0.2f, 0) * Time.deltaTime;
            FlowerofLife.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            yield return null;
        }
        Destroy(ItemHintEffect.gameObject);
        ItemActiveEffect = (GameObject)Instantiate(Resources.Load("Prefabs/Item Active Effect"), FlowerofLife.transform.position - new Vector3(0, 0, 0.5f), new Quaternion(0, 0, 0, 0));
        ItemActiveEffect.transform.Find("Effect").localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }
    IEnumerator SHOWCHARMVITALITY()
    {
        CharmVitality = (GameObject)Instantiate(Resources.Load("Prefabs/Charm of Vitality"), new Vector3(30, 32, -1), new Quaternion(0, 0, 0, 0));
        CharmVitality.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        float alpha = 0;
        while (alpha < 1)
        {
            alpha += Time.deltaTime * 2;
            CharmVitality.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            yield return null;
        }
    }
    IEnumerator SHOWCHARMTENACITY()
    {
        CharmTenacity = (GameObject)Instantiate(Resources.Load("Prefabs/Charm of Tenacity"), new Vector3(-50, 32, -1), new Quaternion(0, 0, 0, 0));
        CharmTenacity.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        float alpha = 0;
        while (alpha<1)
        {
            alpha += Time.deltaTime * 2;
            CharmTenacity.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            yield return null;
        }
    }
    IEnumerator FADECHARMVITALITY()
    {
        float time = 0;
        float alpha = 1;
        while (time < 0.5f)
        {
            alpha -= Time.deltaTime * 2;
            CharmVitality.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            time += Time.deltaTime;
            yield return null;
        }
        Destroy(CharmVitality.gameObject);
    }
    IEnumerator FADECHARMTENACITY()
    {
        float time = 0;
        float alpha = 1;
        while (time < 0.5f)
        {
            alpha -= Time.deltaTime * 2;
            CharmTenacity.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
            time += Time.deltaTime;
            yield return null;
        }
        Destroy(CharmTenacity.gameObject);
    }

}
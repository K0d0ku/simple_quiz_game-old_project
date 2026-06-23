using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CSS_MENU : MonoBehaviour
{
    public void Menu() => SceneManager.LoadScene(0);
    public void LAST_LVL(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Next_LVL(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Open_CSS_lvl_1() => SceneManager.LoadScene(8);
    public void Open_CSS_lvl_2() => SceneManager.LoadScene(9);
    public void Open_CSS_lvl_3() => SceneManager.LoadScene(10);
    public void Open_Html_lvl_7() => SceneManager.LoadScene(7);
    public void Open_JS_lvl_1() => SceneManager.LoadScene(11);
}

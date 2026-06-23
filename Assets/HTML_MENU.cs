using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HTML_MENU : MonoBehaviour
{
    public void Menu() => SceneManager.LoadScene(0);
    public void LAST_LVL(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Next_LVL(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Open_Html_lvl_1() => SceneManager.LoadScene(1);
    public void Open_Html_lvl_2() => SceneManager.LoadScene(2);
    public void Open_Html_lvl_3() => SceneManager.LoadScene(3);
    public void Open_Html_lvl_4() => SceneManager.LoadScene(4);
    public void Open_Html_lvl_5() => SceneManager.LoadScene(5);
    public void Open_Html_lvl_6() => SceneManager.LoadScene(6);
    public void Open_Html_lvl_7() => SceneManager.LoadScene(7);
    public void Returnt_to_menu () => SceneManager.LoadScene(0);
    public void Open_Css_lvl_1() => SceneManager.LoadScene(8);
}

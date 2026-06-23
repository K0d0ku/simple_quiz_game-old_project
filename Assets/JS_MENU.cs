using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JS_MENU : MonoBehaviour
{
    public void Menu() => SceneManager.LoadScene(0);
    public void LAST_LVL(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Next_LVL(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Open_JS_lvl_1() => SceneManager.LoadScene(11);
    public void Open_JS_lvl_2() => SceneManager.LoadScene(12);
    public void Open_JS_lvl_3() => SceneManager.LoadScene(13);
    public void Open_JS_lvl_4() => SceneManager.LoadScene(14);
    public void Open_JS_lvl_5() => SceneManager.LoadScene(15);
    public void Open_JS_lvl_6() => SceneManager.LoadScene(16);
    public void Open_CSS_lvl_3() => SceneManager.LoadScene(10);
    public void Open_PHP_lvl_1() => SceneManager.LoadScene(17);
}

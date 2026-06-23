using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PHP_MENU : MonoBehaviour
{
    public void Menu() => SceneManager.LoadScene(0);
    public void LAST_LVL(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Next_LVL(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Open_PHP_lvl_1() => SceneManager.LoadScene(17);
    public void Open_PHP_lvl_2() => SceneManager.LoadScene(18);
    public void Open_PHP_lvl_3() => SceneManager.LoadScene(19);
    public void Open_PHP_lvl_4() => SceneManager.LoadScene(20);
    public void Open_JS_lvl_6() => SceneManager.LoadScene(16);
    public void Game_End () => SceneManager.LoadScene(0);
}

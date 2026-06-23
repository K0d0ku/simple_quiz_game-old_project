using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;

    [SerializeField]
    private Text factText;

    [SerializeField]
    private Text trueAnswerText;
    [SerializeField]
    private Text falseAnswerText;
    

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float timeBetweenQuestions = 1f;
    void Start() 
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        SetCurrentQuestion();
        Debug.Log(currentQuestion.fact + "is" + currentQuestion.isTrue);
    }
    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;

        if (currentQuestion.isTrue)
        {
            trueAnswerText.text = "Qate";
            falseAnswerText.text = "Dūrys";
        } 
        else
        {
            trueAnswerText.text = "Dūrys";
            falseAnswerText.text = "Qate";
        }
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions + 1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void UserSelectTrue() 
    {
        animator.SetTrigger("true");
        if (currentQuestion.isTrue)
        {
            Debug.Log("CORRECT");
        }
        else
        {
            Debug.Log("WRONG");
        }

        StartCoroutine(TransitionToNextQuestion());
    }
    public void UserSelectFalse() 
    {
        animator.SetTrigger("false");
        if (!currentQuestion.isTrue)
        {
            Debug.Log("CORRECT");
        }
        else
        {
            Debug.Log("WRONG");
        }

        StartCoroutine(TransitionToNextQuestion());
    }
}

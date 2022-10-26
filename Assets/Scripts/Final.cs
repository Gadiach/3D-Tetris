using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    private Animator animator;
    public rig finish;
    public PhysicMaterial physicMaterial;
    public MoveForward moveForward;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void LateUpdate()
    {
        if (finish.isFinished == true)
        {
            animator.Play("Finish");
        }
        else
        {
            animator.Play("Idle");
        }
    }
    public void Next()
    {
        moveForward.speed = 0.3f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quit()
    {
        moveForward.speed = 0.3f;
        Application.Quit();
    }
}
